// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
int ConvertToIntUserMsg(string mesage)
{
    Console.Write(mesage);
    return Convert.ToInt32(Console.ReadLine());
}

int AllNaturalNumbers(int num)
{
    {
        if (num == 1) return 1;
        Console.Write($"{num} ");
        return AllNaturalNumbers(num - 1);
    }
}
int UserNum = ConvertToIntUserMsg("Введите число: ");
Console.Write(AllNaturalNumbers(UserNum));
