
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorcentJogos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao calculador de porcentagem!");
            Console.WriteLine( "Insira o numero de jogos: ");
            int games = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o numero de vitórias:");
            int wins = Convert.ToInt32(Console.ReadLine());

            //creating the player object
            Player player1 = new Player();
            player1.games = games;
            player1.wins = wins;

            //output
            player1.GetWinRate();
        }
    }

    class Player
    {
        public int games;
        public int wins;
        //winrate is private
        private int winrate;

        //complete the method
        public void GetWinRate()
        {
            winrate = (int)((double)wins / games * 100);
            Console.WriteLine("Numero em porcentagens:");
            Console.WriteLine($" {winrate} %");
        }
    }
}
