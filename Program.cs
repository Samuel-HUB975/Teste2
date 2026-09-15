using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;

namespace Teste1Slamepo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao mundo de Slamepô!");
            Console.WriteLine("Digite seu nome:");

            string nome = Console.ReadLine();

            Console.WriteLine("\nOlá " + nome + "!");
            Console.WriteLine("Digite sua idade:");

            int idade = Convert.ToInt32(Console.ReadLine());

            if (idade <= 12)
            {
                Console.WriteLine("\nVocê ainda não pode participar do torneio.");
                return;
            }

            Console.WriteLine("\nVocê pode participar!");
            Console.WriteLine("Vamos começar!\n");

            // História
            Console.WriteLine(" Há muito tempo, o mundo de Slamepô era formado por enormes ilhas que flutuavam no céu.");
            Console.WriteLine("Cada ilha desenvolveu seu próprio tipo de Slame e passou a dominar um elemento diferente.");
            Console.WriteLine("A Ilha Aurora e a habitada por humanos.");
            Console.WriteLine("A Aqualis e a ilha dos Slames de água.");
            Console.WriteLine("A Terra Incandescente e a ilha dos Slames de fogo.");
            Console.WriteLine("Já as Terras Verdália e habitadas pelos Slames de terra");
            Console.WriteLine("Assim nasceu o torneio Slamepô!");

            int vitorias_jogador = 0;
            int vitorias_computador = 0;

            Random random = new Random();

            while (vitorias_jogador < 2 && vitorias_computador < 2)
            {
                Console.WriteLine("\n NOVA RODADA ");
                Console.WriteLine(nome + ": " + vitorias_jogador);
                Console.WriteLine("Computador: " + vitorias_computador);

                Console.WriteLine("\nEscolha seu Slame:");
                Console.WriteLine("1 - Água");
                Console.WriteLine("2 - Fogo");
                Console.WriteLine("3 - Terra");

                int escolha = Convert.ToInt32(Console.ReadLine());

                if (escolha < 1 || escolha > 3)
                {
                    Console.WriteLine("Escolha inválida!");
                    continue;
                }

                int computador = random.Next(1, 4);

                string[] slames = { "", "Água", "Fogo", "Terra" };

                Console.WriteLine("\nVocê escolheu: " + slames[escolha]);
                Console.WriteLine("Computador escolheu: " + slames[computador]);

                if (escolha == computador)
                {
                    Console.WriteLine("Empate!");
                }
                else if (
                    (escolha == 1 && computador == 2) ||
                    (escolha == 2 && computador == 3) ||
                    (escolha == 3 && computador == 1)
                )
                {
                    Console.WriteLine("Você venceu a rodada!");
                    vitorias_jogador++;
                }
                else
                {
                    Console.WriteLine("O computador venceu a rodada!");
                    vitorias_computador++;
                }

                Console.WriteLine("\nPlacar: " + nome + " " +
                                  vitorias_jogador + " x " +
                                  vitorias_computador + " Computador");
            }

            Console.WriteLine("\n FIM DO TORNEIO ");

            if (vitorias_jogador == 2)
            {
                Console.WriteLine("Parabéns, " + nome + "!");
                Console.WriteLine("Você venceu o torneio de Slamepô!");
            }
            else
            {
                Console.WriteLine("O computador venceu!");
                Console.WriteLine("Você perdeu o torneio.");
            }

            Console.WriteLine("\nObrigado por jogar Slamepô!");
        }
    }
}

