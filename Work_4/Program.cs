﻿//Task2
/*
int SumOfNumber(int num)
{
    int count = 0;
    while(num != 0)
    {
        num/=10;
        count++;
    }
    return count; 
}

Console.Write("Ввидите целое число ");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumOfNumber(number);

Console.WriteLine($"Сумма цыфр из числа {number} будет {result} ");
*/
//TAsk 3

int[]GenerationRandomArray(int size, int minValue, int maxValue)  //Метод для генирации массива с случайными числами
{
    int[] newArray= new int[size];

    for(int i = 0; i < size; i++)
    {
       newArray[i] = new Random().Next(minValue, maxValue + 1); 
    }
   
    return newArray;
}

int[] GenerationArray( int size)  //Метод для генирации массива с запрашиваем у пользователя!

{
    int[] newArray= new int[size];
    
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i+1} element of {size}: ");
        newArray[i]=Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}

void PrintArray(int [] array)  //Метод для вывода массива!
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        Console.WriteLine();
    }
}

int[]array= GenerationArray(8);
PrintArray(array);


/*
int SumOfPositive(int []array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++);
    if(array[i] > 0) sum += array[i];

}
*/