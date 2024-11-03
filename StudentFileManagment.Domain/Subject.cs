namespace StudentFileManagement.Domain
{
    public class Subject
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public int Cource { get; set; }
        public int Semester { get; set; }
        public Guid EducationDirectionId { get; set; }
        public EducationDirection EducationDirection { get; set; } = default!;
        public IEnumerable<Lecture>? Lectures { get; set; }
    }
}
