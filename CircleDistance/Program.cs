using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> x = new List<double>(), y = new List<double>();
            List<Point> points = new List<Point>();
            int calcPoints = 0;
            Boolean check = true;

            getPoints(x, y);
            calcPoints = getPointCounter();

            for (int z = 0; z < x.Count; z++)
            {
                points.Add(new Point(x[z], y[z]));
            }

            points.Sort();

            Console.WriteLine("The " + calcPoints + " closest points areas follows:");
            Console.WriteLine("----------------------------------------------------");

            for(int z = 0; z < calcPoints; z++)
            {
                Point p = points[z];
                Console.WriteLine("X: " + p.getX() + " Y: " + p.getY() + " Distance: " + p.getDistance());
            }

            Console.ReadLine();
        }

        private static void getPoints(List<double> x, List<double> y)
        {
            Boolean check = true;
            
            string yesNo = "n";

            while (check)
            {
                string xCor = "", yCor = "";
                double XCord = 0, YCord = 0;

                Console.Clear();
                Console.WriteLine("Enter the X coordinate.");
                xCor = Console.ReadLine();

                while (check)
                {
                    try
                    {
                        XCord = double.Parse(xCor);
                        check = false;
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Invalid Entry. Please Try Again.");
                        xCor = Console.ReadLine();
                    }
                }

                check = true;

                Console.Clear();
                Console.WriteLine("Enter the Y coordinate.");
                yCor = Console.ReadLine();

                while (check)
                {
                    try
                    {
                        YCord = double.Parse(yCor);
                        check = false;
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Invalid Entry. Please Try Again.");
                    }
                }


                Console.WriteLine(String.Format("You entered ({0},{1})", xCor, yCor) + " Would you like to save this point? (Y/N)");
                yesNo = Console.ReadLine();

                while (yesNo.ToLower() == "n" && yesNo.ToLower() == "y")
                {
                    Console.WriteLine("Please enter Y or N to continue.");
                    yesNo = Console.ReadLine();
                }

                if (yesNo.ToLower() == "y")
                {
                    x.Add(XCord);
                    y.Add(YCord);
                }
                else
                {
                    Console.WriteLine("Coordinate not saved.");
                }

                Console.WriteLine("Would you like to enter another coordinate? (Y/N)");
                yesNo = Console.ReadLine();

                while (yesNo.ToLower() == "n" && yesNo.ToLower() == "y")
                {
                    Console.WriteLine("Please enter Y or N to continue.");
                    yesNo = Console.ReadLine();
                }

                if (yesNo.ToLower() == "y")
                {
                    check = true;
                }
                else
                {
                }
            }
        }

        private static int getPointCounter()
        {
            string valPar = "";
            int value = 0;
            Boolean check = true;

            Console.WriteLine("Please enter the number of points closest to the origin you would like to find. " +
                "\n e.g. Entering 5 would find the five closest points to the origin.");

            valPar = Console.ReadLine();

            while (check)
            {
                try
                {
                    value = int.Parse(valPar);
                    check = false;
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Entry. Please Try Again.");
                    valPar = Console.ReadLine();
                }
            }

            return value;
        }
    }
}
