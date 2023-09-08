Console.WriteLine("Введите число");
string mess = Console.ReadLine();
int len = mess.Length;
int num = Convert.ToInt32(mess);

int GetDig (int num, int len)
{
    int newN=num;
    if(len>3)
    {
        newN = num/(Convert.ToInt32(Math.Pow(10, (len-3))));
    }
    int dig = (newN%100)%10;
    return dig;
}

if (num/100>0)
{
    int dig = GetDig(num, len);
    Console.WriteLine($"{dig}");
}
else
{
    Console.WriteLine("Такой цифры нет");
}
