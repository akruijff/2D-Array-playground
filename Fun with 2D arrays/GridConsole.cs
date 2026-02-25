namespace Fun_with_2D_arrays
{
    internal class GridConsole(Grid<int> grid, int cellWidth, Formatter? formatter = null)
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
                Console.ForegroundColor = formatter.BoarderForegrondColor();
                Console.BackgroundColor = formatter.BoarderBackgrondColor();
                Console.Write(formatter.VerticalChar());
                Console.ForegroundColor = formatter.ContentForegroundColor(x, y);
                Console.BackgroundColor = formatter.ContentBackgrondColor(x, y);
                WritePadding(DeterminePadding(value));
                Console.Write(value);
            }
            Console.ForegroundColor = formatter.BoarderForegrondColor();
            Console.BackgroundColor = formatter.BoarderBackgrondColor();
            Console.WriteLine(formatter.VerticalChar());
        }

        private void WritePadding(int n)
        {
            for (int i = 0; i < n; ++i)
                Console.Write(formatter.BlankChar());
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
            Console.ForegroundColor = formatter.BoarderForegrondColor();
            Console.BackgroundColor = formatter.BoarderBackgrondColor();
            for (int x = 0; x < grid.Width; ++x)
            {
                Console.Write(formatter.IntersectionChar());
                for (int i = 0; i < cellWidth; ++i)
                    Console.Write(formatter.HorizontalChar());
            }
            Console.WriteLine(formatter.IntersectionChar());
        }
    }
}
