using System;

namespace MainMethodAssignment
{
    class MathOperation1
    {
        //create a method that takes two integers as parameters
        ///make one paarmetere optional by providing a default value
        /// 
        public int MathOperation(int i, int j = 1)
        {
            //perform multiplication on integers and return the result
            int result= i* j;
            return result;
        }
    }
}