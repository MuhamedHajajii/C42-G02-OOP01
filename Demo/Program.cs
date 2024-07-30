
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

            #region Access Modifiers
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


        }


    }
}
