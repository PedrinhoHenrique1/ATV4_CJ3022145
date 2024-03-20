using System.Numerics;

Console.WriteLine("Digite o número da atividade: ");
int ativ = int.Parse(Console.ReadLine());
switch (ativ)
{
    //Atividade 1
    case 1:
Console.WriteLine("Atividade 1");
Console.WriteLine("Digite um número equivalente a um dia da semana: ");
int dia = int.Parse(Console.ReadLine());

switch (dia)
{
    case 1:
        Console.WriteLine("O número é equivalente a domingo");
        break;
    case 2:
        Console.WriteLine("O número é equivalente a segunda-feira");
        break;
    case 3:
        Console.WriteLine("O número é equivalente a terça-feira");
        break;
    case 4:
        Console.WriteLine("O número é equivalente a quarta-feira");
        break;
    case 5:
        Console.WriteLine("O número é equivalente a quinta-feira");
        break;
    case 6:
        Console.WriteLine("O número é equivalente a sexta-feira");
        break;
    case 7:
        Console.WriteLine("O número é equivalente a sábado");
        break;
}
     break;

    //Atividade 2
    case 2:
Console.WriteLine("Digite o valor total da compra: ");
int tot = int.Parse(Console.ReadLine());
Console.WriteLine("Digite uma opção válida: \n 1 - Dinheiro \n 2 - Pix \n 3 - Débito \n 4 - Crédito");
int opc1 = int.Parse(Console.ReadLine());

switch (opc1)
{
    case 1:
        Console.WriteLine("Você terá direito a um desconto de 15%");
        Console.WriteLine("O sub-total será de: {0}", (tot - tot * 0.15));
        break;
    case 2:
        Console.WriteLine("Você terá direito a um desconto de 5%");
        Console.WriteLine("O sub-total será de: {0}", (tot - tot * 0.10));
        break;
    case 3:
        Console.WriteLine("Você terá um acréscimo de 5%");
        Console.WriteLine("O sub-total será de: {0}", (tot + tot * 0.5));
        break;
    case 4:
        Console.WriteLine("Você terá um acréscimo de 10%");
        Console.WriteLine("O sub-total será de: {0}", (tot + tot * 0.10));
        break;
}
     break;

    //Atividade 3
    case 3
        Console.WriteLine("Digite o número equivalente a um mês do ano: ");
}