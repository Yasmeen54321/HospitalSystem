using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemShapes
{
    class Program
    {
        //In This function we  find  area of rectangle
        static double getEreaRectangl(double widR, double heiR)
        {
            double areaRe = widR * heiR;
            return areaRe;
        }
        //In This function we  find perimeter of rectangle
        static double getPerimRectangle(double widR, double heiR)
        {
            double perimetRe = (2 * widR) + (2 * heiR);
            return perimetRe;
        }
        //In This function we  find area of square
        static double getEreaSquare(double widR)
        {
            double areaS = widR * widR;
            return areaS;

        }
        //In This function we  find perimeter of square
        static double getPerimeterSquare(double widS)
        {
            double perimetS = 4 * widS;
            return perimetS;

        }
        //In This function we  find area of parallelogram
        static double getEreaParallelogram(double basePar, double widPar)
        {
            double areaP = basePar * widPar;
            return areaP;
        }
        //In This function we  find perimeter of parallelogram
        static double getPeriametParallelo(double basePar, double widPar)
        {
            double perimetP = 2 * basePar + 2 * widPar;
            return perimetP;

        }
        //In This function we  find area of Equilateral triangle
        static double getEquilateralerea(double L1)
        {
            double areaEQ = ((Math.Sqrt(3)) / 4) * (Math.Pow(L1, 2));
            return areaEQ;

        }
        //In This function we  find perimeter of Equilateral triangle
        static double getEquilateralPerimeter(double L1)
        {
            double perimetEQ = 3 * L1;
            return perimetEQ;

        }

        //In This function we  find area of Isosceles triangle
        static double getIsoscelesErea(double Trbase, double Trhight)
        {
            double areaIsos = (Trbase * Trhight) / 2;
            return areaIsos;


        }
        //In This function we  find perimeter of Isosceles triangle
        static double getIsoscelesPerimeter(double Trbase, double TrL)
        {
            double perimetIsos = Trbase + 2 * TrL;
            return perimetIsos;

        }

        //In This function we  find area of Scalene triangle
        static double getScalenearea(double Trbase, double Trhight)
        {
            double areaSca = (Trbase * Trhight) / 2;
            return areaSca;

        }
        //In This function we  find perimeter of Scalene triangle
        static double getScalenePerimeter(double L1, double L2, double L3)
        {
            double perimetScal = L1 + L2 + L3;
            return perimetScal;
        }

        //In This function we  find area of Circle
        static double getCircleArea(double Cred)
        {
            double rPow2 = Math.Pow(Cred, 2);//find r^2
            double areaCir = Math.PI * rPow2;
            return areaCir;

        }
        //In This function we  find perimeter of Circle
        static double getCirclePerimeter(double Cred)
        {
            double perimetCr = Math.PI * Cred * 2;
            return perimetCr;

        }
        static void Main(string[] args)
        {
            ////variables 
            int TypeNumber;//This variable to store Number of shape
            double ForSideNumber;//This variable to store Number of Four-Sides Shapes
            double RectangWid, RectangHgh, RectangErea, RectangPerametr;//This variable for rectangular
            double LenghtOfSquare, SquareErea, SquarePerimeter;//This variable for square
            double ParallelBase, PparallelWidth, ParallelErea, ParallelPeriameter;//This variable for parallelogram
            double TriangleNumber;//This variable to store Number of Triangl type
            //This variable for Triangl
            double TrL1, TrL2, TrL3, TrHigh, TrBase, equilateralErea, equilateralPeriameter, IsosErea, IsosPeriameter, ScalenaArea, ScalenaPeriameter;
            double Circleradius, CircleErea, CirclePerimeter;//This variable for Circle
            //This variable to store area or periameter
            string Numberformul;
            //Show All Shapes
            Console.WriteLine("List-of-Shapes: - \n 1- Four-sides \n 2- Triangle \n 3- Circle");
            Console.Write("Enter-the-type-of-shape: ");
            //Choose the number corresponding to the shape you want
            TypeNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            //If Four-Sides Shapes is choosen
            if (TypeNumber == 1)
            {
                //show Four-Sides Shapes
                Console.WriteLine("\nList-of-Four-Sides-Shapes: \n1.1-Rectangle\n1.2-Square\n1.3-Parallelogram\n");
                Console.Write("\nEnter-the-type-of-Four-Sides-shape:  ");
                //Choose the number corresponding to the  Four-Sides shapes you want
                ForSideNumber = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                //Type of Four-Sides selection
                switch (ForSideNumber)
                {
                    //Rectangle selection
                    case 1.1:
                        //Choose letter to calculate Area, or Perimeter
                        Console.Write("\nWhich-formula-you-want-to-calculate-(A- Area, B- Perimeter)?  ");
                        Numberformul = Console.ReadLine();
                        Console.WriteLine();

                        //state of area of rectangle selection
                        if (Numberformul == "A")
                        {
                            //Get width and height for rectangle from user
                            Console.Write("\nEnter-the-width-of-the-rectangle-in-cm:  ");
                            RectangWid = Convert.ToDouble(Console.ReadLine());
                            Console.Write("\nEnter-the-height-of-the-rectangle-in-cm:  ");
                            RectangHgh = Convert.ToDouble(Console.ReadLine());
                            //get area of rectangle from calling function getEreaRectangl
                            RectangErea = getEreaRectangl(RectangWid, RectangHgh);
                            Console.WriteLine("\nThe-area-of-the-rectangle-equals: (Length * Width)");
                            //print result
                            Console.WriteLine("The-area-of-the-required-rectangle-is-(" + Math.Round(RectangErea, 2) + "cm)");

                        }
                        //state of perimeter of rectangle selection
                        else if (Numberformul == "B")
                        {
                            //Get width and height for rectangle from user
                            Console.Write("\nEnter-the-width-of-the-rectangle-in-cm:  ");
                            RectangWid = Convert.ToDouble(Console.ReadLine());
                            Console.Write("\nEnter-the-height-of-the-rectangle-in-cm:  ");
                            RectangHgh = Convert.ToDouble(Console.ReadLine());
                            //get area of rectangle from calling function getPerimRectangle
                            RectangPerametr = getPerimRectangle(RectangWid, RectangHgh);
                            Console.WriteLine("\nThe-perimeter-of-the-rectangle-equals-(2*width + 2*height)");
                            //print result
                            Console.WriteLine("The-perimeter-of-the-required-rectangle-is-(" + Math.Round(RectangPerametr, 2) + "cm-)");
                        }
                        //In this case user enter number not found
                        else
                        {
                            Console.WriteLine("Sorry, it is Wrong choice");
                            break;
                        }
                        Console.WriteLine();

                        break;
                    //Square selection
                    case 1.2:
                        //Choose letter to calculate Area, or Perimeter
                        Console.Write("\nWhich-formula-you-want-to-calculate- (A-Area, B-Perimeter-)-?  ");
                        Numberformul = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("\nEnter-the-side-length-of-the-square-in-cm:  ");
                        //Get length of side for square from user
                        LenghtOfSquare = Convert.ToDouble(Console.ReadLine());
                        //state of area of square selection 
                        if (Numberformul == "A")
                        {
                            //get area of square from calling function getEreaSquare
                            SquareErea = getEreaSquare(LenghtOfSquare);
                            Console.WriteLine("\nThe-area-of-the-square-equals-(Width * Width)");

                            Console.WriteLine("The-area-of-the-required-square-is-(" + Math.Round(SquareErea, 2) + "-cm)");
                        }
                        //state of perimeter of square selection 
                        else if (Numberformul == "B")
                        {
                            //get perimeter of square from calling function getPerimeterSquare
                            SquarePerimeter = getPerimeterSquare(LenghtOfSquare);
                            Console.WriteLine("\nThe-perimeter-of-the-square-equals-(4*width)");

                            Console.WriteLine("The-perimeter-of-the-required-square-is-(" + Math.Round(SquarePerimeter, 2) + "-cm)");
                        }
                        //state of user choose number not found
                        else
                        {
                            Console.WriteLine("Sorry, it is Wrong choice");
                            break;
                        }
                        Console.WriteLine();

                        break;
                    //Parallelogram selection
                    case 1.3:
                        //Choose letter to calculate Area, or Perimeter
                        Console.Write("\nWhich-formula-you-want-to-calculate- (A-Area, B-Perimeter-)-?  ");
                        Numberformul = Console.ReadLine();
                        Console.WriteLine();
                        //Get base and width of side for parallelogram from user
                        Console.Write("\nEnter-the-length-of-the-base-of-the-parallelogram-in-cm:  ");
                        ParallelBase = Convert.ToDouble(Console.ReadLine());
                        Console.Write("\nEnter-the-length-of-the-width-of-the-parallelogram-in-cm:  ");
                        PparallelWidth = Convert.ToDouble(Console.ReadLine());
                        //state of area of parallelogram selection
                        if (Numberformul == "A")
                        {
                            //get erea of parallelogram from calling function ParallelErea
                            ParallelErea = getEreaParallelogram(ParallelBase, PparallelWidth);
                            Console.WriteLine("\nThe-area-of-the-parallelogram-equals-(base*width)");

                            Console.WriteLine("The-area-of-the-required-parallelogram-is-(" + Math.Round(ParallelErea, 2) + "-cm)");
                        }
                        //state of perimeter of parallelogram selection  
                        else if (Numberformul == "B")
                        {
                            //get perimeter of parallelogram from calling function getPeriametParallelo
                            ParallelPeriameter = getPeriametParallelo(ParallelBase, PparallelWidth);
                            Console.WriteLine("\nThe-perimeter-of-the-parallelogram-equals-(2*base+2*hight)");

                            Console.WriteLine("The-perimeter-of-the-required-parallelogram-is-(" + Math.Round(ParallelPeriameter, 2) + "-cm)");

                        }
                        //In this case user enter number not found
                        else
                        {
                            Console.WriteLine("Sorry, it is Wrong choice");
                            break;
                        }
                        Console.WriteLine();
                        break;
                    //In this case user enter number not found
                    default:
                        Console.WriteLine("Sorry, it is Wrong choice");
                        break;
                }

            }
            //If Triangle Shapes is choosen
            else if (TypeNumber == 2)
            {
                //Print type of Triangle Shapes
                Console.WriteLine("\nList-of-Triangle Shapes: \n2.1-Equilateral \n2.2-Isosceles \n 2.3-Scalene \n");
                //get Number 
                Console.Write("\nEnter-the-type-of-triangle:  ");
                //Choose the number corresponding to the Triangle Shapes you want
                TriangleNumber = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                //Type of Triangle selection
                switch (TriangleNumber)
                {
                    //Equilateral selection
                    case 2.1:
                        //Choose letter to calculate Area, or Perimeter
                        Console.Write("\nWhich-formula-you-want-to-calculate- (A-Area, B-Perimeter-)-?  ");
                        Numberformul = Console.ReadLine();
                        Console.WriteLine();
                        //Get the length of the first side of the equilateral
                        Console.Write("\nEnter-the-length-of-the-first-side-of-the-equilateral-triangle-in-cm:  ");
                        TrL1 = Convert.ToDouble(Console.ReadLine());
                        //state of area of equilateral triangle selection
                        if (Numberformul == "A")
                        {
                            //get erea of equilateral from calling function getEquilateralerea
                            equilateralErea = getEquilateralerea(TrL1);
                            Console.WriteLine("\nThe-area-of-the-triangle-equals-((Sqrt(3)/4)*L^2)");

                            Console.WriteLine("The-area-of-the-required-triangle-is-(" + Math.Round(equilateralErea, 2) + "-cm)");
                        }
                        //state of area of periameter triangle selection
                        else if (Numberformul == "B")
                        {
                            //find perimeter of equilateral from calling function getEquilateralPerimeter
                            equilateralPeriameter = getEquilateralPerimeter(TrL1);

                            Console.WriteLine("\nThe-perimeter-of-the-triangle-equals-(L1+L2+L3)");

                            Console.WriteLine("The-perimeter-of-the-required-triangle-is-(" + Math.Round(equilateralPeriameter, 2) + "-cm)");
                        }
                        //In this case user enter number not found
                        else
                        {
                            Console.WriteLine("Sorry, it is Wrong choice");
                            break;
                        }
                        Console.WriteLine();
                        break;
                    case 2.2:
                        //Choose letter to calculate Area, or Perimeter
                        Console.Write("\nWhich-formula-you-want-to-calculate- (A-Area, B-Perimeter-)-?  ");
                        Numberformul = Console.ReadLine();
                        Console.WriteLine();
                        //state of area of Isosceles triangle selection  
                        if (Numberformul == "A")
                        {
                            //Get heigh and base for Isosceles triangle
                            Console.Write("\nEnter-the-length-of-the-height-of-the-triangle-in-cm:  ");
                            //enter heigh
                            TrHigh = Convert.ToDouble(Console.ReadLine());
                            Console.Write("\nEnter-the-length-of-the-base-of-the-triangle-in-cm:  ");
                            //enter base
                            TrBase = Convert.ToDouble(Console.ReadLine());
                            //get erea of Isosceles from calling function getIsoscelesErea
                            IsosErea = getIsoscelesErea(TrBase, TrHigh);
                            Console.WriteLine("\nThe-area-of-the-triangle-equals-((base*hight)/2)");

                            Console.WriteLine("The-area-of-the-required-triangle-is-(" + Math.Round(IsosErea, 2) + "-cm)");
                        }

                        //state of periameter of Isosceles triangle selection 
                        else if (Numberformul == "B")
                        {
                            //get side's Length of Isosceles  and height 
                            Console.Write("\nEnter-the-length-of-the-base-of-the-triangle-in-cm:  ");
                            TrBase = Convert.ToDouble(Console.ReadLine());
                            Console.Write("\nEnter-the-length-of-the-other-side-of-the-triangle-in-cm:  ");
                            TrL2 = Convert.ToDouble(Console.ReadLine());
                            //get perimeter of Isosceles from calling function getIsoscelesPerimeter
                            IsosPeriameter = getIsoscelesPerimeter(TrBase, TrL2);
                            Console.WriteLine("\nThe-perimeter-of-the-triangle-equals-(base+2*L)");

                            Console.WriteLine("The-perimeter-of-the-required-triangle-is-(" + IsosPeriameter + "-cm)");
                        }
                        //In this case user enter number not found
                        else
                        {
                            Console.WriteLine("Sorry, it is Wrong choice");
                            break;
                        }
                        Console.WriteLine();
                        break;
                    case 2.3:
                        //Choose letter to calculate Area, or Perimeter
                        Console.Write("\nWhich-formula-you-want-to-calculate- (A-Area, B-Perimeter-)-?  ");
                        Numberformul = Console.ReadLine();
                        Console.WriteLine();
                        //state of area of Scalene triangle selection 
                        if (Numberformul == "A")
                        {
                            //get height and base of Scalene
                            Console.Write("\nEnter-the-length-of-the-height-of-the-triangle-in-cm:  ");
                            TrHigh = Convert.ToDouble(Console.ReadLine());
                            Console.Write("\nEnter-the-length-of-the-base-of-the-triangle-in-cm:  ");
                            TrBase = Convert.ToDouble(Console.ReadLine());
                            //get area of Scalene from calling function getScalenearea
                            ScalenaArea = getScalenearea(TrBase, TrHigh);
                            Console.WriteLine("\nThe-area-of-the-triangle-equals-((baseTS*hight)/2)");

                            Console.WriteLine("The-area-of-the-required-triangle-is-(" + ScalenaArea + "cm)");
                        }
                        //state of periameter of Scalene triangle selection 
                        else if (Numberformul == "B")
                        {
                            //get Length of all sides in Scalene
                            Console.Write("\nEnter-the-length-of-the-first-side-of-the-triangle-in-cm:  ");
                            TrL1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("\nEnter-the-length-of-the-second-side-of-the-triangle-in-cm:  ");
                            TrL2 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("\nEnter-the-length-of-the-third-side-of-the-triangle-in-cm:   ");
                            TrL3 = Convert.ToDouble(Console.ReadLine());
                            //get perimeter of Scalene from calling function getScalenePerimeter
                            ScalenaPeriameter = getScalenePerimeter(TrL1, TrL2, TrL3);

                            Console.WriteLine("\nThe-perimeter-of-the-triangle-equals-(L1+L2+L3)");

                            Console.WriteLine("The-perimeter-of-the-required-triangle-is-(" + Math.Round(ScalenaPeriameter, 2) + "cm)");
                        }
                        //In this case user enter number not found
                        else
                        {
                            Console.WriteLine("Sorry, it is Wrong choice");
                        }
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Sorry, it is Wrong choice");
                        break;

                }

            }
            else if (TypeNumber == 3)
            {
                //Choose letter to calculate Area, or Perimeter
                Console.Write("\nWhich-formula-you-want-to-calculate- (A-Area, B-Perimeter-)-?  ");
                Numberformul = Console.ReadLine();
                Console.WriteLine();
                //state of area of Circle selection 
                if (Numberformul == "A")
                {
                    //Get the radius of the circle
                    Console.Write("\nEnter-the-length of the radius of the circle in-cm:  ");
                    Circleradius = Convert.ToDouble(Console.ReadLine());
                    //get area of circle from calling function getCircleArea
                    CircleErea = getCircleArea(Circleradius);
                    Console.WriteLine("\nThe-area-of-the -Circle-equals (PI * r^2)");

                    Console.WriteLine("The-area-of-the-required-circle- is (" + Math.Round(CircleErea, 2) + "cm)");

                }
                //state of periameter of Circle selection 
                else if (Numberformul == "B")
                {
                    //Get the radius of the circle
                    Console.Write("\nEnter-the-length of-the-radius-of-the-circle-in-cm:  ");
                    Circleradius = Convert.ToDouble(Console.ReadLine());
                    //get periameter of circle from calling function getCirclePerimeter
                    CirclePerimeter = getCirclePerimeter(Circleradius);

                    Console.WriteLine("\nThe-perimeter-of-the circle equals (PI*r*2)");

                    Console.WriteLine("The-perimeter-of-the-required-circle-is (" + Math.Round(CirclePerimeter, 2) + "-cm)");

                }
                else
                {
                    Console.WriteLine("Sorry, it is Wrong choice");
                }
            }
            else
            {
                Console.WriteLine("Sorry, it is Wrong choice");
            }
            Console.ReadLine();

        }

    }
}
