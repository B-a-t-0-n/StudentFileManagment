using StudentFileManagment.Application.Database;
using StudentFileManagment.Application.FileProvider;
using StudentFileManagment.Application.Providers;

namespace StudentFileManagment.Application.Lectures.AddLectureFiles
{
    public class AddLectureFilesHandler
    {
        private const string BUCKET_NAME = "lecture";

        private readonly ILectureRepositiry _lectureRepository;
        private readonly IFileProvider _fileProvider;
        private readonly IUnitOfWork _unitOfWork;

        public AddLectureFilesHandler(
            ILectureRepositiry lectureRepository,
            IUnitOfWork unitOfWork,
            IFileProvider fileProvider)
        {
            _lectureRepository = lectureRepository;
            _unitOfWork = unitOfWork;
            _fileProvider = fileProvider;
        }

        //public async Task<Guid> Handle(AddPetPhotosCommand command, CancellationToken cancellationToken = default)
        //{
        //    var transaction = await _unitOfWork.BeginTransaction(cancellationToken);

        //    try
        //    {
        //        var volunteerResult = await _volunteerRepository.GetById(
        //            VolunteerId.Create(command.VolunteerId), cancellationToken);

        //        if (volunteerResult.IsFailure)
        //            return volunteerResult.Error;

        //        var petId = PetId.Create(command.PetId);

        //        var pet = volunteerResult.Value.Pets.FirstOrDefault(p => p.Id == petId);
        //        if (pet is null)
        //            return Errors.General.NotFound(petId);

        //        List<FileData> filesData = [];
        //        foreach (var file in command.Files)
        //        {
        //            var extension = Path.GetExtension(file.FileName);

        //            var photoPathResult = PhotoPath.Create(Guid.NewGuid().ToString(), extension);
        //            if (photoPathResult.IsFailure)
        //                return photoPathResult.Error;

        //            var fileContent = new FileData(file.Content, photoPathResult.Value, BUCKET_NAME);

        //            var petPhotoId = PetPhotoId.NewPetPhotoId();

        //            var photoResult = PetPhoto.Create(petPhotoId, photoPathResult.Value, false);
        //            if (photoResult.IsFailure)
        //                return photoResult.Error;

        //            pet.AddPetPhoto(photoResult.Value);
        //        }

        //        await _unitOfWork.SaveChanges(cancellationToken);

        //        var uploadResult = await _fileProvider.UploadFiles(filesData, cancellationToken);

        //        if (uploadResult.IsFailure)
        //            return uploadResult.Error;

        //        transaction.Commit();

        //        return pet.Id.Value;
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex,
        //            "Can not add pet photos to pet - {id} in transaction", command.PetId);

        //        transaction.Rollback();
        //        return Error.Failure("Can not add pet photos to pet - {id}", "pet.petPhotos.failure");
        //    }
        //}
    }

    public record AddLectureFilesCommand();
}
