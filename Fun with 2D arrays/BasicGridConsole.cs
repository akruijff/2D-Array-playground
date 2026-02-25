namespace Fun_with_2D_arrays
{
    internal class BasicGridConsole(Grid<int> grid, int cellWidth, Formatter? formatter = null)
    {
        private int cellWidth = cellWidth;
        private Grid<int> grid = grid;
        private Formatter formatter = formatter ?? new DefaultFormatter();

        internal void Write()
        {
            for (int y = 0; y < grid.Height; ++y)
            {
                WriteBorder();
                WriteValues(y);
            }
            WriteBorder();
        }

        private void WriteValues(int y)
        {
            for (int x = 0; x < grid.Width; ++x)
            {
                int value = grid.Get(x, y);
                Console.Write("|");
                WritePadding(DeterminePadding(value));
                Console.ForegroundColor = formatter.ContentColor();
                Console.Write(value);
            }
            Console.ForegroundColor = formatter.BoarderColor();
            Console.WriteLine("|");
        }

        private static void WritePadding(int n)
        {
            for (int i = 0; i < n; ++i)
                Console.Write(" ");
        }

        private int DeterminePadding(int value)
        {
            int n = cellWidth;
            while (value > 0 && n > 0)
            {
                --n;
                value /= 10;
            }
            return n;
        }

        private void WriteBorder()
        {
            Console.ForegroundColor = formatter.BoarderColor();
            for (int x = 0; x < grid.Width; ++x)
            {
                Console.Write("+");
                for (int i = 0; i < cellWidth; ++i)
                    Console.Write('-');
            }
            Console.WriteLine("+");
        }
    }
}
