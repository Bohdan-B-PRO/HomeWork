//Task 1
/*
int InputNumbers(int m)
{
    int sum = 0;
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введи {i+1} число: ");
    Convert.ToInt32(Console.ReadLine());
  }
  return sum;
}
Console.Write($"Введи число М: ");
int m = Convert.ToInt32(Console.ReadLine());
InputNumbers(m);
Console.Write($"Количество чисел после нуля {m} ");
*/
//Task 2
void  LineIntersection( int b1, int k1, int b2, int k2)
{
  int x= 0;
  int y = 0;
  x = (b2 - b1) / (k1 - k2);
  y = k1 * (b2 - b1) / (k1 - k2) + b1;
 //Console.Write(x,y);
}

Console.WriteLine("Ввидите координаты b1 ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввидите координаты k1 ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввидите координаты b2 ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввидите координаты k2 ");
int k2 = Convert.ToInt32(Console.ReadLine());
LineIntersection(b1, k1, b2, k2);


Console.Write("Координаты пересечения точе x,y " + LineIntersection );

