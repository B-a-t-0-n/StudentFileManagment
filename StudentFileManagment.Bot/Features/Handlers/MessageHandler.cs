﻿using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types;
using Telegram.Bot;
using Microsoft.AspNetCore.Mvc;

namespace StudentFileManagment.Bot.Features.Handlers
{
    public class MessageHandler : IHandler<Message>
    {
        private readonly ITelegramBotClient _botClient;

        public MessageHandler(ITelegramBotClient botClient)
        {
            _botClient = botClient;
        }

        public async Task Handle(Message message, CancellationToken cancellationToken)
        {

            InlineKeyboardMarkup inlineKeyboard = new(
            [
                [InlineKeyboardButton.WithCallbackData("Информация о занятиях", "lessons-info")],
                [InlineKeyboardButton.WithCallbackData("Подать заявку на занятия", "lessons-application")],
            ]);

            await _botClient.SendTextMessageAsync(
                chatId: message.Chat.Id,
                text: "Выбери опцию",
                replyMarkup: inlineKeyboard,
                cancellationToken: cancellationToken);
        }
    }
}
