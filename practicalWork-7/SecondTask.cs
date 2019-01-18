using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicalWork_7
{
    class SecondTask
    {
         int[] _array;
       
        public SecondTask()
        {
            _array = new int[] { 1, 2, 3, 4, 5 };
        }      

        public static bool operator <(SecondTask obj, int value)
        {
            int sum = 0;

            for(int i = 0; i < obj._array.Length; i++)
            {
                sum += obj._array[i];
            }

            if (sum < value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >(SecondTask obj, int value)
        {
            int sum = 0;

            for (int i = 0; i < obj._array.Length; i++)
            {
                sum += obj._array[i];
            }

            if (sum > value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
