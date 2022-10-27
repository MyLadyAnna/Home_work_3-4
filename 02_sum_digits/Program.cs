// Напишите программу, которая принимает на вход число и выдаёт 
// сумму цифр в числе.

int GetSumOfDigit(int n)
{
    int sum = 0;
    int digit = 0;
    do
    {
        digit = n % 10;
        sum += digit;
        n /= 10;
    } while (n > 0);
    return sum;
}

Console.Clear();
Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine(GetSumOfDigit(number));