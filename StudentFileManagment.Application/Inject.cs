using Microsoft.Extensions.DependencyInjection;
using StudentFileManagment.Application.EducationDirections.AddCousce;
using StudentFileManagment.Application.EducationDirections.AddSemester;
using StudentFileManagment.Application.EducationDirections.Creaate;
using StudentFileManagment.Application.Educations.Create;
using StudentFileManagment.Application.Institutions.AddEducation;
using StudentFileManagment.Application.Institutions.Create;
using StudentFileManagment.Application.Lectures.AddLectureData;
using StudentFileManagment.Application.Lectures.Create;
using StudentFileManagment.Application.Lectures.UploadFilesToLecture;
using StudentFileManagment.Application.Subjects.Create;
using StudentFileManagment.Application.Users.Create;

namespace StudentFileManagment.Application
{
    public static class Inject
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<CreateUserHandler>();
            services.AddScoped<CreateSubjectHandler>();
            services.AddScoped<UploadFilesToLectureHandler>();
            services.AddScoped<CreateLectureHandler>();
            services.AddScoped<AddLectureDataHandler>();
            services.AddScoped<CreateInstitutionHandler>();
            services.AddScoped<AddEducationHandler>();
            services.AddScoped<CreateEducationHandler>();
            services.AddScoped<CreateEducationDirectionHandler>();
            services.AddScoped<AddSemesterHandler>();
            services.AddScoped<AddCourceHandler>();

            return services;
        }
    }
}
