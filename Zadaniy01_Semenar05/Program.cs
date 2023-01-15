
void FillArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100,1000);
}

void NumberArray(int[] array)
{
    int count = 0;
    for (int i=0; i<array.Length;i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    Console.WriteLine(count);
}


void PrintArray(int [] array)
{
    for (int i=0;i<array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}



Console.WriteLine("Введите длину масива");
int n =Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

FillArray(array);
PrintArray(array);
NumberArray(array);







