Console.Write("Введите число => ");
string paramString = Console.ReadLine();
int paramInt = int.Parse(paramString);

if (paramInt == 6 || paramInt == 7)
{
    Console.WriteLine("Ура, сегодня выходной");
}

if (paramInt < 6)
{
    Console.WriteLine("Сегодня рабочий день");
}

if (paramInt > 7 || paramInt < 0)
{
    Console.WriteLine("Такого дня недели не существует");
}