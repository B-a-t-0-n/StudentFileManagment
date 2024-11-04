using StudentFileManagement.Domain;

namespace StudentFileManagment.Domain
{
    public class Semester
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public Guid CourceId { get; set; }
        public Cource Cource { get; set; } = null!;
        public IEnumerable<Subject>? Subjects { get; set; }
    }
}
