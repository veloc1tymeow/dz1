Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num < 100 || num >= 1000)
{
    Console.WriteLine("Вы ввели не трёхзначное число");
}
int num2 = num / 10 % 10;
Console.WriteLine($"{"Вторая цифра числа - "}{num2}");
