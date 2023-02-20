namespace CSharpPractice.OPPsPrograms
{
    public static class PolymorphismPrograms
    {
        /// <summary>
        /// Polymorphism Programs Contents
        /// </summary>
        public static void PolymorphismProgramsContents()
        {
            bool loopSkipOrContinue = false;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("-------------------- Method Overriding -----------------");
                Console.WriteLine("Please Enter 1 and get the Animals Sounds are same same.");
                Console.WriteLine("Please Enter 2 and get the Animals sounds method override.");
                Console.WriteLine("-------------------- Method Overloading ---------------");
                Console.WriteLine("Please Enter 3 and get the changing number of arguments");
                Console.WriteLine("Please Enter 4 and get the changing number of arguments from user Inputs.");
                Console.WriteLine("------------------- Base Method ------------");
                Console.WriteLine("Please Enter 5 and get the access fields, constructors and methods of base class.");
                Console.WriteLine("Please Enter 6 and get the calling base class method");
                Console.WriteLine("------------------ Polymorphism ------------");
                Console.WriteLine("Please Enter 7 and get the Run Time Polymorphism");
                Console.WriteLine("Please Enter 8 and get the another example of runtime polymorphism in C# where we are having two derived classes.");
                Console.WriteLine("Please Enter 9 and get the Runtime Polymorphism with Data Members");
                Console.WriteLine("------------------ Polymorphism in Sealed ------------");
                Console.WriteLine("Please Enter 10 and get the Sealed Class.");
                Console.WriteLine("Please Enter 11 and get the Sealed Method.!");
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
                        case 3:
                            FindSumResults();
                            Console.WriteLine("Do you Want to Continue the Basic OOPs Program! Please Enter Y or N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 4:
                            FindAddition2();
                            Console.WriteLine("Do you Want to Continue the Basic OOPs Program! Please Enter Y or N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 5:
                            FindBaseClassField();
                            Console.WriteLine("Do you Want to Continue the Basic OOPs Program! Please Enter Y or N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 6:
                            FindBaseClassMethod();
                            Console.WriteLine("Do you Want to Continue the Basic OOPs Program! Please Enter Y or N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 7:
                            FindRunTime();
                            Console.WriteLine("Do you Want to Continue the Basic OOPs Program! Please Enter Y or N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 8:
                            FindRunTime2();
                            Console.WriteLine("Do you Want to Continue the Basic OOPs Program! Please Enter Y or N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 9:
                            FindWithDataMember();
                            Console.WriteLine("Do you Want to Continue the Basic OOPs Program! Please Enter Y or N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 10:
                            FindSealedClass();
                            Console.WriteLine("Do you Want to Continue the Basic OOPs Program! Please Enter Y or N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 11:
                            FindSealedMethod();
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
        /// //-------------- Polymorphism Programs ----------------
        /// This Method is used to find the Run time polymorphism.
        #region
        private static void FindRunTime()
        {
            Bird b = new Crow();
            b.eat();
        }
        #endregion
        /// <summary>
        /// This Method is used to another example of runtime polymorphism in C# where we are having two derived classes.
        /// </summary>
        #region
        private static void FindRunTime2()
        {
            Shape s;
            s = new Shape();
            s.draw();
            s = new Triangle();
            s.draw();
            s = new Circle();
            s.draw();
        }
        #endregion
        /// <summary>
        /// This Method is used to find the Runtime Polymorphism with Data Members.
        /// </summary>
        #region
        private static void FindWithDataMember()
        {
            Person11 p = new Men();
            Console.WriteLine(p.color11);
        }
        #endregion
        /// <summary>
        /// This Method is used to Polymorphism means "many forms", and it occurs when we have many classes 
        /// that are related to each other by inheritance.
        ///The output from the example above was probably not what you expected.That is because the base class 
        ///method overrides the derived class method, when they share the same name.
        /// 1.Method Overriding
        /// 2.Method Overloading
        /// </summary>------------------------------- Method Overriding -----------------------------------
        #region
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
        #endregion
        /// <summary>
        /// However, C# provides an option to override the base class method, by adding the virtual keyword to the 
        /// method inside the base class, and by using the override keyword for each derived class methods:
        /// </summary>
        private static void FindAnimalOverride()
        {
            Animal1 ani = new Animal1();
            Animal1 myCat = new Cat1();
            Animal1 myDog = new Dog1();

            ani.animalSound();
            myCat.animalSound();
            myDog.animalSound();
        }
        /// <summary>--------------------------------- Method Overloading -------------------------------------
        /// This Method is used to find Having two or more methods with same name but different in parameters, is 
        /// known as method overloading in C#.
        /// 
        /// And this method is By changing number of arguments.
        /// </summary>
        #region
        private static void FindSumResults()
        {
            ////Console.WriteLine(Addition.add(10,20));
            ////Console.WriteLine(Addition.add(10, 20,30));
            Console.WriteLine("Enter first number:");
            int.TryParse(Console.ReadLine(), out int fnum);
            Console.WriteLine("Enter second number:");
            int.TryParse(Console.ReadLine(), out int secnum);
            Console.WriteLine("Enter third number:");
            int.TryParse(Console.ReadLine(), out int thnum);
            Console.WriteLine("------------------------------");
            Console.WriteLine("The Sum of Two Integers: " + Addition.add(fnum, secnum));
            Console.WriteLine("The Sum of Three Integers: " + Addition.add(fnum, secnum, thnum));

        }
        #endregion
        #region
        private static void FindAddition2()
        {
            Addtion2 addtion = new Addtion2();
            Console.WriteLine("Enter 1 to add two integers");
            Console.WriteLine("Enter 2 to add two doubles");
            Console.WriteLine("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Enter two integers to add: ");
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine("The sum is: " + Addtion2.Add(x, y));
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter two doubles to add: ");
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                Console.WriteLine("The sum is: " + Addtion2.Add(x, y));
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }
        #endregion
        /// <summary>
        /// This Method is In C#, base keyword is used to access fields, constructors and methods of base class.
        /// --------- Note: ---------------
        /// You can use base keyword within instance method, constructor or instance property accessor only. 
        /// You can't use it inside the static method.
        /// </summary>--------------- Base Method ----------------        
        #region
        private static void FindBaseClassField()
        {
            //------- accessing base class field -------
            DogColor dog = new DogColor();
            dog.showColor();
        }
        /// <summary>
        /// Thid Method is used to calling base class method.
        /// </summary>
        private static void FindBaseClassMethod()
        {
            DogEat eat1 = new DogEat();
            eat1.eat();
        }
        #endregion

        /// <summary> ----------------------- C# Sealed ---------------
        /// This Method is used to sealed keyword applies restrictions on the class and method. If you create 
        /// a sealed class, it cannot be derived. If you create a sealed method, it cannot be overridden.
        /// 
        /// Note: Structs are implicitly sealed therefore they can't be inherited.
        /// </summary> 
        #region --------------- Sealed Class ------------
        private static void FindSealedClass()
        {
            Duck d = new Duck();
            //d.fly();
            d.run();
        }
        #endregion
        /// <summary>
        /// This Method is used to find the sealed method in C# cannot be overridden further. It must be used 
        /// with override keyword in method.
        /// </summary>
        #region ------------ Sealed Method ---------------
        private static void FindSealedMethod()
        {
            BabyBird baby = new BabyBird();
            baby.fly();
            baby.run();
        }
        #endregion
        /// <summary>
        /// This Method is used to find Local variables. Note: Local Variables can't be sealed.
        /// </summary>

        //sealed int x = 10;    // Compile Time Error: Invalid expression term 'sealed'
        //x++;
        //Console.WriteLine(x); 
    }

    //----------------------------------------- Creating Classes ---------------------------
    //----------------------------------------- Method Overriding ------------------------------------
    // -- Polymorphism Methods --
    #region
    public class Bird
    {
        public virtual void eat()
        {
            Console.WriteLine("Eating...!");
        }
    }
    public class Crow : Bird
    {
        public override void eat()
        {
            Console.WriteLine("Eating Bread...!");
        }
    }
#endregion
    // Another Example With Two Drived Class
    #region
    public class Shape
    {
        public virtual void draw()
        {
            Console.WriteLine("Drawing..!");
        }
    }
    public class Triangle : Shape 
    {
        public override void draw()
        {
            Console.WriteLine("Triangle Draw..!");
        }
    }
    public class Circle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Circle Draw..!");
        }
    }
    #endregion
    // Runtime Polymorphism with Data Members
    #region
    public class Person11
    {
        public string color11 = "White";
    }
    public class Men : Person11
    {
        public string color11 = "Black";
    }
    #endregion
    #region
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
    #endregion
    //----------------------------------------------- Part of Method Overriding --------------------------------------
    /// <summary>
    /// However, C# provides an option to override the base class method, by adding the virtual keyword to the 
    /// method inside the base class, and by using the override keyword for each derived class methods:
    /// </summary>
    #region
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
    #endregion
    //--------------------------------------------------- Part of Method Overloading -------------------------------------
    #region
    class Addition
    {
        public static int add(int fnum, int snum)
        {
            return fnum + snum;
        }
        public static int add(int fnum, int snum, int tnum)
        {
            return fnum + snum + tnum;
        }
    }
    #endregion
    #region
    class Addtion2
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static double Add(double x, double y)
        {
            return x + y;
        }
    }
    #endregion
    //------------------------ Base Method ------------------------------
    //------ accessing base class field -------
    #region
    public class AnimalColor
    {
        public string animalColor = "white"; // field
    }
    public class DogColor : AnimalColor
    {
        public  string animalColor = "black";
        public void showColor()
        {
            Console.WriteLine(base.animalColor);    // using base keyword
            Console.WriteLine(animalColor);
        }
    }
    #endregion
    //------------------ calling base class method ---------------
    #region
    public class AnimalEat
    {
        public virtual void eat()
        {
            Console.WriteLine("eating..");
        }
    }
    public class DogEat : AnimalEat
    {
        public override void eat()
        {
            base.eat();
            Console.WriteLine("Animal Eating...");
        }
    }
    #endregion
    //------------------ Sealed Class -----------------
    // --- sealed class cannot be derived by any class ---
    #region
    //sealed public class Birds
    //{
    //    public void fly()
    //    {
    //        Console.WriteLine("flying..!");
    //    }
    //}
    //public class Duck : Birds   // sealed class cannot be derived by any class. Error
    //{
    //    public void run()
    //    {
    //        Console.WriteLine("running...");
    //    }
    //}
    #endregion
    //-------------- example of sealed method -------------

    #region
    public class Bird1
    {
        public virtual void fly() { Console.WriteLine("eating..."); }
        public virtual void run() { Console.WriteLine("running..."); }

    }
    public class Duck : Bird1
    {
        public override void fly() { Console.WriteLine("eating bread..."); }
        public sealed override void run()
        {
            Console.WriteLine("running very fast...");
        }
    }
    public class BabyBird : Bird1
    {
        public override void fly() { Console.WriteLine("eating biscuits..."); }
        public override void run() { Console.WriteLine("running slowly..."); }
    }
    #endregion    
}