Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
while(num > 999)
{
    num /= 10;
}
int num2 = num % 10;
Console.WriteLine($"{"Третья цифра числа - "}{num2}");