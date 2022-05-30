double calc_preçototal = 0;
double calc_estoquetotal = 0;
double consu_mediodiario = 0;
double consu_temporepo = 0;
double resultado = 0;
double estoque_min = 0;
double estoque_max = 0;
double estoque_medio = 0;
double estoque_inicial = 0;
double estoque_final = 0;
double estoque_mediano = 0;
int lotes = 0;
int quebrado = 0;
int repete = 0;

Console.Title = "Calculadora de Comércio";

Console.WriteLine("Digite a quantidade de Lotes que você quer calcular");
lotes = int.Parse(Console.ReadLine());
Console.Clear();

double[] valor = new double[lotes +1];
double[] estoque = new double[lotes +1];

///
/// Perguntas para calculo do estoque
///
Console.WriteLine("====================================");
Console.WriteLine("\n");
Console.WriteLine("Digite o Consumo médio diario");
consu_mediodiario = double.Parse(Console.ReadLine());
Console.WriteLine("\n");

Console.WriteLine("Digite o Tempo de reposição");
consu_temporepo = double.Parse(Console.ReadLine());
Console.WriteLine("\n");

Console.WriteLine("Digite o Estoque Inicial");
estoque_inicial = double.Parse(Console.ReadLine());
Console.WriteLine("\n");

Console.WriteLine("Digite o Estoque Final");
estoque_final = double.Parse(Console.ReadLine());
Console.WriteLine("\n");
Console.WriteLine("====================================");

///
/// Cálculo dos estoques
///
//minimo
estoque_min = (consu_mediodiario * consu_temporepo);
//maximo
estoque_max = (estoque_min + 5);
//médio
estoque_medio = (estoque_inicial + estoque_final);
Console.Clear();


for (int i = 0; i <= lotes; i++)
{
    repete++;
    Console.WriteLine("Digite o Estoque do Produto Lote #"+ i);
    estoque[i] = int.Parse(Console.ReadLine());
    Console.Clear();

    Console.WriteLine("Digite o valor do Lote #" + i);
    valor[i] = int.Parse(Console.ReadLine());
    Console.Clear();
    
    //calculo preço total das arrays
    foreach (var a in valor)
    {
        calc_preçototal += a;
    }
    //estoque total
    foreach (var b in estoque)
    {
        calc_estoquetotal += b;
    }
    //calc_preçototal = (valor[0] + valor[1] + valor[2] + valor[3] + valor[4]);
    //calc_estoquetotal = (estoque[0] + estoque[1] + estoque[2] + estoque[3] + estoque[4]);

    estoque_mediano = (calc_estoquetotal / lotes);

    if (estoque_max < calc_estoquetotal)
    {
        Console.WriteLine("Estoque total =" + calc_estoquetotal);
        Console.WriteLine("Valor total =" + calc_preçototal);
        Console.WriteLine("Estq Min =" + estoque_min);
        Console.WriteLine("Estq Max =" + estoque_max);
        Console.WriteLine("Estq Mediano = " + estoque_mediano);
        Console.WriteLine("Estq Med =" + estoque_medio);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("PARA DE COMPRAR, TU VAI FALIR A EMPRESA");
        quebrado = 1;
        Console.ForegroundColor = ConsoleColor.White;
        break;
    }
}

if (quebrado == 0) { 
Console.WriteLine("Estoque total =" + calc_estoquetotal);
Console.WriteLine("Valor total =" + calc_preçototal);
Console.WriteLine("Estq Min = " + estoque_min);
Console.WriteLine("Estq Max = " + estoque_max);
Console.WriteLine("Estq Med = " + estoque_medio);
Console.WriteLine("\n");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Pode comprar mais meu chapa");
Console.ForegroundColor = ConsoleColor.White;
}