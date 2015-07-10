namespace _03.CompanyHierarchy
{
    public interface IEmployee
    {
        decimal Salary { get; set; }
        DepartmentType Department { get; set; }
    }
}
