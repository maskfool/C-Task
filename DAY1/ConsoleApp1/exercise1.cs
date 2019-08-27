using System;


namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            int convert_1 = Convert.ToInt32(number);
            int x1 = convert_1 + 5;
            int convert_2 = Int32.Parse(number);
            int x2 = convert_2 + 5;
   
            Int32.TryParse(number, out convert_3);
            int x3 = convert_3 + 5;

            Console.Write("\t" + x1);
            //Console.WriteLine("\t" + x2);
            //Console.WriteLine("\t" + x3);
            Console.ReadKey();


        }
    }
}
