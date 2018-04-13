using System;

namespace Lab1_MathChallenge
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("\n\n Game to Calculate Corresponding Space of 2 Integers :\n");
            Console.Write("——————————————————————————————————————————————————————————————\n");
            Console.Write("Enter first 3-digit number: ");

            string firstInput = Console.ReadLine();

            //Validates user inputs 3 numbers, if it is not a 3 digit integer user is notified
            //TryParse is used to convert firstInput string into an integer using "out" keyword to pass the argument
            while (firstInput.Length != 3 || !Int32.TryParse(firstInput, out int firstOutput))
            {   
                Console.WriteLine("We need a 3-digit number, please try again.");//Message returned if incorrect data is submitted
                firstInput = Console.ReadLine();
            }
            int num1 = Convert.ToInt32(firstInput);


            Console.Write("Enter second 3-digit number: ");
            string secondInput = Console.ReadLine();

            while (secondInput.Length != 3 || !Int32.TryParse(secondInput, out int secondOutput))
            {
                Console.WriteLine("We need a 3-digit number, please try again.");
                secondInput = Console.ReadLine();
            }
            int num2 = Convert.ToInt32(secondInput);

            //string used to assign and divide digits 
            int firstNum1, secondNum1, thirdNum1 = 0;
            int firstNum2, secondNum2, thirdNum2 = 0;

            //Modulus operator divides each integer 
            firstNum1 = (num1 % 10);
            secondNum1 = (num1 / 10) % 10;
            thirdNum1 = (num1 / 100);

            firstNum2 = (num2 % 10);
            secondNum2 = (num2 / 10) % 10;
            thirdNum2 = (num2 / 100);

            //string used to calculate solution 
            int total1 = 0;
            int total2 = 0;
            int total3 = 0;

            //adding corresponding numbers
            total1 = (thirdNum1 + thirdNum2);
            total2 = (secondNum1 + secondNum2);
            total3 = (firstNum1 + firstNum2);

            //determines if corresponding numbers are equal
            bool a = (total1 == total2 && total2 == total3);

            Console.WriteLine("Result: "+ total1  + total2 +   total3 + " | " + a + " | ");

        }
    }
}
