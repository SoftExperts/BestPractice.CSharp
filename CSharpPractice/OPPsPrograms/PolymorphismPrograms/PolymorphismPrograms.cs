using System.Xml.Linq;

namespace CSharpPractice.OPPsPrograms
{
    public static class PolymorphismPrograms
    {
        /// <summary>
        /// Constructor And Properties Programs Contents
        /// </summary>
        public static void PolymorphismProgramsContents()
        {
            bool loopSkipOrContinue = false;
            do
            {
                Console.WriteLine("Please Enter 1 and get the Animals Sounds are same same.");
                Console.WriteLine("Please Enter 2 and get the Animals sounds method override.");
                Console.WriteLine("Please Enter 'N' to Skip the Program");

                string userInput = Console.ReadLine();
                bool basicPrograms = int.TryParse(userInput, out int programInputResult);

                if (basicPrograms)
                {
                    switch (programInputResult)
                    {
                        case 1:
                            FindAnimalSound();
                            Console.WriteLine("Do you Want to continue the Basic OOPs Programs? Please Enter Y or N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 2:
                            FindAnimalOverride();
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
        //-------------- Polymorphism Programs ----------------
        /// <summary>
        /// This Method is used to Polymorphism means "many forms", and it occurs when we have many classes 
        /// that are related to each other by inheritance.
        ///The output from the example above was probably not what you expected.That is because the base class 
        ///method overrides the derived class method, when they share the same name.
        /// 
        /// </summary>
        private static void FindAnimalSound()
        {
            //---- Not The Output I Was Looking For 
            Animals.animalSound();
            Animals.animalSound();
            Animals animals = new Animals();
            Animals myCat = new Cats();
            Animals myDog = new Dogs();
            Animals myWolf = new Wolf();              
        }
        /// <summary>
        /// However, C# provides an option to override the base class method, by adding the virtual keyword to the 
        /// method inside the base class, and by using the override keyword for each derived class methods:
        /// </summary>
        private static void FindAnimalOverride()
        {
            Animal1 ani= new Animal1();
            Animal1 myCat = new Cat1();
            Animal1 myDog = new Dog1();

            ani.animalSound();
            myCat.animalSound();
            myDog.animalSound();
        }
    }
    class Animals
    {
        public static void animalSound()
        {
            Console.WriteLine("The animal makes a sounds!");
        }
    }
    class Cats : Animals
    {
        public static void animalSound()
        {
            Console.WriteLine("The cat says: mew mew");
        }
    }
    class Dogs : Animals
    {
        public static void animalSound()
        {
            Console.WriteLine("The dog says: Barking..");
        }
    }
    class Wolf : Animals
    {
        public static void animalSound()
        {
            Console.WriteLine("The Wolf says: Wwoooo");
        }
    }
    /// <summary>
    /// However, C# provides an option to override the base class method, by adding the virtual keyword to the 
    /// method inside the base class, and by using the override keyword for each derived class methods:
    /// </summary>
    class Animal1  // Base class (parent) 
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Cat1 : Animal1  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The Cat says: mew mew");
        }
    }

    class Dog1 : Animal1  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }
}