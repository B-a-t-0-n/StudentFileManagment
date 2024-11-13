namespace StudentFileManagment.Application.Subjects.Create
{
    public record CreateSubjectCommand(Guid SemesterId, string Name);
}
