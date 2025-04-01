Console.WriteLine("***** Arrays *****");

// Tell me how many students and grades are to be entered
Console.Write("Please indicate thew number of grades to be entered: ");
int numberOfGrades = Convert.ToInt32(Console.ReadLine());

//Declare Fixed Size Array
int[] grades = new int[numberOfGrades];
string[] students = new string[numberOfGrades];

//Add values to Fixed Size Aray
//grades[0] = 45;
//grades[1] = 25;
//grades[2] = 38;
//grades[3] = 45;
//grades[4] = 54;

for (int i = 0; i < numberOfGrades; i++)
{
    Console.WriteLine("Enter Student Name: ");
    students[i] = Console.ReadLine();

    Console.WriteLine("Enter Grade: ");
    grades[i] = Convert.ToInt32(Console.ReadLine());

}

//Print values in Fixed Size Array
Console.WriteLine("The grades you have entered are: ");
for (int i = 0;i < grades.Length; i++)
{
    Console.WriteLine($"{students[i]}: {grades[i]}");
}

//Print values in list
foreach (int g in grades)
{
    Console.WriteLine(g);
}

//Declare Variable Sized Array
string[] studentNames = { "Newton", "Joshua", "Nehemiah" };

//Add values to Variable Sized Array
for (int i = 0; i < studentNames.Length; i++)
{
    Console.WriteLine("Enter Student Name: ");
    studentNames[i] = Console.ReadLine();

}
Console.WriteLine("The names you have entered are: ");
for (int i = 0; i < studentNames.Length; i++)
{
    Console.WriteLine(studentNames[i]);
}

//Print values in Variable Sized Array
