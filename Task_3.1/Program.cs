//либо решение через string

Console.Write("Введи число: ");

int anyNumber = Convert.ToInt32(Console.ReadLine());

string anyNumberText = Convert.ToString(anyNumber);

if (anyNumberText.Length > 2)
{
  Console.WriteLine($"третья цифра числа {anyNumber} равна {anyNumberText[2]}");
}
else 
{
  Console.WriteLine("третьей цифры нет");
}