Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 99 && number < 1000)
{
    int a = (number / 10) % 10;
    Console.Write(a);
}

else
{
    Console.Write("Введенно не трёхзначное число");
}

