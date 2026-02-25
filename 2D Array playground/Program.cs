namespace _2D_Array_playground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with 2D arrays");
            int width = GetValue("Width:");
            int height = GetValue("Height:");

            Grid<int> grid = new(width, height);
            grid.Initialize(new RandomIntGenerator(1, 99));

            new BasicGridConsole(grid, 3).Write();
        }

        private static int GetValue(String msg)
        {
            while (true)
            {
                try
                {
                    Console.Write(msg + " ");
                    int value = Convert.ToInt32(Console.ReadLine());
                    if (value > 0)
                        return value;
                }
                catch
                {
                    Console.WriteLine("Please pick an integer greater than 0!");
                }
            }
        }
    }
}
