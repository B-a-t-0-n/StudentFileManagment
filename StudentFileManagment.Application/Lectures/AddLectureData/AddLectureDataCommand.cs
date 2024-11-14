namespace StudentFileManagment.Application.Lectures.AddLectureData
{
    public record AddLectureDataCommand(Guid LectureId, string Comment, Guid UserId);
}
