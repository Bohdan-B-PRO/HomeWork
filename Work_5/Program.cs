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

int DifferenceMinMaxElementsArray( int[]array, int size, int min, int max) 

{
    
    int result = 0;
    Random rand = new Random();
    double number = rand.Next(1,100) + rand.NextDouble();   
    for(int i = 0; i < size; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
        result = max - min;
    }
    return result;
}


int result = DifferenceMinMaxElementsArray(10, 22, 100);

Console.WriteLine($"Differentce  between minmum and maximum elements of array{result}");
*/

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

int CreateArray(int[]array)
{
    int min = 1;
    int max =;
    int result = 0;

    for(int i = 0; i < array.Length; i++)
    {
       if(array[i] > max) max = array[i];
       if(array[i] < min) min = array[i];
    
      result= max-min;
      
    }
    return result;
}



Console.Write("Input min number of element  ");
int min= Convert.ToInt32(Console.ReadLine());

Console.Write("Input max number of element ");
int max= Convert.ToInt32(Console.ReadLine());
int[]array =CreateArray(min, max);
*/



