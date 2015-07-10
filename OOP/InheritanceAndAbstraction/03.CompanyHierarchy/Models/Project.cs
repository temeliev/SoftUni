using System;

namespace _03.CompanyHierarchy
{
    public class Project : IProject
    {
        private string projectName;
        private DateTime projectStartDate;
        private string projectDetails;

        public Project(string projectName, DateTime projectStartDate, string projectDetails, ProjectState state)
        {
            this.ProjectName = projectName;
            this.ProjectStartDate = projectStartDate;
            this.ProjectDetails = projectDetails;
            this.CurrentState = state;
        }

        public string ProjectName
        {
            get { return this.projectName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The project name is missing!");
                }

                this.projectName = value;
            }
        }

        public DateTime ProjectStartDate
        {
            get { return this.projectStartDate; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The project start date is missing!");
                }

                this.projectStartDate = value;
            }
        }

        public string ProjectDetails
        {
            get { return this.projectDetails; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The project details are missing!");
                }

                this.projectDetails = value;
            }
        }

        public ProjectState CurrentState { get; set; }
        public void CloseProject()
        {
            this.CurrentState = ProjectState.Closed;
        }

        public override string ToString()
        {
            return string.Format("Project: {0}\nStart date: {1}\nDetails: {2}\nState: {3}\n", this.ProjectName,
                this.ProjectStartDate, this.ProjectDetails, this.CurrentState);
        }
    }

    public enum ProjectState { Open, Closed }
}
