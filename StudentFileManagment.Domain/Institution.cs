namespace StudentFileManagement.Domain
{
    public class Institution
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public IEnumerable<InstitutionAndEducation>? InstitutionAndEducation { get; set; }
        public IEnumerable<EducationDirection>? Directions { get; set; }
    }
}
