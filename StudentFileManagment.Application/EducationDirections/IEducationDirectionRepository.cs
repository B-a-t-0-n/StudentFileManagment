using CSharpFunctionalExtensions;
using StudentFileManagement.Domain;
using StudentFileManagment.Domain.Shared;

namespace StudentFileManagment.Application.EducationDirections
{
    public interface IEducationDirectionRepository
    {
        Task<Guid> Add(EducationDirection educationDirection, CancellationToken cancellationToken = default);
        Task<Result<EducationDirection, Error>> GetById(Guid id, CancellationToken cancellationToken = default);
        Task<Result<EducationDirection, Error>> GetByName(string name, CancellationToken cancellationToken = default);
    }
}
