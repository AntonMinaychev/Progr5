Console.WriteLine("Set the size of the array"); 
int a = int.Parse(Console.ReadLine());
int sum = 0;

int[] Array = new int[a]; 
Random rnd = new Random(); 
for (int i=0; i<a; i++)
{
Array[i] = rnd.Next(-500,500);  // Случайные числа от -500 до 500
Console.Write($"{Array[i]} "); 
}
for (int i=0; i<a; i++)
{
 if (i%2 == 0)
 sum = sum + Array[i]; // В массиве i с 0, т.е. i++ после for - это фактически второй член массива
}
Console.WriteLine(); // Перевод строки для красоты
Console.WriteLine($"Sum of odd in array is {sum}");