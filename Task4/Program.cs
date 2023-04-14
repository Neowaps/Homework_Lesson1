System.Console.Write("Введите первое число: ");
string textA = Console.ReadLine();
int numberA = Convert.ToInt32(textA);
System.Console.Write("Введите второе число: ");
string textB = Console.ReadLine();
int numberB = Convert.ToInt32(textB);
System.Console.Write("Введите третье число: ");
string textC = Console.ReadLine();
int numberC = Convert.ToInt32(textC);
int max = Convert.ToInt32(textA);


if (numberA >= numberB & numberA >= numberC)
{
    max = numberA;
}
if (numberB >= numberA & numberB >= numberC)
{
    max = numberB;
}
if (numberC >= numberA & numberC >= numberB)
{
    max = numberC;
}
System.Console.WriteLine("Максимальным из предоставленных чисел является: " + max);
