Console.Clear();
Console.Write("Введите число A: ");
int NumberA = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int NumberB = int.Parse(Console.ReadLine());
int sqr = Convert.ToInt32 (Math.Pow(NumberA, 2));
if (sqr == NumberB)
{
    Console.WriteLine(value: $"Квадрат числа A ({NumberA}) равен числу ({NumberB}) и это Верно");
}
else {Console.WriteLine("не верно");}


