namespace _04.StudentClass
{
    using System.ComponentModel;

    public class CustomEventArgs : PropertyChangedEventArgs
    {
        public CustomEventArgs(string oldValue, string newValue, string propertyName)
            : base(propertyName)
        {
            this.OldValue = oldValue;
            this.NewValue = newValue;
        }

        public string OldValue { get; private set; }

        public string NewValue { get; private set; }
    }
}
