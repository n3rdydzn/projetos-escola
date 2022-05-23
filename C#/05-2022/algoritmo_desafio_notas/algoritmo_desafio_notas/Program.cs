Console.Title = "Desafio - Calculadora Notas";

double[] notas = new double[] {0, 0, 0, 0, 0};

double resultado = 0;

int notita = 0;

for (int i = 0; i <= 4; i++)
{
    notita++;
    Console.WriteLine("Digite a Nota " + notita);
    notas[i] = int.Parse(Console.ReadLine());
}

resultado = ((notas[0] + notas[1] + notas[2] + notas[3] + notas[4])/5);
Console.WriteLine("A Média do aluno foi: " + resultado);