namespace StudentFileManagment.Bot.Features
{
    public static class Command
    {
        public const string Institution = "/Institution";
        public const string Education = "/Education";
        public const string EducationDirections = "/EducationDirections";
        public const string Cource = "/Cource";
        public const string Semester = "/Semester";
        public const string Subject = "/Subject";
        public const string Lecture = "/Lecture";
        public const string AddLecture = "/AddLecture";
    }

    public static class UserState
    {
        public static Dictionary<long, (string, Guid)> UserStates = new Dictionary<long, (string, Guid)>();

        public const string AddLecture = "/AddLecture";
    }
}
