Console.WriteLine("Enter a number as to determine number sign?");
int number = Convert.ToInt32(Console.ReadLine());

//Determine the number sign and whether zero

if (number >= 0)
{
    if (number == 0)
    {
        Console.WriteLine("The number is zero");
    }
    else
    {
        Console.WriteLine("The number is positive");
    }
}
else
{
    Console.WriteLine("The number is negative");
}

//Determine day name of the week 

Console.WriteLine("Enter a number as to determine day name");
int day = Convert.ToInt32(Console.ReadLine());

day = day%7;

switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 0:
        Console.WriteLine("Sunday");
        break;
}

Console.WriteLine("What you wanna do?\n 1. Add \n 2. Subtract \n 3. Multiply \n 4. Divide");
int choice = Convert.ToInt32(Console.ReadLine());

switch(choice)
{
    case 1:
        Console.WriteLine("Enter two numbers to add");
        int add1 = Convert.ToInt32(Console.ReadLine());
        int add2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The sum is " + (add1 + add2));
        break;
    case 2:
        Console.WriteLine("Enter two numbers to subtract");
        int sub1 = Convert.ToInt32(Console.ReadLine());
        int sub2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The difference is " + (sub1 - sub2));
        break;
    case 3:
        Console.WriteLine("Enter two numbers to multiply");
        int mul1 = Convert.ToInt32(Console.ReadLine());
        int mul2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The product is " + (mul1 * mul2));
        break;
    case 0:
        Console.WriteLine("Enter two numbers to divide");
        int div1 = Convert.ToInt32(Console.ReadLine());
        int div2 = Convert.ToInt32(Console.ReadLine());
        if (div2 != 0)
        {
            Console.WriteLine("The quotient is " + ((double)div1 / div2));
        }
        else
        {
            Console.WriteLine("Cannot divide by zero.");
        }
        break;

    default:
        Console.WriteLine("Invalid choice.");
        break;
}

//Determine the largest number among three numbers
Console.WriteLine("Enter three numbers to determine the largest number");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("The largest number is " + Math.Max(num9, Math.Max(num10, num11)));

if (number1 > number2)
{
    if (number1 > number3)
    {
        Console.WriteLine("The largest number is " + number1);
    }
    else
    {
        Console.WriteLine("The largest number is " + number3);
    }
}
else
{
    if (number2 > number3)
    {
        Console.WriteLine("The largest number is " + number2);
    }
    else
    {
        Console.WriteLine("The largest number is " + number3);
    }
}

//Checking Password Strength
Console.WriteLine("Enter a password to check its strength");
string password = Console.ReadLine();

string specialCharacters = "@#$%";

if (password!.Length >= 8 || password.Contains(specialCharacters) || password.Any(char.IsUpper))
{
    Console.WriteLine("The password is strong");
}
else
{
    Console.WriteLine("The password is incompatible." +
        "It has to be at least 8 charachters,special charachters and at least 1 upper letter! ");
}

