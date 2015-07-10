using System.Collections.Generic;

namespace _03.CompanyHierarchy
{
    public interface IManager
    {
        List<Employee> Employees { get; set; }
    }
}
