using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HumanStudentAndWorker
{
    class HumanStudentAndWorker
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("1234561","Ivan","Ivanov"),
                new Student("1234571","Petkan","Ivanov"),
                new Student("1234511","Maria","Mareva"),
                new Student("1234599","Veneta","Mirchvea"),
                new Student("1234577","Lop","Vea"),
                new Student("1234512","We","Bee"),
                new Student("1234712","Maria","Huy"),
                new Student("1233599","Gre","Za"),
                new Student("1234577","Er","BNE"),
                new Student("1234512","IU","XC"),
            };

            students.OrderBy(x => x.FacultyNumber).ToList().ForEach(x => Console.WriteLine(x));

            List<Worker> workers = new List<Worker>()
            {
                new Worker(120,8,"Ivan1","Worker1"),
                new Worker(220,12,"Ivan2","Worker2"),
                new Worker(320,12,"Ivan3","Worker3"),
                new Worker(100,8,"Ivan4","Worker4"),
                new Worker(522,5,"Ivan5","Worker5"),
                new Worker(899,8,"Ivan6","Worker6"),
                new Worker(145,12,"Ivan7","Worker7"),
                new Worker(220,10,"Ivan8","Worker8"),
                new Worker(220,6,"Ivan9","Worker9"),
                new Worker(220,12,"Ivan10","Worker10")
            };

            workers.OrderByDescending(x => x.MoneyPerHour()).ToList().ForEach(x => Console.WriteLine(x));

            List<Human> humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(workers);

            humans.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
