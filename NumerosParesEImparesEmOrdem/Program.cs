Console.WriteLine("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

for(int p = 0; p <= numero; p++)
{
    if(p % 2 == 0) Console.WriteLine(p);
}
Console.WriteLine("-------------------------");
for (int i = numero; i >= 0; i--)
{
    if (i % 2 == 1) Console.WriteLine(i);
}
