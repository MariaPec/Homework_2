Console.Write("Введите трехзначное число => ");
string paramString = Console.ReadLine();
int paramInt = int.Parse(paramString);

paramInt = paramInt / 10;

int result = paramInt % 10;

Console.WriteLine($"Вторая цифра числа - {result}");
