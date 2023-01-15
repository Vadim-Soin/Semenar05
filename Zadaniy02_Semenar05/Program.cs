

void FillArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-99,100);
}


void Summ(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i+2) sum+= array[i];
    Console.WriteLine(sum);
}


void PrintArray(int [] array)
{
    for (int i=0;i<array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}


int[] array = new int[10];
FillArray(array);
PrintArray(array);
Summ(array);








