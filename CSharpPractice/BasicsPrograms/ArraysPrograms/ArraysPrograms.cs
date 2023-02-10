namespace CSharpPractice.BasicsPrograms
{
    public static class ArraysPrograms
    {
        /// <summary>
        /// Content of Array Programming
        /// </summary>
        public static void ArraysProgramsContent()
        {
            bool loopSkipOrContinue = false;
            do
            {
                Console.WriteLine("Please Enter 1 and to see the program of all values in the arrays.");
                Console.WriteLine("Please Enter 2 and to see the program of all values using for loop.");
                Console.WriteLine("Please Enter 3 and to see the program of sum and average of these values.");
                Console.WriteLine("Please Enter 4 and to see the program of finding maximum number.");
                Console.WriteLine("Please Enter 5 and to see the program of sum finding minimum number.");
                Console.WriteLine("Please Enter 6 and to see the program of Actual order and Reverce order.");
                Console.WriteLine("Please Enter 7 and to see the program of searches the numbers in the array");
                Console.WriteLine("Please Enter 8 and to see the program of sorting array in ascending order.");
                Console.WriteLine("Please Enter 9 and to see the program of Two dimensional array of 2 rows and 3 column.");
                Console.WriteLine("Please Enter 'N' to Skip the Program");
                string? userInput = Console.ReadLine();

                bool basicPrograms = int.TryParse(userInput, out int programInputResult);

                if (basicPrograms)
                {
                    switch (programInputResult)
                    {
                        case 1:
                            FindAllValues();
                            Console.WriteLine("If you want to Continue Loops Program? Press Y for yes or Press N for skip");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 2:
                            FindAllValuesUsingLoop();
                            Console.WriteLine("If you Want to Continue Loops Program? PPress Y for yes or Press N for skip");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 3:
                            FindSumAndAverage();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y for yes or Press N for skip");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 4:
                            FindMaxValues();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y for yes or Press N for skip");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 5:
                            FindMiniValue();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y for yes or Press N for skip");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 6:
                            FindActualAndReverce();
                            Console.WriteLine("\nIf you Want to Continue Loops Program? Press Y for yes or Press N for skip");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 7:
                            FindSearchesNumbers();
                            Console.WriteLine("\nIf you Want to Continue Loops Program? Press Y for yes or Press N for skip");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 8:
                            FindSortingNumbers();
                            Console.WriteLine("\nIf you Want to Continue Loops Program? Press Y for yes or Press N for skip");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 9:
                            FindTwoDArray();
                            Console.WriteLine("\nIf you Want to Continue Loops Program? Press Y for yes or Press N for skip");
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

        //---------------- All Arrays Programs -----------------
        /// <summary>
        /// This Method is used displays all values from user inputs.
        /// </summary>
        private static void FindAllValues()
        {
            int[] numbers = new int[3];
            Console.WriteLine("Enter Firts integers :");
            int.TryParse(Console.ReadLine(), out int firstValue);
            Console.WriteLine("Enter Second integers :");
            int.TryParse(Console.ReadLine(), out int secondValue);
            Console.WriteLine("Enter Third integers :");
            int.TryParse(Console.ReadLine(), out int thirdValue); 

            Console.WriteLine("The Values in arrays are: ");
            Console.WriteLine(firstValue);
            Console.WriteLine(secondValue);
            Console.WriteLine(thirdValue);
        }

        /// <summary>
        /// This method is used to display all values using for loop.
        /// </summary>
        private static void FindAllValuesUsingLoop()
        {
            int[] numbers = new int[3];
            for(int i = 0; i < 3; i++)      // 0 < 3 true , 1 < 3 true, 2 < 3 true, 3 < 3 false
            {
                Console.WriteLine("Enter an interger: ");   
                numbers[i] = int.Parse(Console.ReadLine()); // 22, 33, 44
            }
            Console.WriteLine("The values in array are: ");
            for (int i = 0; i < numbers.Length; i++)    // 0 < 3 , 
            {
                Console.WriteLine(numbers[i]);  // 22, 
            }
        }

        /// <summary>
        /// This method is used to display the sum and average of these values.
        /// </summary>
        private static void FindSumAndAverage()
        {
            // Declare an array of size 5
            int[] numbers = new int[5];

            // Take input of 5 integers from the user
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter an integer: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // Calculate the sum of the elements in the array
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }

            // Calculate the average of the elements in the array
            float average = sum / numbers.Length;

            // Print the sum and average to the console
            Console.WriteLine("The sum of the integers is: " + sum);
            Console.WriteLine("The average of the integers is: " + average);
        }

        /// <summary>
        /// This Method is used to find and display the maximum number.
        /// </summary>
        private static void FindMaxValues()
        {
            int[] numbers = new int[5];
            int max;
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter Value:");
                int.TryParse(Console.ReadLine(), out int userInput);
                numbers[i] = userInput;
            }
            max = numbers.Length;
            for(int i = 0; i < 5; i++)
                if(max < numbers[i])
                    max = numbers[i];
            Console.WriteLine("Maximum Value: " + max);
        }

        /// <summary>
        /// This Method is used to find and display the minimum number.
        /// </summary>
        private static void FindMiniValue()
        {
            int[] numbers = new int[5];
            int mini;
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter Value: ");
                int.TryParse(Console.ReadLine(), out int userInput);
                numbers[i] = userInput;
            }
            mini = numbers.Length;
            for(int i = 0; i < numbers.Length; i++)
            
                if(mini > numbers[i])
                    mini = numbers[i];
                Console.WriteLine("Minimum Value: " + mini);            
        }

        /// <summary>
        /// This method is used to display Actual order and Reverce order.
        /// </summary>
        private static void FindActualAndReverce()
        {
            int[] numbers = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter Value: ");
                int.TryParse(Console.ReadLine(), out int userInput);
                numbers[i] = userInput;
            }
            Console.WriteLine("The array in atual order: ");
            for(int i = 0; i < 5; i++)            
                Console.Write(numbers[i] + " " );
                Console.WriteLine("\nThe array in reverce order: ");

                for(int i = 4; i>=0; i--)                
            Console.Write(numbers[i] + " ");                
        }

        /// <summary>
        /// This Method is used to find and display searches the number in the array.
        /// </summary>
        private static void FindSearchesNumbers()
        {
            int[] numbers = { 10,21,20,30,40,50,60,70,80,90 };
            int i, loc = -1;
            Console.WriteLine("Enter value to find: ");
            int.TryParse(Console.ReadLine(), out int userInputNumber);
            
            for(i = 0; i < 10; i++)
                if (numbers[i] == userInputNumber)
                    loc= i;
            if (loc == -1)
                Console.WriteLine("Value not found in the array.");
            else
                Console.WriteLine("Value found at index " + loc);
        }

        /// <summary>
        /// This method is used to display sorts array in ascending order.
        /// </summary>
        private static void FindSortingNumbers()
        {
            int[] numbers = new int[5];
            int i, j, min, temp;
            for(i= 0; i < 5; i++)
            {
                Console.WriteLine("Enter value: ");
                int.TryParse(Console.ReadLine(), out int userInput);
                numbers[i] = userInput;
            }
            Console.WriteLine("The original values in array: ");
            for(i= 0; i < 5; i++)
                Console.Write(numbers[i] + " ");

            for(i = 0; i < 4; i++)
            {
                min = i;
                for (j = i + 1; j < 5; j++)
                    if (numbers[j] < numbers[min])
                        min = j;
                if(min != i)
                {
                    temp = numbers[i];
                    numbers[i] = numbers[min];
                    numbers[min] = temp;
                }
            }
            Console.WriteLine("\nThe Sorted array:");
            for(i = 0; i < 5; i++)
                Console.Write(numbers[i] + " ");

        }

        /// <summary>
        /// This Method is used to find two dimensional array of 2 rows and 3 columns and then displays its values.
        /// </summary>
        private static void FindTwoDArray()
        {
            int[,] numbers = new int[2, 3] { { 1, 2,3 }, { 12, 32, 43 } };
            //int[,] matrix = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };

            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 3; j++)
                    Console.Write(numbers[i,j] + "\t");
                Console.WriteLine();
            }
        }
    }
}
