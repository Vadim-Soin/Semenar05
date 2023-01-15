


void FillArray(decimal[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9,10);
}


void PrintArray(decimal[] array)
{
    for (int i=0;i<array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}


void Distance(decimal[] array)
{
    decimal max = array[0];
    decimal min = array[0];

    for (int i=0; i < array.Length; i++)
        if(max < array[i]) max = array[i];

    for (int i=0; i < array.Length; i++)
        if(min > array[i]) min = array[i]; 

    decimal distance = max - min;
    Console.Write($"{max}  ");
    Console.WriteLine(min);
    Console.WriteLine(distance);
}


decimal[] array = new decimal[10];

FillArray(array);
PrintArray(array);
Distance(array);













