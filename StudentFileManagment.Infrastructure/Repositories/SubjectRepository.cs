using CSharpFunctionalExtensions;
using Microsoft.EntityFrameworkCore;
using StudentFileManagement.Domain;
using StudentFileManagement.Infrastructure;
using StudentFileManagment.Application.Subjects;
using StudentFileManagment.Domain.Shared;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Error = StudentFileManagment.Domain.Shared.Error;

namespace StudentFileManagment.Infrastructure.Repositories
{
    public class SubjectRepository : ISubjectRepository
    {
        private readonly DataContext _dbContext;

        public SubjectRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Add(Subject subject, CancellationToken cancellationToken = default)
        {
            await _dbContext.Subjects.AddAsync(subject, cancellationToken);
            return subject.Id;
        }

        public async Task<Result<Subject, Error>> GetById(Guid id, CancellationToken cancellationToken = default)
        {
            var subject = await _dbContext.Subjects.FirstOrDefaultAsync(s => s.Id == id, cancellationToken);

            if (subject is null)
                return Errors.General.NotFound(id);

            return subject;
        }

        public async Task<Result<Subject, Error>> GetByName(string name, CancellationToken cancellationToken = default)
        {
            var subject = await _dbContext.Subjects.FirstOrDefaultAsync(s => s.Name == name, cancellationToken);

            if (subject is null)
                return Error.NotFound("record.not.found", $"record not found for nane {name}");

            return subject;
        }
    }
}
