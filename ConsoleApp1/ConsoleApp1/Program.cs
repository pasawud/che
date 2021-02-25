using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int code;
            string branchs;
            Console.Write("input code : ");
            code = int.Parse(Console.ReadLine());
            Console.Write("input branchs : ");
            branchs = Console.ReadLine();
            if (branchs == "CIA")
            {
                bool check1 = (code - 3) % 10 == 0 || (code - 6) % 10 == 0 || (code - 9) % 10 == 0;
                bool check2 = check1 && (code % 100) / 10 != 1 && (code % 100) / 10 != 3 && (code % 100) / 10 != 5;
                bool check3 = check2 && (code % 10000) / 1000 >= 6 && (code % 10000) / 1000 != 8;
                Console.Write(check3);
            }
            else if (branchs == "FBI")
            {
                bool check1 = (code % 1000000) / 100000 >= 4 && (code % 1000000) / 100000 <= 7;
                bool check2 = check1 && (code % 1000) / 100 == 2 || (code % 1000) / 100 == 4 || (code % 1000) / 100 == 6 || (code % 1000) / 100 == 8 && (code % 1000) / 100 != 6;
                bool check3 = check2 && (code % 100000) / 10000 == 1 || (code % 100000) / 10000 == 3 || (code % 100000) / 10000 == 5 || (code % 100000) / 10000 == 7 || (code % 100000) / 10000 == 9;
                Console.Write(check3);
            }
            else if (branchs == "NSA")
            {
                bool check1 = 30 % (code % 10) == 0;
                bool check2 = check1 && (code % 10000) % 3 == 0 && (code % 10000) % 2 != 0;
                bool check3 = check2 && ((code % 10) == 7 || (code % 100) / 10 == 7 ||  (code % 1000) / 100 == 7 ||  (code % 10000) / 1000 == 7 || (code % 100000) / 10000 == 7 || (code % 1000000) / 100000 == 7);
                Console.Write(check3);
            }
            else
                Console.WriteLine("false");
        }
    }
}
