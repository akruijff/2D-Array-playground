namespace Fun_with_2D_arrays
{
    internal class FunHouseFormatter(params ConsoleColor[] colors) : Formatter
    {
        private int index = 0;
        private ConsoleColor[] colors = colors;

        public char BlankChar() => Formatter.DEFAULT.BlankChar();
        public ConsoleColor BoarderBackgrondColor() => Formatter.DEFAULT.BoarderBackgrondColor();
        public ConsoleColor BoarderForegrondColor() => Formatter.DEFAULT.BoarderForegrondColor();
        public ConsoleColor ContentBackgrondColor(int x, int y) => Formatter.DEFAULT.ContentBackgrondColor(x, y);

        public ConsoleColor ContentForegroundColor(int x, int y)
        {
            ConsoleColor cc = colors[index];
            if (++index == colors.Length)
                index = 0;
            return cc;
        }

        public char HorizontalChar() => Formatter.DEFAULT.HorizontalChar();
        public char IntersectionChar() => Formatter.DEFAULT.IntersectionChar();
        public char VerticalChar() => Formatter.DEFAULT.VerticalChar();
    }
}