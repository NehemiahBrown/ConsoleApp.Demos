// See https://aka.ms/new-console-template for more information



int choice = 0;
int num1 = 0;
int num2 = 0;
while (choice != -1)
{
    try
    {

        //Welcome Message
        PrintMenu();

        choice = Convert.ToInt32(Console.ReadLine());

        if (choice == -1)
        {
            break;
        }

        Console.Write("Please enter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        /* Switch statement */
        int answer = 0;
        switch (choice)
        {
            case 1:
                answer = AddNumbers(num1, num2);
                break;
            case 2:
                answer = SubtractNumbers(num1, num2);
                break;
            case 3:
                answer = Product(num1, num2);
                break;
            case 4:
                answer = Quotient(num1, num2);
                break;
            case 5:
                answer = Fibonaci(num1, num2);
                break;
            default:
                throw new Exception("Invalid Menu Item Selected.");
        }

        // print output 
        Console.WriteLine($"The result is: {answer}");
        Console.WriteLine("Press Enter to continue");
        Console.ReadLine();
        Console.Clear();



    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Cannot divide by zero");
        Console.WriteLine("Press enter to continue");
        Console.ReadLine();
        Console.Clear();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        Console.WriteLine("Press any key to try again");
        Console.ReadLine();
        Console.Clear();
    }
}
Console.WriteLine("******** - Thank you for using the sample calculator! - ********");

//Method Declaration

int AddNumbers(int num1, int num2)
{
    return num1 + num2;
}

int SubtractNumbers(int num1, int num2)
{
    return num1 - num2;
}

int Product(int num1, int num2)
{
    return num1 * num2;
}

int Quotient(int num1, int num2)
{
    return num1 / num2;
}

int Fibonaci(int num1, int num2)
{
    var answer = 0;
    for (int i = num1; i <= num2; i++)
    {
        answer += i;
    }
    return answer;
}

void PrintMenu()
{
    Console.Clear();
    Console.WriteLine("******** - Welcome to the sample calculator! - ********");
    Console.WriteLine("Please select an operation (-1 to exit program) ");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Fibonacci sequence");
}


