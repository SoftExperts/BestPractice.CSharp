

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
                Console.WriteLine("Do you Want to continue the Program! Please Enter Y or Skip the Main Programs N");
                FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                break;

            case 2:
                Console.WriteLine("-- Welcome to C# OOPs Programs! --");
                Console.WriteLine("Do you Want to continue the Program! Please Enter Y or N");
                FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                break;
            case 3:
                Console.WriteLine("-- Welcome to C# Data Structure & Algorithm Programs! --");
                Console.WriteLine("Do you Want to continue the Program! Please Enter Y or N");
                FindYesOrNo(Console.ReadLine(), ref loopSkipOrContinue);
                break;
            case 4:
                Console.WriteLine("-- Welcome to C# Reflection Programs! --");
                Console.WriteLine("Do you Want to continue the Program! Please Enter Y or N");
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