using JogoVelha;
Tabuleiro matriz = new Tabuleiro();
Jogadores jogadores = new Jogadores();
jogadores.InputName1();
jogadores.InputName2();
bool vencedor = false;
var nomeVencedor = "";
int qtdJogadas = 0;

while (!vencedor)
{
    qtdJogadas++;
    matriz.JogadaJogador1();
    var vencedor1 = matriz.ChecaVencedorJog1();
    if (vencedor1)
    {
        vencedor = true;
        nomeVencedor = jogadores.Jogador1;
        break;
    }
    matriz.JogadaJogador2();
    var vencedor2 = matriz.ChecaVencedorJog1();
    if (vencedor2)
    {
        vencedor = true;
        nomeVencedor = jogadores.Jogador2;
        break;
    }
    if(qtdJogadas == 9)
    {
        vencedor = true;
        Console.WriteLine("Deu Velha");
        nomeVencedor = "Ninguém";
    }

}

Console.WriteLine($"{nomeVencedor} ganhou");