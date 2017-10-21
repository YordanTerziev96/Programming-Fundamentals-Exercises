using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.MasterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (IsPolidrome(i) && IsThereAEvenDigit(i) && IsDevisibleBySeven(i)) {
                    Console.WriteLine(i);
                }
            }

        }
        static bool IsPolidrome(int n) {
            bool isPoli = false;
            int num = n;
            int rev = 0;
            int digit = 0;
            while (num > 0) {
                digit = num % 10;
                rev = rev * 10 + digit;
                num /= 10;
            }
            if (n == rev)
            {
                isPoli = true;
            }
            return isPoli;
        }
        static bool IsDevisibleBySeven(int n) {
            bool isDiv = false;
            int num = n;
            int sum = 0;
            int digit = 0;
            while (num > 0)
            {
                digit = num % 10;
                sum += digit;
                num /= 10;
            }
            if (sum % 7 == 0)
            {
                isDiv = true;
            }
            return isDiv;
        }
        static bool IsThereAEvenDigit(int n) {
            bool isEvenDig = false;
            int num = n;
            int Digit = 0;
            while (num > 0)
            {
                Digit = num % 10;
                if (Digit % 2 == 0)
                {
                    isEvenDig = true;
                }
                num /= 10;
            }
            return isEvenDig;

        }
    }
}
