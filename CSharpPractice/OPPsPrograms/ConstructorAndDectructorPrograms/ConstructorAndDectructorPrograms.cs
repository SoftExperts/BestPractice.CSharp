namespace CSharpPractice.OPPsPrograms
{
    public static class ConstructorAndDectructorPrograms
    {
        /// <summary>
        /// Constructor And Dectructor Programs Contents
        /// </summary>
        public static void ConstructorAndDectructorProgramsContents()
        {
            bool loopSkipOrContinue = false;
            do
            {
                Console.WriteLine("Please Enter 1 and get the Static and Default constructors will invoke for first instance.");
                Console.WriteLine("Please Enter 2 and get the static Constructor.");
                Console.WriteLine("Please Enter 3 and get the Car Model.");
                Console.WriteLine("Please Enter 4 and get the Many Parameterized Constructor.");
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
                            Display();
                            Console.WriteLine("Do you Want to continue the Basic OOPs Programs? Please Enter Y or N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 2:
                            FindEmployeeData();
                            Console.WriteLine("Do you Want to Continue the Basic OOPs Program! Please Enter Y or N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 3:
                            FindParameterizedConstructor();
                            Console.WriteLine("Do you want to continue the Basic OOPs Program! Please Enter Y or N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 4:
                            FindCarData();
                            Console.WriteLine("Do you want to continue the Basic OOPs Program! Please Enter Y or N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 5:
                            FindStudentData();
                            Console.WriteLine("Do you want to continue the Basic OOPs Program! Please Enter Y or N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 6:                        
                            FindBooksData();
                            Console.WriteLine("Do you want to continue the Basic OOPs Program! Please Enter Y or N");
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
        //-----------------C# Default Constructors Programs ---------------------------
        /// <summary>
        /// This Method is used to Static and Default constructors will invoke for first instance
        /// </summary>
        private static void Display()
        {
            // Both Static and Default constructors will invoke for first instance
            User user = new User();
            // Only Default constructor will invoke
            User user1 = new User();
        }
        /// <summary>
        /// This method is used to find Static Constructor.
        /// </summary>
        private static void FindEmployeeData()
        {
            Employee.DisplayEmployeeDetails();
        }
        /// <summary>
        /// This Method is used to find Parameterized Constructor.
        /// </summary>
        private static void FindParameterizedConstructor()
        {
            Console.WriteLine("Enter Car Model:");
            string modelN = (Console.ReadLine());
            modelN = modelN;
            //new CarModel("Suzki");
            CarModel car = new CarModel(modelN);
            car.DisplayCarModel();
            
            
        }
        /// <summary>
        /// This Method is used to find as many parameters.
        /// </summary>
        private static void FindCarData()
        {
            Console.WriteLine("Enter Car Model:");
            int.TryParse(Console.ReadLine(), out int modelNo);
            modelNo = modelNo;
            Console.WriteLine("Enter Car Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Car Color:");
            string color = Console.ReadLine();
            CarDetails Mehraan = new CarDetails(modelNo, name, color);
            Mehraan.ShowCarDetails();
        }
        private static void FindStudentData()
        {
            Console.WriteLine("Enter Student Name:");
            string name = (Console.ReadLine());
            Console.WriteLine("Enter Student Age:");
            int.TryParse(Console.ReadLine(), out int age);
            age = age;
            Student Aqib = new Student(name, age);
            Aqib.DisplayStudent();
        }
        /// <summary>
        /// This Method is used to find the Destructor.
        /// Note: Destructor can't be public. We can't apply any modifier on destructors.
        /// </summary>
        private static void FindBooksData()
        {
            Console.WriteLine("Enter a Book Name:");
            string bname = (Console.ReadLine());
            Console.WriteLine("Enter Book Version");
            int.TryParse(Console.ReadLine(), out int version);
            version = version;
            Books CSharp = new Books(bname, version);
            CSharp.DisplayBook();            
        }
    }   
    class User
    {
        // Static Constructor
        static User()
        {
            Console.WriteLine("I am Static Constructor");
        }
        // Default Constructor
        public User()
        {
            Console.WriteLine("I am Default Constructor");
        }
    }
    /// <summary>
    /// This method is used to find Static Constructor.
    /// </summary>
    class Employee
    {
        public static int id;
        public static string name;
        public static float salary;
        static Employee()
        {
            Console.WriteLine("Enter Id:");
            int.TryParse(Console.ReadLine(), out int userInputId);
            id = userInputId;
            Console.WriteLine("Enter Employee Name:");
            string userName = (Console.ReadLine());
            name = userName;
            Console.WriteLine("Enter Employee Salary:");
            float.TryParse(Console.ReadLine(), out float userSalary);
            salary = userSalary;
        }
        public static void DisplayEmployeeDetails()
        {
            Console.WriteLine("--------- After entered Employee Details --------");
            Console.WriteLine("Employee Id is: " +id);
            Console.WriteLine("Employee Name is: " + name);
            Console.WriteLine("Employee Salary is: " + salary);
        }       
    }
    //-----------Parameterized Constructor.
    class CarModel
    {
        private string modelN;

        public CarModel(string modelN)
        {
            
            this.modelN = modelN;
        }
        public void DisplayCarModel()
        {
            Console.WriteLine("Your Car Model is: " + modelN);
        }
    }
    //---------- Many Parameters --------
    class CarDetails
    {
        public  int modelNo;
        public string name;
        public string color;

        public CarDetails(int modelNo, string name, string color)
        {
            this.modelNo= modelNo;
            this.name= name;
            this.color= color;
        }
        public void ShowCarDetails()
        {
            Console.WriteLine("Your Car Model No: " + modelNo);
            Console.WriteLine("Your Car Name: " + name);
            Console.WriteLine("Your Car Color: " + color);
        }
    }
    class Student
    {
        public string name;
        public int age;

        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void DisplayStudent()
        {
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Student Age: " + age);
        }
    }
    // ------------- Destructor ----------
    class Books
    {
        public string bname;
        public int version;

        public Books(string bname, int version)
        {
            this.bname = bname;
            this.version = version;
        }
        public void DisplayBook()
        {
            Console.WriteLine("---------------------------");
            //Console.WriteLine("Book Name: " + bname);
            Console.WriteLine("Book Version: " + version);
        }
        ~Books()
        {
            Console.WriteLine("Destructor Called for " + bname);    // remove the memory in memory location.
        }
    }

}