//  Напишите программу, которая принимает на вход число 
//  и выдаёт сумму цифр в числе.
string Read (string text)
{
    System.Console.WriteLine(text);
    return Console.ReadLine();
}
// замененный кусок System.Console.WriteLine("введите ваше число");
// string number = Console.ReadLine();
int Sum (string number)
{
    int length = number.Length;
    int sum = 0;
  for (int i=0; i<length; i++)
 {
      sum = sum + Convert.ToInt32(Convert.ToString(number[i]));
 }
 return sum;
}
// замененный кусок int length = number.Length;
// int sum = 0;
//   for (int i=0; i<length; i++)
//  {
//       sum = sum + Convert.ToInt32(Convert.ToString(number[i]));
//  }

string number = Read ("введите ваше число");
System.Console.WriteLine(Sum(number));
