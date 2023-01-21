namespace CSharpPractice.BasicsPrograms
{
    public static class AirthmeticPrograms
    {
        /// <summary>
        /// Airthmetic Programs Contents
        /// </summary>
        public static void AirthmeticProgramsContents()
        {
            bool loopSkipOrContinue = false;
            do
            {
                Console.WriteLine("Please Enter 1 to Sum Two Values");
                Console.WriteLine("Please Enter 2 to Subtraction Two Values");
                Console.WriteLine("Please Enter 3 to Multiplication Two Values");
                Console.WriteLine("Please Enter 4 to Division Two Values");
                Console.WriteLine("Please Enter 'N' to Skip the Program");

                string userInput = Console.ReadLine();
                bool basicPrograms = int.TryParse(userInput, out int programInputResult);

                if (basicPrograms)
                {
                    switch (programInputResult)
                    {
                        case 1:
                            Sum();
                            Console.WriteLine("Do you Want to continue the Airthmetic Programs! Please Enter Y or N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 2:
                            Subtraction();
                            Console.WriteLine("Do you Want to Continue the Arithmetic Program! Please Enter Y or N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 3:
                            Multiplication();
                            Console.WriteLine("Do you want to continue the Arithmetic Program! Please Enter Y or N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 4:
                            Division();
                            Console.WriteLine("Do you want to continue the Arithmetic Program! Please Enter Y or N");
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
            } 
            while (loopSkipOrContinue);
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

        //------------------- All Airthmetic Programs -----------

        /// <summary>
        /// This Method is Used to Perform Addition.
        /// </summary>
        private static void Sum()
        {
            Console.WriteLine("Please Enter first Number");
            int.TryParse(Console.ReadLine(), out int firstNumber);

            Console.WriteLine("Please Enter second Number");
            int.TryParse(Console.ReadLine(), out int secondNumber);

            Console.WriteLine("The Sum = " + (firstNumber + secondNumber));
        }
        
        /// <summary>
        /// This Mehtod is Used to Perform Subtraction.
        /// </summary>
        private static void Subtraction()
        {
            Console.WriteLine("Please Enter first Number");
            int.TryParse(Console.ReadLine(), out int firstNumber);

            Console.WriteLine("Please Enter second Number");
            int.TryParse(Console.ReadLine(), out int secondNumber);

            Console.WriteLine("The Subtraction = " + (firstNumber - secondNumber));
        }

        /// <summary>
        /// This Method is Used to Perform Multiplication.
        /// </summary>
        private static void Multiplication()
        {
            Console.WriteLine("Please Enter first Number");
            int.TryParse(Console.ReadLine(), out int firstNumber);

            Console.WriteLine("Please Enter second Number");
            int.TryParse(Console.ReadLine(), out int secondNumber);

            Console.WriteLine("The Multiplication = " + (firstNumber * secondNumber));
        }

        /// <summary>
        /// This Mehtod is Used to Perform Division. 
        /// </summary>
        private static void Division()
        {
            Console.WriteLine("Please Enter first Number");
            float.TryParse(Console.ReadLine(), out float firstNumber);

            Console.WriteLine("Please Enter second Number");
            float.TryParse(Console.ReadLine(), out float secondNumber);

            Console.WriteLine("The Division = " + (firstNumber / secondNumber));
        }
    }
}