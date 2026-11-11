Console.WriteLine("Digite um número inteiro");
int numero = int.Parse(Console.ReadLine());

int penultimoNumero = 0;

int ultimoNumero = 1;

int numeroAtual = 0;

for (int posicao = 0; posicao <= numero; posicao++) {

    numeroAtual = penultimoNumero + ultimoNumero;
    penultimoNumero = ultimoNumero;
    ultimoNumero = numeroAtual;

    Console.WriteLine(numeroAtual);
}