using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace batalha_naval
{
    class Program
    {
        static void Main(string[] args)
        {
            int barcoA, barcoB, tamA = 4, tamB = 4, ataqueA, ataqueB, vitoriaA = 4, vitoriaB = 4, pontuacaoA = 0, pontuacaoB = 0, atingidoA = 0, atingidoB = 0;
            string[] rioA = new string[10];
            string[] rioB = new string[10];
            string play1, play2;

            //NOME PARA OS BARCOS

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=============================================================");
            Console.WriteLine("===                 BEM VINDO AO JOGO                     ===");
            Console.WriteLine("=============================================================");
            Console.WriteLine("===                         DE                            ===");
            Console.WriteLine("=============================================================");
            Console.WriteLine("===                    BATALHA NAVAL                      ===");
            Console.WriteLine("=============================================================");
            Console.WriteLine("=============================================================");
            Console.WriteLine("===          Pressione qualquer tecla para começar        ===");
            Console.WriteLine("=============================================================");

            Console.ReadKey();
            Console.Clear();


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Player 1. Digite o nome do seu barco: ");
            play1 = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Player 2. Digite o nome do seu barco: ");
            play2 = Console.ReadLine();

            //POSIÇÃO DO BARCO A

            Console.Clear();

           
            while(vitoriaA != 0)
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine(play1 + ", Digite o a posição em que você quer colocar o seu barco: ");
                barcoA = Convert.ToInt32(Console.ReadLine());

                //REAJUSTAR POSIÇÃO 8+ barco A

                if (barcoA >= 8 || barcoA == 10)
                {
                    Console.WriteLine("Voce não pode por o barco nessa posiçao. O rio é pequeno de mais! O seu barco \n foi alocado para a primeira posiçao." +
                        "Aperte qualquer coisa para continuar");
                    int ReajBarco1 = barcoA - barcoA;
                    barcoA = ReajBarco1;
                    Console.ReadKey();
                }

                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(play2 + ", Digite o a posição em que você quer colocar o seu barco: ");
                barcoB = Convert.ToInt32(Console.ReadLine());

                //REAJUSTAR POSIÇÃO 8+ barco A

                if (barcoB >= 8 || barcoB == 10)
                {
                    Console.WriteLine("Você não pode por o barco nessa posição. O rio é pequeno de mais! O seu barco \n foi alocado para a primeira posiçao." +
                        "Aperte qualquer tecla para continuar");
                    int ReajBarco2 = barcoB - barcoB;
                    barcoB = ReajBarco2;
                    Console.ReadKey();
                }

                Console.Clear();

                //GUARDAR A POSIÇÃO DOS BARCOS

                for (int i = 0; i <= 9; i++)
                {
                    rioA[i] = "Água";
                    if (i >= barcoA - 1 && tamA > 0)
                    {
                        rioA[i] = "BARCO";
                        tamA = tamA - 1;
                    }
                    else { rioA[i] = "Água"; }
                }



                for (int i = 0; i <= 9; i++)
                {
                    rioB[i] = "Água";
                    if (i >= barcoB - 1 && tamB > 0)
                    {
                        rioB[i] = "BARCO";
                        tamB = tamB - 1;
                    }
                    else { rioB[i] = "Água"; }
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(play1 + ", Escolha onde quer atacar: ");
                ataqueA = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i <= 9; i++)
                {
                    if (i == ataqueA - 1 && rioB[i] == "Água")
                    {
                        rioB[i] = "Errou";
                    }

                    else if (i == ataqueA - 1 && rioB[i] == "BARCO")
                    {
                        rioB[i] = "Você foi Atingido";
                        vitoriaA = vitoriaA - 1;
                        pontuacaoA = pontuacaoA + 1;
                        atingidoB = atingidoB + 1;
                    }
                }

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(play2 + ", Escolha onde quer atacar: ");
                ataqueB = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i <= 9; i++)
                {
                    if (i == ataqueB - 1 && rioA[i] == "Água")
                    {
                        rioA[i] = "Errou";
                    }

                    else if (i == ataqueB - 1 && rioA[i] == "BARCO")
                    {
                        rioA[i] = "Você foi Atingido";
                        vitoriaB = vitoriaB - 1;
                        pontuacaoB = pontuacaoB + 1;
                        atingidoA = atingidoA + 1;
                    }
                }

                Console.Clear();

                //VERIFICAR PONTUAÇÃO

                Console.WriteLine("PONTUAÇÃO DOS JOGADORES:\n");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("barco do " + play1 + ": \n");
                for (int i = 0; i <= 9; i++)
                {

                    Console.WriteLine((i + 1) + "º casa: " + rioA[i]);

                }

                Console.WriteLine("\n");
                Console.WriteLine(play1 + ": " + pontuacaoA + " pontos");
                Console.WriteLine(play1 + ": atingido " + atingidoA + " vez(es)");

                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("\n");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("barco do " + play2 + ": \n");
                for (int i = 0; i <= 9; i++)
                {
                    Console.WriteLine((i + 1) + "º casa: " + rioB[i]);

                }



                Console.WriteLine("\n");
                Console.WriteLine(play2 + ": " + pontuacaoB + " ponto(s)");
                Console.WriteLine(play2 + ": atingido " + atingidoB + " vez(es)");

                Console.ReadKey();
                Console.Clear();

                if(vitoriaA == 4)
                {
                    tamB = 4;
                }

                else if (vitoriaA == 3)
                {
                    tamB = 3;
                }
                else if (vitoriaA == 2)
                {
                    tamB = 2;
                }
                else if (vitoriaA == 1)
                {
                    tamB= 1;
                }





                if (vitoriaB == 4)
                {
                    tamA = 4;
                }

                else if (vitoriaB == 3)
                {
                    tamA = 3;
                }
                else if (vitoriaB == 2)
                {
                    tamA = 2;
                }
                else if (vitoriaB == 1)
                {
                    tamA = 1;
                }



                if(vitoriaB == 0)
                {
                    break;
                }

            }

            if (vitoriaA == 0 && vitoriaB == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("O jogo terminou empatado");
            }

            else if (vitoriaA == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("O vencedor do jogo foi: " + play1);
            }

            else if(vitoriaB ==0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("O vencedor do jogo foi: " + play2);
            }

            

            Console.ReadKey();


        }
    }
}
