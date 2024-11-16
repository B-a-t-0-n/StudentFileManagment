using CSharpFunctionalExtensions;
using Microsoft.EntityFrameworkCore;
using StudentFileManagement.Domain;
using StudentFileManagement.Infrastructure;
using StudentFileManagment.Application.Users;
using StudentFileManagment.Domain.Shared;

namespace StudentFileManagment.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _dbContext;

        public UserRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Add(User user, CancellationToken cancellationToken = default)
        {
            await _dbContext.Users.AddAsync(user, cancellationToken);
            return user.Id;
        }

        public async Task<Result<User, Error>> GetByChatId(long chatId, CancellationToken cancellationToken = default)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.ChatId == chatId, cancellationToken);

            if (user is null)
                return Error.NotFound("record.not.found", $"record not found for chatId {chatId}");


            return user;
        }

        public async Task<Result<User, Error>> GetById(Guid id, CancellationToken cancellationToken = default)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == id, cancellationToken);

            if (user is null)
                return Errors.General.NotFound(id);

            return user;
        }
    }
}
