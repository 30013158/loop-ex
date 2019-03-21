/*Name=Rajveer Kaur
  Topic :extension exercise on loops*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_ex
{
    class Program
    {
        static void Main(string[] args)
        {   
            //task-3 part-1
            Console.WriteLine("enter the character you want to display");
            char char1 = char.Parse(Console.ReadLine());
            Console.WriteLine("enter the height of rectangle");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the width of rectangle");
            int w = int.Parse(Console.ReadLine());

            for (int t=0;t<=h;t++)
            {
                for (int a = 1; a<=w; a++)
                { Console.Write($"{char1}"); }
                Console.WriteLine(); }
            Console.ReadLine();
            
            
            
            
            //task 1
            int start = 1;
            int finish = 50;
            for (int i = start; i <= finish; i++)
            {
                Console.WriteLine(i);
                if (i % 10 == 0)
                    Console.WriteLine();
            }
            Console.ReadLine();
            
            
            //task2
            double total = 0;//initialise the total with any number,everytime we enter the number it gets added to the total

            for(int y=1;y<=10;y++)
            { Console.Write($"Please enter  number {y}:");
                /*if(double.TryParse(Console.ReadLine(),out double number))
                    total += number;
                else
                    Console.WriteLine("not a number, try again...");*/
                total += double.Parse(Console.ReadLine());

             }
            //displaying the total
            Console.WriteLine($"sum:{total}");
            Console.ReadLine();

        }
    }
}
