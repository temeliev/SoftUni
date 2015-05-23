using System.Collections.Generic;

namespace _13.LINQtoExcel
{
    public class Student
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string StudentType { get; set; }
        public int ExameResult { get; set; }
        public int HomeworkSent { get; set; }
        public int HomeworkEvaluated { get; set; }
        public decimal TeamworkScore { get; set; }
        public decimal AttendancesCount { get; set; }
        public decimal Bonus { get; set; }

        public decimal Result { get; private set; }

        public void CalculateResult()
        {
            Result = (ExameResult + HomeworkSent + HomeworkEvaluated + TeamworkScore + AttendancesCount + Bonus) / 5;
        }

    }
}
