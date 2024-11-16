using CSharpFunctionalExtensions;
using Microsoft.EntityFrameworkCore;
using StudentFileManagement.Domain;
using StudentFileManagement.Infrastructure;
using StudentFileManagment.Application.Institutions;
using StudentFileManagment.Domain.Shared;

namespace StudentFileManagment.Infrastructure.Repositories
{
    public class InstitutionRepository : IInstitutionRepository
    {
        private readonly DataContext _dbContext;

        public InstitutionRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Add(Institution institution, CancellationToken cancellationToken = default)
        {
            await _dbContext.Institutions.AddAsync(institution, cancellationToken);
            return institution.Id;
        }

        public async Task<Result<Institution, Error>> GetById(Guid id, CancellationToken cancellationToken = default)
        {
            var institution = await _dbContext.Institutions.FirstOrDefaultAsync(i => i.Id == id, cancellationToken);

            if (institution is null)
                return Errors.General.NotFound(id);

            return institution;
        }

        public async Task<Result<Institution, Error>> GetByName(string name, CancellationToken cancellationToken = default)
        {
            var institution = await _dbContext.Institutions.FirstOrDefaultAsync(i => i.Name == name, cancellationToken);

            if (institution is null)
                return Error.NotFound("record.not.found", $"record not found for name {name}");

            return institution;
        }

        public async Task<Result<InstitutionAndEducation, Error>> GetInstitutionAndEducationById(Guid id, CancellationToken cancellationToken = default)
        {
            var institutionAndEducation = await _dbContext.InstitutionAndEducations.FirstOrDefaultAsync(i => i.Id == id);

            if (institutionAndEducation is null)
                return Errors.General.NotFound(id);

            return institutionAndEducation;
        }
    }
}
