using StudentFileManagment.Domain;

namespace StudentFileManagement.Domain
{
    public class Subject
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public Guid SemesterId { get; set; }
        public Semester Semester { get; set; } = null!;
        public IEnumerable<Lecture>? Lectures { get; set; }
    }
}
