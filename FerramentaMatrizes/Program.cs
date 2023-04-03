using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerramentaMatrizes
{

    class Program
    {

        static void Main(string[] args)
        {

            int Linha = 0, Coluna = 0, ControleLinha = 0, ControleColuna = 0;

            bool TamanhoSetado = false, ValoresSetados = false;

            string[,] Matriz = new string[Linha, Coluna];

            Console.WriteLine();

            Console.WriteLine("****Ferramenta de matrizes****");

            Console.WriteLine();

            while (true)
            {

                Console.WriteLine();

                Inicio:

                Console.WriteLine("**Menu:");

                Console.WriteLine("1 - Definir tamanho da matriz");

                Console.WriteLine("2 - Preencher a Matriz");

                Console.WriteLine("3 - Encontrar coordenadas de um dado na matriz");

                Console.WriteLine("4 - Encontrar um dado baseado nas coordenadas na matriz");

                Console.WriteLine("5 - Imprimir matriz completa");

                Console.WriteLine();

                int Menu = int.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine();

                switch (Menu)
                {
                    
                    case 1: //Definir tamanho da matriz

                        Console.WriteLine("**Definir tamanho da matriz:");

                        Console.WriteLine();

                        Console.Write("Informe o número de linhas: ");

                        Linha = int.Parse(Console.ReadLine());

                        Console.Write("Informe o número de colunas: ");

                        Coluna = int.Parse(Console.ReadLine());

                        Matriz = new string[Linha, Coluna];

                        Console.WriteLine();

                        Console.Write("Sua matriz possui " + Linha + " Linhas e " + Coluna + " Colunas.");

                        Console.WriteLine();

                        TamanhoSetado = true;

                        break;

                    case 2: //Preencher a Matriz

                        if (TamanhoSetado == true)
                        {

                            Console.WriteLine();

                            Console.WriteLine();

                            Console.WriteLine("**Preencher a Matriz");

                            Console.WriteLine();

                            for (ControleLinha = 0; ControleLinha < Linha; ControleLinha++)
                            {
                                for (ControleColuna = 0; ControleColuna < Coluna; ControleColuna++)
                                {

                                    Console.Write("Digite o valor localizado na Linha " + ControleLinha + " Coluna " + ControleColuna + " da Matriz: ");

                                    Matriz[ControleLinha, ControleColuna] = (Console.ReadLine());

                                }
                            }

                            Console.WriteLine();

                            Console.WriteLine("**Valores da Matriz:");

                            for (ControleLinha = 0; ControleLinha < Linha; ControleLinha++)
                            {
                                for (ControleColuna = 0; ControleColuna < Coluna; ControleColuna++)
                                {

                                    Console.Write(Matriz[ControleLinha, ControleColuna]);

                                    if (ControleColuna < Coluna - 1)
                                    {

                                        Console.Write(" - ");

                                    }

                                }

                                Console.WriteLine();

                            }

                            ValoresSetados = true;
                           
                        }
                        else
                        {

                            Console.WriteLine("Primeiro defina o tamanho da Matriz");

                        }

                        break;

                    case 3: //Encontrar coordenadas de um dado na matriz

                        if (TamanhoSetado == true)
                        {
                            if (ValoresSetados == true)
                            {

                                Console.WriteLine();

                                Console.WriteLine();

                                Console.WriteLine("**Encontrar coordenadas de um dado na Matriz");

                                Console.WriteLine();

                                Console.Write("Digite o dado que deseja encontrar na Matriz: ");

                                string Validacao = (Console.ReadLine());

                                Console.WriteLine();

                                for (ControleLinha = 0; ControleLinha < Linha; ControleLinha++)
                                {

                                    for (ControleColuna = 0; ControleColuna < Coluna; ControleColuna++)
                                    {

                                        if (Validacao == Matriz[ControleLinha, ControleColuna])
                                        {

                                            Console.WriteLine("O valor digitado esta Linha " + ControleLinha + " Coluna " + ControleColuna + " da Matriz.");

                                        }

                                    }

                                }
                                                                
                            }
                            else
                            {

                                Console.WriteLine("Primeiro defina os valores da Matriz");

                            }

                        }
                        else
                        {

                            Console.WriteLine("Primeiro defina o tamanho da Matriz");

                        }

                        break;

                    case 4: //Encontrar um dado baseado nas coordenadas na matriz

                        if (TamanhoSetado == true)
                        {

                            if (ValoresSetados == true)
                            {

                                Console.WriteLine();

                                Console.WriteLine();

                                Console.WriteLine("**Encontrar um dado Baseado nas coodernadas na Matriz");

                                Console.WriteLine();

                                Console.Write("Informe a Linha do dado que deseja encontrar: ");

                                ControleLinha = int.Parse(Console.ReadLine());

                                Console.Write("Informe a Coluna do dado que deseja encontrar: ");

                                ControleColuna = int.Parse(Console.ReadLine());

                                Console.WriteLine();

                                Console.WriteLine("O dado que se encontra na linha " + ControleLinha + " e na coluna " + ControleColuna + " é o " + Matriz[ControleLinha, ControleColuna] + ".");

                            }
                            else
                            {

                                Console.WriteLine("Primeiro defina os valores da Matriz");

                            }
                        }
                        else
                        {

                            Console.WriteLine("Primeiro defina o tamanho da Matriz");

                        }

                        break;

                    case 5://Imprimir Matriz Completa

                        if (TamanhoSetado == true)
                        {
                            if (ValoresSetados == true)
                            {

                                Console.WriteLine();

                                Console.WriteLine("**Valores da Matriz:");

                                for (ControleLinha = 0; ControleLinha < Linha; ControleLinha++)
                                {
                                    for (ControleColuna = 0; ControleColuna < Coluna; ControleColuna++)
                                    {

                                        Console.Write(Matriz[ControleLinha, ControleColuna]);

                                        if (ControleColuna < Coluna - 1)
                                        {

                                            Console.Write(" - ");

                                        }

                                    }

                                    Console.WriteLine();

                                }

                            }

                            else
                            {

                                Console.WriteLine("Primeiro defina os valores da Matriz");

                            }

                        }
                        else
                        {

                            Console.WriteLine("Primeiro defina o tamanho da Matriz");

                        }
                                                
                        break;

                    default:

                        Console.WriteLine("Escolha uma opção válida:");

                        Console.WriteLine();

                        goto Inicio;

                        break;

                }

                Console.WriteLine();

                Console.WriteLine("0 - Para encerrar");

                Console.WriteLine("1 - Para Voltar ao Menu");

                Console.WriteLine();

                if (int.Parse(Console.ReadLine()) == 0)
                {

                    break;

                }
                else 
                {

                    Console.Clear();

                    Console.WriteLine();

                    Console.WriteLine("****Ferramenta de matrizes****");

                    Console.WriteLine();

                }

            }

        }

    }

}
