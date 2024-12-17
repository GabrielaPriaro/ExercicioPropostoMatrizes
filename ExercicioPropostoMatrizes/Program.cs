namespace ExercicioPropostoMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de linhas e colunas da matriz: ");
            string[] ordemMatriz = Console.ReadLine().Split(' ');
            int m = int.Parse(ordemMatriz[0]);
            int n = int.Parse(ordemMatriz[1]);

            int[,] mat = new int[m, n];
            Console.WriteLine( );
            Console.WriteLine("Digite os valores da matriz:");
            for (int i = 0; i < m; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine( );
            Console.WriteLine("Escolha um numero da matriz:");
            int x = int.Parse(Console.ReadLine());
            
            string posicao = "";
            int left = 0;
            int right = 0;
            int up = 0;
            int down = 0;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (x == mat[i, j])
                    {
                        posicao = $"{i},{j}";
                        left = j - 1; 
                        right = j + 1;
                        up = i - 1;
                        down = i + 1;

                        Console.WriteLine($"Posiçao {posicao}:");
                        if (left >= 0)
                        {
                            Console.WriteLine($"Esquerda: {mat[i, left]}");
                        }
                        if (right < n)
                        {
                            Console.WriteLine($"Direita: {mat[i, right]}");
                        }
                        if (up >= 0)
                        {
                            Console.WriteLine($"Cima: {mat[up, j]}");
                        }
                        if (down < m)
                        {
                            Console.WriteLine($"Baixo: {mat[down, j]}");
                        }
                    }
                }
            }
        }
    }
}
