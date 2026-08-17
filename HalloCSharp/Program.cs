// See https://aka.ms/new-console-template for more information


// public struct  SegTree()
// {
//     public SegTree()
//     {
//         
//     }
//     
//     
// }

void GuessGame()
{
    int c = 0;

    int randomInt = new Random().Next(1, 101);
    string buf;

    int ans = -1;
    
    Console.WriteLine("Guess a number between 1 and 100");
    do
    {
        buf = Console.ReadLine();
        ans = int.Parse(buf);

        if (ans == randomInt)
        {
            Console.WriteLine("Guessed!");
            return;
        } else if (ans < randomInt)
        {
            Console.WriteLine("Too low!");
        }
        else
        {
            Console.WriteLine("Too high!");
        }
    } while (ans != randomInt);
}

int Add(int a, int b)
{
    return a + b;
}

int Subtract(int a, int b)
{
    return a - b;
}

int Multiply(int a, int b) {
    return a * b;
}

int Divide(int a, int b)
{
    if (a == 0 | b == 0) return -1;
    return a / b;
}

int Calculate(int a, int b, char op)
{
    switch (op)
    {
        case '+':
            return Add(a, b);
            break;
        case '-' :
            return Subtract(a, b);
            break;
        case '/':
            return Divide(a, b);
            break;
        case '*':
            return Multiply(a, b);
            break;
        default:
            Console.WriteLine("Invalid Operator...");
            return 0;
    }
}

void CalculatorIO()
{
    char yn;
    string buf;

    do
    {

        Console.Write("First Number: ");
        buf = Console.ReadLine();
        int a = int.Parse(buf);


        Console.Write("Operation (+, -, *, /): ");
        buf = Console.ReadLine();
        char op = char.Parse(buf);

        Console.Write("Second Number: ");

        buf = Console.ReadLine();
        int b = int.Parse(buf);

        Console.WriteLine(a + " " + op + " " + b + " = " +  Calculate(a, b, op));

        do
        {
            Console.Write("calculate again? (y/n): ");
            buf = Console.ReadLine();
            yn = char.Parse(buf);
        } while (yn != 'y' && yn != 'n');
    } while (yn != 'n');



}

void Pyramid(int n)
{
    for (int i = 1; i <= n; i++)
    {
        for (int j = 0; j < i; j++)
        {
            Console.Write('*');
        }
        Console.WriteLine();
    }

    for (int i = n - 1; i > 0; i--)
    {
        for (int j = i; j > 0; j--)
        {
            Console.Write('*');
        }
        Console.WriteLine();
    }
}

int FindMin(int[] arr)
{
    int res = 10 ^ 9;
    foreach (var num in arr)
    {
        res = Math.Min(res, num);
    }

    return res;
}

int FindMax(int[] arr)
{
    int res = 0;
    foreach (var num in arr)
    {
        res = Math.Max(res, num);
    }

    return res;
}



void HelloCSharp()
{
    Console.Write("Wie heisst du? ");

    string name = Console.ReadLine();

    Console.WriteLine("Hallo, " + name + " Willkommen bei C#.");

 
}

void TwoNumbersOperations()
{

    Console.Write("Erste Zahl: ");
    string firstNum = Console.ReadLine();
    Console.Write("Zweite Zahl: ");
    string secondNum = Console.ReadLine();

    int firstNumInt = int.Parse(firstNum);
    int secondNumInt = int.Parse(secondNum);
    
    Console.WriteLine(firstNumInt + " + " + secondNumInt + " = " + (firstNumInt + secondNumInt));
    Console.WriteLine(firstNumInt + " - " + secondNumInt + " = " + (firstNumInt - secondNumInt));
    Console.WriteLine(firstNumInt + " * " + secondNumInt + " = " + (firstNumInt * secondNumInt));
    Console.WriteLine(firstNumInt + " / " + secondNumInt + " = " + (firstNumInt / secondNumInt));

}

int FactorialRec(int n, ref int res)
{
    if (n == 0) return res;

    res *= n;
    
    
    return FactorialRec(n - 1, ref res);
}



int FactorialItt()
{
    string buf = Console.ReadLine();
    int n = int.Parse(buf);

    int res = 1;
    for (int i = n; i > 0; --i)
    {
        res *= i;
    }
    return res;
}

void Main()
{
    
    GuessGame();
    
    
    HelloCSharp();
    TwoNumbersOperations();

    string buf = Console.ReadLine();
    int n = int.Parse(buf);
    int res = n;
    FactorialRec(n - 1, ref res);
    Console.WriteLine(res);

    int resItt = FactorialItt();
    Console.WriteLine(resItt);

    int[] firstExample = { 1, 2, 3, 4, 5, 234, 21235234, 6456 };
    int[] secondExample = { 5345,2341,23492,342345,134,5346 };
    
    Console.WriteLine(FindMax(firstExample) + " " + FindMax(secondExample) + " " + FindMin(firstExample) + " " + FindMin(secondExample));

    Pyramid(5);
    
    CalculatorIO();
}


Main();
