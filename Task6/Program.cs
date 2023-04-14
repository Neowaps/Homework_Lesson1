System.Console.Write("Введите число: ");
string text = Console.ReadLine();
int number = Convert.ToInt32(text);

double even = number % 2;
if (even == 0)
{
    System.Console.WriteLine("Число " + number + " является чётным");
}
else
{
    System.Console.WriteLine("Число " + number + " является нечётным");
}
