int nota1 = 0;
int nota2 = 0;
int nota3 = 0;

int nota_final = 0;

string nome = string.Empty;


System.Net.WebClient cliente = new System.Net.WebClient();
string logo_stng = cliente.DownloadString("https://pastebin.com/raw/CdSAf3Fg");

string LOGO = logo_stng;

Console.Title = "Calculadora de Notas de ALUNO";

Console.WriteLine(LOGO);

Console.WriteLine("");

Console.WriteLine("Digite o Nome do Aluno");
nome = Console.ReadLine();

Console.Clear();

Console.WriteLine(LOGO);
Console.WriteLine(nome + " - Nota de Prova Dissertativa");
int nota1_escolha = int.Parse(Console.ReadLine());
nota1 = nota1_escolha;

Console.Clear();

Console.WriteLine(LOGO);
Console.WriteLine(nome + " - Nota de Prova Prática");
int nota2_escolha = int.Parse(Console.ReadLine());
nota2 = nota2_escolha;

Console.Clear();

Console.WriteLine(LOGO);
Console.WriteLine(nome + " - Nota do Seminario");
int nota3_escolha = int.Parse(Console.ReadLine());
nota3 = nota3_escolha;

Console.Clear();

Console.WriteLine(LOGO);
Console.WriteLine("Calculando Resultado do Aluno...");
System.Threading.Thread.Sleep(1000);



int calculo_final = 0;
nota_final = (int)Math.Round((nota1_escolha * 0.5) + (nota2_escolha * 0.4) + (nota3_escolha * 0.1));

Console.Clear();

Console.WriteLine(LOGO);

Console.WriteLine("Nota Final do Aluno " + nome);
Console.WriteLine("Nota: " + nota_final);


if (nota_final >= 9)
{
    Console.WriteLine("Aluno tirou MB");
}
else
{
    if(nota_final >= 7)
    {
        Console.WriteLine("Aluno tirou B");
    }
    else
    {
        if (nota_final >= 6)
        {
            Console.WriteLine("Aluno tirou R");
        }
        else
        {
            if(nota_final <= 6)
            {
            Console.WriteLine("Aluno tirou I");
            }
        }
    }
}
Console.WriteLine(" ");
Console.Read();
