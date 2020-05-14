using System;

namespace StudentGrade_Using_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of the student");
            String Name = Console.ReadLine();
            Console.WriteLine("enter the marks");
            int Marks = Convert.ToInt32(Console.ReadLine());
            switch(Marks)
            {
                case 10:
                case 9:
                    Console.WriteLine("Your Grade is Excellent");
                    break;
                case 8:
                case 7:
                    Console.WriteLine("Your Grade is Notable");
                    break;
                case 6:
                    Console.WriteLine("Your Grade is Good");
                    break;
                case 5:
                    Console.WriteLine("Your Grade is Pass");
                    break;
                default:
                    Console.WriteLine("Your Grade is Fail");
                    break;

            }
            Console.ReadLine();

        }
    }
}
