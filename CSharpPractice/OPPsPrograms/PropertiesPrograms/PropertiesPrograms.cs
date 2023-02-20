namespace CSharpPractice.OPPsPrograms
{
    public static class PropertiesPrograms
    {
        /// <summary>
        /// Constructor And Properties Programs Contents
        /// </summary>
        public static void PropertiesProgramsContents()
        {
            bool loopSkipOrContinue = false;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Please Enter 1 and get the Properties Method.");
                Console.WriteLine("Please Enter 2 and get the Automatic Properties (Short Hand).");
                Console.WriteLine("Please Enter 3 and get the How to work Counter.");
                Console.WriteLine("Please Enter 4 and get the how many year old Collage.!.");
                Console.WriteLine("Please Enter 5 and get the Many Student Parameterized Constructor.");
                Console.WriteLine("Please Enter 6 and get the Parameterized Destructor.");
                Console.WriteLine("Please Enter 'N' to Skip the Program");

                string userInput = Console.ReadLine();
                bool basicPrograms = int.TryParse(userInput, out int programInputResult);

                if (basicPrograms)
                {
                    switch (programInputResult)
                    {
                        case 1:
                            FindPerson();
                            Console.WriteLine("Do you Want to continue the Basic OOPs Programs? Please Enter Y or N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 2:
                            FindShortHandPropertie();
                            Console.WriteLine("Do you Want to Continue the Basic OOPs Program! Please Enter Y or N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 3:
                            FindCounter();
                            Console.WriteLine("Do you want to continue the Basic OOPs Program! Please Enter Y or N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 4:
                            FindCollageDetails();
                            Console.WriteLine("Do you want to continue the Basic OOPs Program! Please Enter Y or N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        //case 5:
                        //    FindStudentData();
                        //    Console.WriteLine("Do you want to continue the Basic OOPs Program! Please Enter Y or N");
                        //    FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                        //    break;
                        //case 6:
                        //    FindBooksData();
                        //    Console.WriteLine("Do you want to continue the Basic OOPs Program! Please Enter Y or N");
                        //    FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                        //    break;
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
        //------------------ Properties (Get and Set) Programs ---------------
        //---------------- Properties and Encapsulation------------------
        /// <summary>
        /// This Method is used to A property is like a combination of a variable and a method, and it has two 
        /// methods: a get and a set method:
        /// </summary>
        private static void FindPerson()
        {
            //---- Create Object -------
            Person person = new Person();

            Console.WriteLine("Enter Name:");   // Using from user Input
            string name = Console.ReadLine();
            person.Name = name;
            Console.WriteLine("\nYour Name is: " + person.Name);

            //------- Direct Calling -------
            //Person.Name = "Aqib";
            //Console.WriteLine(Person.Name);

            //----This Method is used From User Input ------
            //Console.WriteLine("Enter Name:");
            //string name = Console.ReadLine();
            //Person.Name = name;
            //Console.WriteLine("Your Name is: " + Person.Name);
        }
        /// <summary>
        /// This Method is used to Automatic Properties (Short Hand).
        /// </summary>
        private static void FindShortHandPropertie()
        {
            Person2 person2 = new Person2();
            Console.WriteLine("Enter a Name:");
            string name2 = Console.ReadLine();
            person2.PName = name2;
            Console.WriteLine("Enter a Age:");
            int.TryParse(Console.ReadLine(), out int inputAge);
            person2.Age = inputAge;

            Console.WriteLine("Person Name is: " + name2);
            Console.WriteLine("Person Age is: " + inputAge);
        }
        /// <summary>
        /// This Method is used to read-only property.
        /// </summary>
        private static void FindCounter()
        {
            Emp emp = new Emp();
            Emp emp1 = new Emp();
            Emp emp2 = new Emp();
            Console.WriteLine("No. of Employee: "+ Emp.Counter);
        }
        /// <summary>
        /// This Method is used to find Collage how many year old.! 
        /// </summary>
        private static void FindCollageDetails()
        {
            Collage collage = new Collage();
            Console.WriteLine("Enter Collage Name:");
            string cName = Console.ReadLine();
            collage.Name = cName;
            Console.WriteLine("Enter Collage Year:");
            int.TryParse(Console.ReadLine(), out int cYear);
            collage.yearOld = cYear;
            Console.WriteLine("Collage Name is " + cName + " and Collage is " + cYear + " years Old.");
        }
    }
    class Person
    {
        /// <summary>
        /// The Name property is associated with the name field. It is a good practice to use the same name 
        /// for both the property and the private field, but with an uppercase first letter.
        /// Now we can use the Name property to access and update the private field of the Person class:
        /// The get method returns the value of the variable name.The set method assigns a value to the name 
        /// variable.The value keyword represents the value we assign to the property.
        /// </summary>
        /// Non-Static 
        private string name;    // Feilds
        public string Name     // Properties
        {
            get { return name; }
            set { name = value; }
        }
        /// Static 
        //private static string name;    // Feilds
        //public static string Name     // Properties
        //{
        //    get { return name; }
        //    set { name = value; }
        //}
    }
    class Person2
    {
        public string PName { get; set; }      // Properties
        public int Age { get; set; }
    }
    class Emp
    {
        private static int counter;
        public Emp()
        {
            counter++;
        }
        public static int Counter
        {
            get
            {
                return counter;
            }
        }
    }
    class Collage
    {
        public string name;
        public int yearOld;

        public string Name  { get; set; }
        public int Year_Old { get; set; }
    }
}