Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 7 == 0 && number % 23 == 0)
{
    Console.Write("Да, число кратное одновременно 7 и 23");
}

else
{
    Console.Write("Нет, число не кратное одновременно 7 и 23");
}