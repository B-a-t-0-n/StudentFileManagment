using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types;
using Telegram.Bot;
using StudentFileManagement.Infrastructure;
using Microsoft.EntityFrameworkCore;


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
            var buttons = new List<List<InlineKeyboardButton>>();

            var institutions = await _context.Institutions.ToListAsync();

            foreach (var institution in institutions) 
            {
                var rowButtons = new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(institution.Name, $"/Education {institution.Id}")
                };
                buttons.Add(rowButtons);
            }

            InlineKeyboardMarkup inlineKeyboard = new(buttons);

            await _botClient.SendTextMessageAsync(
                chatId: message.Chat.Id,
                text: "Выберете учебное заведение",
                replyMarkup: inlineKeyboard,
                cancellationToken: cancellationToken);
        }
    }
}
