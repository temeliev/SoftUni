using System.Collections.Generic;

namespace _03.CompanyHierarchy
{
    public interface ISalesEmployee
    {
        List<Sale> Sales { get; set; }
    }
}