int number = new Random().Next(100, 1000);

Console.WriteLine($"Случайное трехзначное число: {number}");

int number1 = number % 10;

int number2 = number / 100;


Console.WriteLine($"Итоговое двухзначное число: {number2}{number1}");
