using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StudentFileManagement.Infrastructure;
using StudentFileManagment.Application.Database;
using StudentFileManagment.Application.Lectures;
using StudentFileManagment.Application.Providers;
using StudentFileManagment.Infrastructure.Providers;
using StudentFileManagment.Infrastructure.Repositories;
using Minio;
using StudentFileManagment.Infrastructure.Options;

namespace StudentFileManagment.Infrastructure
{
    public static class Inject
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddScoped<DataContext>();
            services.AddScoped<ILectureRepositiry, LectureRepositiry>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddMinio(configuration);

            return services;
        }

        private static IServiceCollection AddMinio(
            this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMinio(options =>
            {
                var minioOptions = configuration.GetSection(MinioOptions.MINIO).Get<MinioOptions>()
                    ?? throw new ApplicationException("Missing minio configuration");

                options.WithEndpoint(minioOptions.Endpoint);

                options.WithCredentials(minioOptions.AccessKey, minioOptions.SecretKey);
                options.WithSSL(minioOptions.WithSSL);
            });

            services.AddScoped<IFileProvider, MinioProvider>();

            return services;
        }
    }
}
