using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt= DateTime.Now;
            Console.WriteLine(dt);
            string dt2= DateTime.Now.ToString("dd.MM.yyyy");
            string dt3= DateTime.Now.ToString("HH:mm:ss");
            Console.WriteLine(dt2);
            Console.WriteLine(dt3);

            string a="20";
             int number= int.Parse(a); //Parse function of int class that can make transform string values to int
             string ad = number.ToString();
             int number2=Convert.ToInt32(ad);

             Console.WriteLine(number2);
        }
    }
}
