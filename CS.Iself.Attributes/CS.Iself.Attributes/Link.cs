using System;
using System.Collections.Generic;
using System.Text;

namespace CS.Iself.Attributes
{
    public class Link
    {
        [HelpAttribute("https://channel9.msdn.com", Topic = "Best practices videos and lessons") ]
        public void Display(string text)
        {
            Console.WriteLine(text);
        }
    }
}
