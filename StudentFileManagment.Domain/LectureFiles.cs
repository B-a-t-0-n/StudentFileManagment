namespace StudentFileManagement.Domain
{
    public class LectureFiles
    {
        public Guid Id { get; set; }
        public string? Comment { get; set; }
        public File File { get; set; } = default!;
        public User User { get; set; } = default!;
        public Lecture Lecture { get; set; } = default!;
    }
}
