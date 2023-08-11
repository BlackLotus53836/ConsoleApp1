class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите номер дня недели (1-7): ");
        int dayOfWeek = int.Parse(Console.ReadLine());

        if (IsWeekend(dayOfWeek))
        {
            Console.WriteLine("Этот день является выходным");
        }
        else
        {
            Console.WriteLine("Этот день не является выходным");
        }
    }

    static bool IsWeekend(int dayOfWeek)
    {
        // Проверяем, является ли день недели выходным (суббота или воскресенье)
        if (dayOfWeek == 6 || dayOfWeek == 7)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
