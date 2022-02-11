using System;

namespace tupiniquin.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("============================================");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----------Solution---Tupiniquin-------------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("============================================");
            Console.ResetColor();
            Console.WriteLine(" ");

            //IMPUT QUANTIA DE ROBÔS
            Console.WriteLine("Digite o número de robôs que serão designados para a missão:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string strQuantidadeDeRobos = Console.ReadLine();
            Console.ResetColor();
            int quantidadeRobo = Convert.ToInt32(strQuantidadeDeRobos);
            Console.WriteLine(" ");

            //VERIFICAÇÃO
            for (int i = 0; i < quantidadeRobo; i++)
            {
                //IMPUT POSIÇÃO DE X E Y
                Console.WriteLine("Informe a posição de X:");
                Console.ForegroundColor= ConsoleColor.Green;
                string px = Console.ReadLine();
                Console.ResetColor();
                
                Console.WriteLine("Informe a posição de y:");
                Console.ForegroundColor = ConsoleColor.Green;
                string py = Console.ReadLine();
                Console.ResetColor();

                int posicaoX = Convert.ToInt32(px);
                int posicaoY = Convert.ToInt32(py);
                Console.WriteLine(" ");

                //IMPUT DIREÇÃO NORTE/SUL/LESTE/OESTE
                Console.WriteLine("Informe a direção:" + "\n" + "N - Norte" + "\n" + "S - Sul" + "\n" + "L - Leste" + "\n" + "O - Oeste");
                Console.ForegroundColor = ConsoleColor.Green;
                string strDirecao = Console.ReadLine();
                Console.ResetColor();
                char direcao = Convert.ToChar(strDirecao);
                Console.WriteLine(" ");

                //IMPUT DO MOVIMENTO A SER SEGUIDO PELO ROBÔ
                Console.WriteLine("Informe a direção que deseja guiar o robô" + "\n" + "M - Para andar linha reta" + "\n" + "E - Para virar 90° para esquerda" + "\n" + "D - Para virar 90° para direita");
                Console.ForegroundColor = ConsoleColor.Green;
                string strMover = Console.ReadLine();
                Console.ResetColor();
                char[] mover = strMover.ToCharArray();
                Console.WriteLine(" ");

                //VERIFICAÇÃO DAS POSSIVEIS DIREÇÕES PARA OS ROBÔS SEGUIREM
                for (int a = 0; a < mover.Length; a++)
                {
                    if (mover[a] == 'M')
                    {
                        if (direcao == 'N')
                        {
                            posicaoY = posicaoY + 1;
                        }
                        else if (direcao == 'S')
                        {
                            posicaoY = posicaoY - 1;
                        }
                        else if (direcao == 'O')
                        {
                            posicaoX = posicaoX - 1;
                        }
                        else if (direcao == 'L')
                        {
                            posicaoX = posicaoX + 1;
                        }
                    }
                    if (mover[a] == 'E')
                    {
                        if (direcao == 'N')
                        {
                            direcao = 'O';
                        }
                        else if (direcao == 'S')
                        {
                            direcao = 'L';
                        }
                        else if (direcao == 'O')
                        {
                            direcao = 'S';
                        }
                        else if (direcao == 'L')
                        {
                            direcao = 'N';
                        }
                    }
                    if (mover[a] == 'D')
                    {
                        if (direcao == 'N')
                        {
                            direcao = 'L';
                        }
                        else if (direcao == 'S')
                        {
                            direcao = 'O';
                        }
                        else if (direcao == 'O')
                        {
                            direcao = 'N';
                        }
                        else if (direcao == 'L')
                        {
                            direcao = 'S';
                        }
                    }
                }

                //RESULTADO DA PARADA DOS ROBÔS
                Console.WriteLine("Resultado do " + (i + 1) + "° robô djanho");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(Math.Abs(posicaoY) + " " + Math.Abs(posicaoX) + " " + direcao);
                Console.ResetColor();
                Console.WriteLine(" ");
            }
        }
    }
}
