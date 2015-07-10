using System;

namespace _03.CompanyHierarchy
{
    public interface IProject
    {
        string ProjectName { get; set; }
        DateTime ProjectStartDate { get; set; }
        string ProjectDetails { get; set; }
        ProjectState CurrentState { get; set; }
        void CloseProject();
    }
}