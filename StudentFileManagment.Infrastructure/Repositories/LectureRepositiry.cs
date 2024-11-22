using CSharpFunctionalExtensions;
using Microsoft.EntityFrameworkCore;
using StudentFileManagement.Domain;
using StudentFileManagement.Infrastructure;
using StudentFileManagment.Application.Lectures;
using StudentFileManagment.Domain.Shared;
using Error = StudentFileManagment.Domain.Shared.Error;

namespace StudentFileManagment.Infrastructure.Repositories
{
    public class LectureRepositiry : ILectureRepositiry
    {
        private readonly DataContext _dbContext;

        public LectureRepositiry(DataContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Guid> Add(Lecture lecture, CancellationToken cancellationToken = default)
        {
            await _dbContext.Lectures.AddAsync(lecture, cancellationToken);
            return lecture.Id;
        }

        public async Task<Result<Lecture, Error>> GetByDate(DateOnly date, CancellationToken cancellationToken = default)
        {
            var lecture = await _dbContext.Lectures.Include(l => l.Files)
                                                   .FirstOrDefaultAsync(l => l.Date == date, cancellationToken);

            if (lecture is null)
                return Error.NotFound("record.not.found", $"record not found for date {date}");

            return lecture;
        }

        public async Task<Result<Lecture, Error>> GetById(Guid id, CancellationToken cancellationToken = default)
        {
            var lecture = await _dbContext.Lectures.Include(l => l.Files).ThenInclude(l => l.User)
                                                   .FirstOrDefaultAsync(l => l.Id == id, cancellationToken);

            if (lecture is null)
                return Errors.General.NotFound(id);

            return lecture;
        }
    }
}