using System;
using System.Reflection;

namespace CS.Iself.Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowHelp(typeof(Link));
            ShowHelp(typeof(Link).GetMethod("Display"));
        }

        static void ShowHelp(MemberInfo memberInfo)
        {
            HelpAttribute a = Attribute.GetCustomAttribute(memberInfo, typeof(HelpAttribute)) as HelpAttribute;
            if (a == null)
            {
                Console.WriteLine($"No help for {memberInfo}");
            }
            else
            {
                Console.WriteLine($"Help for {memberInfo}");
                Console.WriteLine($"Url: {a.Url}, Topic: {a.Topic}");
            }
        }
    }
}
