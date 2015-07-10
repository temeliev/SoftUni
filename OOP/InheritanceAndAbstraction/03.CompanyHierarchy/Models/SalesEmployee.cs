using System;
using System.Collections.Generic;

namespace _03.CompanyHierarchy
{
    public class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        private List<Sale> sales;

        public SalesEmployee(int id, string firstName, string lastName, decimal salary, DepartmentType type, List<Sale> sales)
            : base(id, firstName, lastName, salary, type)
        {
            this.Sales = sales;
        }

        public List<Sale> Sales
        {
            get { return sales; }
            set
            {
                if (value == null || value.Count == 0)
                {
                    throw new ArgumentException("Sales must hold a set of sales!");
                }

                this.sales = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Set of sales: \n{0}", string.Join("", this.Sales));
        }
    }
}
