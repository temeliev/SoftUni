using System;
using System.Collections.Generic;

namespace _03.CompanyHierarchy
{
    public class Developer : RegularEmployee, IDeveloper
    {
        private List<Project> projects;

        public Developer(int id, string firstName, string lastName, decimal salary, DepartmentType type, List<Project> projects)
            : base(id, firstName, lastName, salary, type)
        {
            this.Projects = projects;
        }

        public List<Project> Projects
        {
            get { return this.projects; }
            set
            {
                if (value == null || value.Count == 0)
                {
                    throw new ArgumentException("Developer must hold a set of projects!");
                }

                this.projects = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Set of projects: \n{0}", string.Join("", this.Projects));
        }
    }
}
