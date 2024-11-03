using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using StudentFileManagement.Domain;
using System.Text.RegularExpressions;
using File = StudentFileManagement.Domain.File;

namespace StudentFileManagement.Infrastructure
{
    public class DataContext(IConfiguration configuration) : DbContext
    {
        private const string DATABASE = "Database";

        public DbSet<User> Users { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<LectureFiles> LectureFiles { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<InstitutionAndEducation> InstitutionAndEducations { get; set; }
        public DbSet<Institution> Institutions { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<EducationDirection> EducationDirections { get; set; }
        public DbSet<Education> Educations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(configuration.GetConnectionString(DATABASE));
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);

            var educationsList = new List<Education>()
            {
                new Education() { Id = Guid.NewGuid(), Name = "СПО"},
                new Education() { Id = Guid.NewGuid(), Name = "Бакалавриат" },
                new Education() { Id = Guid.NewGuid(), Name = "Магистратура" }
            };

            var institutionList = new List<Institution>()
            {
                new Institution() { Id = Guid.NewGuid() , Name = "ВГЛТУ"}
            };

            var institutionAndEducationList = new List<InstitutionAndEducation>()
            {
                new InstitutionAndEducation() { Id = Guid.NewGuid(), EducationId = educationsList[0].Id, InstitutionId = institutionList[0].Id },
                new InstitutionAndEducation() { Id = Guid.NewGuid(), EducationId = educationsList[1].Id, InstitutionId = institutionList[0].Id },
                new InstitutionAndEducation() { Id = Guid.NewGuid(), EducationId = educationsList[2].Id, InstitutionId = institutionList[0].Id }
            };

            var educationDirectionList = new List<EducationDirection>()
            {
                new EducationDirection()
                {
                    Id = Guid.NewGuid(),
                    Name = "Информационные системы и программирование",
                    NumberCources = 4,
                    NumberSemesters = 2,
                    InstitutionAndEducationId = institutionAndEducationList[0].Id},
                new EducationDirection()
                {
                    Id = Guid.NewGuid(),
                    Name = "Информационные системы и программирование",
                    NumberCources = 4,
                    NumberSemesters = 2,
                    InstitutionAndEducationId = institutionAndEducationList[1].Id},
                new EducationDirection()
                {
                    Id = Guid.NewGuid(),
                    Name = "Информационные системы и программирование",
                    NumberCources = 4,
                    NumberSemesters = 2,
                    InstitutionAndEducationId = institutionAndEducationList[2].Id,
                },
            };

            var subjectsList = new List<Subject>()
            {
                new Subject()
                {
                    Id = Guid.NewGuid(),
                    Cource = 2,
                    EducationDirectionId = educationDirectionList[0].Id,
                    Semester = 1,
                    Name = "Проектирование и дизайн информационных систем"
                },
            };

            modelBuilder.Entity<Institution>().HasData(institutionList.ToArray());
            modelBuilder.Entity<Education>().HasData(educationsList.ToArray());
            modelBuilder.Entity<InstitutionAndEducation>().HasData(institutionAndEducationList.ToArray());
            modelBuilder.Entity<EducationDirection>().HasData(educationDirectionList.ToArray());
            modelBuilder.Entity<Subject>().HasData(subjectsList.ToArray());
        }
    }

}
