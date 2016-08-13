using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamGehem;
namespace localization
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Localization.csv";

            Localization l = Localization.Create(path);
            Localization.ChangeLanguage(1);




            //Console.WriteLine("Hello");

            //using (StreamReader sr = new StreamReader(path, Encoding.UTF8))
            //{
            //    while (!sr.EndOfStream)
            //    {
            //        string s = sr.ReadLine();
            //        string[] temp = s.Split(',');        // Split() 메서드를 이용하여 ',' 구분하여 잘라냄
            //        if (temp.Length > 2)
            //        {
            //            Console.WriteLine("{0},{1},{2}", temp[0], temp[1], temp[2]);
            //        }
            //        else if (temp.Length > 1)
            //        {
            //            Console.WriteLine("{0},{1}", temp[0], temp[1]);
            //        }
            //    }
            //}
        }
    }
}
