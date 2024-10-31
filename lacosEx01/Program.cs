Console.WriteLine(@$"
----------------------------------------
|         Bem vindo ao programa        |
|              Contador                |
|                 De                   |
|               Pessoas                |
----------------------------------------
");



int QtdMulher = 0;
int QtdHomem = 0;
int QtdGostaEsporte = 0;
int QtdNaoGostaEsporte = 0;
Console.WriteLine($"Quantas pessoas tem na sua mesa?");
int QtdEntrevistados = int.Parse(Console.ReadLine()!);


for (int i = 1; i <= QtdEntrevistados; i++)
{
    Console.WriteLine($"Qual é o seu sexo ? m/f");
    string sexo = Console.ReadLine()!;



    if(sexo == "f"){
        QtdMulher++;
    }else{
        QtdHomem++;
    }

    if (sexo == "f")
    {
    else
    {
    QtdHomem++;    
    }
    }

    Console.WriteLine($"Voce gosta de esportes? s/n");
    string esportes = Console.ReadLine()!;

    if(esportes == "s")
    {
        qtdEsportes++;
    }
    else
    {
        QtdNaoGostaEsporte++;
    }
    float percentual = (100 / qtdDeEntrevistados) * qtdEsportes;
 }
    Console.WriteLine($"Quantidade de Mulheres: {qtdMulher}");
    Console.WriteLine($"Quantidade de Homens: {qtdHomem}");
    Console.WriteLine($"Total de entervistados:{qtdDeEntrevistados}");
    Console.WriteLine($"Total de pessoas que gostam de esportes{qtdEsportes}");
    Console.WriteLine($"Total de pessoas que Nao gostam de esportes {qtdNaoGostaDeEsportes}");
    Console.WriteLine($"Percentual de pessoas que gostam de esportes {percentual}%");