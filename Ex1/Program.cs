Console.WriteLine("Set the size of the array"); 
int a = int.Parse(Console.ReadLine());
int counter = 0;

int[] Array = new int[a]; 
Random rnd = new Random(); 
for (int i=0; i<a; i++)
{
Array[i] = rnd.Next(1,999);  // Случайные положительные трехзначные
Console.Write($"{Array[i]} "); 
}
for (int i=0; i<a; i++)
{
 if (Array[i]%2 == 0)
 {
    counter++;
 }
}
Console.WriteLine(); // Перевод строки для красоты
Console.WriteLine($"Number of even in array is {counter}");