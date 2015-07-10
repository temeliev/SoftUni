using System;

namespace _03.CompanyHierarchy
{
    public abstract class Employee : Person, IEmployee
    {
        private decimal salary;

        public Employee(int id, string firstName, string lastName, decimal salary, DepartmentType type)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Department = type;
        }

        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The salary is negative!");
                }

                salary = value;
            }
        }

        public DepartmentType Department { get; set; }

        public override string ToString()
        {
            return base.ToString() + string.Format("Salary: {0:f2} lv.\nDepartment: {1}\n", this.Salary, this.Department);
        }
    }

    public enum DepartmentType { Production, Accounting, Sales, Marketing }
}
