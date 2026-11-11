int contador = 10;

while(contador > 0) {
    Console.WriteLine(contador);
    contador--;
    Thread.Sleep(1000);
}
Console.WriteLine("Yeaaah, a Terra completou mais uma volta no Sol!");


do {
    contador++;
    Console.WriteLine(contador);
    Thread.Sleep(1000);
} while (contador < 10);

Console.WriteLine("Yeaaah, faz 10 segundos que a Terra completou mais uma volta no Sol!");

for (int contador2 = 1; contador2 <= 10; contador2++) {
    Console.WriteLine(contador2);
    Thread.Sleep(1000);
}

Console.WriteLine("Yeaaah, faz 20 segundos que a Terra completou mais uma volta no Sol!");