// See https://aka.ms/new-console-template for more information
Console.WriteLine("Restaurante!\n");
Console.WriteLine("Cardápio:\n");

string[] produtos = new string[5] { "1 - Hamburger", "2 - Cachorro-Quente", "3 - Nachos", "4 - Suchi", "5 - Pizza" };
double[] preco = new double[5] { 10.00, 5.00, 20.00, 50.00, 25.00};

double valorTotal = 0.0;
bool menu = true;
string opcao;
string sair = "S";

while (menu)
{
    Console.Clear();


    for (int i = 0; i < produtos.Length; i++)
    {
        Console.WriteLine($"{produtos[i]}, {preco[i]}");
    }

    Console.WriteLine("\n");
    Console.WriteLine("Escolha a opção desejada ou aperte S para sair:\n");
    opcao = Console.ReadLine();

    if (opcao == "1")
    {
        Console.WriteLine($"Você escolheu {produtos[0]}, {preco[0]}");
        Console.WriteLine("\n");
        Console.WriteLine("Aperte qualquer tecla para continuar\n");
        Console.ReadKey();
        valorTotal = valorTotal + preco[0];
    }

    else if (opcao == "2")
    {
        Console.WriteLine($"Você escolheu {produtos[1]}, {preco[1]}");
        Console.WriteLine("\n");
        Console.WriteLine("Aperte qualquer tecla para continuar\n");
        Console.ReadKey();
        valorTotal = valorTotal + preco[1];
    }

    else if (opcao == "3")
    {
        Console.WriteLine($"Você escolheu {produtos[2]}, {preco[2]}");
        Console.WriteLine("\n");
        Console.WriteLine("Aperte qualquer tecla para continuar\n");
        Console.ReadKey();
        valorTotal = valorTotal + preco[2];
    }

    else if (opcao == "4")
    {
        Console.WriteLine($"Você escolheu {produtos[3]}, {preco[3]}");
        Console.WriteLine("\n");
        Console.WriteLine("Aperte qualquer tecla para continuar\n");
        Console.ReadKey();
        valorTotal = valorTotal + preco[3];
    }

    else if (opcao == "5")
    {
        Console.WriteLine($"Você escolheu {produtos[4]}, {preco[4]}");
        Console.WriteLine("\n");
        Console.WriteLine("Aperte qualquer tecla para continuar\n");
        Console.ReadKey();
        valorTotal = valorTotal + preco[4];
    }

    else
    {
        sair = Console.ReadLine();
        Console.WriteLine("Obrigada pela Preferência! \nO valor total de sua conta foi de: R$" + valorTotal);
        menu = false;
    }

}

