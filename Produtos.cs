using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.cardapio
{
    public class Produtos
    {
        public static void Comidas()
        {
            Random random = new Random();
            string[] produtos = new string[5] { "Hamburger", "Cachorro-Quente", "Nachos", "Suchi", "Pizza" };
            string[] preco = new string[5] { "R$ 10,00", "R$ 5,00", "R$ 20,00", "R$ 50,00", "R$ 25,00" };

            for (int i = 0; i < produtos.Length; i++)
            {
                Console.WriteLine($"{produtos[i]}, {preco[i]}");
            }

            

        }
    }
}
