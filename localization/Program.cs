using System;
using System.Collections.Generic;
using TeamGehem;
namespace localization
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Localization.csv";

            Localization l = Localization.Create(path);

            Console.WriteLine(Localization.GetValue("KEY"));
            Console.WriteLine(Localization.GetValue("Login_Message"));
            Localization.ChangeLanguage(1);
            Console.WriteLine(Localization.GetValue("KEY"));
            Console.WriteLine(Localization.GetValue("Login_Message"));

        }
    }
}
