namespace CSharpPractice.OPPsPrograms
{
    public static class BasicOPPsPrograms
    {
        /// <summary>
        /// Basic OOPs Programs Contents
        /// </summary>
        public static void BasicOPPsProgramsContents()
        {
            bool loopSkipOrContinue = false;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Please Enter 1 and get the you entered number.");
                Console.WriteLine("Please Enter 2 and get Student Result.");
                Console.WriteLine("Please Enter 3 and get the Car color.");
                Console.WriteLine("Please Enter 4 and get the Car Details.");
                Console.WriteLine("Please Enter 'N' to Skip the Program");

                string userInput = Console.ReadLine();
                bool basicPrograms = int.TryParse(userInput, out int programInputResult);

                if (basicPrograms)
                {
                    switch (programInputResult)
                    {
                        case 1:
                            FindInOrOut();                            
                            Console.WriteLine("Do you Want to continue the Basic OOPs Programs? Please Enter Y or N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 2:
                            FindStudentMarks();
                            Console.WriteLine("Do you Want to Continue the Basic OOPs Program! Please Enter Y or N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 3:
                            FindCarColor();
                            Console.WriteLine("Do you want to continue the Basic OOPs Program! Please Enter Y or N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 4:
                            FindInCarDetails();
                            Console.WriteLine("Do you want to continue the Basic OOPs Program! Please Enter Y or N");
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
        // ---------------- Basic OOPs Programs --------------
        // ---------------- Create OOP Methods --------------
        /// <summary>
        /// This Method is used to find numbers from user input.
        /// </summary>
        private static void FindInOrOut()
        {
            Console.WriteLine("Enter a number:");
            int.TryParse(Console.ReadLine(), out int userInput);
            Test.n = userInput;
            Console.WriteLine("The value of n = " + Test.n);
        }
        /// <summary>
        /// This Method is used to get student total marks and average.
        /// </summary>
        private static void FindStudentMarks()
        {
            Console.WriteLine("Enter English Marks");
            int.TryParse(Console.ReadLine(), out int engMarks);
            Marks.english = engMarks;
            Console.WriteLine("Enter Math Marks");
            int.TryParse(Console.ReadLine(), out int mathMarks);
            Marks.math = mathMarks;
            Console.WriteLine("Enter Computer Marks");
            int.TryParse(Console.ReadLine(), out int compMarks);
            Marks.computer = compMarks;
            int sum;
            float average;
            sum = engMarks + mathMarks + compMarks;

            average = sum / 3.0f;
            Console.WriteLine("Total Subjects Marks is: " + sum);
            Console.WriteLine("All Subjects Average: " + average);
        }
        /// <summary>
        /// This Method is used to find the Car color.
        /// </summary>
        private static void FindCarColor()
        {
            Console.WriteLine("Your Car color is: " + Car.color);
            // Multiple Objects
            Console.WriteLine("Your Car color is: " + Car.color);
            Console.WriteLine("Your Car color is: " + Car.color);
        }

        private static void FindInCarDetails()  // method
        {
            Car_Details.model = "Mustang";          //call
            Console.WriteLine("Car Model is: " + Car_Details.model);
        }
    }
    // Create Classes
    static class Test
    {
       public static int n;
    }
    static class Marks
    {
        public static int english, math, computer;
    }
    static class Car
    {
        public static string color = "Red"; 
    }
    static class Car_Details
    {
        public static string model;     // feilds or data member   
        public static int year;
        public static string color;
    }
}