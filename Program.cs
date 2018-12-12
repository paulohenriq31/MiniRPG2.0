using System;

namespace MiniRPG2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //HEROI
            string nome, raca, classe;
            int heroi_pv = 50, heroi_ataque = 10, heroi_level = 1;
            //MONSTRO
            int monstro_pv = 50, monstro_level = 1, monstro_ataque = 10;
            //Minios
            int minion1_pv = 15, minion1_level = 1, minion1_ataque = 4;
            int minion2_pv = 15, minion2_level = 1, minion2_ataque = 4;
            //Frescura
            Console.Clear();
            Console.WriteLine("----Bem Vindo ao Jogo----");
            Console.Write("Press Enter");
            Console.ReadKey();
            Console.Clear();
            //Coletando os dados do HEROI
            Console.Write("Qual o nome do seu HEROI: ");
            nome = Console.ReadLine();
            Console.Write("Qual a raça do seu HEROI: ");
            raca = Console.ReadLine();
            Console.Write("Qual a classe do seu HEROI: ");
            classe = Console.ReadLine();
            Console.Clear();
            //Informando as informações
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Dados do seu HEROI");
            Console.WriteLine("====================");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Raça: " + raca);
            Console.WriteLine("Classe: " + classe);
            Console.WriteLine("Ataque: " + heroi_ataque);
            Console.WriteLine("Level: " + heroi_level);
            Console.WriteLine("Pontos de Vida (PV): " + heroi_pv);
            Console.WriteLine("=====================");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
            //Narrativa
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Voce esta em um calabouço escuro, voce olha para a sua esqueda e encontra uma porta, voce tem duas opçõe entrar na sala ou continuar andando em frente");
            Console.ReadKey();
            Console.ResetColor();

        }
    }
}
