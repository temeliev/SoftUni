using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.HTMLDispatcher
{
    public class ElementBuilder
    {
        public ElementBuilder(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Element is null");
            }

            this.name = name;
            attributes = new Dictionary<string, string>();
        }

        private string content;
        private string name;
        private Dictionary<string, string> attributes;

        public void AddAttribute(string attribute, string value)
        {
            if (string.IsNullOrWhiteSpace(attribute) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Attrubute is null");
            }

            if (!attributes.ContainsKey(attribute))
            {
                attributes[attribute] = value;
            }
        }

        public void AddContent(string content)
        {
            if (string.IsNullOrWhiteSpace(content))
            {
                throw new ArgumentNullException("Content is null");
            }

            this.content = content;
        }

        public static string operator *(ElementBuilder element, int multiplier)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < multiplier; i++)
            {
                sb.Append(element);
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var attribute in this.attributes)
            {
                sb.AppendFormat(" {0}=\"{1}\"", attribute.Key, attribute.Value);
            }

            return string.Format("<{0}{1}>{2}</{0}>", this.name, sb, this.content);
        }
    }
}
