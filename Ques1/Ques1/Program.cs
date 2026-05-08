using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definition of variables
            double galones = 0.0;
            double sumgalones = 0.0;
            double miles;
            double milestogaiones;
            double average = 0.0;
            double summiles = 0.0;
            //Loop to get input the miles driven and gallons used for each tankful from user and calculate and display the miles per gallon
            while (galones != -1)
            {
                Console.Write("Enter the gallons used (-1 to end): ");
               
                galones = Math.Round(double.Parse(Console.ReadLine()),2);//get calculate end when user enter -1
                if (galones == -1)//end loop if enter -1 
                    break;
                else
                {
                    sumgalones = sumgalones + galones;//sum of galones
                    Console.Write("Enter the miles driven: ");
                    miles = Math.Round(double.Parse(Console.ReadLine()),2);//get miles
                    summiles = summiles + miles;//sum of miles
                    milestogaiones = miles / galones;//calculate and display the miles per gallon obtained for each tankful
                    Console.WriteLine("The miles/gallon for this tank is: " + $"{milestogaiones:0.00}");


                }
            }
            //display the total combined miles per gallon obtained for all tankfuls
            average = summiles / sumgalones;
            Console.WriteLine("The overall average miles/gallon is:" + Math.Round(average,2));

            //categorize and display the consumption rate of gasoline
            if (average > 30)
            {
                Console.WriteLine("The overall consumption rate is : Low");
            }
            else if (average <= 30 && average >= 20)
            {
                Console.WriteLine("The overall consumption rate is : Normal");
            }
            else
            {
                Console.WriteLine("The overall consumption rate is : High");
            }
            Console.ReadLine();
        }
    }
}
