Console.WriteLine("Введите x");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите y");
double y = Convert.ToDouble(Console.ReadLine());
if (y >= 0 && x >= 0 && y <= 6 - x|| y <= 0 && x <= 0 && y >= -6 - x)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}
