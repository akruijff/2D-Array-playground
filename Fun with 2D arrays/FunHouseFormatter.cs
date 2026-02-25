namespace Fun_with_2D_arrays
{
    internal class FunHouseFormatter(params ConsoleColor[] colors) : Formatter
    {
        private int index = 0;
        private ConsoleColor[] colors = colors;

        public ConsoleColor BoarderColor() => Formatter.DEFAULT.BoarderColor();

        public ConsoleColor ContentColor()
        {
            ConsoleColor cc = colors[index];
            if (++index == colors.Length)
                index = 0;
            return cc;
        }
    }
}