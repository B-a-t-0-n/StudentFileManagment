﻿namespace StudentFileManagement.Domain
{
    public class Lecture
    {
        public Guid Id { get; set; }
        public DateOnly Date { get; set; }
        public Subject Subject { get; set; } = default!;
        public IEnumerable<LectureData>? Files { get; set; }
    }
}
