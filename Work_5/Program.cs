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
/*
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
*/


//Task3
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
int DifferenceMinMaxElementsArray( int[]array,int min, int max) 

{    
    int result = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
        result = max - min;
    }
    return result;
}


int[] result = GenerationRandomArray(4, 1, 100);
DifferenceMinMaxElementsArray(result);

Console.WriteLine($"Differentce  between minmum and maximum elements of array{result}");
*/