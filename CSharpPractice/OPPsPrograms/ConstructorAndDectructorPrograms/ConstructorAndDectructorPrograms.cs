using CSharpPractice.BasicsPrograms;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

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
            new CarModel("Suzki");
            CarModel.DisplayCarModel();
            
        }
        /// <summary>
        /// This Method is used to find as many parameters.
        /// </summary>
        private static void FindCarData()
        {
            new CarDetails(2932, "Mehraan", "White");
            CarDetails.ShowCarDetails();
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
        public static string modelN;

        public CarModel(string userModel)
        {
            //Console.WriteLine("Enter Car Model:");
            //string userInput = (Console.ReadLine());
            //userModel = userInput;
            modelN = userModel;
        }
        public static void DisplayCarModel()
        {
            Console.WriteLine("Your Car Model is: " + modelN);
        }
    }
    //---------- Many Parameters --------
    class CarDetails
    {
        public static int modelNo;
        public static string name;
        public static string color;

        public CarDetails(int carModel, string carName, string carColor)
        {
            modelNo= carModel;
            name= carName;
            color= carColor;
        }
        public static void ShowCarDetails()
        {
            Console.WriteLine("Your Car Model No: " + modelNo);
            Console.WriteLine("Your Car Name: " + name);
            Console.WriteLine("Your Car Color: " + color);
        }
    }
}