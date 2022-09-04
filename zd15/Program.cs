Console.WriteLine("Введите день недели (от 1 до 7)");
int num = int.Parse(Console.ReadLine());

if ((num == 6) | (num == 7))
{
    Console.WriteLine("ДА");
}
else Console.WriteLine("НЕТ");
