// Task 1
/*
int[]GenerationRandomArray(int size, int minValue, int maxValue)  
{
    int[] newArray= new int[size];

    for(int i = 0; i < size; i++)
    {
       newArray[i] = new Random().Next(minValue, maxValue + 1); 
    }
   
    return newArray;
}

void PowerArray(int []array)
{
int result = 0;
for (int i = 0; i < array.Length; i++)
if (array[i] % 2 == 0)
    result+=array[i];
{
Console.WriteLine($"Всего {array.Length} чисел,  сумма чётных {result} ");
}

}

int[]array = GenerationRandomArray(4, 100, 1000);
PowerArray(array);
*/

//Task 2
int[]GenerationRandomArray(int size, int minValue, int maxValue)  
{
    int[] newArray= new int[size];

    for(int i = 0; i < size; i++)
    {
       newArray[i] = new Random().Next(minValue, maxValue + 1); 
    }
   
    return newArray;
}

void PowerArray(int []array)
{
int result = 0;
for (int i = 0; i < array.Length; i++)
if (array[i] % 2 != 0)
    result+=array[i];
{
Console.WriteLine($"Всего {array.Length} чисел, из них сумма нечётных {result} ");
}

}

int[]array = GenerationRandomArray(4, 100, 1000);
PowerArray(array);




//Task3
/*
int[] CreateArray( int[] array, int size, int min, int max) 

{
    int[] newArray= new int[size];
    
    for(int i = 0; i < size; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
        Console.Write($"Input {i+1} element of {size}: ");
        newArray[i]=Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}

*/

