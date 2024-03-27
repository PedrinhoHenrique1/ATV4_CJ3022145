Console.WriteLine("Digite o número da atividade que executar: ");
int ativ = int.Parse(Console.ReadLine());

switch (ativ)
{

    // Exercício 1 
    case 1:
        int semana;

        Console.WriteLine("Escolha um número referente a um dia da semana: ");
        semana = int.Parse(Console.ReadLine());
        switch (semana)
        {
            case 1:
                Console.WriteLine("Domingo");
                break;

            case 2:
                Console.WriteLine("Segunda-Feira");

                break;

            case 3:
                Console.WriteLine("Terça-Feira");
                break;

            case 4:
                Console.WriteLine("Quart-Feira");
                break;

            case 5:
                Console.WriteLine("Quinta-Feira");
                break;

            case 6:
                Console.WriteLine("Sexta-Feira");
                break;

            case 7:
                Console.WriteLine("Sábado");
                break;
        }
        break;

    //Exercício 2
    case 2:
        float compra, atv2, descon, acresci;

        Console.WriteLine("Digite o valor de compra");
        compra = float.Parse(Console.ReadLine());
        Console.WriteLine("Qual o método deseja aplicar");
        Console.WriteLine("1- Dinheiro 2- Pix 3- Débito 4- Crédito");
        atv2 = float.Parse(Console.ReadLine());
        switch (atv2)
        {
            case 1:
                descon = ((compra * 0.15f) - compra);
                Console.WriteLine("O total a ser pago é de {0}", descon);
                break;

            case 2:
                descon = ((compra * 0.10f) - compra);
                Console.WriteLine("O total a ser pago é de {0}", descon);
                break;

            case 3:
                acresci = ((compra * 0.5f) + compra);
                Console.WriteLine("O total a ser pago é de {0}", acresci);
                break;

            case 4:
                acresci = ((compra * 0.10f) + compra);
                Console.WriteLine("o total a ser pago é de {0}", acresci);
                break;

            default:
                Console.WriteLine("Não há essa opção");
                break;

        }
        break;

    // Exercício 3
    case 3:
        int mes, fevereiro;
        Console.WriteLine("Olá, bem vindo!");
        Console.WriteLine("1- Janeiro 2- Fevereiro 3- Março 4- Abril 5- Maio 6- Junho 7- Julho 8- Agosto 9- Setembro 10- Outubro 11- Novembro      12- Dezembro");
        mes = int.Parse(Console.ReadLine());
        switch (mes)
        {

            case 1:
                Console.WriteLine("Janeiro, trinta e um dias");
                break;

            case 2:
                Console.WriteLine("Insira o ano em que estamos");
                fevereiro = int.Parse(Console.ReadLine());
                if (fevereiro % 4 == 0)
                {
                    Console.WriteLine("Fevereiro, vinte e nove dias");

                }
                else
                {
                    Console.WriteLine("Fevereiro, vinte e oito dias");
                }
                break;

            case 3:
                Console.WriteLine("Março, trinta e um dias");
                break;

            case 4:
                Console.WriteLine("Abril, trinta dias");
                break;

            case 5:
                Console.WriteLine("Maio, trinta e um dias");
                break;

            case 6:
                Console.WriteLine("Junho, trinta dias");
                break;

            case 7:
                Console.WriteLine("Julho, trinta e um dias");
                break;

            case 8:
                Console.WriteLine("Agosto, trinta dias");
                break;

            case 9:
                Console.WriteLine("Setembro, trinta e um dias");
                break;

            case 10:
                Console.WriteLine("Outubro, trinta dias");
                break;

            case 11:
                Console.WriteLine("Novembro, trinta e um dias");
                break;

            case 12:
                Console.WriteLine("Dezembro, trinta dias");
                break;
        }
        break;

    // Exercício 4
    case 4:
        int n1, n2, operador, resultado;

        Console.WriteLine("Bem vindo a calculadora 2.0");
        Console.WriteLine("1 - Adição 2- Subtração 3- Multiplicação 4- Divisão 5- Exponencial");
        operador = int.Parse(Console.ReadLine());
        switch (operador)
        {
            case 1:
                Console.WriteLine("Dê o primeiro valor");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Dê o segundo valor ");
                n2 = int.Parse(Console.ReadLine());
                resultado = (n1 + n2);
                Console.WriteLine("o reslutado da operação solicitada é {0}", resultado);
                break;

            case 2:
                Console.WriteLine("Dê o primeiro valor");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Dê o segundo valor ");
                n2 = int.Parse(Console.ReadLine());
                resultado = (n1 - n2);
                Console.WriteLine("o reslutado da operação solicitada é {0}", resultado);
                break;

            case 3:

                Console.WriteLine("Dê o primeiro valor");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Dê o segundo valor ");
                n2 = int.Parse(Console.ReadLine());
                resultado = (n1 * n2);
                Console.WriteLine("o reslutado da operação solicitada é {0}", resultado);
                break;

            case 4:
                Console.WriteLine("Dê o primeiro valor");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Dê o segundo valor ");
                n2 = int.Parse(Console.ReadLine());
                resultado = (n1 / n2);
                Console.WriteLine("o reslutado da operação solicitada é {0}", resultado);
                break;

            case 5:
                Console.WriteLine("Dê o primeiro valor");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Dê o segundo valor ");
                n2 = int.Parse(Console.ReadLine());
                resultado = (n1 ^ n2);
                Console.WriteLine("o reslutado da operação solicitada é {0}", resultado);
                break;

            default:
                Console.WriteLine("Opção invalida");
                break;
        }
        break;

    //Exercício 5
    case 5:
        float sal, carg, total1;

        Console.WriteLine("Deseja ver seu novo salário?");
        Console.WriteLine("Primeiro insire seu salário");
        sal = float.Parse(Console.ReadLine());
        Console.WriteLine("Selecione seu cargo na empresa por meio do código");
        Console.WriteLine("101- Professor 102- Secretário 103- Publicitário 204- Jornalista 206- Mecânico 301- Estagiario 302- Técnico de TI");
        carg = float.Parse(Console.ReadLine());

        switch (carg)
        {
            case 101:
                total1 = ((sal * 0.075f) + sal);
                Console.WriteLine("Você passou a receber {0}", total1);
                Console.WriteLine("Você recebia o total de {0}", sal);
                break;


            case 102:
                total1 = ((sal * 0.097f) + sal);
                Console.WriteLine("Você passou a receber {0}", total1);
                Console.WriteLine("Você recebia o total de {0}", sal);
                break;

            case 103:
                total1 = ((sal * 0.117f) + sal);
                Console.WriteLine("Você passou a receber {0}", total1);
                Console.WriteLine("Você recebia o total de {0}", sal);
                break;

            case 204:
                total1 = ((sal * 0.089f) + sal);
                Console.WriteLine("Você passou a receber {0}", total1);
                Console.WriteLine("Você recebia o total de {0}", sal);
                break;

            case 206:
                total1 = ((sal * 0.1324f) + sal);
                Console.WriteLine("Você passou a receber {0}", total1);
                Console.WriteLine("Você recebia o total de {0}", sal);
                break;

            case 301:
                total1 = ((sal * 0.104f) + sal);
                Console.WriteLine("Você passou a receber {0}", total1);
                Console.WriteLine("Você recebia o total de {0}", sal);
                break;

            case 302:
                total1 = ((sal * 0.146f) + sal);
                Console.WriteLine("Você passou a receber {0}", total1);
                Console.WriteLine("Você recebia o total de {0}", sal);
                break;

            default:
                total1 = ((sal * 0.435f));
                Console.WriteLine("Você passou a receber {0}", total1);
                Console.WriteLine("Você recebia o total de {0}", sal);
                break;
        }

        break;

    //Exercício 6
    case 6:
        float imposto, salario_mes, salario_total;

        Console.WriteLine("Escolha a faixa de renda para efetuarmos o calculo do imposto de renda");
        Console.WriteLine("1- até 1903,98 2- R$ 1903,99 á R$ 2826,65 3- R$2826,66 á R$3751,05 4- R$3751,06 á 4664,68 5- Acima de R$ 4664,69");
        imposto = int.Parse(Console.ReadLine());

        switch (imposto)
        {
            case 1:
                Console.WriteLine("Digite quantos você recebe mensalmente");
                salario_mes = float.Parse(Console.ReadLine());
                if (salario_mes > 1903.98f)
                {
                    Console.WriteLine("Seu valor ultrapassa o valor total dessa faixa");
                }
                else
                {
                    Console.WriteLine("Isento á imposto de renda");
                    Console.WriteLine("Seu salário liquído é de {0}", salario_mes);
                }
                break;

            case 2:
                Console.WriteLine("Digite quantos você recebe mensalmente");
                salario_mes = float.Parse(Console.ReadLine());
                if (salario_mes < 1903.99f || salario_mes > 2826.65f)
                {
                    Console.WriteLine("Você não se encaixa nesta faixa ou ultrapassa o valor dessa faixa");
                }
                else
                {
                    salario_total = (salario_mes - (salario_mes * 0.075f));
                    Console.WriteLine("Seu salário liquído é de {0} ", salario_total);

                }
                break;

            case 3:
                Console.WriteLine("Digite quantos você recebe mensalmente ");
                salario_mes = float.Parse(Console.ReadLine());
                if (salario_mes < 2826.66f || salario_mes > 3751.05f)
                {
                    Console.WriteLine("Você não se encaixa nesta faixa ou ultrapassa o valor dessa faixa");
                }
                else
                {
                    salario_total = (salario_mes - (salario_mes * 0.15f));
                    Console.WriteLine("Seu salário liquído é de {0} ", salario_total);
                }
                break;

            case 4:
                Console.WriteLine("Digite quantos você recebe mensalmente ");
                salario_mes = float.Parse(Console.ReadLine());
                if (salario_mes < 3751.06f || salario_mes > 4664.68f)
                {
                    Console.WriteLine("Você não se encaixa nesta faixa ou ultrapassa o valor dessa faixa");
                }
                else
                {
                    salario_mes = (salario_mes - (salario_mes * 0.225f));
                    salario_total = (salario_mes - (salario_mes * 0.075f));
                    Console.WriteLine("Seu salário liquído é de {0} ", salario_total);
                }
                break;

            case 5:
                Console.WriteLine("Digite quantos você recebe mensalmente ");
                salario_mes = float.Parse(Console.ReadLine());
                if (salario_mes < 4664.69f)
                {
                    Console.WriteLine("Você não se encaixa nesta faixa");
                }
                else
                {
                    salario_total = (salario_mes - salario_mes * 0.227f);
                    Console.WriteLine("Seu salário liquído é de {0} ", salario_total);
                }
                break;
        }
        break;
}