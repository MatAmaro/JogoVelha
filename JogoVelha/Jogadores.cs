using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoVelha
{
    public class Jogadores
    {
        public string Jogador1 { get; set; }
        public string Jogador2 { get; set; }


        public void InputName1()
        {

            Console.WriteLine("Qual seu nome Jogador 1?");
            var name = Console.ReadLine();
            if (String.IsNullOrEmpty(name))
            {
                Console.WriteLine("Entrada invalida, tente novamente");
                InputName1();
            }
            Jogador1 = name;
        }
        public void InputName2()
        {

            Console.WriteLine("Qual seu nome Jogador 2?");
            var name = Console.ReadLine();
            if (String.IsNullOrEmpty(name))
            {
                Console.WriteLine("Entrada invalida, tente novamente");
                InputName2();
            }
            Jogador2 = name;
        }
    }
}
