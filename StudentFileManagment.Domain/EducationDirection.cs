namespace StudentFileManagement.Domain
{
    public class EducationDirection
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public int NumberCources { get; set; }
        public int NumberSemesters { get; set; }
        public Institution Institution { get; set; } = default!;
        public IEnumerable<Subject>? Subjects { get; set; }
    }
}
