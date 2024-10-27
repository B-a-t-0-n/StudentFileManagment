namespace StudentFileManagement.Domain
{
    public class Role
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public IEnumerable<User>? Users { get; set; }
    }
}
