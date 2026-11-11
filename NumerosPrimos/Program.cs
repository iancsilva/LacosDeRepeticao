Console.WriteLine("Digite um número");
int numero = int.Parse(Console.ReadLine());

for(int p = 0; p <= numero; p++) {

    double raiz = Math.Floor(Math.Sqrt(p));
    bool passaNaoPassa = false;

    for(int n = 2; n <= raiz; n++) {
        if(p % n == 0) passaNaoPassa = true;
    }

    if (!passaNaoPassa && p > 1) Console.WriteLine(p);
}