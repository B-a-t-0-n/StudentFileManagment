using CSharpFunctionalExtensions;
using StudentFileManagement.Domain;
using StudentFileManagment.Domain.Shared;

namespace StudentFileManagment.Application.Users
{
    public interface IUserRepository
    {
        Task<Guid> Add(User subject, CancellationToken cancellationToken = default);
        Task<Result<User, Error>> GetById(Guid id, CancellationToken cancellationToken = default);
        Task<Result<User, Error>> GetByChatId(long chatId, CancellationToken cancellationToken = default);
    }
}
