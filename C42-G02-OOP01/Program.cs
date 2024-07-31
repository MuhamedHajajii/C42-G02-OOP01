using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C42_G02_OOP01
{
    internal class Program
    {
        static void Main()
        {
            #region Q1
            /**
             * 1.	Create an enum called "WeekDays" with the days of the week (Monday to Sunday)
             * as its members. Then, write a C# program that prints out all the days of the week using this enum.
             */

            //for (int i = 0; i < 7; i++)
            //{
            //    WeekDays weekDays = (WeekDays) i;
            //    Console.WriteLine($"Day {i+1} : {weekDays}");
            //}

            #endregion

            #region Q2

            /*2.Create an enum called "Season" with the four seasons(Spring, Summer, Autumn, Winter) 
             * as its members.Write a C# program that takes a season name as input from the user and 
             * displays the corresponding month range for that season.
               Note range for seasons ( spring march to may , summer june to august ,
               autumn September to November , winter December to February)
            */
            //Season season;
            //bool Flag;
            //do {

            //    Console.WriteLine("Please Enter A Seaon From:\n (Spring, Summer, Autumn, Winter) ");
            //    Flag = Enum.TryParse(Console.ReadLine(), true, out season);
            //} while (!Flag);

            //Console.WriteLine("==================");

            //string Message = season switch
            //{
            //    Season.Spring => "spring march to may",
            //    Season.Summer => "summer june to august",
            //    Season.Autumn => "autumn September to November",
            //    Season.Winter => "winter December to February",
            //    _ => "No Valid Season"
            //};
            //Console.WriteLine(Message);

            #endregion

            #region Q3

            /*
            3.	Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            ⮚	Create Variable from previous Enum to Add and Remove Permission from variable,
                check if specific Permission is existed inside variable
             */

            // First Way Using XOR and &

            //Permissions Admin = (Permissions) 3;
            //Console.WriteLine(Admin); // Read, Write

            //if((Permissions.Delete & Admin) == Permissions.Delete)
            //{
            //    Console.WriteLine("Permission Already Exist");
            //} else
            //{
            //    Console.WriteLine("Permission Already Exist");
            //    Admin = Admin ^ Permissions.Delete;
            //}
            //Console.WriteLine(Admin);

            //Console.WriteLine("===========================");

            //// Second Way Using | OR
            //Permissions Support = (Permissions) 3;
            //Console.WriteLine(Support); // Read, Write

            //Support  = Support | Permissions.Delete;

            //Console.WriteLine(Support); // Read, Write


            #endregion

            #region Q4

            //Console.WriteLine("Please Enter A Color: ");
            //string Input = Console.ReadLine();

            //bool Flag =  Enum.TryParse(Input, true, out Colors Color);
            //bool IsInt = int.TryParse(Input,out _);

            //if (Flag && !IsInt)
            //{
            //    Console.WriteLine($"Your Color is: {Color}");
            //} else
            //{
            //    Console.WriteLine("This Color is not a Prime Color");
            //}

            #endregion

            #region Q5

            //Point point1 = ReadPoint("First");
            //Point point2 = ReadPoint("Second");

            //double distance = CalculateDistance(point1, point2);

            //Console.WriteLine($"The Distance Between The Two Points is: {distance}");

            //Point ReadPoint(string PointName)
            //{
            //    Console.WriteLine($"Please Enter The x-coordinate of the {PointName} Point:");
            //    double x = double.Parse(Console.ReadLine()!);

            //    Console.WriteLine($"Please Enter The y-coordinate of the {PointName} Point:");
            //    double y = double.Parse(Console.ReadLine()!);

            //    return new Point(x, y);
            //}

            //double CalculateDistance(Point p1, Point p2)
            //{
            //    double dx = p2.X - p1.X;
            //    double dy = p2.Y - p1.Y;
            //    return Math.Sqrt(dx * dx + dy * dy);
            //}


            #endregion

        }
    }
}
