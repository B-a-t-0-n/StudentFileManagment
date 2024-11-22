namespace StudentFileManagement.Domain
{
    public class LectureData
    {
        public Guid Id { get; set; }
        public string? Comment { get; set; }
        public IEnumerable<File>? File { get; set; }
        public User User { get; set; } = default!;

        public Lecture Lecture { get; set; } = default!;
    }
}
