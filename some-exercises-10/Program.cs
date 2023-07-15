using some_exercises_10;

Console.WriteLine("Enter a number from 1 to 7:");
int getDay = int.Parse(Console.ReadLine());

switch (getDay)
{
    case 1:
        Console.WriteLine(DaysOfWeek.Monday);
        break;
    case 2:
        Console.WriteLine(DaysOfWeek.Tuesday);
        break;
    case 3:
        Console.WriteLine(DaysOfWeek.Wednesday);
        break;
    case 4:
        Console.WriteLine(DaysOfWeek.Thursday);
        break;
    case 5:
        Console.WriteLine(DaysOfWeek.Friday);
        break;
    case 6:
        Console.WriteLine(DaysOfWeek.Saturday);
        break;
    case 7:
        Console.WriteLine(DaysOfWeek.Sunday);
        break;
    default:
        Console.WriteLine("Invalid day");
        break;
}

int status = 0;
switch (status)
{
    case 0:
        Console.WriteLine("Message sent");
        break;
    case 1:
        Console.WriteLine("Message delivered");
        break;
    case 2:
        Console.WriteLine("Message deleted");
        break;
    default:
        Console.WriteLine("Unknown status");
        break;
}

Person person = new Person();
Person.Count++;
Console.WriteLine(Person.Count);