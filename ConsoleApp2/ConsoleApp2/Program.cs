using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{

    class Program
    {
        //method to calculate area of rectangle
        static void rectangleErea(double width, double height)
        {
            double area = width * height;
            Console.WriteLine("\nThe area of the rectangle equals (Length * Width)");

            Console.WriteLine("The area of the required rectangle is (" + area + "cm)");
            
        }
        //method to calculate perimeter of rectangle
        static void rectanglePerimeter(double width, double height)
        {
            double perimet = 2*width + 2*height;
            Console.WriteLine("\nThe perimeter of the rectangle equals (2*width + 2*height)");

            Console.WriteLine("The perimeter of the required rectangle is (" + perimet + "cm)");

        }
        //method to calculate area of square
        static void squareErea(double width)
        {
            double area = width * width;
            Console.WriteLine("\nThe area of the square equals (width * Width)");

            Console.WriteLine("The area of the required square is (" + area + "cm)");

        }
        //method to calculate perimeter of square
        static void squarePerimeter(double width)
        {
            double perimet = 4* width;
            Console.WriteLine("\nThe perimeter of the square equals ( 4* width)");

            Console.WriteLine("The perimeter of the required square is (" + perimet + "cm)");

        }
        //method to calculate area of parallelogram
        static void parallelogramErea(double baseP, double width)
        {
            double area = baseP * width;
            Console.WriteLine("\nThe area of the parallelogram equals (base * width)");

            Console.WriteLine("The area of the required parallelogram is (" + area + "cm)");

        }
        //method to calculate perimeter of parallelogram
        static void parallelogramPerimeter(double baseP, double width)
        {
            double perimet = 2 * baseP + 2* width;
            Console.WriteLine("\nThe perimeter of the parallelogram equals (2 * base + 2* hight)");

            Console.WriteLine("The perimeter of the required parallelogram is (" + perimet + "cm)");

        }

        //method to calculate area of Equilateral triangle
        static void EqTriangleArea(double L1)
        {
            double area =((Math.Sqrt(3)) / 4)*(Math.Pow(L1,2));
            Console.WriteLine("\nThe area of the triangle equals ((Sqrt(3) / 4)* L^2)");

            Console.WriteLine("The area of the required triangle is (" + Math.Round(area, 2) + "cm)");

        }
        //method to calculate perimeter of Equilateral triangle
        static void EqTrianglePerimeter(double L1)
        {
            double perimet = 3 * L1;

            Console.WriteLine("\nThe perimeter of the triangle equals (L1 + L2 +L3)");

            Console.WriteLine("The perimeter of the required triangle is (" + perimet + "cm)");

        }

        //method to calculate area of Scalene triangle
        static void ISTriangleArea(double baseTS, double hight)
        {
            double area = (baseTS * hight) / 2;
            Console.WriteLine("\nThe area of the triangle equals ((base * hight)/2)");

            Console.WriteLine("The area of the required triangle is (" + Math.Round(area, 2) + "cm)");

        }
        //method to calculate perimeter of Scalene triangle
        static void ISTrianglePerimeter(double baseIS, double L)
        {
            double perimet = baseIS + 2*L;

            Console.WriteLine("\nThe perimeter of the triangle equals (base + 2*L)");

            Console.WriteLine("The perimeter of the required triangle is (" + perimet + "cm)");

        }

        //method to calculate area of Scalene triangle
        static void ScTriangleArea(double baseTS, double hight)
        {
            double area = (baseTS * hight)/2;
            Console.WriteLine("\nThe area of the triangle equals ((baseTS * hight)/2)");

            Console.WriteLine("The area of the required triangle is (" + Math.Round(area, 2) + "cm)");

        }
        //method to calculate perimeter of Scalene triangle
        static void ScTrianglePerimeter(double L1, double L2,double L3)
        {
            double perimet = L1 + L2 +L3;

            Console.WriteLine("\nThe perimeter of the triangle equals (L1 + L2 +L3)");

            Console.WriteLine("The perimeter of the required triangle is (" + perimet + "cm)");

        }

        //method to calculate area of Circle
        static void CircleArea(double reduis)
        {
            double area = Math.PI * Math.Pow(reduis , 2);
            Console.WriteLine("\nThe area of the triangle equals (PI * r^2)");

            Console.WriteLine("The area of the required triangle is (" +Math.Round( area,2) + "cm)");

        }
        //method to calculate perimeter of Circle
        static void CirclePerimeter(double reduis)
        {
            double perimet = Math.PI* reduis*2;

            Console.WriteLine("\nThe perimeter of the circle equals (PI*r*2)");

            Console.WriteLine("The perimeter of the required circle is (" + Math.Round(perimet,2) + "cm)");

        }






        //Main Section
        static void Main(string[] args)
        {//variables 
            double widR, hegR, baseP;
            double firstSide, secondSide, thirdSide;
            double heightT, baseT;
            double radius;
            int number;
            //Print List of Shipes
            Console.WriteLine("List of Shapes: - \n");
            Console.WriteLine("1- Four-sides");
            Console.WriteLine("2- Triangle");
            Console.WriteLine("3- Circle");
            Console.Write("Enter the type of shape: ");
            //Get type of shape from user
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            //Switch to discusse cases
            switch (number)
            {
                //case of list of Four-Sides Shapes
                case 1:
                    string numFormula;
                    //print list of Four-Sides Shapes
                    Console.WriteLine("\nList of Four-Sides Shapes: \n");
                    Console.WriteLine("1.1 Rectangle");
                    Console.WriteLine("1.2 Square");
                    Console.WriteLine("1.3 Parallelogram");
                    Console.Write("\nEnter the type of Four-Sides shape:  ");
                    //Get type of Four-Sides Shapes from user
                    double numForSide = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    //The user choose Rectangle
                    if (numForSide == 1.1)
                    {
                        //Ask user to choose  Area, or Perimeter
                        Console.Write("\nWhich formula you want to calculate (A- Area, B- Perimeter)?  ");
                        numFormula = Console.ReadLine();
                        Console.WriteLine();
                        //Get dimention of rectangle from user
                        Console.Write("\nEnter the width of the rectangle in cm:  ");
                        widR = Convert.ToDouble(Console.ReadLine());
                        Console.Write("\nEnter the height of the rectangle in cm:  ");
                        hegR = Convert.ToDouble(Console.ReadLine());
                        //The user choose area of rectangle
                        if (numFormula == "A")
                        {
                            //call function to calculate area of rectangle
                            rectangleErea(widR, hegR);
                        }
                        //The user choose perimeter of rectangle
                        else if (numFormula == "B")
                        {
                            //call function to calculate perimeter of rectangle
                            rectanglePerimeter(widR, hegR);
                        }
                        //The user enter choice not found
                        else
                        {
                            Console.WriteLine("Wrong choice");
                            break;
                        }
                        Console.WriteLine();
                    }
                    //The user choose square
                    else if (numForSide == 1.2)
                    {
                        //Ask user to choose  Area, or Perimeter
                        Console.Write("\nWhich formula you want to calculate (A- Area, B- Perimeter)?  ");
                        numFormula = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("\nEnter the side length of the square in cm:  ");
                        //Get dimention of square from user
                        widR = Convert.ToDouble(Console.ReadLine());
                        //The user choose area of square
                        if (numFormula == "A")
                        {
                            //call function to calculate area of square
                            squareErea(widR);
                        }
                        //The user choose perimeter of square
                        else if (numFormula == "B")
                        {
                            //call function to calculate perimeter of square
                            squarePerimeter(widR);
                        }
                        //The user enter choice not found
                        else
                        {
                            Console.WriteLine("Wrong choice");
                            break;
                        }
                        Console.WriteLine();
                    }
                    //The user choose parallelogram
                    else if (numForSide == 1.3)
                    {
                        //Ask user to choose  Area, or Perimeter
                        Console.Write("\nWhich formula you want to calculate (A- Area, B- Perimeter)?  ");
                        numFormula = Console.ReadLine();
                        Console.WriteLine();
                        //Ask user to get dimention of square from user
                        Console.Write("\nEnter the length of the base of the parallelogram in cm:  ");
                        baseP = Convert.ToDouble(Console.ReadLine());
                        Console.Write("\nEnter the length of the width of the parallelogram in cm:  ");
                        hegR = Convert.ToDouble(Console.ReadLine());
                        //The user choose area of parallelogram
                        if (numFormula == "A")
                        {
                            //call function to calculate area of parallelogram
                            parallelogramErea(baseP,hegR);
                        }
                        //The user choose perimeter of parallelogram
                        else if (numFormula == "B")
                        {
                            //call function to calculate perimeter of parallelogram
                            parallelogramPerimeter(baseP,hegR);
                        }
                        //The user enter choice not found
                        else
                        {
                            Console.WriteLine("Wrong choice");
                            break;
                        }
                        Console.WriteLine();

                    }
                    //The user enter choice not found
                    else
                    {
                        Console.WriteLine("Wrong choice");
                        break;
                    }
                    break;
                //case of list of triangle Shapes
                case 2:
                    string numFormulaTr;
                    //print list Triangle Shapes
                    Console.WriteLine("\nList of Triangle Shapes: \n");
                    Console.WriteLine("2.1 Equilateral");
                    Console.WriteLine("2.2 Isosceles");
                    Console.WriteLine("2.3 Scalene");
                    Console.Write("\nEnter the type of triangle:  ");
                    //Get type of Triangle Shapes from user
                    double numFortriangle = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    //The user choose Equilateral triangle
                    if (numFortriangle == 2.1)
                    {
                        //Ask user to choose  Area, or Perimeter
                        Console.Write("\nWhich formula you want to calculate (A- Area, B- Perimeter)?  ");
                        numFormulaTr = Console.ReadLine();
                        Console.WriteLine();
                        //Ask user to enter length of side equilateral triangle
                        Console.Write("\nEnter the length of the first side of the equilateral triangle in cm:  ");
                        firstSide = Convert.ToDouble(Console.ReadLine());
                        //The user choose area of equilateral triangle
                        if (numFormulaTr == "A")
                        {
                            //call function to calculate area of equilateral triangle
                            EqTriangleArea(firstSide);
                        }
                        //The user choose perimeter of equilateral triangle
                        else if (numFormulaTr == "B")
                        {
                            //call function to calculate perimeter of equilateral triangle
                            EqTrianglePerimeter(firstSide);
                        }
                        //The user enter choice not found
                        else
                        {
                            Console.WriteLine("Wrong choice");
                            break;
                        }
                        Console.WriteLine();
                    }
                    //The user choose Isosceles triangle
                    else if (numFortriangle == 2.2)
                    {
                        //Ask user to choose  Area, or Perimeter
                        Console.Write("\nWhich formula you want to calculate (A- Area, B- Perimeter)?  ");
                        numFormulaTr = Console.ReadLine();
                        Console.WriteLine();
                        //The user choose area of Isosceles triangle
                        if (numFormulaTr == "A")
                        {
                            //Ask user to enter height and base for Isosceles triangle
                            Console.Write("\nEnter the length of the height of the triangle in cm:  ");
                            heightT = Convert.ToDouble(Console.ReadLine());
                            Console.Write("\nEnter the length of the base of the triangle in cm:  ");
                            baseT = Convert.ToDouble(Console.ReadLine());
                            //call function to calculate area of Isosceles triangle
                            ISTriangleArea(baseT, heightT);
                        }
                        //The user choose perimeter of Isosceles triangle
                        else if (numFormulaTr == "B")
                        {
                            //Ask user to enter height and side for Isosceles triangle
                            Console.Write("\nEnter the length of the base of the triangle in cm:  ");
                            baseT = Convert.ToDouble(Console.ReadLine());
                            Console.Write("\nEnter the length of the other side of the triangle in cm:  ");
                            firstSide = Convert.ToDouble(Console.ReadLine());
                            //call function to calculate perimeter of Isosceles triangle
                            ISTrianglePerimeter(baseT, firstSide);
                        }
                        //The user enter choice not found
                        else
                        {
                            Console.WriteLine("Wrong choice");
                            break;
                        }
                        Console.WriteLine();
                    }
                    //The user choose Scalene triangle
                    else if (numFortriangle == 2.3)
                    {
                        //Ask user to choose  Area, or Perimeter
                        Console.Write("\nWhich formula you want to calculate (A- Area, B- Perimeter)?  ");
                        numFormulaTr = Console.ReadLine();
                        Console.WriteLine();
                        //The user choose area of Scalene triangle
                        if (numFormulaTr == "A")
                        {
                            //Ask user to enter height and base for Scalene triangle
                            Console.Write("\nEnter the length of the height of the triangle in cm:  ");
                            heightT = Convert.ToDouble(Console.ReadLine());
                            Console.Write("\nEnter the length of the base of the triangle in cm:  ");
                            baseT = Convert.ToDouble(Console.ReadLine());
                            //call function to calculate area of Scalene triangle
                            ScTriangleArea(baseT, heightT);
                        }
                        //The user choose perimeter of Scalene triangle
                        else if (numFormulaTr == "B")
                        {
                            //Ask user to enter dimentions of Scalene triangle
                            Console.Write("\nEnter the length of the first side of the triangle in cm:  ");
                            firstSide = Convert.ToDouble(Console.ReadLine());
                            Console.Write("\nEnter the length of the second side of the triangle in cm:  ");
                            secondSide = Convert.ToDouble(Console.ReadLine());
                            Console.Write("\nEnter the length of the third side of the triangle in cm:   ");
                            thirdSide = Convert.ToDouble(Console.ReadLine());
                            //call function to calculate perimeter of Scalene triangle
                            ScTrianglePerimeter(firstSide, secondSide, thirdSide);
                        }
                        //The user enter choice not found
                        else
                        {
                            Console.WriteLine("Wrong choice");
                            break;
                        }
                        Console.WriteLine();

                    }
                    //The user enter choice not found
                    else
                    {
                        Console.WriteLine("Wrong choice");
                        break;
                    }
                    break;
                //case of circle
                case 3:
                    //Ask user to choose  Area, or Perimeter
                    Console.Write("\nWhich formula you want to calculate (A- Area, B- Perimeter)?  ");
                    string numFormulaC = Console.ReadLine();
                    //Ask user to enter radiusof the circle
                    Console.Write("\nEnter the length of the radius of the circle in cm:  ");
                    radius = Convert.ToDouble(Console.ReadLine());
                    //The user choose area of circle
                    if (numFormulaC == "A")
                    {
                        //call function to calculate area of circle
                        CircleArea(radius);
                        
                    }
                    //The user choose perimeter of circle
                    else if (numFormulaC == "B")
                    {
                        //call function to calculate perimeter of circle
                        CirclePerimeter(radius);
                    }
                    //The user enter choice not found
                    else
                    {
                        Console.WriteLine("Wrong choice");
                        break;
                    }

                    break;
               
            }//End Switchs
            string Key = Console.ReadLine();
        }
    }
}
