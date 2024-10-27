namespace StudentFileManagement.Domain
{
    public class User
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Nickname { get; set; }
        public long ChatId { get; set; }
        public Role Role { get; set; } = default!;
        public IEnumerable<LectureFiles>? LectureFiles { get; set; }
    }
}
