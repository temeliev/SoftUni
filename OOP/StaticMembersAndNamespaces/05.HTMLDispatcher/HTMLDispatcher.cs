using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.HTMLDispatcher
{
    public static class HTMLDispatcher
    {
        public static string CreateImage(string imgSource, string alt, string title)
        {
            ElementBuilder img = new ElementBuilder("img");
            img.AddAttribute("title", title);
            img.AddAttribute("alt", alt);
            img.AddAttribute("src", imgSource);
            return img.ToString();
        }

        public static string CreateURL(string url, string title, string text)
        {
            ElementBuilder urlTag = new ElementBuilder("a");
            urlTag.AddAttribute("href", url);
            urlTag.AddAttribute("title", title);
            urlTag.AddContent(text);
            return urlTag.ToString();
        }


        public static string CreateInput(string inputType, string name, string value)
        {
            ElementBuilder input = new ElementBuilder("input");
            input.AddAttribute("name", name);
            input.AddAttribute("input", inputType);
            input.AddAttribute("value", value);
            return input.ToString();
        }
    }
}
