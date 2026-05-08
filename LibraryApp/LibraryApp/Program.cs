using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    //create book class with its attribute
    class bookLib
    {
        public int BookID { get; set; }//Identifier
        public string BookTitle { get; set; }//Title of book 
        public string BookAuther { get; set; }//Auther of Book
        public int BookYear { get; set; }//Year

    }
    class Program
    {
        //this function to cheack if id of book exist or not
        static bool isIdExist(List<bookLib> ListBook, int bId)
        {
            bool isId = false;
            foreach (bookLib b in ListBook.ToList())
            {
                if (b.BookID == bId)
                {
                    isId = true;
                }
            }
            return isId;

        }

            //In This function we  get inforation of book and add it to new book class
            static bookLib AddNewBook(int bid, string bTitle, string bAuther, int bYear)
        {
            
            //to errore handling we use try catch
            try
            {
                bookLib bNew1 = new bookLib()//create new instance
                {
                    BookID = bid,
                    BookTitle = bTitle,
                    BookAuther = bAuther,
                    BookYear = bYear
                };
                return bNew1;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
                bookLib bNew1 = new bookLib();
                return bNew1;
            }
           
           
        }
        //In This function we  remove book from array by identifier 
        static void removeBook(List <bookLib> rmBook, int bId)
        {

            //to errore handling we use try catch
            try
            {

                int co = 0;//to find index of list
                foreach (bookLib b in rmBook.ToList())
                {
                    if (b.BookID == bId)
                    {
                        rmBook.RemoveAt(co);
                        Console.WriteLine("Book removed successfully.");
                        }
                    else
                    {
                        co = co + 1;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception", e);
            }

        }
        //In This function we  Search from book  then return true or false
        static bool searchBook(List<bookLib> srBook, string titleB)
        {  
            bool resultSearch = false;
            //to errore handling we use try catch
            try
            {
              

                int co = 0;//to find index of list
                foreach (bookLib b in srBook.ToList())
                {
                    if (b.BookTitle.Contains(titleB))//if you find title print information
                    {
                        Console.Write("Identifier: ");
                        Console.WriteLine(b.BookID);
                        Console.WriteLine("Title: " + b.BookTitle);
                        Console.WriteLine("Author: " + b.BookAuther);
                        Console.Write("Publication Year: ");
                        Console.WriteLine(b.BookYear);
                        resultSearch = true;
                        return resultSearch;
                    }
                    else
                    {
                        co = co + 1;                
                    }
                }
                Console.WriteLine("No matching books found");
                return resultSearch;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
                return resultSearch;
            }


        }

        static void Main(string[] args)
        {
            int menuNumber =0;//This variable allows the user to choose one of the menu options
            bookLib bookItem = new bookLib();
            int idBookNum;// This variable to store id of book
            string titleBook;//This variable to store title of book
            string autherBook;//This variable to store auther of book
            int yearBook;// This variable to store year of book
            List<bookLib> bookList = new List<bookLib>(); ;//array of books
            bool isId;//this variable to cheack if id exist or not
            Console.WriteLine("Welcome to Personal Library Management System.");
            //while loop to repete cases
            while (menuNumber != 5)
            {
                //Show Menu of library
                Console.Write("\nMenu: \n");
                Console.Write("1. Add a Book \n");
                Console.Write("2. Remove a Book \n");
                Console.Write("3. Search for a Book \n");
                Console.Write("4. Display All Books \n");
                Console.Write("5. Exit \n");
                //Choose the option
                Console.Write("Enter your choice(1 - 5):");
                menuNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            
                //Switch loop to process the option
                switch (menuNumber)
                {
                    //case to add new book
                    case 1:
                        //get information of book :
                        Console.Write("Enter the book's identifier:");
                        idBookNum = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the book's title: ");
                        titleBook = Console.ReadLine();
                        Console.Write("Enter the book's author: ");
                        autherBook = Console.ReadLine();
                        Console.Write("Enter the book's publication year: ");
                        yearBook = Convert.ToInt32(Console.ReadLine());
                        //cheack if identifier exist or not
                        isId = isIdExist(bookList, idBookNum);
                        if (isId == false)
                        {
                            //call function to add information for book lib attribute 
                            bookItem = AddNewBook(idBookNum, titleBook, autherBook, yearBook);
                            bookList.Add(bookItem);//add book to List
                            Console.WriteLine("Book added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, Book is exist");
                        }
                        Console.WriteLine("==========================================================================");
                        break;
                    case 2:
                        //remove book from list 
                        Console.Write("Enter the identifier of the book to remove:");
                        idBookNum = Convert.ToInt32(Console.ReadLine());//get identifier from user
                        //cheack if identifier exist or not
                        isId = isIdExist(bookList, idBookNum);
                        if (isId == true)
                        {
                            //call remove function 
                            removeBook(bookList, idBookNum);
                        }
                        else
                        {
                            Console.WriteLine("Sorry, Book isnot exist, we can't remove it.");
                        }
                        Console.WriteLine("==========================================================================");
                        break;
                    case 3:
                        //Search about book using word in title
                        Console.Write("Enter the search keyword:");
                        titleBook = Console.ReadLine();//get keyword from user
                        //call search function
                        searchBook(bookList, titleBook);

                        Console.WriteLine("==========================================================================");
                        break;
                    case 4:
                        //Display All Books 
                        Console.WriteLine("All books in the library:");
                        foreach (bookLib b in bookList)//loop to pass on list and print result
                        {
                            Console.Write("Identifier: ");
                            Console.WriteLine(b.BookID);
                            Console.WriteLine("Title: " + b.BookTitle);
                            Console.WriteLine("Author: " + b.BookAuther);
                            Console.Write("Publication Year: ");
                            Console.WriteLine(b.BookYear);
                        }

                        Console.WriteLine("==========================================================================");
                        break;
                    default:
                        Console.WriteLine("Enter Number between 1-5");
                        break;

                }
            }
            Console.ReadLine();
        }
    }
}
