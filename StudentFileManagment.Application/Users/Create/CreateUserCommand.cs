namespace StudentFileManagment.Application.Users.Create
{
    public record CreateUserCommand(string? Name, string? Nickname, long chatId, bool IsAdmin, bool IsModerator);
}
