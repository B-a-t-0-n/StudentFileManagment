using CSharpFunctionalExtensions;
using StudentFileManagement.Domain;
using StudentFileManagment.Domain.Shared;

namespace StudentFileManagment.Application.Institutions
{
    public interface IInstitutionRepository
    {
        Task<Guid> Add(Institution institution, CancellationToken cancellationToken = default);
        Task<Result<Institution, Error>> GetById(Guid id, CancellationToken cancellationToken = default);
        Task<Result<InstitutionAndEducation, Error>> GetInstitutionAndEducationById(Guid id, CancellationToken cancellationToken = default);
        Task<Result<Institution, Error>> GetByName(string name, CancellationToken cancellationToken = default);
    }
}
