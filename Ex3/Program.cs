Console.WriteLine("Set the size of the array"); 
int a = int.Parse(Console.ReadLine());
Double min, max, sum = 0;

Double[] Array = new Double[a]; 
Random rnd = new Random(); 
for (int i=0; i<a; i++)
{
Array[i] = (rnd.NextDouble()*1000)-500;  // Случайные вещественные числа от -500 до 500 
Console.Write($"{Array[i]} "); 
}

max = Array[0];   // Минимальным/максимальным может оказаться первый элемент массива (нулевой)
min = Array[0];

for (int i=0; i<a; i++) // Прохождение по массиву с целью найти максимум, учитываем возможное равенство элементов
{
if (Array[i] >= max)
max = Array[i];
}

for (int i=0; i<a; i++) // Для минимума 
{
if (Array[i] <= min)
min = Array[i];
}

sum = min + max;

Console.WriteLine(); // Перевод строки для красоты
Console.WriteLine($"Sum of min and max in array = {sum}");