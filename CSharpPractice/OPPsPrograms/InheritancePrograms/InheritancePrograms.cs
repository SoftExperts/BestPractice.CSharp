namespace CSharpPractice.OPPsPrograms
{
    public static class InheritancePrograms
    {
        /// <summary>
        /// Constructor And Properties Programs Contents
        /// </summary>
        public static void InheritanceProgramsContents()
        {
            bool loopSkipOrContinue = false;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Please Enter 1 and get the Single Level Inheritance Example: Inheriting Fields.");
                Console.WriteLine("Please Enter 2 and get the inheritance in C# which inherits methods only.");
                Console.WriteLine("Please Enter 'N' to Skip the Program");

                string userInput = Console.ReadLine();
                bool basicPrograms = int.TryParse(userInput, out int programInputResult);

                if (basicPrograms)
                {
                    switch (programInputResult)
                    {
                        case 1:
                            EmployeeSalary();
                            Console.WriteLine("Do you Want to continue the Basic OOPs Programs? Please Enter Y or N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 2:
                            Animals();
                            Console.WriteLine("Do you Want to Continue the Basic OOPs Program! Please Enter Y or N");
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
        //-------------- Inheritance Programs ------------------
        /// <summary>
        /// This Method is used to find Single Level Inheritance Example: Inheriting Fields.
        /// </summary>
        private static void EmployeeSalary()
        {
            Console.WriteLine("Enter Employee Salary:");
            float.TryParse(Console.ReadLine(), out float putSalary);
            Programmer.salary = putSalary;
            Console.WriteLine("Enter Bouns:");
            float.TryParse(Console.ReadLine(), out float putBouns);
            Programmer.bouns = putBouns;

            Console.WriteLine("Employee Salary is: " + putSalary);
            Console.WriteLine("Employee Bouns: " + putBouns);
        }
        /// <summary>
        /// This Method is used to find another example of inheritance in C# which inherits methods only.
        /// Note: Multiple inheritance is not supported in C# through class.
        /// </summary>
        private static void Animals()
        {
            //Cat.eat();
            //Cat.bark();
            Animal.eat();
            Cat.mew();
            Dog.bark();
        }
    }
    //----------- Single Level Inheritance Fields ----------------
    class Employees     // base class (parent)
    {
        public static float salary;

    }
    class Programmer : Employees        // Drived class (Child)
    {
        public static float bouns;
    }
    //------------- Multi Level Inheritance Method ---------------
    // ---- Multiple inheritance is not supported in C# through class.----
    class Animal
    {
        public static void eat()        // Inherit Method
        {
            Console.WriteLine("Animals Eating...");
        }
    }
    class Dog : Animal
    {
        public static void bark()
        {
            Console.WriteLine("Dogs Barking...");
        }
    }
    class Cat : Dog
    {
        public static void mew()
        {
            Console.WriteLine("Cats say Mew mew...");
        }
    }
}