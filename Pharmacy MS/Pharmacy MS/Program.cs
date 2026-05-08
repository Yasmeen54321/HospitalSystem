using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_MS
{
    public class Medicines//this class to define a medicien
    {
        //variables
         public int uniqID { get; set; }//Id
         public String medName { get; set; }//Name
        public DateTime productionDate { get; set; }// prod date
        public DateTime expiryDate { get; set; }//expiry date
        public String price { get; set; }//price attribute
        public Medicines() { }//constructor default
        public Medicines(int uniqID1, String medName1, DateTime productionDate1, DateTime expiryDate1, String price1)//another constructor
        {
            /*attribuite of constructor*/this.uniqID = uniqID1; this.medName = medName1; this.productionDate = productionDate1; this.expiryDate = expiryDate1; this.price = price1;
        }
    }
    class Program//Main class
    {
        //this function to cheack if id of Medicine exist or not
        static bool isIdExist(List<Medicines> MedicineList, int mId)//header of function
        {
            bool isId = false;//variable
            foreach (Medicines b in MedicineList.ToList())//loop to cheack 
            {
                if (b.uniqID == mId)//Verification condition
                {
                    isId = true;//Change the value of the variable if the medicine already exists
                }
            }
            return isId;//return result

        }
        //this function to cheack if id of Medicine exist or not after update
        static bool isIdUpdateExist(List<Medicines> MedicineList, int mId, int ind)//header of function
        {
            bool isId = false;//variable
            int count = 0;
            foreach (Medicines b in MedicineList.ToList())//loop to cheack 
            {
                if (b.uniqID == mId)//Verification condition
                {
                    if (count != ind-1)//if index  not update choice
                    {
                        isId = true;//Change the value of the variable if the medicine already exists
                    }
                }
                count = count + 1;//increment
            }
            return isId;//return result

        }

        static Medicines AddMedicines(int uniqID1, String medName1, DateTime productionDate1, DateTime expiryDate1, String price1)//header of function
        {
            //to errore handling we use try catch
            try
            {
                Medicines NewMedicine = new Medicines() //this object to create new medicine and fill its
            { uniqID = uniqID1, medName = medName1, productionDate = productionDate1,   expiryDate = expiryDate1, price = price1
             };//Add atribuite of new medicine
                return NewMedicine;//return result
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught: {0}", e);
                Medicines NewMedicine = new Medicines();
                return NewMedicine;
            }

        }
    
        //In This function we  remove medicine from array by identifier 
        static void removemedicine(List<Medicines> rmMedicine, int mId)
        {

            //to errore handling we use try catch
            try
            {

                int co;//to find index of list
                for(co = 0; co< rmMedicine.Count; co++)///*****////
                {
                    if (co == mId)///**condition***////
                    {
                        rmMedicine.RemoveAt(co);
                        Console.WriteLine("Medicine deleted successfully.");///**delete medicine***////
                    }
                    
                }
            }
            catch (Exception e)///***handler exception**////
            {
                Console.WriteLine("Exception", e);
            }

        }


        static void Main(string[] args)///***Main**////
        {
            //variables 
            Medicines MedItem = new Medicines();///**object from medicine class***////
            string inputMedAdd, inputMedUpdate;///**variable to add and update medicine***////
            int idMed;String nameMed;///***id and name medicine**////
            DateTime prodDateMed = DateTime.Now;///**Date product of medicin***////
            DateTime expiryMed = DateTime.Now;///**Date expiry of medicine***////
            string priceMed;///**price of medicine***////

            List<Medicines> medicineList = new List<Medicines>(); ;//array of medicines
            bool isId;//this variable to cheack if id exist or not
            int number=0, indexNumber;///**number for loop , index for update***////
            while (number != 6)///***while loop**////
            {


                //Print List of function
                Console.WriteLine("                  Pharmacy Management System \nMenu:");//print title

                Console.WriteLine("1. Add a Medicine");//print add function
                Console.WriteLine("2. Display a Medicine");//print display function
                Console.WriteLine("3. Update a Medicine");//print update function
                Console.WriteLine("4. Delete Medicine");//print Delete function
                Console.WriteLine("5. About.");//print About function
                Console.WriteLine("6. Exit");//exit from app
                Console.Write("Enter your choice (1-5): ");
                //Get number of function from user
                number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                //Switch to discusse cases
                switch (number)
                {
                    //case add medicine
                    case 1:

                        //Ask user to Enter attribute of medicine
                        Console.Write("\nEnter medicine’s details as: unique identifier, medicine name, production date, expiry date, and price.\nEnter medicine’s details:  ");
                        inputMedAdd = Console.ReadLine();///**get medicin attribute from user***////
                        string[] AddMed = inputMedAdd.Split(',');///**split for medicine attribute***////
                        if (AddMed.Length != 5)
                        {
                            Console.WriteLine("Please enter all information, try again");///******///
                            break;
                        }
                        try///**to errore handling we use try catch **///
                        {
                            idMed = Convert.ToInt32(AddMed[0]);///** get id****///
                            nameMed = AddMed[1];////*get name***////
                            DateTime DateP;
                            if (!DateTime.TryParseExact(AddMed[2].Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture,DateTimeStyles.None, out DateP)
                                || !DateTime.TryParseExact(AddMed[3].Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateP)
                               )
                            {
                                Console.WriteLine("Please write a date of production and expiry as dd/MM/yyyy. ");////****////
                                break;
                            }
                            prodDateMed = Convert.ToDateTime(AddMed[2]);////**get prod date**////
                            expiryMed = Convert.ToDateTime(AddMed[3]);////**get expiry date**////
                            if (expiryMed < prodDateMed)//condition about date of expiry must be more than production date
                            {
                                Console.WriteLine("Expiry date must be after production date, try again");///******///
                                break;
                            }
                            priceMed = AddMed[4];////**get price**////
                            //cheack if identifier exist or not
                            isId = isIdExist(medicineList, idMed);
                            if (isId == false)////***condition if not exist*////
                            {
                                //call function to add information for medicine attribute 
                                MedItem = AddMedicines(idMed, nameMed, prodDateMed, expiryMed,priceMed);
                                medicineList.Add(MedItem);//add medicine to List
                                Console.WriteLine("Medicine added successfully.");////****////
                            }
                            else
                            {
                                Console.WriteLine("Sorry, Medicine not added, ID exists");////****////
                            }
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Please write a date as MM/dd/yyyy. ");////****////
                        }
                        
                        Console.WriteLine("==========================================================================");////****////


                        break;////****////
                    case 2:
                        //Display All medicine 
                        if (medicineList.Count == 0)
                        {
                            Console.WriteLine("No medicine available.");////****////
                        }
                        else
                        {
                            Console.WriteLine("All medicine in Pharmacy:");////****////
                            foreach (Medicines medIte in medicineList)//loop to pass on list and print result
                            {
                                Console.Write(medIte.uniqID);////*print Id***////
                                Console.Write( ",   "+ medIte.productionDate.ToShortDateString() + ",   ");////*print production Date***////
                                Console.Write( medIte.expiryDate.ToShortDateString() + " ,  ");////**print expiry Date**////
                                Console.WriteLine( medIte.price);////**print price **////


                            }
                        }
                        Console.WriteLine("==========================================================================");////****////


                        break;////****////
                    case 3://Update
                        if (medicineList.Count > 0)////**condition if list not empty**////
                        {
                            //Ask user to Enter index of medicine that want to update
                            Console.Write("\nEnter the index of the medicine to update:  ");////****////
                            indexNumber = Convert.ToInt32(Console.ReadLine());////**get index number**////

                            if (indexNumber-1 >=0 && indexNumber-1< medicineList.Count)////**condition if index number exist**////
                            {
                                Console.Write("\nEnter updated medicine details: ");////**print**////
                                inputMedUpdate = Console.ReadLine();////****////
                                string[] updateMed = inputMedUpdate.Split(',');////*to split input***////
                                try//to errore handling we use try catch
                                {
                                    idMed = Convert.ToInt32(updateMed[0]);////****////
                                    nameMed = updateMed[1];////****////
                                    prodDateMed = Convert.ToDateTime(updateMed[2]);////****////
                                    expiryMed = Convert.ToDateTime(updateMed[3]);////****////
                                    priceMed = updateMed[4];////****////
                                    //cheack if identifier exist or not
                                    isId = isIdUpdateExist(medicineList, idMed , indexNumber);
                                    if (isId == false)
                                    {
                                        //call function to add information for medicine attribute 
                                        MedItem = AddMedicines(idMed, nameMed, prodDateMed, expiryMed, priceMed);
                                        for (int indexItem=0; indexItem< medicineList.Count; indexItem++)//loop to update list 
                                        {
                                            if (indexItem == indexNumber-1)//Verification condition
                                            {
                                              
                                                medicineList[indexNumber-1] = MedItem;//Modify the required medicine information in the list
                                            }
                                        }
                                        Console.WriteLine("Medicine updated successfully.");////****////
                                    }
                                    else
                                    {
                                        Console.WriteLine("Sorry, Medicine is exist");////****////
                                    }
                                }
                                catch (FormatException e)
                                {
                                    Console.WriteLine("Please write a date as dd/MM/yyyy. ");////****////
                                }
                            }
                            else
                            {
                                int len = medicineList.Count + 1;//to find length of list
                                Console.WriteLine("\nEnter the index between 1 less  "+ len);////****////

                            }


                        }
                        else
                        {
                            Console.WriteLine("\nNo medicine exist");////****////
                        }


                        Console.WriteLine("==========================================================================");////****////


                        break;
                    case 4:
                        //remove medicine from list 
                        Console.Write("Enter the index of the medicine to delete:");
                        idMed = Convert.ToInt32(Console.ReadLine());//get identifier from user
                        //cheack if identifier exist or not
                       
                        if (idMed-1 < medicineList.Count && idMed-1 >= 0 )
                        {
                            //call remove function 
                            removemedicine(medicineList, idMed-1);
                        }
                        else
                        {
                            Console.WriteLine("Sorry, medicine isnot exist, we can't remove it.");////****////
                        }
                        Console.WriteLine("==========================================================================");////****////

                        break;////****////
                    case 5:
                        //Display details of the developer of the code 
                        Console.WriteLine("Developer of the code: Ahlam Abdulkhaleq, 9201821391, s9201821391@aou.edu.sa, 1303.");////****////
                         Console.WriteLine("==========================================================================");

                        break;////****////
                    default:
                        Console.WriteLine("Enter Number between 1-5");////****////

                        Console.WriteLine("==========================================================================");////****////
                        break;////****////



                }
            }
            Console.WriteLine("You are out");////****////

            Console.ReadLine();////****////
        }
    }
}

