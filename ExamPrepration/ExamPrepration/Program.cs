using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrepration
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showmenu = true;
            while (showmenu)
            {
                showmenu = mainmenu();
            }
        }


        private static bool mainmenu()
        {
            {
                Console.WriteLine("\r\nHello Sir.........");
                Console.WriteLine("\r\nChoose any Option: ");
                Console.WriteLine("1. Students Grades");
                Console.WriteLine("2. Integers Value");
                Console.WriteLine("3. Number of Digits");
                Console.WriteLine("4. ASCII Table");
                Console.WriteLine("5. Spaces Count");
                Console.WriteLine("6. Exit the Menu");
                Console.WriteLine("\r\nSelect any Item:");
            }
            switch (Console.ReadLine())
            {
                case "1":
                    studentsgrades();
                    return true;
                case "2":
                    integersvalue();
                    return true;
                case "3":
                    numberofdigits();
                    return true;
                case "4":
                    asciinumbers();
                    return true;
                case "5":
                    spacecount();
                    return true;
                case "6":
                    return false;
                default:
                    return true;
            }
        }

        private static void studentsgrades()
        {
            Console.Clear();

            float quize;
            float gradeMid;
            float gradeFinal;
            float avg;

            Console.WriteLine("Enter the Quize Score: ");
            quize = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Mid Score: ");
            gradeMid = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Final Score: ");
            gradeFinal = float.Parse(Console.ReadLine());

            avg = (quize + gradeMid + gradeFinal) / 3;

            if (avg >= 90)
                Console.WriteLine("Grade A");

            else if ((avg >= 70) && (avg < 90))
                Console.WriteLine("Grade B");

            else if ((avg >= 50) && (avg < 70))
                Console.WriteLine("Grade C");

            else if (avg < 50)
                Console.WriteLine("Grade F");

            else Console.WriteLine("Invalid Entry");

            Console.ReadLine();
            Console.Clear();


        }

        private static void integersvalue()
        {
            Console.Clear();

            Console.WriteLine(" Enter the First Value: ");
            int V1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter the Second Value: ");
            int V2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter the third Value: ");
            int V3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Numbers: " + " " + V1 + " " + V2 + " " + V3);
            Console.WriteLine(" ");

            if (V1 == V2 && V2 == V3)
                Console.WriteLine("All Numbers are the Same value");

            else if (V1 > V2 && V2 > V3)
                Console.WriteLine("Big Number is : " + V1);

            else if (V2 > V1 && V1 > V3)
                Console.WriteLine("Big Number is : " + V2);

            else if (V3 > V2 && V2 > V1)
                Console.WriteLine("Big Number is : " + V3);

            Console.ReadKey();
            Console.Clear();

        }
        private static void numberofdigits()
        {
            Console.Clear();
            Console.WriteLine("Put a value: ");
            string V1 = Console.ReadLine();
            Console.WriteLine(V1 + " Has a total of:  " + V1.Length + "  digits");
            Console.ReadKey();
            Console.Clear();

        }
        private static void asciinumbers()
        {
            Console.Clear();

            for (int j = 1; j < 122; j++)
            {
                Console.Write(" " + j + " = " + (char)j);

                if (j % 10 == 0)
                {
                    Console.WriteLine(" ");

                }

            }
            Console.ReadKey();
            Console.Clear();

        }
        private static void spacecount()
        {
            Console.Clear();
            Console.WriteLine("Put a value: ");

            string V1 = Console.ReadLine();

            var count = V1.Count(t => t == ' ');

            Console.WriteLine("Count: " + count);

            Console.ReadKey();
            Console.Clear();

        }

    }
}
