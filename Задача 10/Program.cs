Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string result = Convert.ToString(number);
Console.WriteLine("Второе число это: " + result[1]);