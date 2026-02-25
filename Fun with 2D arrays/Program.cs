namespace Fun_with_2D_arrays
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

            Options options = new Options("");
            options.Add("Basic", () => { new BasicGridConsole(grid, 3).Write(); });
            options.Add("Fun House", () =>
            {
                var f = new FunHouseFormatter(ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Blue, ConsoleColor.Yellow);
                var gc = new BasicGridConsole(grid, 3, f);
                gc.Write();
            });
            options.Add("Chess", () =>
            {
                var f = new ChesFormatter();
                var gc = new BasicGridConsole(grid, 3, f);
                gc.Write();
            });
            options.Execute();            
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
