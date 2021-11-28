// See https://aka.ms/new-console-template for more information
int num = 562;
int num1 = 0;
int sum = 0;
while (num > 0)
{
    num1 = num % 10;
    num = num / 10;
    sum = sum + num1;



}
Console.WriteLine(sum);
