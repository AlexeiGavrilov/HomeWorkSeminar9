// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

int ConvertToIntUserMsg(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumAllNaturalNumbers(int N, int M)
{
    if (N < 0) N = N + (-N);
    if (N == M) return M;
    else
    {
        int sum = N;
        return sum + SumAllNaturalNumbers((N + 1), (M));
    }

}

int Num1 = ConvertToIntUserMsg("Введите первое натрульное число: ");
int Num2 = ConvertToIntUserMsg("Введите второе натрульное число: ");
Console.WriteLine(SumAllNaturalNumbers(Num1, Num2));


