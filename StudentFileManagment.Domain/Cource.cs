using StudentFileManagement.Domain;

namespace StudentFileManagment.Domain
{
    public class Cource
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public Guid EducationDirectionId { get; set; }
        public EducationDirection EducationDirection { get; set; } = null!;
        public IEnumerable<Semester>? Semesters { get; set; }
    }
}
