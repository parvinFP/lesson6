// See https://aka.ms/new-console-template for more information
int num = Convert.ToInt32(Console.ReadLine());
string cavab;
cavab = "sade";
if (num == 1)
{
    cavab = "ne murekkebdir ne de ki sade";
}
for (int i = 2; i < num; i++)
{


    if (num % i == 0)

    {
        cavab = "murekkeb";

        break;
    }


}
Console.WriteLine(cavab);
