using CSharpFunctionalExtensions;
using StudentFileManagment.Application.FileProvider;
using StudentFileManagment.Domain.Shared;

namespace StudentFileManagment.Application.Providers
{
    public interface IFileProvider
    {
        Task<Result<IReadOnlyList<string>, Error>> UploadFiles(
            IEnumerable<FileData> filesData,
            CancellationToken cancellationToken = default);
        Task<Result<string, Error>> Deletefile(FileMetadata fileMetadata, CancellationToken cancellationToken = default);
        Task<Result<string, Error>> GetfileURL(FileMetadata fileMetadata, CancellationToken cancellationToken = default);
    }
}
