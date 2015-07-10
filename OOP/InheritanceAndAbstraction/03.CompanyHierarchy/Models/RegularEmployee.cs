namespace _03.CompanyHierarchy
{
    public class RegularEmployee : Employee, IRegularEmployee
    {
        public RegularEmployee(int id, string firstName, string lastName, decimal salary, DepartmentType type)
            : base(id, firstName, lastName, salary, type)
        {
        }
    }
}
