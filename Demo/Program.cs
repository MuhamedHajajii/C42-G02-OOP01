namespace Demo
{
    internal class Program
    {

        #region 1- Exception Handling
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
        //         int X, Y, Z;

        //    bool Flag;
        //    do
        //    {
        //        Console.WriteLine("Enter First Number: ");
        //        Flag = int.TryParse(Console.ReadLine(), out X);

        //    } while (!Flag );

        //    do
        //    {
        //        Console.WriteLine("Enter Second Number: ");
        //        Flag = int.TryParse(Console.ReadLine(), out Y);

        //    } while (!Flag || Y == 0);

        //    Z = X / Y;

        //    Console.WriteLine(Z);
        //    }
        //    catch (Exception)
        //    {

        //        throw;
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



        }


    }
}
