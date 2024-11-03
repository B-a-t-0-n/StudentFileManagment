namespace StudentFileManagement.Domain
{
    public class InstitutionAndEducation
    {
        public Guid Id { get; set; }
        public Guid InstitutionId { get; set; }
        public Institution Institution { get; set; } = default!;
        public Guid EducationId { get; set; }
        public Education Education { get; set; } = default!;
        public Guid DirectionsId { get; set; }
        public IEnumerable<EducationDirection>? Directions { get; set; }
    }
}
