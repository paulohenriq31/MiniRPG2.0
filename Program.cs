using System;

namespace MiniRPG2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //HEROI //Defini os nome para poupar tempo
            string nome = "Doctor", raca = "Troll", classe = "Mago";
            int heroi_pv = 50, heroi_ataque = 10, heroi_level = 1;
            //MONSTRO
            int monstro_pv = 50, monstro_level = 1, monstro_ataque = 10;
            //Minios
            int minion1_pv = 15, minion1_level = 1, minion1_ataque = 4;
            int minion2_pv = 15, minion2_level = 1, minion2_ataque = 4;
            //Declarando uma nova variavel para as escolhas
            int escolhaPortas;
            string escolhaAtaque;
            //Frescura
            Console.Clear();
            Console.WriteLine("----Bem Vindo ao Jogo----");
            Console.Write("Press Enter");
            Console.ReadKey();
            Console.Clear();
            //Coletando os dados do HEROI // Estou colocando como comentario para poupater tempo
            /*Console.Write("Qual o nome do seu HEROI: ");
            nome = Console.ReadLine();
            Console.Write("Qual a raça do seu HEROI: ");
            raca = Console.ReadLine();
            Console.Write("Qual a classe do seu HEROI: ");
            classe = Console.ReadLine();
            Console.Clear();*/
            //Informando as informações
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Dados do seu HEROI");
            Console.WriteLine("=========================");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Raça: " + raca);
            Console.WriteLine("Classe: " + classe);
            Console.WriteLine("Ataque: " + heroi_ataque);
            Console.WriteLine("Level: " + heroi_level);
            Console.WriteLine("Pontos de Vida (PV): " + heroi_pv);
            Console.WriteLine("=========================");
            Console.ResetColor();
            Console.Write("Press Enter");
            Console.ReadKey();
            Console.Clear();
            //Narrativa com a primeira decisão
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Voce esta em um calabouço escuro, voce olha para a sua esqueda e encontra uma porta, voce tem duas opçõe entrar na sala ou continuar andando em frente");
            Console.WriteLine("1- Entrar");
            Console.WriteLine("2- Continuar em frente");
            Console.Write("Qual a sua escolha: ");
            Console.ResetColor();
            escolhaPortas = Convert.ToInt32(Console.ReadLine());
            //Resultado entrar ou não na porta
            if (escolhaPortas == 1){
                //Esse comando serve para trocar a cor da letra "escrita"
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Voce optou por entrar na porta");
                //Esse comando serve para ter uma espera antes da execusão dos comando neste caso é de 3 segundos
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine("Dentro da sala voce encontrou um minion virado de costa");
                Console.WriteLine("Voce deseja enfrentar o minion");
                Console.Write("s/n: ");
                //Esse comando serve para resetar a cor da escrita
                Console.ResetColor();
                escolhaAtaque = Console.ReadLine();
                //Escolha de enfrentar ou nao o minion
                if(escolhaAtaque == "s"){
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Voce decidiu enfrentar o minion");
                    System.Threading.Thread.Sleep(3000);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Dados do MINION");
                    Console.WriteLine("=========================");
                    Console.WriteLine("Ataque: " + minion1_ataque);
                    Console.WriteLine("PV: "+ minion1_pv);
                    Console.WriteLine("Level: " + minion1_level);
                    Console.WriteLine("=========================");
                    Console.ResetColor();

                }else{
                    Console.WriteLine("Voce optou por não enfrentar o minion e voltou para o corredor");
                }

            }else if(escolhaPortas == 2){
                Console.WriteLine("Voce optou por seguir em frente");
            }
            Console.WriteLine("FIM DO JOGO");


        }
    }
}
