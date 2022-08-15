using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoVelha
{
    public class Tabuleiro
    {
        Jogadores jogadores = new Jogadores();
        string[,] matrizDeJogadas = new string[3, 3] ;

        public void JogadaJogador1()
        {
            ShowTabuleiro();
            Console.WriteLine($"Jogador 1 Qual a linha:");
            var linha = Console.ReadLine();
            var linhaCorreta = int.TryParse(linha, out var intLinha);
            Console.WriteLine($"Jogador 1 Qual a coluna:");
            var coluna = Console.ReadLine();
            var colunaCorreta = int.TryParse(coluna, out var intcoluna);
            if(!linhaCorreta || !colunaCorreta)
            {
                Console.WriteLine("Entrada invalida, aperte qualquer tecla para tentar novamente");
                Console.ReadKey();
                JogadaJogador1();
            }
            if(!String.IsNullOrEmpty(matrizDeJogadas[intLinha, intcoluna]))
            {
                Console.WriteLine("Posição ja ocupada, aperte qualquer tecla para tentar novamente");
                Console.ReadKey();
                JogadaJogador1();
            }

            matrizDeJogadas[intLinha, intcoluna] = "X";

        }
        public void JogadaJogador2()
        {
            ShowTabuleiro();
            Console.WriteLine($"Jogador 2 Qual a linha:");
            var linha = Console.ReadLine();
            var linhaCorreta = int.TryParse(linha, out var intLinha);
            Console.WriteLine($"Jogador 2 Qual a coluna:");
            var coluna = Console.ReadLine();
            var colunaCorreta = int.TryParse(coluna, out var intcoluna);
            if (!linhaCorreta || !colunaCorreta)
            {
                Console.WriteLine("Entrada invalida, aperte qualquer tecla para tentar novamente");
                Console.ReadKey();
                JogadaJogador2();
            }
            if (!String.IsNullOrEmpty(matrizDeJogadas[intLinha, intcoluna]))
            {
                Console.WriteLine("Posição ja ocupada, aperte qualquer tecla para tentar novamente");
                Console.ReadKey();
                JogadaJogador2();
            }

            matrizDeJogadas[intLinha, intcoluna] = "O";

        }

        public bool ChecaVencedorJog1()
        {
            bool venceu = false;
            var x10 = matrizDeJogadas[0, 0]=="X";
            var x11 = matrizDeJogadas[0, 1] == "X";
            var x12 = matrizDeJogadas[0, 2] == "X";
            var x00 = matrizDeJogadas[1, 0] == "X";
            var x01 = matrizDeJogadas[1, 1] == "X";
            var x02 = matrizDeJogadas[1, 2] == "X";
            var x20 = matrizDeJogadas[2, 0] == "X";
            var x21 = matrizDeJogadas[2, 1] == "X";
            var x22 = matrizDeJogadas[2, 2] == "X";

            var linha = (x00 & x01 & x02) || (x10 & x11 & x12) || (x20 & x21 & x22);
            var coluna = (x00 & x10 & x20) || (x01 & x11 & x21) || (x02 & x12 & x22);
            var diagonal = (x00 && x11 & x22) || (x02 & x11 & x20);
            if(linha|| coluna || diagonal)
            {
                venceu = true;
            }
             
            return venceu;
        }

        public bool ChecaVencedorJog2()
        {
            bool venceu = false;
            var o10 = matrizDeJogadas[0, 0]=="O";
            var o11 = matrizDeJogadas[0, 1] == "O";
            var o12 = matrizDeJogadas[0, 2] == "O";
            var o00 = matrizDeJogadas[1, 0] == "O";
            var o01 = matrizDeJogadas[1, 1] == "O";
            var o02 = matrizDeJogadas[1, 2] == "O";
            var o20 = matrizDeJogadas[2, 0] == "O";
            var o21 = matrizDeJogadas[2, 1] == "O";
            var o22 = matrizDeJogadas[2, 2] == "O";

            var linha = (o00 & o01 & o02) || (o10 & o11 & o12) || (o20 & o21 & o22);
            var coluna = (o00 & o10 & o20) || (o01 & o11 & o21) || (o02 & o12 & o22);
            var diagonal = (o00 && o11 & o22) || (o02 & o11 & o20);
            if (linha || coluna || diagonal)
            {
                venceu = true;
            }

            return venceu;
        }
         public void ShowTabuleiro()
        {
            Console.Clear();
            for(int i = 0; i < matrizDeJogadas.GetLength(0); i++)
            {
                for(int j = 0; j < matrizDeJogadas.GetLength(1); j++)
                {
                    if(String.IsNullOrWhiteSpace(matrizDeJogadas[i, j]))
                    {
                        Console.Write("_");
                    }
                    else
                    Console.Write(matrizDeJogadas[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
