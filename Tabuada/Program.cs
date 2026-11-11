Console.WriteLine("Digite um número para ver a tabuada do 1 ao 10: ");
int numero = int.Parse(Console.ReadLine());

for (int multiplicador = 1; multiplicador <= 10; multiplicador++) {
    int resultado = numero * multiplicador;
    Console.WriteLine(numero + "X" + multiplicador + "=" + resultado);
}