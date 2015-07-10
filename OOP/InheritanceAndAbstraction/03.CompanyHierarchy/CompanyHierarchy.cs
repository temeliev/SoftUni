using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.CompanyHierarchy
{
    class CompanyHierarchy
    {
        static void Main()
        {
            List<Employee> Employees = new List<Employee>();
            Employee emp = new SalesEmployee(1, "SEmp1", "SEmpov1", 200, DepartmentType.Accounting, new List<Sale>()
            {
                new Sale("Product1",DateTime.Now, 120),
                new Sale("Product2",DateTime.Now, 320),
            });
            Employees.Add(emp);
            Employee emp2 = new SalesEmployee(2, "SEmp2", "SEmpov2", 300, DepartmentType.Accounting, new List<Sale>()
            {
                new Sale("Product1",DateTime.Now, 20),
                new Sale("Product2",DateTime.Now, 55),
            });
            Employees.Add(emp2);
            Employees.Add(emp);
            Employee emp3 = new SalesEmployee(3, "SEmp3", "SEmpov3", 266, DepartmentType.Marketing, new List<Sale>()
            {
                new Sale("Product1",DateTime.Now, 20),
                new Sale("Product2",DateTime.Now, 55),
            });
            Employees.Add(emp3);

            Employee dev1 = new Developer(4, "Dev1", "Devov1", 200, DepartmentType.Accounting, new List<Project>()
            {
                new Project("Project1",DateTime.Now, "Wera", ProjectState.Open),
                new Project("Project2",DateTime.Now.AddDays(-5), "Det", ProjectState.Closed),
            });
            Employees.Add(dev1);

            Employee dev2 = new Developer(5, "Dev2", "Devov2", 666, DepartmentType.Production, new List<Project>()
            {
                new Project("Project1",DateTime.Now, "Wera", ProjectState.Open),
                new Project("Project2",DateTime.Now.AddDays(-5), "Det", ProjectState.Closed),
            });
            Employees.Add(dev2);

            Employee dev3 = new Developer(6, "Dev1", "Devov1", 555, DepartmentType.Accounting, new List<Project>()
            {
                new Project("Project1",DateTime.Now, "Wera", ProjectState.Open),
                new Project("Project2",DateTime.Now.AddDays(-5), "Det", ProjectState.Closed),
            });
            Employees.Add(dev3);

            Manager man1 = new Manager(33, "Manager1", "Managerov1", 500, DepartmentType.Marketing, Employees.Where(x=>x.GetType()==typeof(Developer)).ToList());
            Manager man2 = new Manager(34, "Manager2", "Managerov2", 500, DepartmentType.Production, Employees.Where(x => x.GetType() == typeof(Developer)).ToList());
            Manager man3 = new Manager(35, "Manager3", "Managerov3", 600, DepartmentType.Accounting, Employees.Where(x => x.GetType() == typeof(SalesEmployee)).ToList());

            Employees.Add(man1);
            Employees.Add(man2);
            Employees.Add(man3);

            foreach (var e in Employees)
            {
                Console.WriteLine(e);
            }
        }
    }
}
