Console.Write("Введите число => ");
string paramString = Console.ReadLine();
int paramInt = int.Parse(paramString);
int length = paramString.Length;

int [] array = new int[length];
int index = array.Length -1;

 if (paramInt < 100)
{
Console.WriteLine($"Третьей цифры нет");
Environment.Exit(0);
}

while (paramInt > 0)
{
   array[index] = paramInt % 10;
   paramInt = paramInt / 10;
   index--;
}

Console.WriteLine($"Третья цифра  - {array[2]}");


