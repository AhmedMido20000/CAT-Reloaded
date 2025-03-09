using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treaning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a character: ");
            
            char ch = (char)Console.Read(); // تحويل الرقم إلى حرف
            Console.WriteLine(); // الانتقال إلى السطر التالي

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' ||
                ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("Vowel");
            }
            else if (char.IsLetter(ch))
            {
                Console.WriteLine("Consonant");
            }
            else
            {
                Console.WriteLine("Invalid input"); // في حال كان الإدخال غير حرفي
            }
        }
    }
}
