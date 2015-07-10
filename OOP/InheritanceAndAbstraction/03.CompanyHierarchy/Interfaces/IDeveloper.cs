using System.Collections.Generic;

namespace _03.CompanyHierarchy
{
    public interface IDeveloper
    {
        List<Project> Projects { get; set; }
    }
}