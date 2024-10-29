using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMEWORK_SAADAT_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = 0;
            do
            {
                Console.WriteLine(" ENTER TO LENGTH PLEAS >0");
                n = int.Parse(Console.ReadLine());
            } while (n<=0);//TO ENTER A VALID LENGTH

            Random random = new Random();
            int[] arr=new int[n];

            Console.WriteLine("matrix elements");
            for (int i = 0; i < arr.Length; i++)//TI FILL THE MATRIX
            {
                arr[i] = random.Next(-15,15);
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine(  " ----------------------------------------------------------" );

            for (int i=0;i< arr.Length; i++)//TO SORT THE array
                for (int j = i+1; j < arr.Length; j++)
                            if (arr[i] > arr[j])
                            {
                                int temp = arr[i];
                                arr[i] = arr[j];
                                arr[j] = temp;
                            }
            Console.WriteLine("stored matrix elements");

            for (int i=0;i<arr.Length; i++)//stored matrix elements
                Console.WriteLine(arr[i]);

            Console.WriteLine("+=================================+");
            Console.WriteLine("##################################"+"\n"+search_<int>.serch_frequency(arr, int.Parse(Console.ReadLine())));
            Console.WriteLine("##################################"+"\n"+search_<int>.search_recidivism(arr, int.Parse(Console.ReadLine()), 0, arr.Length-1));
        }
    }
}
