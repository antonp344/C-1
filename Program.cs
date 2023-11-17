// Задача 1 на вход принимает два числа и выводит, какое число большее, а какое меньшее.
//Console.Clear();
//Console.Write("Введите 1-ое число: ");
//int firstNumber = int.Parse(Console.ReadLine()!);
//Console.Write("Введите 2-ое число: ");
//int secondNumber = int.Parse(Console.ReadLine()!);

//if (firstNumber > secondNumber)
//    Console.WriteLine($"Число {firstNumber} больше числа {secondNumber}");
//    else if (firstNumber < secondNumber)
//        Console.WriteLine($"Число {firstNumber} меньше числа {secondNumber}");
//else
//    Console.WriteLine($"Число {firstNumber} равно числу {secondNumber}");


// Задача 2 принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.Write("Введите 1-ое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-ое число: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите 3-ое число: ");
int c = int.Parse(Console.ReadLine()!);
int max = a;
if (a > max ) max = a;
if (b > max ) max = b;
if (c > max ) max = c;
Console.WriteLine(max);


