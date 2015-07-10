using System;

namespace _04.GenericListVersion
{
    [AttributeUsage(AttributeTargets.Class |
                       AttributeTargets.Struct | 
                       AttributeTargets.Interface | 
                       AttributeTargets.Enum | 
                       AttributeTargets.Method,
                       AllowMultiple = false)]
    public class VersionAttribute : Attribute
    {
        public double Version { get; set; }

        public VersionAttribute()
        {
            this.Version = 1.0;
        }

        public override string ToString()
        {
            return "Version : " + this.Version;
        }
    }
}
