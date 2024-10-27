namespace StudentFileManagement.Domain
{
    public class Lecture
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public DateOnly Date { get; set; }
        public Subject Subject { get; set; } = default!;
        public IEnumerable<LectureFiles>? Files { get; set; }
    }
}
