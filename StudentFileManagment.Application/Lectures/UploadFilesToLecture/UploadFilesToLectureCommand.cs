using StudentFileManagment.Application.DTO;

namespace StudentFileManagment.Application.Lectures.UploadFilesToLecture
{
    public record UploadFilesToLectureCommand(Guid LectureId ,Guid LectureDataId, IEnumerable<CreateFileDto> Files);
}
