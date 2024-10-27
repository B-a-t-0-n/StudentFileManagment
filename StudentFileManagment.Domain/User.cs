namespace StudentFileManagement.Domain
{
    public class User
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Nickname { get; set; }
        public long ChatId { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsModerator { get; set; }
        public IEnumerable<LectureFiles>? LectureFiles { get; set; }
    }
}
