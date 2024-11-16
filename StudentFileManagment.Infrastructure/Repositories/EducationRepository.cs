using CSharpFunctionalExtensions;
using Microsoft.EntityFrameworkCore;
using StudentFileManagement.Domain;
using StudentFileManagement.Infrastructure;
using StudentFileManagment.Application.Educations;
using StudentFileManagment.Domain.Shared;
using Error = StudentFileManagment.Domain.Shared.Error;

namespace StudentFileManagment.Infrastructure.Repositories
{
    public class EducationRepository : IEducationRepository
    {
        private readonly DataContext _dbContext;

        public EducationRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Guid> Add(Education education, CancellationToken cancellationToken = default)
        {
            await _dbContext.Educations.AddAsync(education, cancellationToken);
            return education.Id;
        }

        public async Task<Result<Education, Error>> GetById(Guid id, CancellationToken cancellationToken = default)
        {
            var education = await _dbContext.Educations.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);

            if (education is null)
                return Errors.General.NotFound(id);

            return education;
        }

        public async Task<Result<Education, Error>> GetByName(string name, CancellationToken cancellationToken = default)
        {
            var education = await _dbContext.Educations.FirstOrDefaultAsync(e => e.Name == name, cancellationToken);

            if (education is null)
                return Error.NotFound("record.not.found", $"record not found for name {name}");

            return education;
        }
    }
}
