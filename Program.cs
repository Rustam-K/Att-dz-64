   Console.Write("Введите значение M: ");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите значение N: ");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Чётные числа от {m} до {n}:");
    evenNumbers(m, n); -m

void evenNumbers(int start, int end)
{
        if (start > end)
    {
        return;
    }
    if (start % 2 == 0)
    {
        Console.WriteLine(start);
    }

 
    evenNumbers(start + 1, end);
}
