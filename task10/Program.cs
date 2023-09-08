int GetNumber(string mess)
{
    Console.WriteLine($"Введите {mess}");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int num = GetNumber("число");
if (num/100>0&&num/100<10)
{
    Console.WriteLine($"{num/10-(num/100)*10}");
}
else
{
    Console.WriteLine("Недопустимое число");
}