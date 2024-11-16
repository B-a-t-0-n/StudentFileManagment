using CSharpFunctionalExtensions;
using Microsoft.Extensions.Logging;
using StudentFileManagement.Domain;
using StudentFileManagment.Application.Database;
using StudentFileManagment.Application.FileProvider;
using StudentFileManagment.Application.Lectures.Create;
using StudentFileManagment.Application.Providers;
using StudentFileManagment.Domain.Shared;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using File = StudentFileManagement.Domain.File;

namespace StudentFileManagment.Application.Lectures.UploadFilesToLecture
{
    public class UploadFilesToLectureHandler
    {
        private const string BUCKET_NAME = "lecture";

        private readonly ILectureRepositiry _lectureRepository;
        private readonly IFileProvider _fileProvider;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UploadFilesToLectureHandler> _logger;

        public UploadFilesToLectureHandler(
            ILectureRepositiry lectureRepository,
            IUnitOfWork unitOfWork,
            IFileProvider fileProvider,
            ILogger<UploadFilesToLectureHandler> logger)
        {
            _lectureRepository = lectureRepository;
            _unitOfWork = unitOfWork;
            _fileProvider = fileProvider;
            _logger = logger;
        }

        public async Task<Result<Guid, Error>> Handle(UploadFilesToLectureCommand command, CancellationToken cancellationToken = default)
        {
            var lectureResult = await _lectureRepository.GetById(command.LectureId);
            if (lectureResult.IsFailure)
                return lectureResult.Error;

            var lectureData = lectureResult.Value.Files!.FirstOrDefault(f => f.Id == command.LectureDataId);
            if (lectureData is null)
                return Errors.General.NotFound(command.LectureDataId);

            List<FileData> filesData = [];
            foreach (var file in command.Files)
            {
                var extension = Path.GetExtension(file.FileName);

                var filePath = Guid.NewGuid() + extension;
                
                var fileData = new FileData(file.Content, filePath, BUCKET_NAME);

                filesData.Add(fileData);
            }

            var filePathsResult = await _fileProvider.UploadFiles(filesData, cancellationToken);
            if (filePathsResult.IsFailure)
                return filePathsResult.Error;

            var lctureFiles = filePathsResult.Value
                .Select(f => new File() { Id = new Guid(), Path = f})
                .ToList();

            lectureData.File!.ToList().AddRange(lctureFiles);

            await _unitOfWork.SaveChanges(cancellationToken);

            _logger.LogInformation("Success uploaded files to lectureData - {id}", lectureData.Id);

            return lectureData.Id;
        }
    }
}
