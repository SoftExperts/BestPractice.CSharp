using System.Reflection;
using System.Security.Cryptography;

namespace CSharpPractice.BasicsPrograms
{
    public static class PointersPrograms
    {
        /// <summary>
        /// Function Programs Content
        /// </summary>
        public static void PointersProgramsContent()
        {
            bool loopSkipOrContinue = false;
            do
            {
                Console.WriteLine("Please Enter 1 and get the value of address using pointer.");
                Console.WriteLine("Please Enter 2 and get the value and address.");
                Console.WriteLine("Pleae Enter 3 and get the any type of variables..");
                Console.WriteLine("Please Enter 4 and get sum of two numbers..");
                Console.WriteLine("Please Enter 5 and get the Pointer Initialization..");
                Console.WriteLine("Please Enter 6 and get the accessing array.");
                Console.WriteLine("Please Enter 7 and get the Arithmetic two numbers and operator and get results.");
                Console.WriteLine("Please Enter 8 and get the swapping two numbers.");
                Console.WriteLine("Please Enter 9 and get the returns student grade.");
                Console.WriteLine("Please Enter 10 and get the area of triangle.");
                Console.WriteLine("Please Enter 11 and get the first integer return its square. It second integer return its cube and then adds both returned values result.");
                Console.WriteLine("Please Enter 'N' to Skip the Program");
                string userInput = Console.ReadLine();
                bool basicPrograms = int.TryParse(userInput, out int programInputResult);

                if (basicPrograms)
                {
                    switch (programInputResult)
                    {
                        case 1:
                            FindNumberOfAddress();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 2:
                            FindValueAndAddress();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 3:
                            FindAnyTypeOfVariable();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 4:
                            FindNumbersOfSum();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 5:
                            FindInitializeVar();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 6:
                            AccessingArrayValues();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        //case 7:
                        //    FindArithmeticOperation();
                        //    Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                        //    FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                        //    break;
                        //case 8:
                        //    FindSwapping();
                        //    Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                        //    FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                        //    break;
                        //case 9:
                        //    FindGrade();
                        //    Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                        //    FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                        //    break;
                        //case 10:
                        //    FindArea();
                        //    Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                        //    FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                        //    break;
                        //case 11:
                        //    FindSquareNumber();
                        //    Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
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
            } while (loopSkipOrContinue);
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

        //---------------- All Pointers Programs -------------------

        /// <summary>
        /// This Method is used to find the value of address using pointer.
        /// </summary>
        private static void FindNumberOfAddress()
        {
            unsafe
            {
                int* pntr;
                int x = 100;
                pntr = &x;

                Console.WriteLine("The value of n: " + x);
                Console.WriteLine("The address of n: " + (int)pntr);
            }
        }

        /// <summary>
        /// This Method is used to find the value and address.
        /// </summary>
        private static void FindValueAndAddress()
        {
            unsafe
            {
                int n;
                int* ptr;
                Console.WriteLine("Enter an integer:");
                int.TryParse(Console.ReadLine(), out int userInput);
                n = userInput;
                ptr = &n;
                Console.WriteLine("The value of n: " + n);
                Console.WriteLine("The address of n: " + (int)ptr);
            }
        }

        /// <summary>
        /// This Method is used to find any type of variables.
        /// </summary>
        private static void FindAnyTypeOfVariable()
        {
            unsafe
            {
                int n = 10;
                float f = 23.32f;
                char a = '$';
                void *ptr;
                ptr = &n;
                Console.WriteLine("The value of n: " + n);
                Console.WriteLine("The address of n: " + (int)ptr);
                ptr = &f;
                Console.WriteLine("The value of f: " + f);
                Console.WriteLine("The address of f: " + (int)ptr);
                ptr = &a;
                Console.WriteLine("The value of a: " + a);
                Console.WriteLine("The value of a: " + (int)ptr);
            }
        }
        //------ Dereference Operator ----------
        /// <summary>
        /// This Method is used to find the sum of two numbers.
        /// </summary>
        private static void FindNumbersOfSum()
        {
            unsafe
            {
                int a, b, sum;
                int* p1;
                int *p2;
                p1 = &a;
                p2= &b;
                Console.WriteLine("Enter an integer: ");
                int.TryParse(Console.ReadLine(), out int userInput);
                *p1 = userInput;
                Console.WriteLine("Enter an integer: ");
                int.TryParse(Console.ReadLine(), out int userInput2);
                *p2 = userInput2;

                sum = *p1 + *p2;
                Console.WriteLine(*p1 + " + " + *p2 + " = " + sum);
            }
        }
        /// <summary>
        /// This Method is used to find the Pointer Initialization.
        /// </summary>
        private static void FindInitializeVar()
        {
            unsafe
            {
                int a;
                int *ptr = &a;
                Console.WriteLine("Enter an integer:");
                int.TryParse(Console.ReadLine(), out int userInput);
                *ptr = userInput;
                Console.WriteLine("You entered: " + *ptr);
            }
        }
        //------ Pointers and Arrays ---------
        /// <summary>
        /// This Method is used to find the accessing array.
        /// </summary>
        private static void AccessingArrayValues()
        {
            unsafe
            {
                //int i =0, a;
                //int[] marks = new int[4];
                //int* ptr = &a;

                //Console.WriteLine("Enter four subjects marks:");
                //for(i = 0; i < 4; i++)
                //int.TryParse(Console.ReadLine(), out int userInputMarks);
                //marks[i] = userInputMarks;
                //*ptr = marks[i];
                //    Console.WriteLine("You entered the following values:");
                //for(i= 0; i<4; i++)
                //    Console.WriteLine(*ptr++);

                Console.WriteLine("Enter the size of the array:");
                int size = int.Parse(Console.ReadLine());

                int[] numbers = new int[size];

                Console.WriteLine("Enter the elements of the array:");
                for (int i = 0; i < size; i++)
                {
                    numbers[i] = int.Parse(Console.ReadLine());
                }

                fixed (int* p = numbers)
                {
                    for (int i = 0; i < size; i++)
                    {
                        Console.WriteLine("Element at index {0} is: {1}", i, p[i]);
                    }
                }

            }
        }
    }
}
