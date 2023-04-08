Console.WriteLine("Add firstnumber:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Add secondnumber:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Add thirdnumber:");
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (a > b)
{
    max = a;
}
if (b > a)
{
    max = b;
}
if (c > a)
{
   max = c; 
}
Console.WriteLine("max = " + max);