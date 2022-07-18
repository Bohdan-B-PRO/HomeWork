
bool IsPolendrom(int number)
{

    if((number/1000)==((number%10)*10) + (number%100/10)) return true;
    else 
    return false;
}


Console.WriteLine("Ввидите пятизначное число ");
int number=Convert.ToInt32(Console.ReadLine());
bool num=IsPolendrom(number);
Console.WriteLine(num);



/* Task 2 
double Lenth(double xa, double ya, double xb, double yb, double za, double zb)
{
    double Lenth=Math.Sqrt((yb-ya)*(yb-ya)+(xb-xa)*(xb-xa)+(zb-za)*(zb-za));
    return Lenth;
}

Console.Write("Ввидите координаты X точки А ");
double xa=Convert.ToUInt32(Console.ReadLine());
Console.Write("Ввидите координаты Y точки А ");
double ya=Convert.ToUInt32(Console.ReadLine());
Console.Write("Ввидите координаты X точки B ");
double xb=Convert.ToUInt32(Console.ReadLine());
Console.Write("Ввидите координаты Y точки B ");
double yb=Convert.ToUInt32(Console.ReadLine());
Console.Write("Ввидите координаты Z точки А ");
double za=Convert.ToUInt32(Console.ReadLine());
Console.Write("Ввидите координаты Z точки B ");
double zb=Convert.ToUInt32(Console.ReadLine());

double lenth=Lenth(xa,ya,xb,yb,za,zb);
Console.Write($"Растояние между точками А и B  равно {Lenth} ");
*/
/* Task 3
void Cube(int num)
{
    int current=1;
    while(current<=num)
   {
    Console.Write(current*current*current + " ");
    current++;
   }
}

Console.Write("Input intenger number ");
int number=Convert.ToInt32(Console.ReadLine());
Cube(number);
*/



