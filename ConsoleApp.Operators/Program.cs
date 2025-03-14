Console.WriteLine("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int sum = num1 + num2;

int product = num1 * num2;

int quotient = num1 / num2;

int difference = num1 - num2;

int mod = num1 % num2;

Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Quotient: {quotient}");
Console.WriteLine($"Difference: {difference}");
Console.WriteLine($"Modulus: {mod}");


bool isGreaterThan = num1 > num2;
bool isLessThan = num1 < num2;
bool isEqualTo = num1 == num2;
bool isGreaterThanOrEqualTo = num1 >= num2;
bool isLessThanOrEqualTo = num1 <= num2;
bool isNotEqual = num1 != num2;

Console.WriteLine($"Is it greater than?: {isGreaterThan}");
Console.WriteLine($"Is it less than?: {isLessThan}");
Console.WriteLine($"Is it equal to?: {isEqualTo}");
Console.WriteLine($"Is it greater than or equal to? {isGreaterThanOrEqualTo}");
Console.WriteLine($"Is it less than or equal to? {isLessThanOrEqualTo}");
Console.WriteLine($"Is it not equal to? {isNotEqual}");

num1 += 5;
Console.WriteLine($"Num 1 increased by 5 {num1}");
num1 -= 3;
Console.WriteLine($"Num 1 decreased by 3 {num1}");
num1 /= 2;
Console.WriteLine($"Num 1 divided by 2 {num1}");
num1 *= 10;
Console.WriteLine($"Num 1 multiplied by 10 {num1}");
num1 %= 2;
Console.WriteLine($"Num 1 mod by 2 {num1}");

