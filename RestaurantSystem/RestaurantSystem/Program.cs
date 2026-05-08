using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int NumberOfTable = 1;//This variable to store number of table
            int NumberOfPeople;//This variable to store number of people
            int Totalfees; //This variable to store total of fees
            bool[] Isavailable = new bool[10];//This variable to set tables available or not
            int ind = 0;//This variable is index for loop
            while (ind < 0)//loop to intialize all tables of the restaurant by false
            {
                Isavailable[ind] = false;
                ind++;
            }
            do
            {
                Console.Write("Enter-table-number-(-1 to end):  ");
                NumberOfTable = int.Parse(Console.ReadLine());// enter number of table 
                if ((NumberOfTable >= 1) && (NumberOfTable <= 10))
                {
                    ind = NumberOfTable - 1;
                    if (Isavailable[ind] == false)
                    {
                        Console.Write("Enter-the-number-of-persons:   ");
                        NumberOfPeople = Convert.ToInt32(Console.ReadLine());//enter number of persons
                        Console.WriteLine();
                        //if the user enter the number of people up five people, the system is refuse
                        if ((NumberOfPeople >= 1) && (NumberOfPeople <= 5))
                        {
                            Isavailable[ind] = true;//change corresponding table to is not available in array
                            Console.Write("Reservation-is-confirmed-for-table-no. " + NumberOfTable + "\n");
                            Totalfees = NumberOfPeople * 10;// set total fees according to the number of persons
                            Console.WriteLine("Total-fees:  " + Totalfees + " $\n");

                        }
                        else
                        {
                            Console.WriteLine("\nReservation-cancelled-due-to-unallowed-number-of-persons. \n ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nReservation-cancelled-due-to-unavailable table-number. \n ");
                    }
                }
                else if (NumberOfTable == -1)//end loop if user enter number =  -1
                {

                    Console.WriteLine("Sorry, you are out");
                    break;
                }


            }
            while (NumberOfTable != -1);
            Console.ReadLine();
        }
    }
}
