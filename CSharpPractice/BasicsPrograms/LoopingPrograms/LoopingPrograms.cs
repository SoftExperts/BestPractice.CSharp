using System.Data.Common;
using System.Security.Cryptography.X509Certificates;

namespace CSharpPractice.BasicsPrograms.LoopingPrograms
{
    public static class LoopingPrograms
    {
        /// <summary>
        /// Looping Programs Content
        /// </summary>
        public static void LoopingProgramsContent()
        {
            bool loopSkipOrContinue = false;
            do
            {
                Console.WriteLine("Please Enter 1 and get Display Masseges for any times using While Loop.");
                Console.WriteLine("Please Enter 2 and get display Counting Numbers from 1 - 10 using while loop.");
                Console.WriteLine("Please Enter 3 and get display counting numbers and Sum of all numbers.");
                Console.WriteLine("Please Enter 4 and get any Numbers with thier Square.");
                Console.WriteLine("Please Enter 5 and get the Counting Table.");
                Console.WriteLine("Pleae Enter 6 and get diaplay sum of digits.");
                Console.WriteLine("Please Enter 7 and get the Factorial Numbers.");
                Console.WriteLine("Please Enter 8 and get Sum of follwoing Series.");
                Console.WriteLine("Please Enter 9 and get the Even sum and Odd sum numbers.");
                Console.WriteLine("Please Enter 10 and get the Armstrong numbers.");
                Console.WriteLine("Please Enter 11 and get find Fibonacci Numbers.");
                Console.WriteLine("Please Enter 12 and get Check the Fibonacci Numbers.");
                Console.WriteLine("Please Enter 13 and get Check the Reverce Counting.");
                Console.WriteLine("Please Enter 14 and get display the result of first number raise to the power of second number.");
                Console.WriteLine("Please Enter 15 and get check the whether it is Palindrome or not.");
                Console.WriteLine("Please Enter 16 and get All Odd numbers in the given range.");
                Console.WriteLine("Please Enter 17 and get the Odd numbers.");
                Console.WriteLine("Pleae Enter 18 and get Create the Table with Length.");
                Console.WriteLine("Please Enter 19 and get display Sum of Square.");
                Console.WriteLine("Please Enter 20 and get lowest and Higest digit in the number.");
                Console.WriteLine("Please Enter 21 and get prints the sum of the following series.");
                Console.WriteLine("Please Enter 22 and get print following series.");
                Console.WriteLine("Please Enter 23 and get print the following series 1  -4   7    -10 .....-30.");
                Console.WriteLine("Pleae Enter 24 and get check wheter it is a perfect number or not.");
                Console.WriteLine("Please Enter 25 and get the check if it is Prime or Composite.");
                Console.WriteLine("Please Enter 26 and get display the number if it is greater than 0");
                Console.WriteLine("Pleae Enter 27 and get Break Statement.");
                Console.WriteLine("Please Enter 28 and get prints Outer and Inner numbers.");
                Console.WriteLine("Please Enter 29 and get prints Product Component of a number without repeating them.");
                Console.WriteLine("Please Enter 30 and get Sum Component Of Number following output.");
                Console.WriteLine("Please Enter 31 and get height of triangle if user enter any numbers.");
                Console.WriteLine("Please Enter 32 and get Reverce Triangle display in *");
                Console.WriteLine("Please Enter 33 and get displays block in *.");
                Console.WriteLine("Pleasse Enter 34 and get displays the reverce numbers.");
                Console.WriteLine("Please Enter 35 and get dispalys Down to upper triangle in *.");
                Console.WriteLine("Please Enter 36 and get displays Upper to down triagnle in *.");
                Console.WriteLine("Please Enter 37 and get displays numbers of triangle.");
                Console.WriteLine("Please Enter 'N' to Skip the Program");
                string userInput = Console.ReadLine();
                bool basicPrograms = int.TryParse(userInput, out int programInputResult);

                if (basicPrograms)
                {
                    switch (programInputResult)
                    {
                        case 1:
                            DisplayMasseges();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 2:
                            CountingNumbers();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 3:
                            NumberOfSum();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 4:
                            FindSquareNumber();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 5:
                            ArithmeticTable();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 6:
                            FindSumOfDigits();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 7:
                            FindFactorial();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 8:
                            SumOfSeries();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 9:
                            FindEvenOddSum();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 10:
                            FindArmstrongNumber();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 11:
                            FindFibonacciNumber();
                            Console.WriteLine("\n If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 12:
                            CheckFibonacciNumber();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 13:
                            BackCounting();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 14:
                            FindPowerNumber();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 15:
                            FindPalindromeNumber();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 16:
                            FindOnlyOddNumber();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 17:
                            FindOddNumber();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 18:
                            FindAnyTable();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 19:
                            FindSumOfSquare();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 20:
                            FindLowestHighestNumber();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 21:
                            FindSumOfSeries();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(),ref loopSkipOrContinue);
                            break;
                        case 22:
                            FollowingSeries();
                            Console.WriteLine("\n If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 23:
                            FollowingSeries2();
                            Console.WriteLine("\n If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 24:
                            CheckPrefectNumber();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 25:
                            FindPrimeComposite();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 26:
                            ContinueStatement();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 27:
                            BreakStatement();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 28:
                            FindInnerOrOuterNumbers();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 29:
                            FindProductComponentNumber();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 30:
                            FindSumComponentOfNumber();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 31:
                            FindTriangleOFCharacter();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine() , ref loopSkipOrContinue);
                            break;
                        case 32:
                            FindReverceTriange();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 33:
                            FindBlock();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 34:
                            FindReverceNumbers();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 35:
                            FindDownTriangle();
                            Console.WriteLine("If you want to Continue loops program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 36:
                            FindUpperToDownTriangle();
                            Console.WriteLine("If you want to Continue loops program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 37:
                            FindNumbersOfTriangle();
                            Console.WriteLine("If you want to Continue loops program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        default:
                            Console.WriteLine("Please Enter 1-4!");
                            loopSkipOrContinue = true;
                            break;
                    }
                }
                else if (userInput != null && userInput.Contains('n', StringComparison.InvariantCultureIgnoreCase))
                {
                    loopSkipOrContinue = false;
                }
                else
                {
                    Console.WriteLine("Please Enter The Valid Number 1-4 ");
                    loopSkipOrContinue = true;
                }
            } while (loopSkipOrContinue);
        }

        #region
        private static void FindYesOrNo(string input, ref bool loopSkipOrContinue)
        {
            bool flag = false;
            do
            {
                if (input != null && input.Contains('y', StringComparison.InvariantCultureIgnoreCase))
                {
                    loopSkipOrContinue = true;
                    flag = false;
                }
                else if (input != null && input.Contains('n', StringComparison.InvariantCultureIgnoreCase))
                {
                    loopSkipOrContinue = false;
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Please Enter the Y or N");
                    input = Console.ReadLine();
                    flag = true;
                }

            } while (flag);
        }
        #endregion

        //---------------------All Looping Programs------------------

        /// <summary>
        /// This Method is used to Display Messages for any times using While Loop.
        /// </summary>
        private static void DisplayMasseges()
        {
            Console.WriteLine("Dispaly the Messages four times");
            int morning = 1;
            while (morning < 5)
            {
                Console.WriteLine("Goood Morning..!");
                morning++;
            }
        }

        /// <summary>
        /// This Mehtod is used to display Counting Numbers from 1 - 10 using while loop. 
        /// </summary>
        private static void CountingNumbers()
        {
            Console.WriteLine("Display the Counting Numbers 1-10");
            int count = 1;
            while (count < 10)
            {
                Console.WriteLine(count);
                count++;
            }
        }

        /// <summary>
        /// This Method is used to display counting numbers and Sum of all numbers.
        /// </summary>
        private static void NumberOfSum()
        {
            Console.WriteLine("Counting Numbers");
            int number = 1;
            int sum = 0;

            while (number <= 5)
            {
                Console.WriteLine(number);
                sum = sum + number;
                number++;
            }
            Console.WriteLine("Sum of All Numbers is: " + sum);
        }

        /// <summary>
        /// This Method is used to any Numbers with thier Square.
        /// </summary>
        private static void FindSquareNumber()
        {
            Console.WriteLine("Numbers with thier Square");
            int number = 1;

            while (number <= 5)
            {
                Console.WriteLine(number + " of Square is = " + number * number);
                number++;
            }
        }

        /// <summary>
        /// This Method is used dispalay the Counting Table.
        /// </summary>
        private static void ArithmeticTable()
        {
            Console.WriteLine("Enter the any Number");
            int.TryParse(Console.ReadLine(), out int tableNumber);

            int count = 1;

            while (count <= 10)
            {
                Console.WriteLine(tableNumber + " * " + count + " = " + tableNumber * count);
                count++;
            }
        }

        /// <summary>
        /// This Method is used to diaplay sum of digits.
        /// </summary>
        private static void FindSumOfDigits()
        {
            int r, sum = 0;
            Console.WriteLine("Enter the Numbers");
            int.TryParse(Console.ReadLine(), out int number);

            while (number != 0)      // 222 true , 22 true , 2 true , 0 false
            {
                r = number % 10;    // 2 = 222 % 10 , 2 = 22 % 10 , 2 = 2 % 10
                if (r == 0)          // false , false , false
                {
                    sum = sum + r;
                }
                else
                    sum = sum + r;      // 2 = 0+2 , 4 = 2 + 2 , 6 = 4 + 2
                number = number / 10;   // 22 = 222 / 10 , 2 = 22 / 10
            }
            Console.WriteLine("The sum of digits of " + sum);
        }

        /// <summary>
        /// This Method is used to find the Factorial of Numbers.
        /// </summary>
        private static void FindFactorial()
        {
            int fact = 1, count = 1;
            Console.WriteLine("Enter the Number");  // 4
            int.TryParse(Console.ReadLine(), out int userinput);

            while (count <= userinput)       // 1 <= 4 true , 2 <= 4 true , 3 <= 4 , 4 <= 4 true , 5 <= 4 false
            {
                fact = fact * count;        // 1 = 1 * 1 , 2 = 1 * 2 , 6 = 2 * 3 , 24 = 6 * 4
                count++;                    // 1+1 = 2 , 2+1 = 3 , 3+1 = 4 , 4+1 = 5
            }
            Console.WriteLine("Factorial Of " + userinput + " is " + fact); // 24
        }

        /// <summary>
        /// This Method is used to Sum of follwoing Series.
        /// </summary>
        private static void SumOfSeries()
        {
            double count = 2.0, result = 1.0;
            while (count <= 100)
            {
                result = result + 1.0 / count;
                count = count + 2;
            }
            Console.WriteLine("Result is: " + result);
        }

        /// <summary>
        /// This Method is used to display the Even sum and Odd sum numbers.
        /// </summary>
        private static void FindEvenOddSum()
        {
            int evenSum = 0, oddSum = 0;
            Console.WriteLine("Enter a Positive Number");   // 5
            int.TryParse(Console.ReadLine(), out int positiveNumber);

            while (positiveNumber >= 0)      // 5 >=0 true , 4>=0 true ,
            {
                if (positiveNumber % 2 == 0)     // 5 % 2 == 0 => false, 4%2 == 0 => true
                {
                    evenSum = evenSum + positiveNumber;     // 4 + 0 = 4 , 
                }
                else
                {
                    oddSum = oddSum + positiveNumber;   // 5 + 0 = 5, 
                }
                positiveNumber--;       // 5-1 = 4
            }
            Console.WriteLine("The Sum of Even Digits is: " + evenSum);     // 4
            Console.WriteLine("The Sum of Odd Digits is: " + oddSum);        // 5
        }

        /// <summary>
        /// This Method is used to find the Armstrong numbers.
        /// </summary>
        private static void FindArmstrongNumber()
        {
            int num, a, sum = 0;
            Console.WriteLine("Enter a number");
            int.TryParse(Console.ReadLine(), out int userInput);
            num = userInput;
            while (num != 0)
            {
                a = num % 10;
                sum = sum + (a * a * a);
                num = num / 10;
            }
            if (sum == userInput)
            {
                Console.WriteLine(userInput + " is an Armstrong number.");
            }
            else
            {
                Console.WriteLine(userInput + " is not an Armstrong number.");
            }
        }

        /// <summary>
        /// This Mehtod is used to find Fibonacci Numbers.
        /// </summary>
        private static void FindFibonacciNumber()
        {
            int a = 0, b = 1, next, count = 2;
            Console.WriteLine("How many Fibonacci terms requierd: ");
            int.TryParse(Console.ReadLine(), out int userInput);

            Console.WriteLine("Fibonacci terms are");
            Console.Write(a + "  " + b);

            while (count < userInput)
            {
                next = a + b;
                Console.Write("  " + next);
                count++;
                a = b;
                b = next;
            }


        }

        /// <summary>
        /// This Method is used to Check the Fibonacci Numbers.
        /// </summary>
        private static void CheckFibonacciNumber()
        {
            int a, b, next;
            Console.WriteLine("Enter a number");
            int.TryParse(Console.ReadLine(), out int userInput);

            if ((userInput == 0) || (userInput == 1))
                Console.WriteLine(userInput + " is a Fibonacci number.");
            else
            {
                a = 0;
                b = 1;
                next = a + b;

                while (next < userInput)
                {
                    a = b;
                    b = next;
                    next = a + b;
                }
                if (next == userInput)
                    Console.WriteLine(userInput + " is Fibonacci number.");
                else
                    Console.WriteLine(userInput + " is not a Fibonacci number.");
            }
        }

        /// <summary>
        /// This Method is used to Check the Reverce Counting.
        /// </summary>
        private static void BackCounting()
        {
            Console.WriteLine("Back-Counting e.g 10-1");
            Console.WriteLine("Enter Maximum number");
            int.TryParse(Console.ReadLine(), out int maxNumber);

            do
            {
                Console.WriteLine(maxNumber);
                maxNumber--;
            }
            while (maxNumber >= 1);
        }

        /// <summary>
        /// This Method is used to display the result of first number raise to the power of second number.
        /// </summary>
        private static void FindPowerNumber()
        {
            int count = 1, result = 1;
            Console.WriteLine("Enter First Number");
            int.TryParse(Console.ReadLine(), out int firstNumber);
            Console.WriteLine("Enter Second Number");
            int.TryParse(Console.ReadLine(), out int secondNumber);

            do
            {
                result = result * firstNumber;
                count++;
            }
            while (count <= secondNumber);
            {
                Console.WriteLine("Result is: " + result);
            }
        }

        /// <summary>
        /// This method is used to check whether it is Palindrome or not.
        /// </summary>
        private static void FindPalindromeNumber()
        {
            int n, digit, reverce = 0;
            Console.WriteLine("Enter a Positive Number: ");
            int.TryParse(Console.ReadLine(), out int userInput);

            n = userInput;

            do
            {
                digit = userInput % 10;
                reverce = (reverce * 10) + digit;
                userInput = userInput / 10;
            }
            while (userInput != 0); 
            
                Console.WriteLine("The reverce of the number is: " + reverce);
            if(n == reverce)
                Console.WriteLine("The Number is a Palindrome");
            else
                Console.WriteLine("The number is not a Palindrome");
        }

        /// <summary>
        /// This Method is used to All Odd numbers in the given range.
        /// </summary>
        private static void FindOnlyOddNumber()
        {
            int increment;
            Console.WriteLine("Enter Starting number:");
            int.TryParse(Console.ReadLine(), out int strNumber);
            Console.WriteLine("Enter Ending number:");
            int.TryParse(Console.ReadLine(), out int enNumber);

            increment = strNumber;
            do
            {
                if (increment % 2 == 0)
                    Console.WriteLine(increment);
                increment++;
            }
            while (increment <= enNumber);

            Console.WriteLine("Odd number..!");
        }

        //-----------------For Loops--------------------------
        /// <summary>
        /// This method is used to find Odd numbers.
        /// </summary>
        private static void FindOddNumber()
        {
            int product = 1, count;
            for(count = 1; count <= 10; count = count + 2)
                product = product * count;
            Console.WriteLine("Result is: " + product);
        }

        /// <summary>
        /// This Method is used to Create the Table with Length.
        /// </summary>
        private static void FindAnyTable()
        {
            Console.WriteLine("Enter the Table number");
            int.TryParse(Console.ReadLine(), out int tableNumber);
            Console.WriteLine("Enter the Length of Table");
            int.TryParse(Console.ReadLine(), out int lengthNumber);
            int c;
            for(c = 1; c <= lengthNumber; c++)
            {
                Console.WriteLine(tableNumber + " * " + c + " = " + tableNumber * c);
            }
        }

        /// <summary>
        /// This method is used to display Sum of Square.
        /// </summary>
        private static void FindSumOfSquare()
        {
            int c, sum = 0;
            Console.WriteLine("Enter a number");    //3 
            int.TryParse(Console.ReadLine(),out int userInput);

            for(c = 1; c <= userInput; c++)     // 1 <= 3 true , 2 <= 3 true , 3 <= 3 true , 4 <= 3 false
            
                sum = sum + (c * c);        // 1 <= 0 + (1 * 1) , 5 <= 1 + (2 *2) ,  14 <= 5 + (3 * 3)
                Console.WriteLine("Sum is :" + sum);            // 14
        }

        /// <summary>
        /// This method is used to prints the lowest and Higest digit in the number.
        /// </summary>
        private static void FindLowestHighestNumber()
        {
            Console.WriteLine("Enter a number:");
            int.TryParse(Console.ReadLine(), out int userInput);
            int num = userInput;
            int high = userInput % 10, low = userInput % 10, rem;
            userInput = userInput / 10;
            
            for(int i = userInput; i >= 1; i = i/10)
            {
                rem = i % 10;
                if(rem > high)
                    high = rem;
                if(rem < low)
                    low = rem;
            }
            Console.WriteLine("The Highest digit of " + num + " is " + high);
            Console.WriteLine("The Lowest digit of " + num + " is " + low);
        }

        /// <summary>
        /// This Method is used for inputs the value of x and range. It then calculates and prints the sum of the following series.
        /// </summary>
        private static void FindSumOfSeries()
        {
            float sum = 0, den;            
            Console.WriteLine("Enter the value of x :");
            int.TryParse(Console.ReadLine(), out int userX);
            Console.WriteLine("Enter the range :");
            int.TryParse(Console.ReadLine(), out int userRange);

            for(int i = 0; i < userRange; i++)
            {
                den = (float) Math.Pow (userX, i);
                sum = sum + (1 / den);
            }
            Console.WriteLine("Sum of series:" + sum);
        }

        /// <summary>
        /// This Method is used to print following series.
        /// </summary>
        private static void FollowingSeries()
        {
            int a=1, i, incre = 3;
            Console.WriteLine("The Series is as follows:");

            for(i = 1; a <= 40; i++)
            {
                Console.Write(a + "\t");
                a = a + incre;
            }
        }

        /// <summary>
        /// This method is used to print the following series 1  -4   7    -10 .....-30.
        /// </summary>
        private static void FollowingSeries2()
        {
            int a = 1, i, p, incre = 3;
            Console.WriteLine("The Series:");

            for(i = 1; a<= 30; i++)
            {
                if(i % 2 == 0)
                {
                    p = -a;
                    Console.WriteLine(p);
                }
                else
                {
                    Console.Write(a + " ");
                    a = a+ incre;
                }
            }
        }

        /// <summary>
        /// This Method is used to check wheter it is a perfect number or not. For example, 6 is a perfect number vecause te divisiors of 6 are 1,2,3 and 1+2+3 = 6.
        /// </summary>
        private static void CheckPrefectNumber()
        {
            int i, mid, sum = 0;
            Console.WriteLine("Enter the number:");
            int.TryParse(Console.ReadLine(), out int userNum);

            mid = userNum / 2;
            for(i = 1; i <= mid; i++)
            {
                if ((userNum % i) == 0)
                    sum = sum + i;
            }
            if (sum == userNum)
                Console.WriteLine(userNum + " is a perfect number.");
            else
                Console.WriteLine(userNum + " is not a perfect number.");
        }

        /// <summary>
        /// This method is used to prints if it is Prime or Composite.
        /// </summary>
        private static void FindPrimeComposite()
        {
            int c, p = 1;
            Console.WriteLine("Enter an number");
            int.TryParse(Console.ReadLine(), out int userNum);

            for(c= 2; c <= userNum; c++)
                if(userNum % c == 0)
                {
                    p = 0;
                    break;
                }
            if (p == 1)
                Console.WriteLine(userNum + " is a Prime number.");
            else
                Console.WriteLine(userNum + " is a Composite number.");
        }

        /// <summary>
        /// This Method is used to display the number if it is greater than 0 otherwise it inputs next number using continue statement.
        /// </summary>
        private static void ContinueStatement()
        {
            for(int x =1; x <= 5; x++)
            {
                Console.WriteLine("Enter a number:");
                int.TryParse(Console.ReadLine(), out int userNum);

                if (userNum <= 0)
                    continue;
                Console.WriteLine("You Entered " + userNum);
            }            
        }

        /// <summary>
        /// This Method is used to Break Statement.
        /// </summary>
        private static void BreakStatement()
        {
            for(int x = 1; x <= 5; x++)
            {
                Console.WriteLine("Enter a number:");
                int.TryParse(Console.ReadLine(), out int userNum);

                if (userNum >= 0)
                    break;
                Console.WriteLine("You Entered " + userNum);
            }
        }

        //-----------Nested Loops----------
        /// <summary>
        /// This Method is used to prints Outer and Inner numbers.
        /// </summary>
        private static void FindInnerOrOuterNumbers()
        {
            int outer = 1, inner = 1;
            while(outer <= 2)
            {                
                while(inner <= 3)
                {
                    Console.WriteLine("Outer: " + outer + " Inner: " + inner);
                    inner++;
                }
                outer++;
            }
        }

        /// <summary>
        /// This Method is used to prints Product Component of a number without repeating them. e.g user enter 24 it displays 24*1, 12*2, 8*3 etc.
        /// </summary>
        private static void FindProductComponentNumber()
        {
            int outer, inner, sum = 1;
            Console.WriteLine("Enter a number:");
            int.TryParse(Console.ReadLine(), out int userNum);

            Console.WriteLine("Product Component of " + userNum + " are ");
            for (outer = userNum; outer >= sum; outer--)            
                for(inner = 1; inner <= userNum; inner++)
                {
                    if(outer * inner == userNum)
                    {
                        Console.WriteLine(outer + " * " + inner + " = " + outer * inner);
                        sum = inner + 1;
                    }
                }            
        }

        /// <summary>
        /// xxxxxxx This Method is used to Displays the  Find Sum Component Of Number following output.
        /// </summary>
        private static void FindSumComponentOfNumber()
        {
            int  outer, sum = 1;
            for(outer = 1; outer <= 5; outer++)     // 1 <= 5 true  , 2 <= 5 true , 3<= 5 true
            {
                Console.Write("1");                 // print 1  , 1 , 1
                for(int inner = 2; inner <= outer;  inner++)    // 2  <= 1 false    , 2 <= 2 true , 3 <= 2 false , 2 <= 3 true , 3 <= 3 true , 4 <= 3 false
                {
                    Console.Write("+" + inner);     // 1 + 2 , + 2 , + 3
                     sum = sum + inner;         // 3 = 1 + 2  , 5 = 3 + 2 , 8 = 5 + 3
                }
                Console.WriteLine("=" + sum  );       // 1 = 1 , 1+2 = 3 , 1 + 2 + 3 = 8
            }
        }

        /// <summary>
        /// This Method is used to find height of triangle if user enter any numbers.
        /// </summary>
        private static void FindTriangleOFCharacter()
        {
            char ch = 'A';
            int outer, inner;
            Console.WriteLine("Enter the height of triangle :");
            int.TryParse(Console.ReadLine(), out int userInputNumber);

            for (outer = 1; outer <= userInputNumber; outer++)
            {
                for (inner = 1; inner <= outer; inner++)
                { 
                    Console.Write(ch + " ");
                    ch++;
                }

               Console.WriteLine("\n");
            }
        }

        /// <summary>
        /// This Method is used to reverce triangle in *.
        /// </summary>
        private static void FindReverceTriange()
        {
            for(int i = 1; i <= 7; i++)
            {
                int j = i;
                while(j <= 7)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// This Mehtod is used to displays block in *.
        /// </summary>
        private static void FindBlock()
        {
            for(int m = 1; m <= 5; m++)
            {
                for(int n = 1; n <= 5; n++)
                    Console.Write("*");
                Console.WriteLine();
            }

        }

        /// <summary>
        /// This Method is used to displays the reverce numbers.
        /// </summary>
        private static void FindReverceNumbers()
        {
            int m = 4;
            do
            {
                int n = m;
                do
                {
                    Console.Write(m + "\t");
                    n--;
                }
                while (n >= 1);
                Console.WriteLine();
                m--;
            }
            while(m >= 1);
        }

        /// <summary>
        /// This Method is used to dispalys Down to upper triangle in *.
        /// </summary>
        private static void FindDownTriangle()
        {
            for(int i = 5; i >= 1; i--)
            {
                for(int s = 1; s <= 5 - i; s++)
                Console.Write(" ");
                for(int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }

        /// <summary>
        /// This Method is used to displays Upper to down triagnle in *.
        /// </summary>
        private static void FindUpperToDownTriangle()
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }

        /// <summary>
        /// This Method is used to displays numbers of triangle.
        /// </summary>
        private static void FindNumbersOfTriangle()
        {
            int c = 5;
            for(int i = 1; i <= 5; i++)
            {
                for(int k = 1; k <= c; k++)
                    Console.Write(" ");
                for(int j = 1; j<= i; j++)
                    Console.Write(i);     // (0) its means start 1 to 5 
                Console.WriteLine();
                c--;
            }
        }
    }
}