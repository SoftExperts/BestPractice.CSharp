using System.Drawing;

namespace CSharpPractice.OPPsPrograms
{
    public static class EnumerationPrograms
    {
        /// <summary>
        /// Enumeration Programs Contents
        /// </summary>
        public static void EnumerationProgramsContents()
        {
            bool loopSkipOrContinue = false;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("-------------------- Enum -----------------");
                Console.WriteLine("Please Enter 1 and get the working of Enumeration function.");
                Console.WriteLine("Please Enter 2 and get the enum example changing start index");
                Console.WriteLine("Please Enter 3 and get the traversing all values using getNames.");
                Console.WriteLine("Please Enter 4 and get the traversing all values using getValues.");
                Console.WriteLine("Please Enter 'N' to Skip the Program");
                string userInput = Console.ReadLine();
                bool basicPrograms = int.TryParse(userInput, out int programInputResult);

                if (basicPrograms)
                {
                    switch (programInputResult)
                    {
                        case 1:
                            FindEnumeration();
                            Console.WriteLine("Do you Want to continue the Basic OOPs Programs? Please Enter Y or N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 2:
                            FindWeeken();
                            Console.WriteLine("Do you Want to continue the Basic OOPs Programs? Please Enter Y or N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 3:
                            FindDays();
                            Console.WriteLine("Do you Want to continue the Basic OOPs Programs? Please Enter Y or N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 4:
                            FindDaysByGetValues();
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
        /// This Method is used to find Enum constants has default values which starts from 0 and incremented to one by one.
        /// </summary>
        public static void FindEnumeration()
        {
            int x = (int)EnumExample.Season.Winter;
            int y = (int)EnumExample.Season.Fall;
            Console.WriteLine("Winter = " + x);
            Console.WriteLine("Summer = " + y);
        }
        /// <summary>
        /// This Method is used to find  enum example changing start index.
        /// </summary>
        public static void FindWeeken()
        {
            int a = (int)EnumChange.Week.Sun;
            int b = (int)EnumChange.Week.Friday;
            Console.WriteLine("Sun = " + a);
            Console.WriteLine("Friday = " + b);
        }
        /// <summary>
        /// This Method is used to find traversing all values using getNames()
        /// </summary>
        public static void FindDays()
        {
            foreach (string name in Enum.GetNames(typeof(EnumDays)))
            {
                Console.WriteLine(name);
            }
        }
        /// <summary>
        /// This Method is used to find traversing all values using getValues().
        /// </summary>
        public static void FindDaysByGetValues()
        {
            foreach (var value in Enum.GetValues(typeof(EnumColor)))
            {
                Console.WriteLine(value);
            }
        }
    }
    public class EnumExample
    {
        public enum Season { Winter, Spring, Summer, Fall }
    }
    //-----------------------------------------------------------------------------------------------
    class EnumChange
    {
        public enum Week { Sun = 3, Mon, Tuesday, Wednesday, Friday }
    }
    //-----------------------------------------------------------------------------------------------
    enum EnumDays
    {
        Sun, 
        Monday,
        Tuesday, 
        Wednesday, 
        Thursday, 
        Friday, 
        Saturday 

    }
    enum EnumColor
    {
        Red,
        Green,
        Blue,
        Yellow
    }

}