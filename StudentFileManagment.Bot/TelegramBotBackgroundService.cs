using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot;
using StudentFileManagment.Bot.Features;

namespace StudentFileManagment.Bot
{
    public class TelegramBotBackgroundService : BackgroundService
    {
        private readonly ITelegramBotClient _botClient;
        private readonly IServiceScopeFactory _scopeFactory;
        private readonly ILogger<TelegramBotBackgroundService> _logger;

        public TelegramBotBackgroundService(
            ITelegramBotClient botClient,
            IServiceScopeFactory scopeFactory,
            ILogger<TelegramBotBackgroundService> logger)
        {
            _botClient = botClient;
            _scopeFactory = scopeFactory;
            _logger = logger;

            botClient.DropPendingUpdates();
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            ReceiverOptions receiverOptions = new()
            {
                AllowedUpdates = []
            };

            while (!stoppingToken.IsCancellationRequested)
            {
                await _botClient.ReceiveAsync(
                    updateHandler: HandleUpdateAsync,
                    errorHandler: HandleErrorAsync,
                    receiverOptions: receiverOptions,
                    cancellationToken: stoppingToken);
            }
        }

        private async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            var scope = _scopeFactory.CreateScope();

            var messageHandler = scope.ServiceProvider.GetRequiredService<IHandler<Message>>();
            var callbackQueryHandler = scope.ServiceProvider.GetRequiredService<IHandler<CallbackQuery>>();
            var unknownUpdateHandler = scope.ServiceProvider.GetRequiredService<IHandler<Update>>();

            var handler = update switch
            {
                { Message: { } message } => messageHandler.Handle(message, cancellationToken),
                { CallbackQuery: { } query } => callbackQueryHandler.Handle(query, cancellationToken),
                _ => unknownUpdateHandler.Handle(update, cancellationToken)
            };

            await handler;
        }
        private Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            switch (exception)
            {
                case ApiRequestException apiRequestException:
                    _logger.LogError(
                        apiRequestException,
                        "Telegram API Error:\n[{errorCode}]\n{message}",
                        apiRequestException.ErrorCode,
                        apiRequestException.Message);
                    return Task.CompletedTask;

                default:
                    _logger.LogError(exception, "Error while processing message in telegram bot");
                    return Task.CompletedTask;
            }
        }
    }
}
