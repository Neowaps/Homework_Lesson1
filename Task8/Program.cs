System.Console.Write("Введите число: ");
string textN = Console.ReadLine();
int numberN = Convert.ToInt32(textN);
int index = 2;


if (numberN<2)
{
    System.Console.WriteLine("Ошибка, введённое вами число не содержит в себе положительных чётных чисел.");
}
else
{

    System.Console.Write("Вот все чётные числа от 1 до вашего заданного числа: ");
    while(index<=numberN)
{
        System.Console.Write(index + " ");
        index = index+2;
}
}
