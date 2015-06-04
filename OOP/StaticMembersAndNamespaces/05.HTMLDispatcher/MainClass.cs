using System;

namespace _05.HTMLDispatcher
{
    class MainClass
    {
        static void Main()
        {
            ElementBuilder div = new ElementBuilder("div");
            div.AddAttribute("id", "page");
            div.AddAttribute("class", "big");
            div.AddContent("<p>Hello</p>");
            Console.WriteLine(div * 3);

            Console.WriteLine(HTMLDispatcher.CreateImage("www.test.com/my.jpg", "i dont know", "alabala"));
            Console.WriteLine(HTMLDispatcher.CreateInput("text", "test1", "TEST"));
            Console.WriteLine(HTMLDispatcher.CreateURL("https://google.com", "google", "google.com"));
        }
    }
}
