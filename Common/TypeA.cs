using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    /**
     * This Class Has a Access Modifier Public 
     * You Can Use it all over the project and in another project as long as you will import the library there
     */
    public class TypeA
    {
        public TypeA()
        {
            TypeB typeB = new TypeB();
        }
        // The Defult Access modifier inside the Struct && Class is private
        private int x; // By Defult Private [within the block scope where it is]
        internal int y; // Accessable within the project 
        public int z; // Accessable within the solution but reqiuerd to be imported first


        void Print()
        {
            Console.WriteLine(x);
        }
    }
}
