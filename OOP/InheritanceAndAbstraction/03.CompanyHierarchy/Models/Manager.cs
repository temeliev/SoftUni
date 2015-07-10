using System;
using System.Collections.Generic;

namespace _03.CompanyHierarchy
{
    public class Manager : Employee, IManager
    {
        private List<Employee> employees;

        public Manager(int id, string firstName, string lastname, decimal salary, DepartmentType type, List<Employee> employees)
            : base(id, firstName, lastname, salary, type)
        {
            this.Employees = employees;
        }

        public List<Employee> Employees
        {
            get { return employees; }
            set
            {
                if (value == null || value.Count == 0)
                {
                    throw new ArgumentException("Manager must hold a set of employees!");
                }

                this.employees = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Set of employees: \n{0}", string.Join("", this.Employees));
        }
    }
}
