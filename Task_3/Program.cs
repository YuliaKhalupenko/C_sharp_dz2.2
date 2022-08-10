//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Clear();

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);

while (a > 999)
{
a = a / 10;
}
if (a < 100) 
{
Console.WriteLine("третьей цифры нет");
}
else Console.WriteLine($"третья цифра числа {a} равна {a % 10}");

//либо решение через string
//Console.Write("Введи число: ");
//int anyNumber = Convert.ToInt32(Console.ReadLine());
//string anyNumberText = Convert.ToString(anyNumber);
//if (anyNumberText.Length > 2){
//  Console.WriteLine("третья цифра -> " + anyNumberText[2]);
//}
//else {
//  Console.WriteLine("-> третьей цифры нет");
//}