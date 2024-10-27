using Microsoft.Extensions.Options;
using StudentFileManagment.Bot;
using Telegram.Bot.Types;
using Telegram.Bot;
using StudentFileManagment.Bot.Options;
using StudentFileManagment.Bot.Features;
using StudentFileManagment.Bot.Features.Handlers;
using StudentFileManagment.Infrastructure;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<TelegramBotBackgroundService>();

builder.Services.AddTransient<ITelegramBotClient, TelegramBotClient>(serviceProvider =>
{
    var token = serviceProvider.GetRequiredService<IOptions<TelegramOptions>>().Value.Token;

    return new(token);
});

builder.Services.AddInfrastructure();

builder.Services.AddTransient<IHandler<Message>, MessageHandler>();
builder.Services.AddTransient<IHandler<CallbackQuery>, CallbackQueryHandler>();
builder.Services.AddTransient<IHandler<Update>, UnknownUpdateHandler>();

builder.Services.Configure<TelegramOptions>(builder.Configuration.GetSection(TelegramOptions.Telegram));

var host = builder.Build();
host.Run();



//Host=localhost;Port=5434;Database=student_file_managment;Username=postgres;Password=postgres
//Server=(localdb)\\mssqllocaldb;Database=student_file_managment;Trusted_Connection=True;