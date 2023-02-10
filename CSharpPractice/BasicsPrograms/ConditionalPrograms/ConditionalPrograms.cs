namespace CSharpPractice.BasicsPrograms
{
    public static class ConditionalPrograms
    {
        /// <summary>
        /// Conditional Programs Contents
        /// </summary>
        public static void ConditionalProgramsContents()
        {
            bool loopSkipOrContinue = false;
            do
            {
                Console.WriteLine("Please Enter 1 to see the program of Student Marks Calculation!");
                Console.WriteLine("Please Enter 2 to see the program of finding two numbers are Equal!");
                Console.WriteLine("Please Enter 3 to see the program of finding Second Number is Square of First!");
                Console.WriteLine("Please Enter 4 to see the program of Student Admission is granted or not!");
                Console.WriteLine("Please Enter 5 to see the program of Find Maximum Number!");
                Console.WriteLine("Please Enter 6 to see the program Number is Positive, Negative or 0!");
                Console.WriteLine("Please Enter 7 to see the program of finding Largest and Smallest Number!");
                Console.WriteLine("Pleasse Enter 8 to see the program Whether Number is Even or Odd!");
                Console.WriteLine("Please Enter 9 to see the program of year is leap or Not!");
                Console.WriteLine("Please Enter 10 to see the program of Salary Calculation on the base of Grade!");
                Console.WriteLine("Please Enter 11 to see the program Whether first Number is a multuple of second Number!");
                Console.WriteLine("Please Enter 12  to see the program of Student Result Calculation!");
                Console.WriteLine("Please Enter 13 to see the program of the Electricity Bill Calculation!");
                Console.WriteLine("Please Enter 14 to see the program of the Area of Circle Calculation!");
                Console.WriteLine("Please Enter 15 to see the program Numbers are Equal or Not!");
                Console.WriteLine("Pleae Enter 16  to see the program of Vowel Characters Usage!");
                Console.WriteLine("Please Enter 17 to see the program of Weeks Day!");
                Console.WriteLine("Please Enter 18 to see the program of Vowel Character in Switch Case!");
                Console.WriteLine("Please Enter 19 to see the program of Airthmetic Operations On Floating Numbers in Switch Case!");
                Console.WriteLine("Please Enter 20 to see the program of Health Club Menue!");
                Console.WriteLine("Please Enter 21 to see the program of Covert ASCII number to Character and vice versa Conversion!");
                Console.WriteLine("Please Enter 22 to see the program of GoTo Label Working!");
                Console.WriteLine("Please Enter 'N' to Skip the Program");
                string? userInput = Console.ReadLine();

                bool basicPrograms = int.TryParse(userInput, out int programInputResult);

                if (basicPrograms)
                {
                    switch (programInputResult)
                    {
                        case 1:
                            FindStudentMarksStatus();
                            Console.WriteLine("If you Want to Continue Conditional Program? Press Y for yes or Press N for skip");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 2:
                            FindTwoNumbersEquality();
                            Console.WriteLine("If you Want to Continue Conditional Program? Press Y for yes or Press N for skip");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 3:
                            FindSecondNumberSquare();
                            Console.WriteLine("If you Want to Continue Conditional Program? Press Y for yes or Press N for skip");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 4:
                            AdmissionGranted();
                            Console.WriteLine("If you want to Continue Conditional Program? Press Y for yes or Press N for skip");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 5:
                            FindMaximumNumber();
                            Console.WriteLine("If you want to Continue Conditional Program? Press Y for yes or Press N for skip");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 6:
                            FindingNumber();
                            Console.WriteLine("If you want to Continue Conditional Program? Press Y for yes or Press N for skip");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 7:
                            FindLargestAndSmallestNumbers();
                            Console.WriteLine("If you want to Continue Conditional Program? Press Y for yes or Press N for skip");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 8:
                            FindEvenOrOddNumber();
                            Console.WriteLine("If you want to Continue Conditional Program? Press Y for yes or Press N for skip");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 9:
                            FindLeapYears();
                            Console.WriteLine("If you want to Continue Conditional Program? Press Y for yes or Press N for skip");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 10:
                            FindEmployeeBonus();
                            Console.WriteLine("If you want to Continue Conditional Program? Press Y for yes or Press N for skip");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 11:
                            FindMultipleNumber();
                            Console.WriteLine("If you want to Continue Conditional Program? Press Y for yes or Press N for skip");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 12:
                            StudentFindTestResult();
                            Console.WriteLine("If you want to Continue Conditional Program? Press Y for yes or Press N for skip");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 13:
                            CalculateElectricityBill();
                            Console.WriteLine("If you want to Continue Conditional Program? Press Y for yes or Press N for skip");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 14:
                            CalculateArea();
                            Console.WriteLine("If you want to Continue Conditional Program? Press Y for yes or Press N for skip");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 15:
                            FindNumbersEqualOrNot();
                            Console.WriteLine("If you want to Continue Conditional Program? Press Y for yes or Press N for skip");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 16:
                            FindVowelOrNot();
                            Console.WriteLine("If you want to Continue Conditional Program? Press Y for yes or Press N for skip");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 17:
                            FindWeeksDay();
                            Console.WriteLine("If you want to Continue Conditional Program? Press Y for yes or Press N for skip");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 18:
                            FindVowelInSwitch();
                            Console.WriteLine("If you want to Continue Conditional Program? Press Y for yes or Press N for skip");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 19:
                            AirthmeticOperationsOnFloatingNumbers();
                            Console.WriteLine("If you want to Continue Conditional Program? Press Y for yes or Press N for skip");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 20:
                            HealthClub();
                            Console.WriteLine("If you want to Continue Conditional Program? Press Y for yes or Press N for skip");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 21:
                            FindASCII();
                            Console.WriteLine("If you want to Continue Conditional Program? Press Y for yes or Press N for skip");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 22:
                            GoToStatement();
                            Console.WriteLine("If you want to Continue Conditional Program? Press Y for yes or Press N for skip");
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
        //------------------- All Conditional Programs -----------

        /// <summary>
        /// This Method is Used to Perform IF_Else Statement.
        /// </summary>
        private static void FindStudentMarksStatus()
        {
            
            Console.WriteLine("Please Enter Your Marks");
            bool marks = int.TryParse(Console.ReadLine(), out int yourMarks);
            if(yourMarks>=40)
            {
                Console.WriteLine("Congratulations! You Have Passed");
            }
            else
            {
                Console.WriteLine("Please Try Again");
            }
        }
        
        /// <summary>
        /// This Method find the numbers Whether both are Equal.
        /// </summary>
        private static void FindTwoNumbersEquality()
        {
            Console.WriteLine("Enter first Number");
            int.TryParse(Console.ReadLine(), out int firstNumber);
            Console.WriteLine("Enter Second Number");
            int.TryParse(Console.ReadLine(), out int secondNumber);
            if(firstNumber == secondNumber)
            {
                Console.WriteLine("Both Numbers are Equal");
            }
            else
            {
                Console.WriteLine("Both Numbers are Not Equal");
            }
        }

        /// <summary>
        /// This Method is Used to get Two Numbers as inputs and Finds if Second Number is Square of First.
        /// </summary>
        private static void FindSecondNumberSquare()
        {
            Console.WriteLine("Enter First Number");
            int.TryParse(Console.ReadLine(), out int firstNumber);
            Console.WriteLine("Enter Second Number");
            int.TryParse(Console.ReadLine(), out int secondNumber);

            if(firstNumber * firstNumber == secondNumber)
            {
                Console.WriteLine("Seccussfully.! Second Number is Square of First Number");
            }
            else
            {
                Console.WriteLine("Try Again!!.. Please Enter Square Number of First Number ");
            }
        }

        /// <summary>
        /// This Mehtod is Used the Inputs of Three Subjects. If the Average of Marks is more than 80, 
        /// it Display Two Messages.
        /// "Your are above Standerd..!"
        /// "Admission Granted..!"
        /// </summary>
        private static void AdmissionGranted()
        {
            Console.WriteLine("Enter Marks of English Subject");
            int.TryParse(Console.ReadLine(), out int engSubject);
            Console.WriteLine("Enter Marks of Math Subject");
            int.TryParse(Console.ReadLine(), out int mathSubject);
            Console.WriteLine("Enter Marks of Computer Subject");
            int.TryParse(Console.ReadLine(), out int computerSubject);
            float average =(engSubject + mathSubject + computerSubject)/3;
            if(average>80)
            {
                Console.WriteLine("Your are above Standerd..!");
                Console.WriteLine("Admission Granted..!");
            }
            else
            {
                Console.WriteLine("You are Not Qualified...!");
            }
        }

        /// <summary>
        /// This Method is Used Find the Maximum Values.
        /// </summary>
        private static void FindMaximumNumber()
        {
            Console.WriteLine("Enter First Number");
            int.TryParse(Console.ReadLine(), out int firstNumber);
            Console.WriteLine("Enter Second Number");
            int.TryParse (Console.ReadLine(), out int secondNumber);
            Console.WriteLine("Enter Third Number");
            int.TryParse(Console.ReadLine(), out int thirdNumber);

            int max = firstNumber;

            if(secondNumber>max)
                max = secondNumber;

            if(thirdNumber>max)
                max = thirdNumber;

            Console.WriteLine("The Maximum Number is: " + max);
        }

        /// <summary>
        /// This Method is Used to determine whether it is Positive, Negative or 0.
        /// </summary>
        private static void FindingNumber()
        {
            Console.WriteLine("Enter a Number");
            int.TryParse(Console.ReadLine(), out int number);

            if(number > 0)
            {
                Console.WriteLine("The number is Positive");
            }
            else if(number < 0) 
            {
                Console.WriteLine("The Number is Negative");
            }
            else if(number == 0)
            {
                Console.WriteLine("The Number is Zero..!");
            }
            else
            {
                Console.WriteLine("Please Enter Valid Number");
            }
        }

        /// <summary>
        /// This Method is Used the Inputs Five Integers. It finds and Prints the Largest And Smallest Integer.
        /// </summary>
        private static void FindLargestAndSmallestNumbers()
        {
            Console.WriteLine("Enter Any Five Numbers");
            int.TryParse(Console.ReadLine(), out int firstNum);     // 10
            int.TryParse(Console.ReadLine(), out int secNum);       // 20
            int.TryParse(Console.ReadLine(), out int thirdNum);     // 30
            int.TryParse(Console.ReadLine(), out int fourthNum);    // 40
            int.TryParse(Console.ReadLine(), out int fivthNum);     // 50

            int maxNumber;
            int minNumber = maxNumber = firstNum;       // 10,10

            if (secNum < minNumber) 
                minNumber = firstNum;       

            if (thirdNum < minNumber) 
                minNumber = thirdNum;

            if (fourthNum < minNumber) 
                minNumber = fourthNum;

            if (fivthNum < minNumber) 
                minNumber = fivthNum;

            if(secNum > maxNumber) 
                maxNumber= secNum;       // 20

            if(thirdNum>maxNumber) 
                maxNumber= thirdNum;     // 30

            if(fourthNum>maxNumber)
                maxNumber = fivthNum;    // 40    

            if(fivthNum> maxNumber) 
                maxNumber = fivthNum;    // 50
            
            Console.WriteLine("Largest Number is " + maxNumber);    // 50
            Console.WriteLine("Smallest Number is: " + minNumber);  // 10
                       
        }

        /// <summary>
        /// This Method is Used to find a number Whether it is Even or Odd.
        /// </summary>
        private static void FindEvenOrOddNumber()
        {
            Console.WriteLine("Enter a Number:");   //4
            int.TryParse(Console.ReadLine(), out int number);

            if (number % 2 == 0)
            {
                Console.WriteLine(number + " is Even");
            }
            else
            {
                Console.WriteLine(number+ " is Odd");
            }
        }

        /// <summary>
        ///This Mehtod is Used to finds a leap year or Not!.
        /// </summary>
        private static void FindLeapYears() 
        {
            Console.WriteLine("Enter a Year");
            int.TryParse(Console.ReadLine(), out int leapYear);

            if(leapYear % 4 == 0)
            {
                Console.WriteLine(leapYear+ " is a Leap Year.");
            }
            else
            {
                Console.WriteLine(leapYear+ " is not a Leap Year.");
            }
        }

        /// <summary>
        /// This Method get the Inputs i.e Salary and Grade. It adds 50% bonus if the grade is greater tha  15.
        /// It adds 25% bonus if the grade is 15 or less and then Displays the total salary.
        /// </summary>
        private static void FindEmployeeBonus()
        {
            Console.WriteLine("Enter Your Salary!");
            float.TryParse(Console.ReadLine(), out float empSalary);
            Console.WriteLine("Enter Your Grade!");
            int.TryParse(Console.ReadLine(),out int empGrade);

            float bonus;

            if (empGrade > 15)
                bonus = empSalary * 50 / 100;
            else
                bonus = empSalary * 25 / 100;
            
            empSalary = empSalary + bonus;
            
            Console.WriteLine("Your Total Salary is: Rs." + empSalary);            
        }

        /// <summary>
        /// This Method is Used the Inputs Two integers. It Detemines and Prints if the first integer is a 
        /// multuple of second integer.
        /// </summary>
        private static void FindMultipleNumber() 
        {
            Console.WriteLine("Enter first Number");
            int.TryParse(Console.ReadLine(), out int firstnumber);
            Console.WriteLine("Enter Second Number");
            int.TryParse(Console.ReadLine(), out int secondnumber);

            if(firstnumber % secondnumber == 0)
            {
                Console.WriteLine("The First Number is a multiple of Second.");
            }
            else
            {
                Console.WriteLine("The First number is not a multiple of second.");
            }
        }

        /// <summary>
        /// This Method is Used to Calculate the Student Score:
        /// </summary>
        private static void StudentFindTestResult()
        {
            Console.WriteLine("Enter Your Test Result");
            int.TryParse(Console.ReadLine(), out int testResult);

            if(testResult >= 100)
            {
                Console.WriteLine("Your Grade is A+.");
            }
            else if(testResult >= 80)
            {
                Console.WriteLine("Your Grade is A");
            }
            else if(testResult >= 60)
            {
                Console.WriteLine("Your Grade is B");
            }
            else if(testResult >= 40)
            {
                Console.WriteLine("Your Grade is C");
            }
            else if(testResult >= 33)
            {
                Console.WriteLine("Your Grade is E");
            }
            else
            { 
                Console.WriteLine("Your Grade is F"); 
            }
        }

        /// <summary>
        /// This Method is Used to Calculate the Electricity Bill. 
        /// </summary>
        private static void CalculateElectricityBill()
        {
            Console.WriteLine("Enter Unit Consumed");
            int.TryParse(Console.ReadLine(),out int unitConsumed);
            float bill;
            if (unitConsumed > 500)
            {
                bill = unitConsumed * 7;
            }
            else if (unitConsumed > 300)
            {
                bill = unitConsumed * 5; 
            }
            else
            {
                bill = unitConsumed * 2;
            }

            bill = bill + 150;

            if (bill > 2000)
                bill = bill + (bill * 5 / 100);
            
            Console.WriteLine("Tax Applied");
            
            Console.WriteLine("Total Bill =" + bill);
        }

        /// <summary>
        /// The Method is Used to Calculates Area of Circle.
        /// </summary>
        private static void CalculateArea()
        {
            Console.WriteLine("Enter the Radius:");     // 5
            int.TryParse(Console.ReadLine(),out int calcuRadius);   // 5

            float area, circumference;      // Initilization

            Console.WriteLine("Enter 1 for area and 2 for Circumference:");
            int.TryParse(Console.ReadLine(), out int areaAndCircum);    // 1 and if 2

            if(areaAndCircum == 1)  // 1
            {
                area = (float) (calcuRadius * calcuRadius * 3.141);     // 5 * 5 * 3.141 =
                Console.WriteLine("Area:" + area );     // Ans
            }
            else if(areaAndCircum == 2)     // 2
            {
                circumference =(float)( 2.0 * 3.141 * calcuRadius);     // 2.0 * 3.141 * 5 =
                Console.WriteLine("Circumference:" + circumference);    // Ans
            }
            else
            {
                Console.WriteLine("Invalid Choice.");
            }
        }

        /// <summary>
        /// This Method is used to get Three Inputs numbers and display Equal or Not.
        /// </summary>
        private static void FindNumbersEqualOrNot()
        {
            Console.WriteLine("Enter Three Numbers");
            int.TryParse(Console.ReadLine(), out int firstnumber);
            int.TryParse(Console.ReadLine(), out int secondnumber);
            int.TryParse(Console.ReadLine(), out int thirdnumber);

            if(firstnumber == secondnumber)     // 10 , 20  false
                if(secondnumber == thirdnumber)     // 20 , 30 false
                {
                    Console.WriteLine("All Numbers are Equal");     // not exicute
                }
                else
                {
                    Console.WriteLine("Inner : Numbers are different"); // Exicute
                }
            else 
            {
                Console.WriteLine("Outter : Numbers are different");
            }
        }

        /// <summary>
        /// This Method is Find the Vowel Characters.
        /// </summary>
        private static void FindVowelOrNot()
        {
            Console.WriteLine("Enter the any character");
            char.TryParse(Console.ReadLine(), out char vowelchar);

            if (vowelchar == 'A' || vowelchar == 'a' || vowelchar == 'E' || vowelchar == 'e' || vowelchar == 'I' || vowelchar == 'i' || vowelchar == 'O' || vowelchar == 'o' || vowelchar == 'U' || vowelchar == 'u')
            {
                Console.WriteLine("You Enter a Vowel Character:" + vowelchar);
            }
            else
            {
                Console.WriteLine("You did not enter a Vowel Character:" + vowelchar);            
            }
        }

        /// <summary>
        /// This Method is used to Find the Weeks Day.
        /// </summary>
        private static void FindWeeksDay()
        {
            Console.WriteLine("Enter the number of a Weekday:");
            int.TryParse(Console.ReadLine(), out int weeknumber);

            switch(weeknumber)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Please Enter Valid Number");
                    break;
            }
        }

        /// <summary>
        /// This Method is used to Vowel Character in Switch Case.
        /// </summary>
        private static void FindVowelInSwitch()
        {
            Console.WriteLine("Enter a Alphabet..!");
            char.TryParse(Console.ReadLine(), out char vowelchar);

            switch(vowelchar)
            {
                case 'a':
                case 'A':
                    Console.WriteLine("You Enter Vowel Char");
                    break;
                case 'e':
                case 'E':
                    Console.WriteLine("You Enter Vowel Char");
                    break;
                case 'o':
                case 'O':
                    Console.WriteLine("You Enter Vowel Char");
                    break;
                case 'U':
                case 'u':
                    Console.WriteLine("You Enter Vowel Char");
                    break;
                case 'i':
                case 'I':
                    Console.WriteLine("You Enter Vowel Char");
                    break;
                default:
                    Console.WriteLine("Not Vowel Char");
                    break;
            }
        }

        /// <summary>
        /// This Method is used to Floating Point Number in Switch Case.
        /// </summary>
        private static void AirthmeticOperationsOnFloatingNumbers()
        {
            Console.WriteLine("Enter a Floating First Number..!");
            float.TryParse(Console.ReadLine(), out float firstnumber);
            Console.WriteLine("Enter an Operator..!");
            char.TryParse(Console.ReadLine(), out char op);
            Console.WriteLine("Enter a Floating Second Number");
            float.TryParse(Console.ReadLine(), out float secondNumber);

            switch(op)
            {
                case '+':
                    Console.WriteLine(firstnumber + secondNumber);
                    break;
                case '-':
                    Console.WriteLine(firstnumber - secondNumber);
                    break;
                case '*':
                    Console.WriteLine(firstnumber * secondNumber);
                    break;
                case '/':
                    if (firstnumber == secondNumber)
                        Console.WriteLine("Division by Zero");
                    else
                    {
                        Console.WriteLine(firstnumber / secondNumber);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Operator..!");
                    break;
            }
        }

        /// <summary>
        /// This Method is used to menu of a Health Club.
        /// </summary>
        private static void HealthClub()
        {
            Console.WriteLine("Health Club Membership Menu..!");
            Console.WriteLine("1. Standard Adult Membership..!");
            Console.WriteLine("2. Child Membership..!");
            Console.WriteLine("3. Senior Citizen Membership..!");
            Console.WriteLine("4. Quit the Program");

            double charges = 0.0;
            Console.WriteLine("Enter your choice..!");
            int.TryParse(Console.ReadLine(), out int choiceNumber);

            if(choiceNumber >= 1 && choiceNumber <=3 )
            {
                Console.WriteLine("How many months..?");
                int.TryParse(Console.ReadLine(), out int monthNumber);

                switch(choiceNumber)
                {
                    case 1:
                        charges = monthNumber * 50.0;
                        break;
                    case 2:
                        charges = monthNumber * 20.0;
                        break;
                    case 3:
                        charges = monthNumber * 30.0;
                        break;

                }
                    Console.WriteLine("The Total Charges are Rs." + charges);
            }
            else if(choiceNumber != 4)
            {
                Console.WriteLine("The Valid Choice are 1 to 4.");
                Console.WriteLine("Run the program again and select one of these..!");
            }
        }

        /// <summary>
        /// This Method is used to Covert ASCII numbers to Character and vice versa.
        /// </summary>
        private static void FindASCII()
        {
            Console.WriteLine("1. Convert ASCII value to Character..!");
            Console.WriteLine("2. Covert Character to ASCII Value..!");
            Console.WriteLine("Enter your Choice..!");
            int.TryParse(Console.ReadLine(), out int optionNumber);

            //int firstNum;
            //char secondNUm;
            switch(optionNumber)
            {
                case 1:
                    Console.WriteLine("Enter a Number");
                    int.TryParse(Console.ReadLine(), out int firstNumber);
                    Console.WriteLine("The corresponding character is:" + (char)firstNumber);
                    break;
                case 2:
                    Console.WriteLine("Enter a Letter");
                    char.TryParse(Console.ReadLine(), out char letter);
                    Console.WriteLine("ASCII value of the Letter is: " + (int)letter);
                    break;               
            }
        }

        /// <summary>
        /// This Method is used how to work GoTo Loop.
        /// </summary>
        private static void GoToStatement()
        {
            int n = 1;
            loop:
            Console.WriteLine(n + ": C#");
            n++;

            if(n<=5)
                goto loop;

            Console.WriteLine("End the Program..!");
        }
    }
}
