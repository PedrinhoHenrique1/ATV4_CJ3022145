Console.WriteLine("Escolha uma das seguintes opções: \n 1 - Débito \n 2 - Crédito \n 3 - Pix \n 4 - Boleto \n 5 - Transferência bancária");
int opc = int.Parse(Console.ReadLine());

switch (opc)
{
    case 1:
        Console.WriteLine("O pagamento será feito em débito");
        break;
    case 2:
        Console.WriteLine("O pagamento será feito no crédito");
        Console.WriteLine("Haverá um acréscimo de 5%");
        break;
    case 3:
        Console.WriteLine("O pagamento será feito no pix");
        Console.WriteLine("Haverá um desconto de 5%");
        break;
    case 4:
        Console.WriteLine("O pagamento será feito no boleto");
        Console.WriteLine("Haverá um acréscimo de 5%");
        break;
    case 5:
        Console.WriteLine("O pagamento será feito com transferência bancária");
        break;
}