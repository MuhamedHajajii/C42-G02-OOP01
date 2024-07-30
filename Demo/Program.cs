
/* Before Import The common class you must declare it in the references of the project */
using Common;

namespace Demo
{
    internal class Program
    {

        #region 1- Exception Handling Functions
        //static void DoSomeCode()
        //{
        //    try
        //    {
        //        int X, Y, Z;
        //        X = int.Parse(Console.ReadLine()!); // string Aliaa == Formate Exception
        //        Y = int.Parse(Console.ReadLine()!); // string Aliaa == Formate Exception
        //        Z = X / Y; // Divided By Zero Exception


        //        int[] Numbers = { 1, 2, 3 }; // Index Out Of Range Exception
        //        Numbers[10] = 100;

        //        /** The Parent Is Can Be separated in more than catch scope 
        //         *  But You Should only put the parent Exception class and let the clr throw the Exception throw the catch scope
        //         *  And You should type a protective code rather than just depend on the try catch scope
        //         */

        //    }
        //    catch(FormatException ex)
        //    {
        //        /**
        //         * Clr Will Create an object from the type of the Exception
        //         * If Any Exception Happen in the try block clr will create a new object from the exception and throw it within the catch block
        //         * In Real Project You Must Save It f
        //         */
        //        Console.WriteLine(ex.Message);
        //    }catch(Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }

        //}
        //static void DoSomeProtectiveCode()
        //{
        //    try
        //    {
        //        int X, Y, Z;

        //        bool Flag;
        //        do
        //        {
        //            Console.WriteLine("Enter First Number: ");
        //            Flag = int.TryParse(Console.ReadLine(), out X);

        //        } while (!Flag);

        //        do
        //        {
        //            Console.WriteLine("Enter Second Number: ");
        //            Flag = int.TryParse(Console.ReadLine(), out Y);

        //        } while (!Flag || Y == 0);

        //        Z = X / Y;

        //        Console.WriteLine(Z);
        //    }
        //    catch (Exception)
        //    {

        //        throw;

        //    }
        //    finally
        //    {

        //        Console.WriteLine("Finally");
        //        /**
        //         * If I Not Handle The Code Throw the try catch will never complete the code 
        //         * The Exectution of the program will be stop
        //         * This is the main benifit from it 
        //         * and the finally alway run after the try catch 
        //         * but the main reason for it is to manage un managed code
        //         * like 
        //         * Close / Delete / Release // Deallocate the un managed Resourses
        //         * Open File
        //         * Connection with the database
        //         */
        //    }
        //}
        #endregion

        #region 2- Enum
        // I Can Make It Sart With The Value I want and i can make all of them start with any value and hold any value
        public enum Days { Saturday = 1 ,Sunday,monday,tuesday,wedesday }
        
        public enum Grades : int  { A, B, C, D }



        enum Gender : int
        {
            Male = 1, Female
        }

        public enum Roles { Admin = 10, Editor = 20 , Viewer = 30}

        //public enum Branches : int { Dokki, NasrCity, Maadi, Alexandria, Smarvillage}
        // Byte = 8 bits = 0 : 255 -- The Limit is the 255 i can not add more lables or predeifind constants more than 255 
        public enum Branches : byte { Dokki = 200 , NasrCity, Maadi = 253, Alexandria, Smarvillage}

        //public enum Permissions : int
        //{
        //    Delete,
        //    Execute,
        //    Read,
        //    Write
        //}

        [Flags] // I should put this attribute there to make the clr recognize this is a decimal set
        public enum Permissions : byte
        {
            Delete = 1,
            Execute = 2,
            Read = 4,
            Write = 8
        }

        // The Gender Now Will Be Stored in the data base as numbers [integers] but i will deal with it in the application as the label
        // if i have more than one label with the same value it will return the first value it will find
        //class Employee 
        //{
        //    string Name;
        //    int Age;
        //    decimal Salary;
        //    Gender Gender;
        //    Roles Role;
        //}


        /** If i made array of boolean for each employee i will go and allocate 4 bytes for each employee
         * 1 byte == 8 bits and the byte save 0 or 1
         * if i want to give him the permission of write 1000
         * if i want to give him the permission of read  0100
         * if i want to give him the permission of write 0010
         * if i want to give him the permission of Del   0001
         * to convert it to decimal every column will be * 2
         * 1 2 4 8 16 32 64 128
         * 
         * delete 1
         * write 2
         * execute 4 
         * read 8
         * delete write 3
         * delete write execute 7
         * delete write execute read 15
         * if they are more than 8 you can use short so the bits will be more than those numbers
         */

        class Employee
        {
         public string Name;
         public int Age;
         public decimal Salary;
         public Gender Gender;
         public Permissions Permissions;
         //public Permissions[] Permissions;
         //public bool[] Permissions;
        }

        #endregion

        static void Main()
        {
            /* Before OOP */
            #region 1- Exception Handling
            // Try Catch Is The Last Choic To Handle The Exceptions
            // Exception is the error in the run time
            //Program.DoSomeCode();
            //DoSomeProtectiveCode();
            /** SystemException Is The Child For Class Exception */
            // The All Inherit From The System Exception
            /* Exception Types
             * 1- System Exceptions
             *      1- Formate Exception
             *      2- Index Out of range Exception
             *      3- null reference Exception
             *      4- arithmatic Exception
             *      5- Arithmatic Exception
             *          1- Devided By Zero Exception
             *          2- overflow exception
             * 2- Application Exception [Not ToDay]
             */

            #endregion

            #region 2- Access Modifiers
            /** Access Modifiers is a c sharp keyword to indicate the accessibility scope
             * What is the access modifiers 
             * 1- Private
             * 2- protected private 
             * 3- protected
             * 4- internal
             * 5- protected internal
             * 6- public
             * 
             * Inside the Name Space we can write
             * 1- Class
             * 2- Struct
             * 3- Interface
             * 4- Enum
             * 
             * What is the access modifiers allowed inside the namespace
             * 1- Public
             * 2- Internal
             * The Defult for the access modifier inside the namespace is internal
             * Any Access modifier related to protected is allow only within the class because the only data type can inherit 
             */

            /// After Import the project Common Now i can use the public classes inside it
            /// TypeA typeA = new TypeA();
            ///  Type B is Accessible within its project only
            /// TypeB typeB = new TypeB(); // Invalid


            /** What I can type inside the class and struct
             * 1- Attributes [Fields] Member Variable
             * 2- Functions [User Constructor Functions, Getter Setters, Methods]
             * 3- Properties [Full Property, Automatic Property, Indexer]
             * 4- Events
             */

            /** What Is the access modifiers allowed within the class
             *  the 6 Accessmodifiers are allowed within the class
             *  1- public
             *  2- private
             *  3- protected private
             *  4- protected
             *  5- internal
             *  6- internal protected
             */


            /** what is the access modifiers allowed within the struct 
            * 1- public
            * 2- internal
            * 3- private
            * bc the struct is not allow the inheritance
            */

            //TypeA typeA = new TypeA();
            //typeA.z = 1; // The Only one Allowed because it public



            #endregion

            #region 3- Enum

            // Enum is a special data type that enables the variables to set [predefind constants] like days, gender
            // Day now will store one of the constants i predefind them
            //Days Day = Days.Sunday;

            #region Ex01

            //Grades X = Grades.A;
            ////Console.WriteLine(X); // A

            //if (X == Grades.A)
            //{
            //    Console.WriteLine(":)");
            //} else
            //{
            //    Console.WriteLine(":(");
            //}

            //Grades Y = (Grades) 2; // Explicit Casting because the compiler can not Casting from int to Gender
            //Console.WriteLine(Y);
            //Grades Z = (Grades) 10; // Explicit Casting with a label not predefind in the constats within the enum Grade
            //Console.WriteLine(Y);

            #endregion

            #region Ex02

            //Console.WriteLine("Please Enter Your Grade: ");
            //// The Type of Enum which i will convert the data from string to it
            ////            3-Grades     <<     2-Object       <<     1-String
            ////Grades X = (Grades)  Enum.Parse(typeof(Grades),Console.ReadLine()!);
            ////Console.WriteLine($"Your Grade Is: {X}");
            //// Not Safe Because if i recive any other value except the predefind constants i already defind will throw exception

            ////                              2-Enum         <<    1-String        >>     3-Object
            //bool Result =  Enum.TryParse(typeof(Grades), Console.ReadLine(), out object X);
            //Console.WriteLine($"Your Grade Is: {X}");
            //Console.WriteLine($"The Result is {Result}");


            #endregion

            #region Ex03

            //Gender G1 = Gender.Female;
            //Console.WriteLine(G1);

            //Gender G2 = (Gender)2;
            //Console.WriteLine(G2);

            //string Gneder = "Male";
            //string Gender = "male";
            //// Gendre X = (Gender) Gneder; // Casting Operator Cannot convert from String to Gender

            ////Enum.TryParse(typeof(Gender), Gneder, out object Result);
            ////Console.WriteLine(Result);

            //// Try Parse Generic

            ////Enum.TryParse<Gender>(Gender, true, out Gender result);
            //// The True To Avoid The Casesensitive for the lables of the enum
            //// Ignore The Case
            //Enum.TryParse(Gender, true, out Gender result);
            //Console.WriteLine(result);

            // The Defult Value of the enum is zero 

            //Gender X = new Gender();
            //// New Here Not Create The Object 
            //// its only create the defult value 
            //// The defult value is assigned by the construtctor function
            //// if i start my values with the zero i will not now if the parse is success or not 
            //Console.WriteLine(X);

            // The Enum Lables Is Case Sensitive

            #endregion

            #region Ex04
            //// Permissions
            //// PreDefined Values so i will store it inside enum

            //Employee employee = new Employee();
            //employee.Name = "Haji";
            //employee.Age = 25;
            //employee.Gender = Gender.Male;
            //employee.Permissions = (Permissions) 3;
            ////employee.Permissions[0] = Permissions.Delete;
            ////employee.Permissions[1] = Permissions.Delete;

            //Console.WriteLine(employee.Permissions); // Delete, Execute

            //// If You Want To Add New Permission For This Employee
            //// Do XOR
            //// Add The Read Permission
            //employee.Permissions = Permissions.Read ^ employee.Permissions;
            //Console.WriteLine(employee.Permissions); // Delete, Execute, Read

            ///** XOR Will Works on the Bits
            // * 3*4 binary number
            // * 0011 Delete, Execute
            // * 0100 Read
            // * 0111 Delete, Execute, Read
            // * when find matching will return zero
            // */
            //employee.Permissions = Permissions.Read ^ employee.Permissions;
            //Console.WriteLine(employee.Permissions); // Delete, Execute

            //// if you want to deny the permission do the xor again 
            ///** XOR Will Works on the Bits
            // * 3*4 binary number
            // * 0111 Delete, Execute, Read
            // * 0100 Read
            // * 0011 Delete, Execute
            // * when find matching will return zero
            // */

            //// & Can Check If You Want To Check If Delete Permission Do & Operation
            //// Permissions.Delete & employee.Permissions == Delete or random Number
            //if((Permissions.Delete & employee.Permissions) == Permissions.Delete)
            //{
            //    Console.WriteLine("Delete Already Exist");
            //} else
            //{
            //    employee.Permissions = Permissions.Delete & employee.Permissions;
            //}
            //Console.WriteLine(employee.Permissions); // Delete, Execute

            ///** And Will Works on the Bits
            // * 3*4 binary number
            // * 0011 Delete, Execute
            // * 0001 Delete
            // * 0001 Delete
            // * when find the both 1
            // */

            //// So To Add It Or Delete permission just use the xor , to check before add just use & to make the both operation use the |

            //// If you want to check if permission is already exist will not do any thing but if it already not existed will add it 
            //employee.Permissions = Permissions.Delete | employee.Permissions;
            //Console.WriteLine(employee.Permissions); // Delete, Execute

            ///** OR Will Works on the Bits
            // * 3*4 binary number
            // * 0011 Delete, Execute
            // * 0001 Delete
            // * 0011 Delete, Execute
            // * will return if one of them equal 1
            // */

            #endregion

            #endregion

        }




    }
}
