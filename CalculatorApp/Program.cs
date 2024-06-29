Console.WriteLine("-------------------------------------");
Console.WriteLine("****** CALCULATOR PROGRAM ***********");
Console.WriteLine("-------------------------------------");

double num1  = 0;
double num2 = 0;
double result  = 0;

do
{
    Console.Write("Enter first number: ");
    num1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter first number: ");
    num2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Choose operation: ");
    Console.WriteLine("+ : add");
    Console.WriteLine("- : subtract");
    Console.WriteLine("* : multiply");
    Console.WriteLine("/ : divide");

    switch (Console.ReadLine())
    {
        case "+":
            result = num1 + num2;
            Console.WriteLine($"Your result: {num1} + {num2} = " + result);
            break;
        case "-":
            result = num1 - num2;
            Console.WriteLine($"Your result: {num1} - {num2} = " + result);
            break;
        case "*":
            result = num1 * num2;
            Console.WriteLine($"Your result: {num1} * {num2} = " + result);
            break;
        case "/":
            result = num1 / num2;
            Console.WriteLine($"Your result: {num1} / {num2} = " + result);
            break;
        default:
            Console.WriteLine("You entered an invalid option");
            break;
    }

    Console.WriteLine("Would you like to continue (Y/N)");

} while (Console.ReadLine().ToUpper() == "Y");
