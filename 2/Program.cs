Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int a;

if(number > 99 && number < 1000)
{
    a = (number / 10) % 10;
    Console.Write(a);
}

else if(number > 999 && number < 10000)
{
    a = (number / 10) % 10;
    Console.Write(a);
}

else if(number > 9999 && number < 100000)
{
    a = (number / 100) % 10;
    Console.Write(a);
}

else if(number < 99)
{
    Console.Write("Нету третьей цифры");
}

else if(number > 100000)
{
    Console.Write("Ошибка");
}