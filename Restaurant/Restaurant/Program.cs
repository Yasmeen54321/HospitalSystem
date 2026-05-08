using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Program
    {
        //Main Section
        static void Main(string[] args)
        {
            //Definition of variables
            int numTable = 1;
            int numPerson;
            int fee;
            bool[] availabletTables = new bool[10];//array to know available tables of the restaurant
            for (int i = 0; i < 10; i++)//set all values for available  tables of the restaurant to false
            {
                availabletTables[i] = false;
            }
            while (numTable != -1)
            {
                Console.Write("Enter table number (-1 to end):  ");
                numTable = int.Parse(Console.ReadLine());// get number of seate
                if (numTable == -1)//end when user enter -1
                {

                    Console.WriteLine();
                    break;
                }
                else if ((numTable > 0) && (numTable < 11))
                {
                    if (availabletTables[numTable-1] == false)
                    {
                        Console.Write("Enter the number of persons:   ");
                        numPerson = Convert.ToInt32(Console.ReadLine());//get number of persons
                        Console.WriteLine();
                        if ((numPerson > 0) && (numPerson < 6))
                        {
                            availabletTables[numTable-1] = true;//As each table is assigned, set the corresponding element of the array to true to indicate that the table is not available.
                            Console.Write("Reservation is confirmed for table no. "+ numTable+"\n");
                            fee = numPerson * 10;// calculates for the user the total fees according to the number of persons
                            Console.WriteLine("Total fees:  " + fee+" $\n");

                        }
                        else
                        {
                            Console.WriteLine("\nReservation cancelled due to unallowed number of persons. \n ");
                        }
                    }
                    else//When a user enters an unavailable table
                    {
                        Console.WriteLine("Reservation cancelled due to unavailable table number\n");
                    }


                }
                else
                {
                    Console.WriteLine("Reservation cancelled due to unavailable table number\n");
                }

            }
            Console.ReadLine();

        }
    }
}
