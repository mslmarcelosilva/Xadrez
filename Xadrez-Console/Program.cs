using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(3, 5));

                tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(7, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(6, 3));
                tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(7, 5));

                Tela.imprimirTabuleiro(tab);
            } 
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
