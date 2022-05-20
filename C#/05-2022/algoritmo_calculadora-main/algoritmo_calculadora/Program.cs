using System.Net;

//Config. Initial
Console.Title = "Calculadora - Algoritmo Somar, Subtrair e Multiplicar";
Console.WriteLine("Carregando...");

//Vars
double valor_1 = 0;
double valor_2 = 0;
double valor_3 = 0;
double resposta = 0;
string user_resp = string.Empty;
WebClient web = new WebClient();
string logo = web.DownloadString("https://pastebin.com/raw/6BgRhdfW");

Console.WriteLine("Carregado!");
//Funções
void calc_somar()
{
    Console.Clear();
    Console.WriteLine("Somando...");
    resposta = (valor_1 + valor_2);

    Console.WriteLine(valor_1 + "+" + valor_2);
    Console.WriteLine("Resultado é: " + resposta);

}
void calc_subtrair()
{
    Console.Clear();
    Console.WriteLine("Subtraindo...");
    resposta = (valor_1 - valor_2);

    Console.WriteLine(valor_1 + "-" + valor_2);
    Console.WriteLine("Resultado é: " + resposta);
}
void calc_multiplicar()
{
    Console.Clear();
    Console.WriteLine("Multiplicando...");
    resposta = (valor_1 * valor_2);

    Console.WriteLine(valor_1 + "*" + valor_2);
    Console.WriteLine("Resultado é: " + resposta);
}
void calc_divisao()
{
    Console.Clear();
    Console.WriteLine("Dividindo...");
    resposta = (valor_1 / valor_2);

    Console.WriteLine(valor_1 + "/" + valor_2);
    Console.WriteLine("Resultado é: " + resposta);
}
void calc_equc2grau()
{
    Console.Clear();
    Console.WriteLine("Digite o valor de C");
    valor_3 = Double.Parse(Console.ReadLine());
    Console.WriteLine("Calculando...");
    double resposta2 = 0;
    resposta = (Math.Pow(valor_1, 2) + 4 * valor_2 * valor_3);
    resposta2 = (Math.Pow(valor_1, 2) - 4 * valor_2 * valor_3);

    Console.WriteLine("Positivo: DELTA = " + valor_1 + "² + 4 * " + valor_2 + " * " + valor_3);
    Console.WriteLine("Negativo: DELTA = " + valor_1 + "² - 4 * " + valor_2 + " * " + valor_3);
    Console.WriteLine("\n");
    Console.WriteLine("Resultado Positivo é: " + resposta);
    Console.WriteLine("Resultado Negativo é: " + resposta2);

}
void calc_porcentagem()
{
    Console.Clear();
    Console.WriteLine("Calculando...");
    double calc_number = valor_1;
    valor_1 = (valor_1 / 100);
    resposta = (valor_2 * valor_1);

    Console.WriteLine(calc_number + " % de " + valor_2);
    Console.WriteLine("Resultado é: " + resposta);
}
void user_menu()
{
    Console.Clear();
    Console.WriteLine("\n");
    Console.WriteLine(logo);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("[1] Somar        | [6] Porcentagem");
    Console.WriteLine("[2] Subtrair     | [0] Sair");
    Console.WriteLine("[3] Multiplicar");
    Console.WriteLine("[4] Divisão");
    Console.WriteLine("[5] Equação 2° Grau");
    Console.ForegroundColor= ConsoleColor.White;
    user_resp = Console.ReadLine();
    
    user_ask(user_resp);

    switch (user_resp)
    {
        case "0":
            Environment.Exit(0);
            break;
        case "1":
            calc_somar();
            break;

        case "2":
            calc_subtrair();
            break;
        case "3":
            calc_multiplicar();
            break;
        case "4":
            calc_divisao();
            break;
        case "6":
            calc_porcentagem();
            break;
        default:
            Console.WriteLine("Opção Invalida");
            break;
    }

}
void user_ask(string conta)
{
    Console.Clear();
    switch (conta)
    {
        case "6":
            Console.WriteLine("Digite o Primeiro valor (%)");
            valor_1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Segundo valor");
            valor_2 = Double.Parse(Console.ReadLine());
            break;
        default:
            Console.WriteLine("Digite o Primeiro valor");
            valor_1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Segundo valor");
            valor_2 = Double.Parse(Console.ReadLine());
            break;
    }

}

//Loader
user_menu();
Console.WriteLine("Pressione qualquer tecla para continuar...");
Console.ReadKey();
user_menu();