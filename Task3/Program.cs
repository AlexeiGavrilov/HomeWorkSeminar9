// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9 (?)
//m = 3, n = 2 -> A(m,n) = 29 (?)

int ConvertToIntUserMsg(string mesage)
{
    Console.Write(mesage);
    return Convert.ToInt32(Console.ReadLine());
}

int AckermanFunction(int M, int N)
{
    if (M == 0) return N + 1;
    else if (M > 0 && N == 0) return AckermanFunction(M - 1, 1);
    else return AckermanFunction(M - 1, AckermanFunction(M, N - 1));
}

int UserNum1 = ConvertToIntUserMsg("Введите первое число: ");
int UserNum2 = ConvertToIntUserMsg("Введите второе число: ");

Console.WriteLine(AckermanFunction(UserNum1, UserNum2));
