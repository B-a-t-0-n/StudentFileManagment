using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types;
using Telegram.Bot;
using StudentFileManagement.Infrastructure;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using StudentFileManagment.Application.Lectures.Create;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.AspNetCore.Http;
using System.Globalization;

namespace StudentFileManagment.Bot.Features.Handlers
{
    public class MessageHandler : IHandler<Message>
    {
        private readonly ITelegramBotClient _botClient;
        private readonly DataContext _context;
        private readonly CreateLectureHandler _createLectureHandler;

        public MessageHandler(
            ITelegramBotClient botClient,
            DataContext context,
            CreateLectureHandler createLectureHandler)
        {
            _botClient = botClient;
            _context = context;
            _createLectureHandler = createLectureHandler;
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
            }
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
