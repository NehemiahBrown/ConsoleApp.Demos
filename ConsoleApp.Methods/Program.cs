Console.WriteLine("******* METHODS *******");

// void methods - complete a task without returning a value
void PrintName()
{
    //  Method code
    Console.WriteLine("Nehemiah Brown");
}

// value returning methods - returns a value after an operation
int GetFiveYearsAgo()
{
  int year = DateTime.Now.AddYears(-5).Year;
    return year;
}
// methods with parameters
void PrintNameWithParams(string name)
{
    //  Method code
    Console.WriteLine(name);
}

int GetYearDifferenceWithParams(int year)
{
    int yearDifference = DateTime.Now.Year - year;
    return yearDifference;
}
// methods with optional parameters - parameter is not required..also has a default value
int GetFutureOrPastyear(int numberOfyears = 0)
{
    var year = DateTime.Now.AddYears(numberOfyears).Year;
    return year;
}

// methods with nullable parameters
void PrintNameNullableParam(string? name, int? count = 0)
{
    if (string.IsNullOrEmpty(name))
    {
        name = "Default Name";
        Console.WriteLine();
    }
    if (count.HasValue == false)
    {
        count = 1;
    }

    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(name);
    }
}

/*Function Calls */
PrintName();
int fiveYearsAgo = GetFiveYearsAgo();
Console.WriteLine("Five years ago was: " +  fiveYearsAgo);

Console.WriteLine("Enter your name");
string name1 = Console.ReadLine();
PrintNameWithParams("name1");

Console.WriteLine("Enter a year");
int pastYear = Convert.ToInt32(Console.ReadLine());
int yearsAgo = GetYearDifferenceWithParams(pastYear);
Console.WriteLine("This was " + yearsAgo + " years ago.");

Console.WriteLine("Enter number of years in the future or past");
int numberOfYears = Convert.ToInt32(Console.ReadLine());

var pastYear1 = GetFutureOrPastyear();
Console.WriteLine("The year is : " + pastYear1);

var pastYear2 = GetFutureOrPastyear(9);
Console.WriteLine("The year is : " + pastYear2);

PrintNameNullableParam(null, null);
PrintNameNullableParam("Chester", 5);