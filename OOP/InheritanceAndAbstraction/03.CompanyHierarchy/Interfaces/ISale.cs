using System;

namespace _03.CompanyHierarchy
{
    public interface ISale
    {
        string ProductName { get; set; }
        DateTime ProductDate { get; set; }
        decimal ProductPrice { get; set; }
    }
}