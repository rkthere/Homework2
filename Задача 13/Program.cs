Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string result = Convert.ToString(number);
if(result.Length > 2)
{
    Console.WriteLine("Третье число это: " + result[2]);
}
else
{
    Console.WriteLine("Третьего числа нет");
}