using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace HOMEWORK_SAADAT_2
{
    internal class search_<T>
    {
        public static int serch_frequency(T[]arR,T Key) //repetition method
        {
            for(int i=0;i<arR.Length;i++)
                if (Key.Equals(arR[i]))//If the value is equal to the value from the array
                    return i;

            Console.WriteLine("sorry,there is no matching value for the one you entered");
            return -1;
        }
        public static int search_recidivism<T>(T[]arR, T Key,int l,int h) where T : IComparable<T>//method the recurrence IComparable added to allow comparison
        {
            int med = (l + h) / 2;
                 /* //  if(h<0) { Console.WriteLine("Sorry, there is no matching value for the one you entered."); return -1; }//I added this condition because if a number is entered that is smaller than all the existing numbers*/
            if (l == h)//This condition is an improvement over the condition in line 33, where if L>h, one cycle is shortened
            {
                if (Key.Equals(arR[med]))
                    return med;
                Console.WriteLine("Sorry, there is no matching value for the one you entered.");
                return -1;
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (l > h)//The basic rule is to go through all the elements, and we do not find this by exceeding the minimum limit to the maximum limit
            {
                Console.WriteLine("Sorry, there is no matching value for the one you entered.");
                return -1;
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            int B = arR[med].CompareTo(Key);

            if (arR[med].Equals(Key))
            {
                return med; 
            }

            if (B > 0)
            {
                return search_recidivism(arR, Key, l, med - 1); 
            }
            else // B<0
            {
                return search_recidivism(arR, Key, med + 1, h); 
            }

        }
    }
}
