Console.Title = "Jorge's Market";
string nome = Super_Mercado.Properties.Resources.atendente;

//Preço Por KG
double pkg_mussarela = 22.6;
double pkg_mortadela = 8.98;
double pkg_presunto = 31.03;
double pkg_pdeperu = 58.90;

//Porcentagem de comissão
double prnt_mussarela = 0.05;
double prnt_mortadela = 0.065;
double prnt_presunto = 0.045;
double prnt_pdeperu = 0.025;
string prnt_mussarela2 = "5%";
string prnt_mortadela2 = "6.5%";
string prnt_presunto2 = "4.5%";
string prnt_pdeperu2 = "2.5%";

//Quantidade que o cliente comprou
double qnt_mussarela = 0;
double qnt_mortadela = 0;
double qnt_presunto = 0;
double qnt_pdeperu = 0;

//Salvar aliquota
double a_mussarela = 0;
double a_mortadela = 0;
double a_presunto = 0;
double a_pdeperu = 0;

//Salvar total
double total_mussarela = 0;
double total_mortadela = 0;
double total_presunto = 0;
double total_pdeperu = 0;

double final = 0;
double final_kg = 0;
string escolha = " ";

System.Net.WebClient TOPTOP = new System.Net.WebClient();
string logo_stng = TOPTOP.DownloadString("https://pastebin.com/raw/0rJrsKPr");
Menu:
escolha = String.Empty;

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine(logo_stng);
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("1. Calcular");
Console.WriteLine("2. Atendente");
escolha = Console.ReadLine();
Console.Clear();

if (escolha == "1")
{
    /// após
    Console.WriteLine(logo_stng);
    Console.WriteLine("Quantidade de MUSSARELA");
    qnt_mussarela = double.Parse(Console.ReadLine());
    Console.Clear();

    Console.WriteLine(logo_stng);
    Console.WriteLine("Quantidade de MORTADELA");
    qnt_mortadela = double.Parse(Console.ReadLine());
    Console.Clear();

    Console.WriteLine(logo_stng);
    Console.WriteLine("Quantidade de PRESUNTO");
    qnt_presunto = double.Parse(Console.ReadLine());
    Console.Clear();

    Console.WriteLine(logo_stng);
    Console.WriteLine("Quantidade de PEITO DE PERU");
    qnt_pdeperu = double.Parse(Console.ReadLine());
    Console.Clear();


    //calcular preço por kilo por qntidade
    a_mussarela = (pkg_mussarela * qnt_mussarela);
    a_mortadela = (pkg_mortadela * qnt_mortadela);
    a_presunto = (pkg_presunto * qnt_presunto);
    a_pdeperu = (pkg_pdeperu * qnt_pdeperu);

    //calcular comissão com a_item
    total_mussarela = (a_mussarela * prnt_mussarela);
    total_mortadela = (a_mortadela * prnt_mortadela);
    total_presunto = (a_presunto * prnt_presunto);
    total_pdeperu = (a_pdeperu * prnt_pdeperu);

    final = (total_mortadela + total_mussarela + total_pdeperu + total_presunto);
    final_kg = (a_mortadela + a_mussarela + a_pdeperu + a_presunto);

    Console.WriteLine(logo_stng);
    Console.WriteLine(nome);
    Console.WriteLine("Você vendeu:");
    Console.WriteLine("------------------------------------------------------------------------");
    Console.WriteLine(qnt_mussarela + "kg de mussarela" + "| " + prnt_mussarela2 + " de comissão |" + " PREÇO P/KG: R$" + pkg_mussarela);
    Console.WriteLine(qnt_mortadela + "kg de mortadela | " + prnt_mortadela2 + " de comissão |" + " PREÇO P/KG: R$" + pkg_mortadela);
    Console.WriteLine(qnt_presunto + "kg de presunto | " + prnt_presunto2 + " de comissão |" + " PREÇO P/KG: R$" + pkg_presunto);
    Console.WriteLine(qnt_pdeperu + "kg de Peito de Peru | " + prnt_pdeperu2 + " de comissão |" + " PREÇO P/KG: R$" + pkg_pdeperu);
    Console.WriteLine("------------------------------------------------------------------------");
    Console.WriteLine(" ");
    Console.WriteLine("No total você lucrou: R$" + final);
    Console.Read();
    Console.Clear();
    escolha = String.Empty;
    goto Menu;
}
else if (escolha == "2")
{
    Console.WriteLine("Nome do Atendente?");
    nome = Console.ReadLine();
    Console.Clear();
    escolha = String.Empty;
    goto Menu;
}
else
{
    Console.Clear();
    escolha = String.Empty;
    goto Menu;
}