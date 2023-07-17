// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int firstDigit = number % 1000000000 / 100000000;
int secondDigit = number % 100000000 / 10000000;
int thirdDigit = number % 10000000 / 1000000;
int fourthDigit = number % 1000000 / 100000;
int fifthDigit = number % 100000 / 10000;
int sixthDigit = number % 10000 / 1000;
int seventhDigit = number % 1000 / 100;
int eightрDigit = number % 100 / 10;
int ninthDigit = number % 10;

int result = firstDigit + secondDigit + thirdDigit + fourthDigit + fifthDigit + sixthDigit + seventhDigit + eightрDigit + ninthDigit;

Console.WriteLine($"Сумма цифр в числе {number} равна: {result}");

// Console.WriteLine($"Первая цифра: {firstDigit}");
// Console.WriteLine($"Вторая цифра: {secondDigit}");
// Console.WriteLine($"Третья цифра: {thirdDigit}");
// Console.WriteLine($"Четвертая цифра: {fourthDigit}");
// Console.WriteLine($"Пятая цифра: {fifthDigit}");
// Console.WriteLine($"Шестая цифра: {sixthDigit}");
// Console.WriteLine($"Седьмая цифра: {seventhDigit}");
// Console.WriteLine($"Восьмая цифра: {eightрDigit}");
// Console.WriteLine($"Девятая цифра: {ninthDigit}");