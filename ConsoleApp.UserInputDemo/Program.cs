string firstName = string.Empty;
string lastName = string.Empty;
int age = 0;
int retirementAge = 67;
decimal salary = 0;
char gender = char.MinValue;
bool working = true;


//Prompt user for input
Console.WriteLine("Please enter your name");
firstName = Console.ReadLine();

Console.WriteLine("Please enter your name");
lastName = Console.ReadLine();

Console.WriteLine("Please enter your age");
age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter your age");


//Process the data
int workingYearsRemaining = retirementAge - age;

//Output the results to the user
Console.WriteLine($"Full name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Working years remaining: {workingYearsRemaining}");