namespace CSharpPractice.BasicsPrograms
{
    public static class FunctionPrograms
    {
        /// <summary>
        /// Function Programs Content
        /// </summary>
        public static void FunctionProgramsContent()
        {
            bool loopSkipOrContinue = false;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please Enter 1 and get the Display Message using function.");
                Console.WriteLine("Please Enter 2 and get the find maximum numbers.");
                Console.WriteLine("Pleae Enter 3 and get the Table.");
                Console.WriteLine("Please Enter 4 and get processor and successor  numbers using function.");
                Console.WriteLine("Please Enter 5 and get the Factorial numbers.");
                Console.WriteLine("Please Enter 6 and get the find a number is prime number, even number or odd number using function.");
                Console.WriteLine("Please Enter 7 and get the Arithmetic two numbers and operator and get results.");
                Console.WriteLine("Please Enter 8 and get the swapping two numbers.");
                Console.WriteLine("Please Enter 9 and get the returns student grade.");
                Console.WriteLine("Please Enter 10 and get the area of triangle.");
                Console.WriteLine("Please Enter 11 and get the first integer return its square. It second integer return its cube and then adds both returned values result.");
                Console.WriteLine("Please Enter 'N' to Skip the Program");
                string userInput = Console.ReadLine();
                bool basicPrograms = int.TryParse(userInput, out int programInputResult);

                if (basicPrograms)
                {
                    switch (programInputResult)
                    {
                        case 1:
                            DisplayMessage();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 2:
                            FindMaxNumber();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 3:
                            FindTable();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 4:
                            FindProcessorAndSeccessorNum();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 5:
                            FindFactorial();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 6:
                            FindPrimeEvenAndOdd();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 7:
                            FindArithmeticOperation();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 8:
                            FindSwapping();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 9:                        
                            FindGrade();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 10:
                            FindArea();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 11:
                            FindSquareNumber();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
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
        /// <summary>
        /// Validate the Input in Case of Yes or No
        /// </summary>
        /// <param name="input"></param>
        /// <param name="loopSkipOrContinue"></param>
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

        //---------------- All Function Programs -------------------
        /// <summary>
        /// This method is used to display a message on screen using functon.
        /// </summary>
        private static void DisplayMessage()
        #region
        {            
                // Function call
                PrintMessage(); 
        }
            // Function definition
            static void PrintMessage()
            {
                Console.WriteLine("Programming makes life interesting.");
            }
        #endregion

        /// <summary>
        /// This method is used to find maximum numbers.
        /// </summary>
        private static void FindMaxNumber()
        #region
        {
            // Function call with parameters
          
            int x, y;
            Console.WriteLine("Enter first numbers:");
            int.TryParse(Console.ReadLine(), out int userfirstInput);
            x = userfirstInput;
            Console.WriteLine("Enter second numbers:");
            int.TryParse(Console.ReadLine(), out int userSecInput);
            y = userSecInput;
            max(x, y);
        }
            // Function definition with parameters
            static void max(int mini, int maxi) 
            {
            if (mini > maxi)
                Console.WriteLine("Minimum number is: " + mini);
            else
                Console.WriteLine("Maximum number is:" + maxi);                
            }
        #endregion
        /// <summary>
        /// This method is used to display any number of Table.
        /// </summary>
        private static void FindTable()
        #region
        {
            Console.WriteLine("Enter a number:");
                int.TryParse(Console.ReadLine(), out int userTableNumber);
            table(userTableNumber);
        }
        static void table(int n)
        {
            for (int c = 1; c <= 10; c++)
            {
                Console.WriteLine(n + " * " + c + "=" + n * c);
            }
        }
        #endregion

        /// <summary>
        /// This method is used to displays its processor and successor  numbers using function.
        /// </summary>
        private static void FindProcessorAndSeccessorNum()
        #region
        {
            int x;
            Console.WriteLine("Enter an integer: ");
            int.TryParse(Console.ReadLine(), out int userInputNum);
            x= userInputNum;
            value(x);
        }
        static void value(int x)
        {
            int p, n;
            p = x - 1;
            n = x + 1;
            Console.WriteLine("The number before " + x + " is " + p);
            Console.WriteLine("The number after " + x + " is " + n);
        }
        #endregion

        /// <summary>
        /// This method is used to find the Factorial numbers.
        /// </summary>
        private static void FindFactorial()
        #region
        {
            int num;
            Console.WriteLine("Enter a number:");
            int.TryParse(Console.ReadLine(), out int userInput);
            num = userInput;
            factorial(num);
        }
        
        static void factorial(int x)
        {
            long fact;
            fact = 1;
            for(int i = 1; i <= x; i++)
                fact = fact * i;
            Console.WriteLine("Factorial of " + x + " is " + fact);
        }
        #endregion

        /// <summary>
        /// This method is used to find a number is prime number, even number or odd number using function.
        /// </summary>
        private static void FindPrimeEvenAndOdd()
        #region
        {
            int n;
            Console.WriteLine("Enter a number:");
            int.TryParse(Console.ReadLine(),out int userInput);
            n = userInput;
            Console.WriteLine("Nature of number");
            Console.WriteLine("-----------------------");
            checkNumber(n);
        }
        static void checkNumber(int n)
        {
            int c = 0;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    c = 1;
            }
            if (n % 2 == 0 && c == 0)
                Console.WriteLine(n + " is a prime even number: ");
            else if (n % 2 != 0 && c == 0)
                Console.WriteLine(n + " is a odd prime number: ");
            else if (n % 2 == 0 && c != 0)
                Console.WriteLine(n + " is only an even number, not prime.");
            else if (n % 2 != 0)
                Console.WriteLine(n + " is only an odd number, not prime.");
            else
                Console.WriteLine(" is not a prime number.");
        }
        #endregion

        /// <summary>
        /// This method is used to find Arithmetic two numbers and operator and get results. 
        /// </summary>
        private static void FindArithmeticOperation()
        #region
        {
            int x, y;
            char c;
            Console.WriteLine("Enter first number:");
            int.TryParse(Console.ReadLine(), out int firstNumber);
            x = firstNumber;
            Console.WriteLine("Enter Operator:");
            char.TryParse(Console.ReadLine(), out char userOperator);
            c = userOperator;
            Console.WriteLine("Enter second number:");
            int.TryParse(Console.ReadLine(), out int secondNumber);
            y = secondNumber;

            calling(x, y, c);
        }
        static void calling(int a, int b, char ope)
        {
            switch(ope)
            {
                case '+':
                    Console.WriteLine(a + " + " + b + " = " + (a + b));
                    break;
                case '-':
                    Console.WriteLine(a + " - " + b + " = " + (a - b));
                    break;
                case '*':
                    Console.WriteLine(a + " * " + b + " = " + (a * b));
                    break;
                case '/':
                    Console.WriteLine(a + " / " + b + " = " + (a / b));
                    break;
                case '%':
                    Console.WriteLine(a + " % " + b + " = " + (a % b));
                    break;
                default:
                    Console.WriteLine("Invailid Operator!");
                    break;
            }
        }
        #endregion
        /// <summary>
        /// This method is used to find displays swapping two numbers.
        /// </summary>
        private static void FindSwapping()
        #region
        {
            int a, b;
            Console.WriteLine("Enter an integer:");
            int.TryParse(Console.ReadLine(), out int userInput);
            a = userInput;
            Console.WriteLine("Enter an integer:");
            int.TryParse(Console.ReadLine(), out int userInput1);
            b = userInput1;

            Console.WriteLine("Value before Swapping:");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("Swapping the values..");
            swap(ref a,ref b);
            Console.WriteLine("Values after swapping:");
                Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }
        static void swap(ref int x, ref int y)
        {
            int t;
            t = x;
            x = y;
            y = t;
        }
        #endregion

        /// <summary>
        /// This method is used to find returns student grade.
        /// </summary>
        private static void FindGrade()
        #region
        {
            int marks;
            char g;
            Console.WriteLine("Enter marks: ");
            int.TryParse(Console.ReadLine(), out int userMarks);
            marks = userMarks;
            g = grade(marks);
            Console.WriteLine("Your Grade is " + g);
        }
        static char grade(int m)
        {
            if (m > 80)
                return 'A';
            else if (m > 60)
                return 'B';
            else if (m > 40)
                return 'C';
            else
                return 'F';
        }
        #endregion

        /// <summary>
        /// This Method is used to find the area of triangle.
        /// </summary>
        private static void FindArea()
        #region
        {
            int bas, height;
            double ar;
            Console.WriteLine("Enter Base:");
            int.TryParse(Console.ReadLine(), out int userBaseInput);
            bas = userBaseInput;
            Console.WriteLine("Enter Height:");
            int.TryParse(Console.ReadLine(), out int userHeightInput);
            height = userHeightInput;
            ar = Area(bas, height);
            Console.WriteLine("Area of triangle is :" + ar);
        }
        static float Area(int b, int hei)
        {
            double a;
            a = 0.5 * b * hei;
            return (float)a;
        }
        #endregion

        /// <summary>
        /// This Method is used to find first integer return its square. It second integer return its cube and then adds both returned values result. 
        /// </summary>
        private static void FindSquareNumber()
        #region
        {
            int firstNum, secondNum, result;
            Console.WriteLine("Enter first integer:");
            int.TryParse(Console.ReadLine(), out int firstNumber);
            firstNum = firstNumber;
            Console.WriteLine("Enter second integer:");
            int.TryParse(Console.ReadLine(), out int secondNumber);
            secondNum = secondNumber;
            result = Square(firstNum) + Cube(secondNum);
            Console.WriteLine("Result: = " + result);

        }
        static int Square(int num)
        {
            return num * num;
        }
        static int Cube(int num)
        {
            return num * num * num;
        }
        #endregion
    }
}
