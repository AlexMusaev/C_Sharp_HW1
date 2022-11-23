// Задание первое. Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число больше, а какое меньше.

Console.Clear();
Console.WriteLine("Введите первое число: ");
int numOne = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numTwo = int.Parse(Console.ReadLine());

if (numOne > numTwo) 
{
    Console.Write($"Число {numOne} больше, чем число {numTwo}");
}
else 
{
    Console.Write($"Число {numTwo} больше, чем число {numOne}");
}

// Задание второе. Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих числе.

Console.Clear();
Console.WriteLine("Введите первое число: ");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numC = int.Parse(Console.ReadLine());

if (numA > numB && numA > numB) 
{
    Console.Write($"Число {numA} больше числа {numB} и {numC}");
}
else if (numB > numA && numB > numC) 
{
    Console.Write($"Число {numB} больше числа {numA} и {numC}");
}
else if (numC > numA && numC > numB) 
{
    Console.Write($"Число {numC} больше числа {numA} и {numB}");
}
else if(numA == numB && numA == numC && numB == numC)
{
    Console.Write("Числа равны");
}

// Задание третье. Задача 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число четным(делится ли оно на два без остатка).

Console.Clear();
Console.WriteLine("Введите ваше число");
int even = int.Parse(Console.ReadLine());

if (even % 2 == 0) 
{
    Console.Write($"Число {even} четное");
}
else
{
    Console.Write($"Число {even} не четное");
}

// Задание четвертое. Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N

Console.Clear();
Console.WriteLine("Введите ваше число");
int n = int.Parse(Console.ReadLine());

while (n > 1)
{
    if (n % 2 == 0) 
    {
        Console.WriteLine($"Четное значение из задоного вами числа = {n}");
        n--;
    }
    else 
    {
        n--;
    }
    
}

// Спасибо за внимание : )
