using System.Net;
//definindo configurações essenciais para uso do algoritmo
Console.Title = "Algoritmo Equação de 2° Grau";
WebClient web = new WebClient();
string logo_msg = web.DownloadString("https://pastebin.com/raw/iGF6Ex0C");
string resultado_msg = web.DownloadString("https://pastebin.com/raw/bRL3LYfF");
double resposta1 = 0;
double resposta2 = 0;
double resposta3 = 0;
double resultado = 0;
double resultado2 = 0;
Console.WriteLine("Carregado!");

//inicio e perguntas ao usuario
void Inicio() {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(logo_msg);
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine("    ");
    Console.WriteLine("    ");
    Console.WriteLine("Algoritmo - Calculadora de Equação 2° Grau");
    Console.WriteLine("========================================");
    Console.WriteLine("    ");
    Console.WriteLine("DELTA = b² - 4 * a * c");
    Console.WriteLine("    ");
    Console.WriteLine("========================================");
    Console.WriteLine("    ");

    //pegando valores para realizar conta

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Digite o Valor A");
    resposta2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Digite o Valor B²");
    resposta1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Digite o Valor C");
    resposta3 = Convert.ToDouble(Console.ReadLine());

    if(resposta1 == 0 || resposta2 == 0 || resposta3 == 0)
    {
        Console.WriteLine("Erro!");
        Console.ReadKey();
        Console.Clear();
        Inicio();

    }
    user_resultado();
}
void user_resultado(){ 

    //calculo negativo
    resultado = (Math.Pow(resposta1, 2) - 4 * resposta2 * resposta3);
    //calculo positivo
    resultado2 = (Math.Pow(resposta1, 2) + 4 * resposta2 * resposta3);

    Console.Clear();

    //mostrando resultado
    Console.WriteLine(resultado_msg);
    Console.WriteLine("========================================");
    Console.WriteLine("Negativo: DELTA = " + resposta1 + "² - 4 * " + resposta2 + " * " + resposta3);
    Console.WriteLine("Positivo: DELTA = " + resposta1 + "² + 4 * " + resposta2 + " * " + resposta3);
    Console.WriteLine("    ");
    Console.WriteLine("Resultado Negativo é: " + resultado);
    Console.WriteLine("Resultado Positivo é: " + resultado2);
    Console.WriteLine("========================================");

    //voltando para o começo
    Console.ReadKey();
    Console.Clear();
    Inicio();
}

//voltando para o começo
Console.Clear();
Inicio();

