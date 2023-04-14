System.Console.Write("Введите первое число: ");
string textA = Console.ReadLine();
int numberA = Convert.ToInt32(textA);
System.Console.Write("Введите второе число: ");
string textB = Console.ReadLine();
int numberB = Convert.ToInt32(textB);

if (numberA > numberB)
{
    System.Console.WriteLine("Число " + numberA + " больше, чем число " + numberB);
}
else
{
    System.Console.WriteLine("Число " + numberB + " больше, чем число " + numberA);
}
