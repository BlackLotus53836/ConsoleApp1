class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите трехзначное число: ");
        int number = int.Parse(Console.ReadLine());

        // Получаем третью цифру числа
        int thirdDigit = (number / 100) % 10;

        if (thirdDigit != 0)
        {
            Console.WriteLine($"Третья цифра числа: {thirdDigit}");
        }
        else
        {
            Console.WriteLine("Третьей цифры нет");
        }
    }
}
