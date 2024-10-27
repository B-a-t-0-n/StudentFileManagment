namespace StudentFileManagement.Domain
{
    public class File
    {
        public Guid Id { get; set; }
        public string Path { get; set; } = default!;
        public IEnumerable<LectureFiles>? LectureFiles { get; set; }
    }
}
