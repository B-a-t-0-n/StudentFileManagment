using Telegram.Bot.Types;
using Telegram.Bot;

namespace StudentFileManagment.Bot.Features.Handlers
{
    public class UnknownUpdateHandler : IHandler<Update>
    {
        private readonly ITelegramBotClient _botClient;
        private readonly ILogger<UnknownUpdateHandler> _logger;

        public UnknownUpdateHandler(ITelegramBotClient botClient, ILogger<UnknownUpdateHandler> logger)
        {
            _botClient = botClient;
            _logger = logger;
        }

        public Task Handle(Update update, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Unknown type message");
            return Task.CompletedTask;
        }
    }
}
