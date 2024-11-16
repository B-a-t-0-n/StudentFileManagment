using CSharpFunctionalExtensions;
using Microsoft.EntityFrameworkCore;
using StudentFileManagement.Domain;
using StudentFileManagement.Infrastructure;
using StudentFileManagment.Application.EducationDirections;
using StudentFileManagment.Domain;
using StudentFileManagment.Domain.Shared;
using Error = StudentFileManagment.Domain.Shared.Error;

namespace StudentFileManagment.Infrastructure.Repositories
{
    public class EducationDirectionRepository : IEducationDirectionRepository
    {
        private readonly DataContext _dbContext;

        public EducationDirectionRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Add(EducationDirection educationDirection, CancellationToken cancellationToken = default)
        {
            await _dbContext.EducationDirections.AddAsync(educationDirection, cancellationToken);
            return educationDirection.Id;
        }

        public async Task<Result<Cource, Error>> GetByCourceId(Guid id, CancellationToken cancellationToken = default)
        {
            var cource = await _dbContext.Cources.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);

            if (cource is null)
                return Errors.General.NotFound(id);

            return cource;
        }

        public async Task<Result<EducationDirection, Error>> GetById(Guid id, CancellationToken cancellationToken = default)
        {
            var educationDirection = await _dbContext.EducationDirections.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);

            if (educationDirection is null)
                return Errors.General.NotFound(id);

            return educationDirection;
        }

        public async Task<Result<EducationDirection, Error>> GetByName(string name, CancellationToken cancellationToken = default)
        {
            var educationDirection = await _dbContext.EducationDirections.FirstOrDefaultAsync(e => e.Name == name, cancellationToken);

            if (educationDirection is null)
                return Error.NotFound("record.not.found", $"record not found for name {name}");

            return educationDirection;
        }

        public async Task<Result<Semester, Error>> GetBySemesterId(Guid id, CancellationToken cancellationToken = default)
        {
            var semester = await _dbContext.Semesters.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);

            if (semester is null)
                return Errors.General.NotFound(id);

            return semester;
        }
    }
}
