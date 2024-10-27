using Telegram.Bot.Types;
using Telegram.Bot;

namespace StudentFileManagment.Bot.Features.Handlers
{
    public class CallbackQueryHandler : IHandler<CallbackQuery>
    {
        private readonly ITelegramBotClient _botClient;

        public CallbackQueryHandler(ITelegramBotClient botClient)
        {
            _botClient = botClient;
        }

        public async Task Handle(CallbackQuery query, CancellationToken cancellationToken)
        {
            if (query.Message is not { } message)
                return;

            switch (query.Data)
            {
                case "lessons-info":
                    await _botClient.SendTextMessageAsync(
                        chatId: message.Chat.Id,
                        text: "Вот тебе информация о занятиях, дорогой друг",
                        cancellationToken: cancellationToken);

                    await _botClient.AnswerCallbackQueryAsync(callbackQueryId: query.Id, cancellationToken: cancellationToken);
                    return;
            }
        }
    }
}
