namespace StudentFileManagement.Domain
{
    public class InstitutionAndEducation
    {
        public Guid Id { get; set; }
        public Institution Institution { get; set; } = default!;
        public Education Education { get; set; } = default!;

    }
}
