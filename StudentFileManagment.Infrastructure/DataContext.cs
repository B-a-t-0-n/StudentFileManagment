using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using StudentFileManagement.Domain;
using StudentFileManagment.Domain;
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
        public DbSet<Cource> Cources { get; set; }
        public DbSet<Semester> Semesters { get; set; }

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
                    InstitutionAndEducationId = institutionAndEducationList[0].Id,
                },
                new EducationDirection()
                {
                    Id = Guid.NewGuid(),
                    Name = "Информационные системы и программирование",
                    InstitutionAndEducationId = institutionAndEducationList[1].Id},
                new EducationDirection()
                {
                    Id = Guid.NewGuid(),
                    Name = "Информационные системы и программирование",
                    InstitutionAndEducationId = institutionAndEducationList[2].Id,
                },
            };

            var courceList = new List<Cource>()
            {
                new Cource()
                {
                    Id = Guid.NewGuid(),
                    Number = 1,
                    EducationDirectionId = educationDirectionList[0].Id,
                },
                new Cource()
                {
                    Id = Guid.NewGuid(),
                    Number = 2,
                    EducationDirectionId = educationDirectionList[0].Id,
                },
                new Cource()
                {
                    Id = Guid.NewGuid(),
                    Number = 3,
                    EducationDirectionId = educationDirectionList[0].Id,
                },
                new Cource()
                {
                    Id = Guid.NewGuid(),
                    Number = 4,
                    EducationDirectionId = educationDirectionList[0].Id,
                },
                new Cource()
                {
                    Id = Guid.NewGuid(),
                    Number = 1,
                    EducationDirectionId = educationDirectionList[1].Id,
                },
                new Cource()
                {
                    Id = Guid.NewGuid(),
                    Number = 2,
                    EducationDirectionId = educationDirectionList[1].Id,
                },
                new Cource()
                {
                    Id = Guid.NewGuid(),
                    Number = 3,
                    EducationDirectionId = educationDirectionList[1].Id,
                },
                new Cource()
                {
                    Id = Guid.NewGuid(),
                    Number = 4,
                    EducationDirectionId = educationDirectionList[1].Id,
                },
                new Cource()
                {
                    Id = Guid.NewGuid(),
                    Number = 1,
                    EducationDirectionId = educationDirectionList[2].Id,
                },
                new Cource()
                {
                    Id = Guid.NewGuid(),
                    Number = 2,
                    EducationDirectionId = educationDirectionList[2].Id,
                }
            };

            var semesterList = new List<Semester>() 
            {
                new Semester()
                {
                    Id = Guid.NewGuid(),
                    Number = 1,
                    CourceId = courceList[0].Id,
                },
                new Semester()
                {
                    Id = Guid.NewGuid(),
                    Number = 2,
                    CourceId = courceList[0].Id,
                },
                new Semester()
                {
                    Id = Guid.NewGuid(),
                    Number = 1,
                    CourceId = courceList[1].Id,
                },
                new Semester()
                {
                    Id = Guid.NewGuid(),
                    Number = 2,
                    CourceId = courceList[1].Id,
                },
                new Semester()
                {
                    Id = Guid.NewGuid(),
                    Number = 1,
                    CourceId = courceList[2].Id,
                },
                new Semester()
                {
                    Id = Guid.NewGuid(),
                    Number = 2,
                    CourceId = courceList[2].Id,
                },
                new Semester()
                {
                    Id = Guid.NewGuid(),
                    Number = 1,
                    CourceId = courceList[3].Id,
                },
                new Semester()
                {
                    Id = Guid.NewGuid(),
                    Number = 2,
                    CourceId = courceList[3].Id,
                },

                new Semester()
                {
                    Id = Guid.NewGuid(),
                    Number = 1,
                    CourceId = courceList[4].Id,
                },
                new Semester()
                {
                    Id = Guid.NewGuid(),
                    Number = 2,
                    CourceId = courceList[4].Id,
                },
                new Semester()
                {
                    Id = Guid.NewGuid(),
                    Number = 1,
                    CourceId = courceList[5].Id,
                },
                new Semester()
                {
                    Id = Guid.NewGuid(),
                    Number = 2,
                    CourceId = courceList[5].Id,
                },
                new Semester()
                {
                    Id = Guid.NewGuid(),
                    Number = 1,
                    CourceId = courceList[6].Id,
                },
                new Semester()
                {
                    Id = Guid.NewGuid(),
                    Number = 2,
                    CourceId = courceList[6].Id,
                },
                new Semester()
                {
                    Id = Guid.NewGuid(),
                    Number = 1,
                    CourceId = courceList[7].Id,
                },
                new Semester()
                {
                    Id = Guid.NewGuid(),
                    Number = 2,
                    CourceId = courceList[7].Id,
                },

                new Semester()
                {
                    Id = Guid.NewGuid(),
                    Number = 1,
                    CourceId = courceList[8].Id,
                },
                new Semester()
                {
                    Id = Guid.NewGuid(),
                    Number = 2,
                    CourceId = courceList[8].Id,
                },

                new Semester()
                {
                    Id = Guid.NewGuid(),
                    Number = 1,
                    CourceId = courceList[9].Id,
                },
                new Semester()
                {
                    Id = Guid.NewGuid(),
                    Number = 2,
                    CourceId = courceList[9].Id,
                },
            };

            var subjectsList = new List<Subject>()
            {
                new Subject()
                {
                    Id = Guid.NewGuid(),
                    Name = "Проектирование и дизайн информационных систем",
                    SemesterId = semesterList[2].Id,
                },
            };

            modelBuilder.Entity<Institution>().HasData(institutionList.ToArray());
            modelBuilder.Entity<Education>().HasData(educationsList.ToArray());
            modelBuilder.Entity<InstitutionAndEducation>().HasData(institutionAndEducationList.ToArray());
            modelBuilder.Entity<EducationDirection>().HasData(educationDirectionList.ToArray());
            modelBuilder.Entity<Cource>().HasData(courceList.ToArray());
            modelBuilder.Entity<Semester>().HasData(semesterList.ToArray());
            modelBuilder.Entity<Subject>().HasData(subjectsList.ToArray());
        }
    }

}
