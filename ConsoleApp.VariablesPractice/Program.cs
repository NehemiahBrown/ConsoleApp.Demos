
Console.WriteLine("Welcome to Symphony Bank");

int userBalance = 0;
int deposit = 0;
int withdrawal = 0;

Console.WriteLine("Enter your balance");
userBalance = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter deposit amount");
deposit = Convert.ToInt32(Console.ReadLine());
userBalance = userBalance + deposit;
Console.WriteLine($"The total in your bank account is: {userBalance}");

Console.WriteLine("Enter withdrawal amount");
withdrawal = Convert.ToInt32(Console.ReadLine());
userBalance = userBalance - withdrawal;
Console.WriteLine($"The total in your bank account is: {userBalance}");
