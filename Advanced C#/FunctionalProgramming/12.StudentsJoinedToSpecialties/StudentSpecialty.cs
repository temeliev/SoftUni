namespace _12.StudentsJoinedToSpecialties
{
    public class StudentSpecialty
    {
        public StudentSpecialty() { }

        public StudentSpecialty(string specialty, string facNum)
        {
            SpecialtyName = specialty;
            FacultyNumber = facNum;
        }
        public string SpecialtyName { get; set; }
        public string FacultyNumber { get; set; }
    }
}
