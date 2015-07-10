namespace RestaurantManager.Models
{
    using System;
    using System.Text;

    using RestaurantManager.Interfaces;

    public class MainCourse : Meal, IMainCourse
    {
        public MainCourse(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isVegan, string type)
            : base(name, price, calories, quantityPerServing, timeToPrepare, isVegan)
        {
            this.Type = (MainCourseType)Enum.Parse(typeof(MainCourseType), type);
        }

        public MainCourseType Type { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (this.IsVegan)
            {
                sb.Append("[VEGAN] ");
            }

            sb.Append(base.ToString());
            sb.AppendFormat("Type: {0}", this.Type).AppendLine();

            return sb.ToString();
        }
    }
}
