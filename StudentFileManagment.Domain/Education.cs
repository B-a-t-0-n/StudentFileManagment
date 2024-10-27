namespace StudentFileManagement.Domain
{
    public class Education
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public IEnumerable<InstitutionAndEducation>? InstitutionAndEducation { get; set; }
    }
}
