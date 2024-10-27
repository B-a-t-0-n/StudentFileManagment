using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using StudentFileManagement.Domain;
using File = StudentFileManagement.Domain.File;

namespace StudentFileManagement.Infrastructure 
{ 
    public class DataContext(IConfiguration configuration) : DbContext 
    {
        private const string DATABASE = "Database";

        public DbSet<User> Users { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<LectureFiles> LectureFiles { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<InstitutionAndEducation> InstitutionAndEducations { get; set; }
        public DbSet<Institution> Institutions { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<EducationDirection> EducationDirections { get; set; }
        public DbSet<Education> Educations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(configuration.GetConnectionString(DATABASE));
            optionsBuilder.EnableSensitiveDataLogging();

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
        }
    }

}
