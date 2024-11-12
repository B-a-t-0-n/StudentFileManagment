using CSharpFunctionalExtensions;
using StudentFileManagement.Domain;
using StudentFileManagment.Domain.Shared;

namespace StudentFileManagment.Application.Educations
{
    public interface IEducationRepository
    {
        Task<Guid> Add(Education education, CancellationToken cancellationToken = default);
        Task<Result<Education, Error>> GetById(Guid id, CancellationToken cancellationToken = default);
        Task<Result<Education, Error>> GetByName(string name, CancellationToken cancellationToken = default);

    }
}
