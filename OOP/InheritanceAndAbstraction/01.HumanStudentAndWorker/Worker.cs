using System;

namespace _01.HumanStudentAndWorker
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker(decimal weekSalary, int workHoursPerDay, string firstName, string lastName)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get { return weekSalary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The salart cannot be negative!");
                }

                weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get { return workHoursPerDay; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The salart cannot be negative!");
                }

                workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            return this.WeekSalary / this.WorkHoursPerDay / this.WorkHoursPerDay;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Week salary: {0}\nWork hours per day: {1}\nMoney per hour: {2:f2}\n{3}"
                , this.WeekSalary, this.WorkHoursPerDay, this.MoneyPerHour(), new String('-', 20));
        }
    }
}
