using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    /**
     * This Class Internal so it only accessible within the project called common only
     */
    internal class TypeB
    {
        public TypeB()
        {
            // I Can Access This Class Because its public && Within external project
            TypeA typeA = new TypeA();

            //typeA.x = 1; // invlaid because it private
            typeA.z = 1; // Valid Because it intenrnal
            typeA.y = 1; // Valid Because it public

        }
    }
}
