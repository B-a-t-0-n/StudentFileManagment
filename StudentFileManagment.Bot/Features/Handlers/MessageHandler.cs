﻿using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types;
using Telegram.Bot;
using StudentFileManagement.Infrastructure;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using StudentFileManagment.Application.Lectures.Create;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.AspNetCore.Http;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;
using StudentFileManagment.Application.Lectures.AddLectureData;
using StudentFileManagement.Domain;
using Microsoft.EntityFrameworkCore;
using User = StudentFileManagement.Domain.User;
using StudentFileManagment.Application.Users.Create;

namespace StudentFileManagment.Bot.Features.Handlers
{
    public class MessageHandler : IHandler<Message>
    {
        private readonly ITelegramBotClient _botClient;
        private readonly DataContext _context;
        private readonly CreateLectureHandler _createLectureHandler;
        private readonly AddLectureDataHandler _addLectureDataHandler;
        private readonly CreateUserHandler _createUserHandler;

        public MessageHandler(
            ITelegramBotClient botClient,
            DataContext context,
            CreateLectureHandler createLectureHandler,
            AddLectureDataHandler addLectureDataHandler,
            CreateUserHandler createUserHandler)
        {
            _botClient = botClient;
            _context = context;
            _createUserHandler = createUserHandler;
            _createLectureHandler = createLectureHandler;
            _addLectureDataHandler = addLectureDataHandler;
        }

        public async Task Handle(Message message, CancellationToken cancellationToken)
        {
            switch (message.Text)
            {
                case "/start":
                    await Start(message, cancellationToken);
                    break;
                default:
                    await InputHandler(message, cancellationToken);
                    break;

            }
        }

        private async Task InputHandler(Message message, CancellationToken cancellationToken)
        {
            if (!UserState.UserStates.ContainsKey(message.Chat.Id))
                return;

            var userState = UserState.UserStates[message.Chat.Id].Item1;

            switch (userState)
            {
                case UserState.AddLecture:
                    await AddLecture(message, cancellationToken);
                    break;
                case UserState.AddLectureData:
                    await AddLectureData(message, cancellationToken);
                    break;
            }
        }

        private async Task AddLectureData(Message message, CancellationToken cancellationToken)
        {
            if (message.Text == null)
                return;

            var id = UserState.UserStates[message.Chat.Id].Item2;

            UserState.UserStates.Remove(message.Chat.Id);

            InlineKeyboardMarkup inlineKeyboard = new();

            inlineKeyboard.AddButton(InlineKeyboardButton.WithCallbackData("Вернуться назад", $"{Command.LectureData} {id}"));

            var user = await Authorization(message, cancellationToken );

            var command = new AddLectureDataCommand(id, message.Text, user.Id);

            var result = await _addLectureDataHandler.Handle(command, cancellationToken);
            if (result.IsFailure)
            {
                //error
                await _botClient.SendMessage(
                    chatId: message.Chat.Id,
                    text: "произошла ошибка, вызовете меню заного",
                    cancellationToken: cancellationToken,
                    replyMarkup: inlineKeyboard);
                
                return;
            }

            inlineKeyboard.AddButton(InlineKeyboardButton.WithCallbackData("Добавить файлы", $"{Command.AddFile} {result.Value}"));

            await _botClient.SendMessage(
                chatId: message.Chat.Id,
                text: "Данные успешно занесены",
                cancellationToken: cancellationToken,
                replyMarkup: inlineKeyboard);
            return;
        }
        
        private async Task<User> Authorization(Message message, CancellationToken cancellationToken = default)
        {
            var chatId = message.Chat.Id;

            var user = await _context.Users.FirstOrDefaultAsync(u => u.ChatId == chatId, cancellationToken);
            if(user is null)
            {
                user = await Registration(message, cancellationToken);
            }

            return user!;
        }

        private async Task<User> Registration(Message message, CancellationToken cancellationToken = default)
        {
            var telegramUser = message.From!;
            var command = new CreateUserCommand(telegramUser.FirstName, telegramUser.Username, message.Chat.Id, false, false);

            var result = await _createUserHandler.Handle(command);
            if (result.IsFailure)
            {
                return new User();
            }

            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == result.Value, cancellationToken);
            return user!;
        }

        private async Task Start(Message message, CancellationToken cancellationToken)
        {
            InlineKeyboardMarkup inlineKeyboard = new(InlineKeyboardButton.WithCallbackData("Начать", Command.Institution));

            var text = "Привет, я бот котрый хранит лекционные файлы студентов.\nХочешь начать пользоваться, нажми кнопку";

            await _botClient.SendMessage(
                chatId: message.Chat.Id,
                text: text,
                replyMarkup: inlineKeyboard,
                cancellationToken: cancellationToken);
        }

        private async Task AddLecture(Message message, CancellationToken cancellationToken)
        {
            bool dateResult = DateOnly.TryParseExact(
                message.Text,
                "dd.MM.yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out DateOnly date);
            if (!dateResult)
            {
                await _botClient.SendMessage(
                chatId: message.Chat.Id,
                text: "введите время в правильном формате дд.мм.гггг",
                cancellationToken: cancellationToken);
                return;
            }

            var id = UserState.UserStates[message.Chat.Id].Item2;

            InlineKeyboardMarkup inlineKeyboard = new(InlineKeyboardButton.WithCallbackData("Вернуться назад", $"{Command.Lecture} {id}"));

            var command = new CreateLectureCommand(date, id);

            var result = await _createLectureHandler.Handle(command, cancellationToken);
            if (result.IsFailure)
            {
                //error
                await _botClient.SendMessage(
                    chatId: message.Chat.Id,
                    text: "Лекция уже сущевствует",
                    cancellationToken: cancellationToken,
                    replyMarkup: inlineKeyboard);
                return;
            }

            UserState.UserStates.Remove(message.Chat.Id);

            await _botClient.SendMessage(
                chatId: message.Chat.Id,
                text: "Лекция успешно создалась",
                cancellationToken: cancellationToken,
                replyMarkup: inlineKeyboard);
            return;
        }
    }
}
