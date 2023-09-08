int GetNumber(string mess)
{
    Console.WriteLine($"Введите {mess}");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int day = GetNumber("номер дня");
if (day<8)
{
    switch (day)
    {
        case 6:
            Console.WriteLine("Да");
            break;
        case 7:
            Console.WriteLine("Да");
         break;
        default:
        Console.WriteLine("Нет");
        break;
    }
}
else
{
    Console.WriteLine("Неверное число");
}