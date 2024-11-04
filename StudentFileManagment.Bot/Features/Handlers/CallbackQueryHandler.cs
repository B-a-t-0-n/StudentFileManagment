using Telegram.Bot.Types;
using Telegram.Bot;
using StudentFileManagement.Infrastructure;
using Telegram.Bot.Types.ReplyMarkups;
using Microsoft.EntityFrameworkCore;
using StudentFileManagement.Domain;

namespace StudentFileManagment.Bot.Features.Handlers
{
    public class CallbackQueryHandler : IHandler<CallbackQuery>
    {
        private readonly ITelegramBotClient _botClient;
        private readonly DataContext _context;
        private static Dictionary<long, int> _userCource = new Dictionary<long, int>();
        private static Dictionary<long, int> _userSemester = new Dictionary<long, int>();

        public CallbackQueryHandler(ITelegramBotClient botClient, DataContext context)
        {
            _botClient = botClient;
            _context = context;
        }

        public async Task Handle(CallbackQuery query, CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(query.Data))
                return;

            switch (query.Data.Split(" ")[0])
            {
                case "/Education":
                    await ChoosingEducation(query, cancellationToken);
                    return;
                case "/EducationDirections":
                    await ChoosingEducationDirections(query, cancellationToken);
                    return;
                case "/Cource":
                    await ChoosingCource(query, cancellationToken);
                    return;
                case "/Semester":
                    await ChoosingSemester(query, cancellationToken);
                    return;
                case "/Subject":
                    await ChoosingSubject(query, cancellationToken);
                    return;
                default:
                    await _botClient.AnswerCallbackQueryAsync(callbackQueryId: query.Id, "кнопка не работает", cancellationToken: cancellationToken);
                    return;
            }
        }

        private async Task SendMessageAndCallbackButtons(
            CallbackQuery query,
            string text,
            string command,
            IEnumerable<(string, Guid)> buttonsData,
            CancellationToken cancellationToken)
        {
            if (query.Message is not { } message)
                return;

            var buttons = new List<List<InlineKeyboardButton>>();

            foreach (var buttonData in buttonsData)
            {
                var rowButtons = new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(
                        buttonData.Item1,
                        $"{command} {buttonData.Item2}")
                };
                buttons.Add(rowButtons);
            }

            InlineKeyboardMarkup inlineKeyboard = new(buttons);

            await _botClient.AnswerCallbackQueryAsync(callbackQueryId: query.Id, cancellationToken: cancellationToken);
            await _botClient.SendTextMessageAsync(
                        chatId: message.Chat.Id,
                        text: text,
                        replyMarkup: inlineKeyboard,
                        cancellationToken: cancellationToken);
        }

        private async Task ChoosingEducation(CallbackQuery query, CancellationToken cancellationToken)
        {
            var parametrs = query.Data!.Split(" ")[1];

            var institutionAndEducations = await _context.InstitutionAndEducations
                .Include(i => i.Education)
                .Where(i => i.InstitutionId.ToString() == parametrs)
                .ToListAsync(cancellationToken: cancellationToken);

            var buttonsData = institutionAndEducations.Select(i => (i.Education.Name, i.Id));

            await SendMessageAndCallbackButtons(
                query,
                "Выберите тип образования",
                "/EducationDirections",
                buttonsData,
                cancellationToken);
        }

        private async Task ChoosingEducationDirections(CallbackQuery query, CancellationToken cancellationToken)
        {
            var parametrs = query.Data!.Split(" ")[1];

            var educationDirections = await _context.EducationDirections
                .Where(e => e.InstitutionAndEducationId.ToString() == parametrs)
                .ToListAsync(cancellationToken: cancellationToken);

            var buttonsData = educationDirections.Select(i => (i.Name, i.Id));

            await SendMessageAndCallbackButtons(
                query,
                "Выберите направление",
                "/Cource",
                buttonsData,
                cancellationToken);
        }

        private async Task ChoosingCource(CallbackQuery query, CancellationToken cancellationToken)
        {
            var parametrs = query.Data!.Split(" ")[1];

            var cources = await _context.Cources
                .Where(e => e.EducationDirectionId.ToString() == parametrs)
                .ToListAsync(cancellationToken: cancellationToken);

            var buttonsData = cources.OrderBy(c => c.Number).Select(i => (i.Number.ToString(), i.Id));

            await SendMessageAndCallbackButtons(
                query,
                "Выберите курс",
                "/Semester",
                buttonsData,
                cancellationToken);
        }

        private async Task ChoosingSemester(CallbackQuery query, CancellationToken cancellationToken)
        {
            var parametrs = query.Data!.Split(" ")[1];

            var semesters = await _context.Semesters
                .Where(e => e.CourceId.ToString() == parametrs)
                .ToListAsync(cancellationToken: cancellationToken);

            var buttonsData = semesters.OrderBy(c => c.Number).Select(i => (i.Number.ToString(), i.Id));

            await SendMessageAndCallbackButtons(
                query,
                "Выберите семестр",
                "/Subject",
                buttonsData,
                cancellationToken);
        }

        private async Task ChoosingSubject(CallbackQuery query, CancellationToken cancellationToken)
        {
            var parametrs = query.Data!.Split(" ")[1];

            var semesters = await _context.Subjects
                .Where(s => s.SemesterId.ToString() == parametrs)
                .ToListAsync(cancellationToken: cancellationToken);

            var buttonsData = semesters.Select(i => (i.Name.ToString(), i.Id));

            await SendMessageAndCallbackButtons(
                query,
                "Выберите предмет",
                "/Lecture",
                buttonsData,
                cancellationToken);
        }

    }
}
