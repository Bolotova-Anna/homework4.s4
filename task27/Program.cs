//  Напишите программу, которая принимает на вход число 
//  и выдаёт сумму цифр в числе.
System.Console.WriteLine("введите ваше число");
string number = Console.ReadLine();
int length = number.Length;
int sum = 0;
  for (int i=0; i<length; i++)
 {
      sum = sum + Convert.ToInt32(Convert.ToString(number[i]));
 }
  System.Console.WriteLine(sum);