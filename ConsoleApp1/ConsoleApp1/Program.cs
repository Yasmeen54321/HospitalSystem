using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definition of variables
            int seatNum = 0;
            double waightBag = 0.0;
            double fee;
            double sumfee = 0.0;
            int resiveseat = 0;//to know number of reservation seats
            bool[]  arrTrip = new bool[10];//array to know available seats in the flight
            for (int i =0; i<10; i++)//set all values of  trip array to false
            {
                arrTrip[i] = false;
            }
            while (seatNum != -1)
            {   
                Console.Write("Enter seat number (-1 to end):  ");

                seatNum = int.Parse(Console.ReadLine());// get number of seate
                if (seatNum == -1)//end when user enter -1
                {

                    Console.WriteLine("The flight has " + resiveseat + " reserved seats with total income " + sumfee + " $.");
                   break;
                }
                else if ((seatNum > 0) &&(seatNum <11))
                {

                    if (arrTrip[seatNum] == false)
                    {
                        Console.Write("Enter the weight of the bag:   ");
                        
                       waightBag = double.Parse(Console.ReadLine());//get waight of bag
                        arrTrip[seatNum] = true;//As each seat is assigned, set the corresponding element of the array to true to indicate that the seat is no longer available.
                        resiveseat = resiveseat + 1;
                        if ((waightBag > 10) && (waightBag <= 20))//if seat available and waight of bag between 10 and 20 
                        {
                            Console.WriteLine("Reservation is confirmed for seat no." + seatNum);
                            fee = (waightBag - 10) * 5;//Each extra kg is charged with 5 $.
                            Console.WriteLine("Fees of extra weight: " + fee + "$");
                            fee = fee + 500;//calculate total fees for each passenger.
                            Console.WriteLine("Total fees:" + fee + " $");
                            sumfee = sumfee + fee;//calculat total fees for all flight
                        }
                        else if ((waightBag <= 10) && (waightBag >= 0))//Not extra fees.
                        {
                            Console.WriteLine("Reservation is confirmed for seat no." + seatNum);
                            fee = 0.0;
                            Console.WriteLine("Fees of extra weight: " + fee + "$");
                            fee = 500;
                            Console.WriteLine("Total fees:" + fee + " $");
                            sumfee = sumfee + fee;
                        }
                        else//To do not assign a seat that has already been assigned
                        {
                            arrTrip[seatNum] = false;
                            resiveseat = resiveseat - 1;
                            Console.WriteLine("Reservation cancelled due to unallowed baggage weight");
                        }

                    }
                    else//When a user enters an unavailable seat
                    {
                        Console.WriteLine("Reservation cancelled due to unavailable seat number");
                    }


                }
                else//when a user entres number < 0 or >10 
                {
                    Console.WriteLine("This number not found");
                }
            }
            Console.Read();
        }
            
    }
}


