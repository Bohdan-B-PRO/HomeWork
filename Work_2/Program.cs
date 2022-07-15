/* Task 1
int FindSecondNumber(int num)
{
   int number=num/10%10;
   return number;
}


Console.Write("Ввидите трёхзнычное число ");
int number=Convert.ToInt32(Console.ReadLine());
number=FindSecondNumber(number);
Console.Write($"Second number is {number} ");
*/

//Task 2
/*
int FindNumber(int num)
{
    while (num > 999)
    {
        
        num = num / 10;
    }
        if( num<1000&&num>99F)
        {
            int result=num%10;
            return result;
        }

       else
       {
        int num1=-1;
        return num1;
       }
}
    
Console.Write("Ввидите число ");
int number = Convert.ToInt32(Console.ReadLine());

 number = FindNumber(number);

if(number==-1)
{
    Console.WriteLine("Третьего числа нет! ");
}
else
{
    Console.Write($"Third number is {number} ");
}
*/

// Task 3

bool IsWeekendDay(int num)
{
if(num<=7 && num>5 || num<8 ) return true;
else
return false;
}

Console.Write("Выберите день который вас интересует от 1 до 7 ");
int day = Convert.ToInt32(Console.ReadLine());

bool num= IsWeekendDay(day);
if(day<=5)
Console.WriteLine("В этот день нужно поработать! ");
if(day>5 && day<=7)
Console.WriteLine("Сегодня можно отдохнуть! ");
if(day>8) 
Console.WriteLine("Извините, Вы ошиблись, такого дня не существует! ");
