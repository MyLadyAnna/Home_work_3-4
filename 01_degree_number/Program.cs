// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

double GetAToDegreeB(double number1, double number2)
{
    if (number2 <= 0 || number2 % 10 > 9) return -1;       // в условии прописано, что B должно быть натуральным (это целые числа от 1)
    return Math.Pow(number1, number2);
}


Console.Clear();
Console.Write("Введите 1 число ");
double numberA = Convert.ToDouble(Console.ReadLine() ?? "0");
Console.Write("Введите 2 число ");
double numberB = Convert.ToDouble(Console.ReadLine() ?? "0");

Console.Write(GetAToDegreeB(numberA, numberB));
