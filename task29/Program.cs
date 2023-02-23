// Напишите программу, которая 
// задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] Ourarray = new int [8];
void FillArray (int[]array) 
{
    int length = array.Length;
    for (int i = 0; i<length; i++)
    {
        System.Console.WriteLine("введите число");
        array[i]=int.Parse(Console.ReadLine());
    }
}
void PrintArray (int[]array)
{
    int length = array.Length;
    for (int i = 0; i<length; i++)
    {
        System.Console.Write(array[i]);
    }
}
FillArray (Ourarray);
PrintArray (Ourarray);