using CSharpPractice.BasicsPrograms;

bool loopSkipOrContinue = false;

do
{
    Console.WriteLine("Please Enter 1 to Execute C# Basics Programs");
    Console.WriteLine("Please Enter 2 to Execute C# OOPs Programs");
    Console.WriteLine("Please Enter 3 to Execute C# Data Structure & Algorithm");
    Console.WriteLine("Please Enter 4 to Execute C# Reflection Programs");
    Console.WriteLine("Please Enter 'N' to Skip the Program");
    string userInput = Console.ReadLine();
    bool basicPrograms = int.TryParse(userInput, out int programInputResult);


    if (basicPrograms)
    {
        switch (programInputResult)
        {
            case 1:
                Console.WriteLine("-- Welcome to C# Basic Programs! --");
                BasicPrograms.BasicProgramsContents();
                Console.WriteLine("If you Want to continue? Press Y or End the Programs Press N ");
                FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                break;

            case 2:
                Console.WriteLine("-- Welcome to C# OOPs Programs! --");
                OPPsPrograms.OPPsProgramsContents();
                Console.WriteLine("If you Want to continue? Press Y or End the Programs Press N ");
                FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                break;
            case 3:
                Console.WriteLine("-- Welcome to C# Data Structure & Algorithm Programs! --");
                Console.WriteLine("If you Want to continue? Press Y or End the Programs Press N ");
                FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                break;
            case 4:
                Console.WriteLine("-- Welcome to C# Reflection Programs! --");
                Console.WriteLine("If you Want to continue? Press Y or End the Programs Press N ");
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


#region Methods 

static void FindYesOrNo(string input, ref bool loopSkipOrContinue)
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
    }
    while (flag);
}
#endregion

//// Online C# Editor for free
//// Write, Edit and Run your C# code using C# Online Compiler

//public class HelloWorld
//{
//    static DateTime time;
//    static void Main(string[] args)
//    {
//        if (time == null)
//            Console.WriteLine("Hello Mono World");
//    }
//}
//var ints = new List<int>( 1 );
//IEnumerable<int> ns = ints.Select(n => n * 0);
//ints.Add( 2 );
//foreach( int n in ns )
//    Console.WriteLine(n + ",");

//Action[] actions = new Action[3];
//for (int i = 0; i < 3; i++)
//    actions[i] = () => Console.Write(i);
//foreach (Action a in actions) a();

//Console.WriteLine((TimeSpan.FromDays(10) - TimeSpan.FromSeconds(1)).Seconds);