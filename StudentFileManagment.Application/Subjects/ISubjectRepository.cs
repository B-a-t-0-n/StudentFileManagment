using CSharpFunctionalExtensions;
using StudentFileManagement.Domain;
using StudentFileManagment.Domain.Shared;

namespace StudentFileManagment.Application.Subjects
{
    public interface ISubjectRepository
    {
        Task<Guid> Add(Subject subject, CancellationToken cancellationToken = default);
        Task<Result<Subject, Error>> GetById(Guid id, CancellationToken cancellationToken = default);
        Task<Result<Subject, Error>> GetByName(string name, CancellationToken cancellationToken = default);
    }
}
