Console.Clear();
Console.WriteLine("Введите цифру дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if(dayNumber == 6 || dayNumber == 7)
{
    Console.WriteLine("Этот день выходной");
}
else
{
    Console.WriteLine("Это не выходной :(");
}