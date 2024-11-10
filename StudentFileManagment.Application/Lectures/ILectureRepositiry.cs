using CSharpFunctionalExtensions;
using StudentFileManagement.Domain;
using StudentFileManagment.Domain.Shared;

namespace StudentFileManagment.Application.Lectures
{
    public interface ILectureRepositiry
    {
        Task<Guid> Add(Lecture lecture, CancellationToken cancellationToken = default);
        Task<Result<Lecture, Error>> GetByDate(DateOnly date, CancellationToken cancellationToken = default);
    }
}
