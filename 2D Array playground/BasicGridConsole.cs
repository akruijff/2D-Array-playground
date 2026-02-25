namespace _2D_Array_playground
{
    internal class BasicGridConsole(Grid<int> grid, int cellWidth)
    {
        private int cellWidth = cellWidth;
        private Grid<int> grid = grid;

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
                WritePAdding(value);
                Console.Write(value);
            }
            Console.WriteLine("|");
        }

        private void WritePAdding(int value)
        {
            int n = DeterminePadding(value);
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
