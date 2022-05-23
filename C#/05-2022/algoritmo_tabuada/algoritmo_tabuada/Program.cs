Console.Title = "Algoritmo Tabuada";

int num_mulcador = 0;
int num_fator = 0;
int produto = 0;
int num_inicial = 0;
string resposta = string.Empty; 

void calcular() { 
    Console.WriteLine("Digite a tabuada que desejas meu caro");
    Console.WriteLine("\n");
    num_mulcador = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite até quanto você quer ("+ num_mulcador + " x B)");
    Console.WriteLine("\n");
    num_inicial = int.Parse(Console.ReadLine());

    num_fator = num_inicial;

for (int i = 0; i <= num_inicial; i++)
{

    produto = (num_mulcador * i);
    Console.WriteLine(num_mulcador + "*" + i + "=" + produto);
    num_fator++;

}

    Console.WriteLine("Deseja fazer mais contas? (S/N)");
    Console.WriteLine("\n");
    resposta = Console.ReadLine();

}

calcular();

if (resposta == "S")
{
    Console.Clear();
    calcular();
}
else
{
    Environment.Exit(1);
}
