namespace StudentFileManagment.Application.Lectures.Create
{
    public record CreateLectureCommand(DateOnly Date, Guid SubjectId);
}
