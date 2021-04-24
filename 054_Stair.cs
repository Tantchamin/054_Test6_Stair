using System;

namespace Test6
{
    class Program
    {
        static void Main(string[] args)
        {
            char Character = char.Parse(Console.ReadLine());
            int wide = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int row = int.Parse(Console.ReadLine());

            for (int k = 0; k <= row; k++)
            {
                for (int z = 0; z < height; z++)
                {
                    for (int i = 0; i < k; i++)
                    {
                        for (int j = 0; j < wide; j++)
                        {
                            Console.Write(Character);
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
