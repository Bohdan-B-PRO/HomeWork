/* Task 1
bool IsPolendrom(int number)
{

    if((number/1000)==((number%10)*10) + (number%100/10)) return true;
    else 
    return false;
}


Console.WriteLine("Ввидите пятизначное число ");
int number=Convert.ToInt32(Console.ReadLine());
bool num=IsPolendrom(number);
if(true)
Console.WriteLine("Это число является полиндромом ");
else
Console.WriteLine("Это число не является полиндромо ");
*/


