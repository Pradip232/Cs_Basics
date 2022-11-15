using System;

namespace CS_BasicProgramming
{
    public class ArmStrongNumber
    {

        public int FindNumberOfDigits(int number) {
            int NumberOfDigits = 0;
            while (number != 0)
            {
                NumberOfDigits++;
                number /= 10;
            }
            return NumberOfDigits;
        }

        public static void Main() {

            ArmStrongNumber Ao=new ArmStrongNumber();
            int TotalSum = 0, SingleDigitPower = 1;
            Console.WriteLine("Enter a number to check wheather it is Armstrong Number or not...\n");
            Console.WriteLine("Enter the number: ");

            if (int.TryParse(Console.ReadLine(), out int Number))
            {
                int NumberOfDigits = Ao.FindNumberOfDigits(Number);

                int temp = Number;
                while (temp != 0) 
                {
                    for (int i = 0; i < NumberOfDigits; i++)
                        SingleDigitPower *= (temp % 10);

                    TotalSum += SingleDigitPower;
                    SingleDigitPower = 1;       //Inintialize to 1
                    temp /= 10;
                }

                if (TotalSum == Number)
                    Console.WriteLine($"{Number} is Armstrong Number");
                else
                    Console.WriteLine($"{Number} is not Armstrong Number");
            } 

            else
                Console.WriteLine("Invalid Number type.....\nPLease enter correct input.");
        }
    }
}
