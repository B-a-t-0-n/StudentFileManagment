using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types;
using Telegram.Bot;
using StudentFileManagement.Infrastructure;


namespace StudentFileManagment.Bot.Features.Handlers
{
    public class MessageHandler : IHandler<Message>
    {
        private readonly ITelegramBotClient _botClient;
        private readonly DataContext _context;

        public MessageHandler(ITelegramBotClient botClient, DataContext context)
        {
            _botClient = botClient;
            _context = context;
        }

        public async Task Handle(Message message, CancellationToken cancellationToken)
        {
            switch (message.Text)
            {
                case "/start":
                    await Start(message, cancellationToken);
                    break;

            }
        }

        private async Task Start(Message message, CancellationToken cancellationToken)
        {
            InlineKeyboardMarkup inlineKeyboard = new(InlineKeyboardButton.WithCallbackData("Начать", "/Institution"));

            var text = "Привет, я бот котрый хранит в себе лекции, хочешь начать пользоваться, нажми кнопку \"Начать\"";

            await _botClient.SendTextMessageAsync(
                chatId: message.Chat.Id,
                text: text,
                replyMarkup: inlineKeyboard,
                cancellationToken: cancellationToken);
        }
    }
}
