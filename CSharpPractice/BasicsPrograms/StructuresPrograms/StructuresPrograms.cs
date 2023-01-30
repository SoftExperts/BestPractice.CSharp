using System.Runtime.CompilerServices;

namespace CSharpPractice.BasicsPrograms
{
    public static class StructuresPrograms
    {
        /// <summary>
        /// Looping Programs Content
        /// </summary>
        public static void StructuresProgramsContent()
        {
            bool loopSkipOrContinue = false;
            do
            {
                Console.WriteLine("Please Enter 1 and get the Student Record.");
                Console.WriteLine("Please Enter 2 and get the Date of Birth");
                Console.WriteLine("Pleae Enter 3 and get most costly books.");
                Console.WriteLine("Please Enter 4 and get Employee Details.");
                Console.WriteLine("Please Enter 5 and get store roll no and marks of three subjects and displays roll no, marks, and average marks.");
                Console.WriteLine("Please Enter 6 and get the find Result and Record.");
                Console.WriteLine("Please Enter 7 and get the Stores Languages using Enumeration");
                Console.WriteLine("Please Enter 'N' to Skip the Program");
                string userInput = Console.ReadLine();
                bool basicPrograms = int.TryParse(userInput, out int programInputResult);

                if (basicPrograms)
                {
                    switch (programInputResult)
                    {
                        case 1:
                            FindStudentDetails();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 2:
                            FindBirthDate();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 3:
                            FindCostlyBooks();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 4:
                            FindEmployeeData();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 5:
                            FindTestResult();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 6:
                            FindResultAndRecord();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
                            FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                            break;
                        case 7:
                            FindEnumeration();
                            Console.WriteLine("If you Want to Continue Loops Program? Press Y or Skip Program Press N");
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

        //------------- All Structures Programs -----------------
        /// <summary>
        /// This method is used to find Student details.
        /// </summary>
        private static void FindStudentDetails()
        {
            Student student;
            Console.WriteLine("Enter Roll No:");
            int.TryParse(Console.ReadLine(), out int studentRollNumber);
            student.rollNo = studentRollNumber;
            Console.WriteLine("Enter Marks:");
            int.TryParse(Console.ReadLine(), out int studentMarks);
            student.marks = studentMarks;
            Console.WriteLine("Enter Average:");
            float.TryParse(Console.ReadLine(), out float studentAverage);
            student.average = studentRollNumber;
            Console.WriteLine("Enter Grade:");
            char.TryParse(Console.ReadLine(), out char studentGrade);
            student.grade = studentGrade;

            Console.WriteLine("You entered student details:");
            Console.WriteLine("Your Roll No: " + studentRollNumber);
            Console.WriteLine("Your Marks is: " + studentMarks);
            Console.WriteLine("Your Average is: " + studentAverage);
            Console.WriteLine("Your Grade is: " + studentGrade);
        }

        /// <summary>
        /// This Method us used to find Date of Birth.
        /// </summary>
        private static void FindBirthDate()
        {
            birth b;
            Console.WriteLine("Enter Day of Birth");
            int.TryParse(Console.ReadLine(), out int birthDay);
            b.day = birthDay;
            Console.WriteLine("Enter Month of Birth");
            int.TryParse(Console.ReadLine(), out int birthMonth);
            b.month = birthMonth;
            Console.WriteLine("Enter Year of Birth");
            int.TryParse(Console.ReadLine(), out int birthYear);
            b.year = birthYear;

            Console.WriteLine("Your date of birth is " + b.day + "/" + b.month + "/" + b.year);
        }

        /// <summary>
        /// This Method is used to find most costly books.
        /// </summary>
        private static void FindCostlyBooks()
        {
            Books book1, book2;
            Console.WriteLine("Enter Book1 BookId, BookName, and BookPrice");
            int.TryParse(Console.ReadLine(), out int bookId);
            string bookName = (Console.ReadLine());
            float.TryParse(Console.ReadLine(), out float bookPrice);
            book1.id = bookId;
            book1.name = bookName;
            book1.price = bookPrice;

            Console.WriteLine("Enter Book2 BookId, BookName, and BookPrice");
            int.TryParse(Console.ReadLine(), out int book2Id);
            string book2Name = (Console.ReadLine());
            float.TryParse(Console.ReadLine(), out float book2Price);
            book2.id = book2Id;
            book2.name = book2Name;
            book2.price = book2Price;
            Console.WriteLine("The most costly book is as follows:");

            if (book1.price > book2.price)
            {
                Console.WriteLine("BookId: " + book1.id);
                Console.WriteLine("BookName: " + book1.name);
                Console.WriteLine("BookPrice: " + book1.price);
            }
            else
            {
                Console.WriteLine("BookId: " + book2.id);
                Console.WriteLine("BookName: " + book2.name);
                Console.WriteLine("BookPrice: " + book2.price);
            }
        }

        /// <summary>
        /// This method is used to find the initializing structure valriables and displays Employee Details.
        /// </summary>
        private static void FindEmployeeData()
        {
            employee emp;
            emp.empId = 101;
            emp.empName = "Aqib Saeed";
            emp.empSalary = 25500;

            Console.WriteLine("Employee Id is: " + emp.empId);
            Console.WriteLine("Employee Name is: " + emp.empName);
            Console.WriteLine("Employee Salary is: " + emp.empSalary);
        }

        /// <summary>
        /// This method is used to store roll no and marks of three subjects and displays roll no, marks, and average marks.
        /// </summary>
        private static void FindTestResult()
        {
            TestResult[] Result = new TestResult[3];
            int i, total = 0;
            double average = 0.0;

            Console.WriteLine("Enter Roll No: ");
            int.TryParse(Console.ReadLine(), out int rollNo);
            Result[0].rollNo = rollNo;
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Marks:");
                int.TryParse(Console.ReadLine(), out int marksInput);
                Result[i].marks = marksInput;
                total = total + Result[i].marks;
            }
            average = total / 5.0;
            Console.WriteLine("Roll NO: " + Result[0].rollNo);
            Console.WriteLine("Total Marks: " + total);
            Console.WriteLine("Average: " + average);

        }

        /// <summary>
        /// This method is used to find Result and Record. The result structure stores marks and grade, Record structure stores roll number and a result type.
        /// </summary>
        private static void FindResultAndRecord()
        {
            Result result;
            Record record;
            Console.WriteLine("Enter Roll No: ");
            int.TryParse(Console.ReadLine(), out int rollNo);
            record.rollNo = rollNo;
            Console.WriteLine("Enter Marks: ");
            int.TryParse(Console.ReadLine(), out int marksInput);
            record.res.marks = marksInput;
            Console.WriteLine("Enter Grade: ");
            char.TryParse(Console.ReadLine(), out char gradeInput);
            record.res.grade = gradeInput;

            Console.WriteLine("Roll No: " + record.rollNo);
            Console.WriteLine("Marks: " + record.res.marks);
            Console.WriteLine("Grade: " + record.res.grade);
        }

        /// <summary>
        /// This method is used to declares an enumeration to store languages.
        /// </summary>
        private static void FindEnumeration()
        {

            //enum languages { C, Cpp, Java, CSharp, HTML, CSS, Python };


            lengu.languages lang;
            lang = lengu.languages.CSS;

            Console.WriteLine("The Value of Languages is: " + lang);
        }
    }
    struct Student
    {
        public int rollNo;
        public int marks;
        public float average;
        public char grade;
    };

    struct birth
    {
        public int day;
        public int month;
        public float year;
    };

    struct Books
    {
        public int id;
        public string name;
        public float price;
    }

    struct employee
    {
        public int empId;
        public string empName;
        public double empSalary;
    };

    struct TestResult
    {
        public int rollNo;
        public int marks;
    }

    struct Result
    {
        public int marks;
        public char grade;
    };
    struct Record
    {
        public int rollNo;
        public Result res;
    };

    class lengu
    {
        public enum languages { C, Cpp, Java, CSharp, HTML, CSS, Python };
    }
}