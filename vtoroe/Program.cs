//Напишите программу, которая принимает 
// на вход три числа и выдаёт максимальное из этих чисел.

int x;
Console.WriteLine("Введи первое - ");
x = Convert.ToInt32(Console.ReadLine());

int y;
Console.WriteLine("Введи второе теперь - ");
y = Convert.ToInt32(Console.ReadLine());

int z;
Console.WriteLine("Введите третье - ");
z = Convert.ToInt32(Console.ReadLine());

int max;
max= x;

if(x<y)
{
    max = y;
    if(y<z)
    {
        max = z;
    }
}
else
{
    max = x;
    if(x<z)
    {
        max = z;
    }
    else 
    {
        max = x;
    }
}
Console.WriteLine(max);