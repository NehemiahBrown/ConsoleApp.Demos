
//Console.WriteLine("*****Simple For Loop*****");

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine($"Hello, World! - {i}");
//}


//Console.WriteLine("How many times do you want to print the following statement?");
//int numOfTimes = Convert.ToInt32(Console.ReadLine());

//for (int i = 0; i < numOfTimes; i++)
//{
//    Console.WriteLine($"Hello, World! - {i}");
//}

//While Loop
Console.WriteLine("****While Loop****");

//int counter = 0;
//while (counter < 10)
//{
//    Console.WriteLine($"Hello World! - {counter}");
//    counter++;
//}


int totalBananas = 0;
int bananasEarned = 0;
while (bananasEarned != -1)
{
    Console.WriteLine("How many bananas did you earn today?");
    bananasEarned = Convert.ToInt32(Console.ReadLine());
    totalBananas += bananasEarned;
}

Console.WriteLine($"Bananas Earned: {totalBananas}");