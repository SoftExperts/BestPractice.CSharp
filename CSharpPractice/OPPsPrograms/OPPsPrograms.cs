using CSharpPractice.OPPsPrograms;

namespace CSharpPractice.BasicsPrograms

{
    public static class OPPsPrograms
    {
        /// <summary>
        /// Basic OOPs Programs Contents
        /// </summary>
        public static void OPPsProgramsContents()
        {
            bool loopSkipOrContinue = false;
            do
            {
                Console.WriteLine("Please Enter 1 to Display Basic OOPs Programs");
                Console.WriteLine("Please Enter 2 to Display Constructor And Dectructor Programs");
                //Console.WriteLine("Please Enter 3 to Display Looping Programs");
                //Console.WriteLine("Please Enter 4 to Display Arrays Programs");
                //Console.WriteLine("Please Enter 5 to Display Structrues Programs");
                //Console.WriteLine("Please Enter 6 to Display Functions Programs");
                //Console.WriteLine("Please Enter 7 to Display Pointers Programs");
                Console.WriteLine("Please Enter 'N' to Skip the Program");

                string userInput = Console.ReadLine();
                bool basicPrograms = int.TryParse(userInput, out int programInputResult);

                if (basicPrograms)
                {
                    switch (programInputResult)
                    {
                        case 1:
                            Console.WriteLine("-- Welcome to C# Basic OOPs Programs! --");
                            BasicOPPsPrograms.BasicOPPsProgramsContents();
                            Console.WriteLine("Do you wnat to countinue Basic Program Content? Press Y  or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;

                        case 2:
                            Console.WriteLine("-- Welcome to C# Constructor And Dectructor Programs! --");
                            ConstructorAndDectructorPrograms.ConstructorAndDectructorProgramsContents();
                            Console.WriteLine("Do you wnat to countinue Basic Program Content? Press Y  or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                            //case 3:
                            //    Console.WriteLine("--- Welcome to C# Looping Programs! ----");
                            //    LoopingPrograms.LoopingPrograms.LoopingProgramsContent();
                            //    Console.WriteLine("Do you wnat to countinue Basic Program Content? Press Y  or Skip Program Press N");
                            //    FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            //    break;
                            //case 4:
                            //    Console.WriteLine("--------- Welcome to C# Arrays Programs! ---------");
                            //    ArraysPrograms.ArraysProgramsContent();
                            //    Console.WriteLine("Do you wnat to countinue Basic Program Content? Press Y  or Skip Program Press N");
                            //    FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            //    break;
                            //case 5:
                            //    Console.WriteLine("--------- Welcome to C# Structure Programs! ---------");
                            //    StructuresPrograms.StructuresProgramsContent();
                            //    Console.WriteLine("Do you wnat to countinue Basic Program Content? Press Y  or Skip Program Press N");
                            //    FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            //    break;
                            //case 6:
                            //    Console.WriteLine("--------- Welcome to C# Function Programs! ---------");
                            //    FunctionPrograms.FunctionProgramsContent();
                            //    Console.WriteLine("Do you wnat to countinue Basic Program Content? Press Y  or Skip Program Press N");
                            //    FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            //    break;
                            //case 7:
                            //    Console.WriteLine("--------- Welcome to C# Pointers Programs! ---------");
                            //    PointersPrograms.PointersProgramsContent();
                            //    Console.WriteLine("Do you wnat to countinue Basic Program Content? Press Y  or Skip Program Press N");
                            //    FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            //    break;
                            //default:
                            //    Console.WriteLine("Please Enter 1-4!");
                            //    loopSkipOrContinue = true;
                            //    break;
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
    }
}