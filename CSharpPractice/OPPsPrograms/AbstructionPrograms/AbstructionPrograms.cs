namespace CSharpPractice.OPPsPrograms
{
    public static class AbstructionPrograms
    {
        /// <summary>
        /// Abstruction Programs Contents
        /// </summary>
        public static void AbstructionProgramsContents()
        {
            bool loopSkipOrContinue = false;
            do
            {
                Console.WriteLine("-------------------- Abstruct Method and Classes -----------------");
                Console.WriteLine("Please Enter 1 and get the working Abstruct Method.");
                Console.WriteLine("Please Enter 2 and get the working Abstruct Class in with method.");
                Console.WriteLine("------------------------- Interface --------------------");
                Console.WriteLine("Please Enter 3 and get the Interface working.");
                Console.WriteLine("Please Enter 4 and get the another Example Interface working.");
                Console.WriteLine("Please Enter 5 and get the Multiple Interface Classes work.");

                Console.WriteLine("Please Enter 'N' to Skip the Program");

                string userInput = Console.ReadLine();
                bool basicPrograms = int.TryParse(userInput, out int programInputResult);

                if (basicPrograms)
                {
                    switch (programInputResult)
                    {
                        case 1:
                            FindAbstructClass();
                            Console.WriteLine("Do you Want to continue the Basic OOPs Programs? Please Enter Y or N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 2:
                            FindClass();
                            Console.WriteLine("Do you Want to Continue the Basic OOPs Program! Please Enter Y or N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 3:
                            FindInterface();
                            Console.WriteLine("Do you Want to Continue the Basic OOPs Program! Please Enter Y or N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 4:
                            FindInterface2();
                            Console.WriteLine("Do you Want to Continue the Basic OOPs Program! Please Enter Y or N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 5:
                            FindMultiInterface();
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

        //----------------------- Abstruction Programs ------------------------------
        /// <summary>
        /// This Method is used to Abstract class: is a restricted class that cannot be used to create objects 
        /// (to access it, it must be inherited from another class).
        /// Abstract method: can only be used in an abstract class, and it does not have a body. The body is 
        /// provided by the derived class (inherited from).
        /// </summary>
        private static void FindAbstructClass()
        {
            Pakistan pak;
            pak = new Punjab();
            pak.draw();
            pak = new Sindh();
            pak.draw();
        }
        private static void FindClass()
        {
            Java j = new Java();
            j.CSharp();
            j.Cpp();
        }
        /// <summary>
        /// This Method is used An interface is a completely "abstract class", which can only contain abstract 
        /// methods and properties (with empty bodies):
        /// Note: Interfaces can contain properties and methods, but not fields.
        /// </summary>
        private static void FindInterface()
        {
            MyPunjab punjab = new MyPunjab();
            punjab.MyCountry();
        }
        private static void FindInterface2()
        {
            Books1 b;
            b = new CSharp();
            b.ReadingBooks();
            b = new Java1();
            b.ReadingBooks();
        }
        /// <summary>
        /// This Method is used to find Multiple Interface Classes.
        /// </summary>
        private static void FindMultiInterface()
        {
            DemoClass demo = new DemoClass();
            demo.myMethod();
            demo.myOtherMethod();
        }
    }
    //---------------------------------- Part of Creating Abstruction Classes --------------------------
    abstract class Pakistan
    {
        // Abstract method
        public abstract void draw();        
    }
    // Regular Method
    class Punjab : Pakistan     // Derived class (inherit from Animal)
    {
        public override void draw()
        {
            Console.WriteLine("Punjab here....!");
        }
    }
    // The body of animalSound() is provided here
    class Sindh : Pakistan
    { 
        public override void draw()
        {
            Console.WriteLine("Sindh here...!");
        } 
    }
    //---------------------------------------------------------------------------------
    // Abstract class
    abstract class Language
    {
        // Abstract method (does not have a body)
        public abstract void CSharp();
        // Regular method
        public void Cpp()
        {
            Console.WriteLine("C++ Class here...!");
        }
    }

    // Derived class (inherit from Animal)
    class Java : Language
    {
        public override void CSharp()
        {
            // The body of CSharp() is provided here
            Console.WriteLine("Java Class here...!");
        }
    }
    //------------------------------ Part of Creating Interface Classes --------------------------------
    // interface
    //interface Animal
    //{
    //    void animalSound(); // interface method (does not have a body)
    //    void run(); // interface method (does not have a body)
    //}
    interface Pakistan1
    {
        void MyCountry();       // interface method (does not have a body)
    }
    // MyPunjab "implements" the Pakistan1 interface
    class MyPunjab : Pakistan1
    {
        public void MyCountry()
        {
            // The body of MyCountry() is provided here
            Console.WriteLine("I Love Pakistan.!");
        }
    }
    //---------------------------------------------------------------------------------------------------
    interface Books1
    {
        void ReadingBooks();
    }
    class CSharp : Books1
    {
        public void ReadingBooks()
        {
            Console.WriteLine("CSharp Book here..");
        }
    }
    class Java1 : Books1
    {
        public void ReadingBooks()
        {
            Console.WriteLine("Java Book here..");
        }
    }
    //------------------------------------------- Multi Interface Classes -----------------------------
    interface FirstInterface
    {
        void myMethod(); // interface method
    }

    interface SecondInterface
    {
        void myOtherMethod(); // interface method
    }

    // Implement multiple interfaces
    class DemoClass : FirstInterface, SecondInterface   // To implement multiple interfaces, separate them with a comma:
    {
        public void myMethod()
        {
            Console.WriteLine("Some text..");
        }
        public void myOtherMethod()
        {
            Console.WriteLine("Some other text...");
        }
    }
}