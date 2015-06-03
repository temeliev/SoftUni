using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem
{
    public class SULSTest
    {
        public List<object> Objects { get; set; }
        public SULSTest()
        {
            Objects = new List<object>();
            CreateCurrentStudents();
            CreateJuniorTrainers();
            CreatePersons();
            CreateStudents();
            CreateTrainers();
            CreateSeniorTrainers();
        }

        public void CreatePersons()
        {

            Person person1 = new Person();
            person1.FirstName = "Ivan";
            person1.LastName = "Ivanov";
            person1.Age = 18;
            Objects.Add(person1);

            Person person2 = new Person();
            person2.FirstName = "Petkan";
            person2.LastName = "Yordanov";
            person2.Age = 28;
            Objects.Add(person2);

            Person person3 = new Person();
            person3.FirstName = "Maria";
            person3.LastName = "Porteva";
            person3.Age = 22;
            Objects.Add(person3);
        }

        public void CreateTrainers()
        {
            Trainer trainer1 = new Trainer();
            trainer1.FirstName = "Gosho";
            trainer1.LastName = "Geshev";
            trainer1.Age = 28;
            Objects.Add(trainer1);

            Trainer trainer2 = new Trainer();
            trainer2.FirstName = "Toncho";
            trainer2.LastName = "Perchemov";
            trainer2.Age = 38;
            Objects.Add(trainer2);

            Trainer trainer3 = new Trainer();
            trainer3.FirstName = "Veneta";
            trainer3.LastName = "Raikova";
            trainer3.Age = 100;
            Objects.Add(trainer3);
        }

        public void CreateJuniorTrainers()
        {
            JuniorTrainer jtrainer1 = new JuniorTrainer();
            jtrainer1.FirstName = "Gancho";
            jtrainer1.LastName = "Terminatora";
            jtrainer1.Age = 60;
            Objects.Add(jtrainer1);

            JuniorTrainer jtrainer2 = new JuniorTrainer();
            jtrainer2.FirstName = "Mara";
            jtrainer2.LastName = "Podrobnata";
            jtrainer2.Age = 20;
            Objects.Add(jtrainer2);

            JuniorTrainer jtrainer3 = new JuniorTrainer();
            jtrainer3.FirstName = "Vesela";
            jtrainer3.LastName = "Praznikova";
            jtrainer3.Age = 24;
            Objects.Add(jtrainer3);
        }

        public void CreateSeniorTrainers()
        {
            SeniorTrainer strainer1 = new SeniorTrainer();
            strainer1.FirstName = "Venio";
            strainer1.LastName = "Vipera";
            strainer1.Age = 60;
            Objects.Add(strainer1);

            SeniorTrainer strainer2 = new SeniorTrainer();
            strainer2.FirstName = "Gena";
            strainer2.LastName = "Krokodila";
            strainer2.Age = 20;
            Objects.Add(strainer2);

            SeniorTrainer strainer3 = new SeniorTrainer();
            strainer3.FirstName = "Traicho";
            strainer3.LastName = "Kechista";
            strainer3.Age = 24;
            Objects.Add(strainer3);
        }

        public void CreateStudents()
        {
            Student student1 = new Student();
            student1.FirstName = "Gancho";
            student1.LastName = "Gandi";
            student1.Age = 60;
            Objects.Add(student1);

            Student student2 = new Student();
            student2.FirstName = "Mara";
            student2.LastName = "Otvarachkata";
            student2.Age = 20;
            Objects.Add(student2);

            Student student3 = new Student();
            student3.FirstName = "Todor";
            student3.LastName = "Todo";
            student3.Age = 24;
            Objects.Add(student3);
        }

        public void CreateCurrentStudents()
        {
            CurrentStudent student1 = new CurrentStudent();
            student1.FirstName = "Jeko";
            student1.LastName = "Kokala";
            student1.Age = 20;
            student1.AverageGrade = 5.51;
            student1.CurrentCourse = "OOP";
            student1.Number = 10001;
            Objects.Add(student1);

            CurrentStudent student2 = new CurrentStudent();
            student2.FirstName = "Kuna";
            student2.LastName = "Babeva";
            student2.Age = 73;
            student2.AverageGrade = 3.22;
            student2.CurrentCourse = "OOP";
            student2.Number = 10002;
            Objects.Add(student2);

            CurrentStudent student3 = new CurrentStudent();
            student3.FirstName = "Heal";
            student3.LastName = "Nomana";
            student3.Age = 24;
            student3.AverageGrade = 4;
            student3.CurrentCourse = "OOP";
            student3.Number = 10003;
            Objects.Add(student3);
        }


    }
}
