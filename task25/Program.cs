// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B
int Read (string text1)
{
    System.Console.WriteLine(text1);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}
int NumberInNumber (int number1, int number2)
{
    int result =1;
    for (int i = 1; i <= number2; i++)
{
    result =result*number1;
}
return result;
}
int A = Read("Введите число А");
int B = Read("Введите число B");
System.Console.WriteLine(NumberInNumber(A, B));


