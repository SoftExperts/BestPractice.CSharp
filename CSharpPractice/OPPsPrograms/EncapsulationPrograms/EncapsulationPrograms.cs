using System.Runtime.CompilerServices;

namespace CSharpPractice.OPPsPrograms
{
    public static class EncapsulationPrograms
    {
        /// <summary>
        /// Encapsulation Programs Contents
        /// </summary>
        public static void EncapsulationProgramsContents()
        {
            bool loopSkipOrContinue = false;
            do
            {
                Console.WriteLine("-------------------- Encapsulation -----------------");
                Console.WriteLine("Please Enter 1 and get the working Encapsulation.");
                Console.WriteLine("Please Enter 'N' to Skip the Program");
                string userInput = Console.ReadLine();
                bool basicPrograms = int.TryParse(userInput, out int programInputResult);

                if (basicPrograms)
                {
                    switch (programInputResult)
                    {
                        case 1:
                            FindStudentDetails();
                            Console.WriteLine("Do you Want to continue the Basic OOPs Programs? Please Enter Y or N");
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
        /// <summary>
        /// This Method is used to A fully encapsulated class has getter and setter functions that are used to read 
        /// and write data. This class does not allow data access directly.
        /// </summary>
        private static void FindStudentDetails()
        {            
            Console.WriteLine("Enter Student Id!");
            int.TryParse(Console.ReadLine(), out int userId);

            Console.WriteLine("Enter Student Name:");
            string userName = Console.ReadLine();

            Console.WriteLine("Enter Student Year:");
            int.TryParse(Console.ReadLine(), out int userYear);

            StudentData std = new StudentData(userId, userName, userYear);
            Console.WriteLine("Student Id is: " + std.Id);
            Console.WriteLine("Student Name is: " + std.Name);
            Console.WriteLine("Studen Year is: " + std.Year);
        }
    }
    class StudentData
    {
        private int id;
        private string name;
        private int year;

        public StudentData(int id, string name, int year)
        {
            this.id = id;
            this.name = name;
            this.year = year;
        }
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Name
        { 
            get { return this.name; }
            set { this.name = value; } 
        }
        public int Year
        {
            get { return this.year; }
            set { this.year = value;}
        }
    }
}