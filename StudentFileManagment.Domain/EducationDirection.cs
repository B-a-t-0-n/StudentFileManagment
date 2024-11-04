using StudentFileManagment.Domain;

namespace StudentFileManagement.Domain
{
    public class EducationDirection
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public IEnumerable<Cource>? Cources { get; set; }
        public Guid InstitutionAndEducationId { get; set; }
        public InstitutionAndEducation InstitutionAndEducation { get; set; } = default!;
    }
}
