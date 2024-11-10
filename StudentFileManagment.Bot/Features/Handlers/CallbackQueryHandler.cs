using Telegram.Bot.Types;
using Telegram.Bot;
using StudentFileManagement.Infrastructure;
using Telegram.Bot.Types.ReplyMarkups;
using Microsoft.EntityFrameworkCore;

namespace StudentFileManagment.Bot.Features.Handlers
{
    public class CallbackQueryHandler : IHandler<CallbackQuery>
    {
        private readonly ITelegramBotClient _botClient;
        private readonly DataContext _context;

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
                case "/Institution":
                    await ChoosingInstitution(query, cancellationToken);
                    return;
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
                case "/Lecture":
                    await ChoosingLecture(query, cancellationToken);
                    return;
                case "/AddLecture":
                    await AddLecture(query, cancellationToken);
                    return;
                default:
                    await _botClient.AnswerCallbackQueryAsync(
                        callbackQueryId: query.Id,
                        "кнопка не работает",
                        cancellationToken: cancellationToken);
                    return;
            }
        }

        private async Task AddLecture(CallbackQuery query, CancellationToken cancellationToken)
        {
        }

        private async Task SendMessageAndCallbackButtons(
            CallbackQuery query,
            string text,
            string command,
            IEnumerable<(string, Guid)> buttonsData,
            CancellationToken cancellationToken,
            bool addButtonBack = false,
            bool addButtonAdd = false,
            string buttonBackRoute = "back",
            string buttonAddRoute = "add")
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

            var funcButtons = new List<InlineKeyboardButton>();

            if (addButtonBack)
                funcButtons.Add(InlineKeyboardButton.WithCallbackData("<---", buttonBackRoute));
            if (addButtonAdd)
                funcButtons.Add(InlineKeyboardButton.WithCallbackData("[+]", buttonAddRoute));

            buttons.Add(funcButtons);

            InlineKeyboardMarkup inlineKeyboard = new(buttons);

            await _botClient.AnswerCallbackQueryAsync(callbackQueryId: query.Id, cancellationToken: cancellationToken);
            await _botClient.EditMessageTextAsync(
                        messageId: query.Message.MessageId,
                        chatId: message.Chat.Id,
                        text: text,
                        replyMarkup: inlineKeyboard,
                        cancellationToken: cancellationToken);
        }

        private async Task ChoosingInstitution(CallbackQuery query, CancellationToken cancellationToken)
        { 
            var institution = await _context.Institutions
                .ToListAsync(cancellationToken: cancellationToken);

            var buttonsData = institution.Select(i => (i.Name, i.Id));

            await SendMessageAndCallbackButtons(
                query,
                "Выберите учебное заведение",
                "/Education",
                buttonsData,
                cancellationToken);
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
                cancellationToken,
                addButtonBack: true,
                buttonBackRoute: "/Institution");
        }

        private async Task ChoosingEducationDirections(CallbackQuery query, CancellationToken cancellationToken)
        {
            var parametrs = query.Data!.Split(" ")[1];

            var educationDirections = await _context.EducationDirections
                .Where(e => e.InstitutionAndEducationId.ToString() == parametrs)
                .ToListAsync(cancellationToken: cancellationToken);

            var buttonsData = educationDirections.Select(i => (i.Name, i.Id));

            var institutionAndEducations = await _context.InstitutionAndEducations.FirstOrDefaultAsync(i => i.Id.ToString() == parametrs);
            if (institutionAndEducations == null)
            {
                await _botClient.AnswerCallbackQueryAsync(
                        callbackQueryId: query.Id,
                        "ошибка",
                        cancellationToken: cancellationToken);
                //log
                return;
            }

            await SendMessageAndCallbackButtons(
                query,
                "Выберите направление",
                "/Cource",
                buttonsData,
                cancellationToken,
                addButtonBack: true,
                buttonBackRoute: $"/Education {institutionAndEducations.InstitutionId}");
        }

        private async Task ChoosingCource(CallbackQuery query, CancellationToken cancellationToken)
        {
            var parametrs = query.Data!.Split(" ")[1];

            var cources = await _context.Cources
                .Where(e => e.EducationDirectionId.ToString() == parametrs)
                .ToListAsync(cancellationToken: cancellationToken);

            var buttonsData = cources.OrderBy(c => c.Number).Select(i => (i.Number.ToString(), i.Id));

            var educationDirection = await _context.EducationDirections.FirstOrDefaultAsync(e => e.Id.ToString() == parametrs);
            if (educationDirection == null)
            {
                await _botClient.AnswerCallbackQueryAsync(
                        callbackQueryId: query.Id,
                        "ошибка",
                        cancellationToken: cancellationToken);
                //log
                return;
            }

            await SendMessageAndCallbackButtons(
                query,
                "Выберите курс",
                "/Semester",
                buttonsData,
                cancellationToken,
                addButtonBack: true,
                buttonBackRoute: $"/EducationDirections {educationDirection.InstitutionAndEducationId}");
        }

        private async Task ChoosingSemester(CallbackQuery query, CancellationToken cancellationToken)
        {
            var parametrs = query.Data!.Split(" ")[1];

            var semesters = await _context.Semesters
                .Where(e => e.CourceId.ToString() == parametrs)
                .ToListAsync(cancellationToken: cancellationToken);

            var buttonsData = semesters.OrderBy(c => c.Number).Select(i => (i.Number.ToString(), i.Id));

            var cource = await _context.Cources.FirstOrDefaultAsync(c => c.Id.ToString() == parametrs);
            if(cource == null)
            {
                await _botClient.AnswerCallbackQueryAsync(
                        callbackQueryId: query.Id,
                        "ошибка",
                        cancellationToken: cancellationToken);
                //log
                return;
            }

            await SendMessageAndCallbackButtons(
                query,
                "Выберите семестр",
                "/Subject",
                buttonsData,
                cancellationToken,
                addButtonBack: true,
                buttonBackRoute: $"/Cource {cource.EducationDirectionId}");
        }

        private async Task ChoosingSubject(CallbackQuery query, CancellationToken cancellationToken)
        {
            var parametrs = query.Data!.Split(" ")[1];

            var subjects = await _context.Subjects
                .Where(s => s.SemesterId.ToString() == parametrs)
                .ToListAsync(cancellationToken: cancellationToken);

            var buttonsData = subjects.Select(i => (i.Name.ToString(), i.Id));

            var semester = await _context.Semesters.FirstOrDefaultAsync(s => s.Id.ToString() == parametrs);
            if (semester == null)
            {
                await _botClient.AnswerCallbackQueryAsync(
                        callbackQueryId: query.Id,
                        "ошибка",
                        cancellationToken: cancellationToken);
                //log
                return;
            }

            await SendMessageAndCallbackButtons(
                query,
                "Выберите предмет",
                "/Lecture",
                buttonsData,
                cancellationToken,
                addButtonBack: true,
                buttonBackRoute: $"/Semester {semester.CourceId}");
        }

        private async Task ChoosingLecture(CallbackQuery query, CancellationToken cancellationToken)
        {
            var parametrs = query.Data!.Split(" ")[1];

            var lectures = await _context.Lectures
                .Include(l => l.Subject)
                .Where(l => l.Subject.Id.ToString() == parametrs)
                .ToListAsync(cancellationToken: cancellationToken);

            var buttonsData = lectures.OrderBy(i => i.Date).Select(i => ($"Дата: {i.Date}", i.Id));

            var subject = await _context.Subjects.FirstOrDefaultAsync(s => s.Id.ToString() == parametrs);
            if (subject == null)
            {
                await _botClient.AnswerCallbackQueryAsync(
                        callbackQueryId: query.Id,
                        "ошибка",
                        cancellationToken: cancellationToken);
                //log
                return;
            }

            await SendMessageAndCallbackButtons(
                query,
                "Выберите лекцию",
                "/LectureFiles",
                buttonsData,
                cancellationToken,
                addButtonBack: true,
                buttonBackRoute: $"/Subject {subject.SemesterId}",
                addButtonAdd: true);
        }

    }
}
