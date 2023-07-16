// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите первое число: ");
double firstNumber = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите второе число: ");
double secondNumber = Convert.ToDouble(Console.ReadLine());

double result = Math.Pow(firstNumber, secondNumber);

Console.WriteLine($"Число {firstNumber} в степени {secondNumber} равно: {result}");