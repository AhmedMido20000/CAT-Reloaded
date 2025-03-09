using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_cat_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* #region Largest num
            int[] arr = new int[10];
            Console.WriteLine("Enter numbers:");
            for (int i = 0; i < 10; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int largest = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > largest)
                {
                    largest = arr[i];
                }
            }
            Console.Write("The largest number is:");
            Console.WriteLine(largest); 
            #endregion 
            */

            /* #region Vowel chars
            Console.WriteLine("Enter characters:");
            char c = char.Parse(Console.ReadLine());
            if (c == 'a' || c == 'o' || c == 'u' || c == 'i' || c == 'e')
            {
                Console.WriteLine("Vowel");
            }
            else
                Console.WriteLine("consonant");

            #endregion*/

            /* #region Multiplication Table
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(num+"*"+i+"="+(num*i));
            } 
            #endregion*/

            /* #region Divided by 3 and 4
            Console.WriteLine("Enter number:");
            int num = int.Parse(Console.ReadLine());
            if (num % 4 == 0 && num % 3 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
                Console.WriteLine("No");

            #endregion*/

            /* #region Binary number
            Console.WriteLine("Enter number:");
            int num = int.Parse(Console.ReadLine());
            String binary = "";
            for(;num>0;num/=2)
            {
                binary = (num % 2) + binary;
            }
            Console.WriteLine(binary);
            #endregion*/

            /* #region Stored ascending arry
            Console.WriteLine("Enter size of arry");
            int size = int.Parse(Console.ReadLine());
            double[] arr1 = new double[size];
            double[] arr2 = new double[size];
            double[] mergArr = new double[size * 2];
            Console.WriteLine("Enter numers of first arry");
            for(int i=0;i<size;i++)
            {
                arr1[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter numers of second arry");
            for (int i = 0; i < size; i++)
            {
                arr2[i] = double.Parse(Console.ReadLine());
            }
            for(int i=0;i<size;i++)
            {
                mergArr[i] = arr1[i];
                mergArr[i + size] = arr2[i];
            }
            Array.Sort(mergArr);
            Console.WriteLine("The merg arry:");
            for(int i=0;i<mergArr.Length;i++)
            {
                Console.WriteLine(mergArr[i]);
            }

            #endregion*/

            /* #region Second largest number
            Console.WriteLine("Enter size of arry");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter numbers:");
            for(int i=0;i<size;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int largestNum =arr [0];
            int SecondLargestNum = arr[0];
            for(int i=1;i<size;i++)
            {
                if (arr[i] > largestNum)
                {
                    SecondLargestNum = largestNum;
                    largestNum = arr[i];
                }
                else if (arr[i] > SecondLargestNum && arr[i] < largestNum)
                    SecondLargestNum = arr[i];
            }
            Console.WriteLine(SecondLargestNum);
            #endregion*/

            /* #region Reverse arry
            Console.WriteLine("Enter size of arry");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter numbers:");
            for(int i=0;i<size;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Revers arry is:");
            for(int i=size-1;i>=0;i--)
            {
                Console.WriteLine(arr[i]);
            }
            #endregion*/
        }
    }
}
