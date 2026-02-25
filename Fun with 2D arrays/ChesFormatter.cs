namespace Fun_with_2D_arrays
{
    internal class ChesFormatter : Formatter
    {
        public ConsoleColor BoarderBackgrondColor() => Formatter.DEFAULT.BoarderBackgrondColor();
        public ConsoleColor BoarderForegrondColor() => Formatter.DEFAULT.BoarderForegrondColor();
        public ConsoleColor ContentBackgrondColor(int x, int y) => 
            (x + y) % 2 == 0 ? ConsoleColor.Black : ConsoleColor.White;
        public ConsoleColor ContentForegroundColor(int x, int y) =>
            (x + y) % 2 == 0 ? ConsoleColor.White : ConsoleColor.Black;
    }
}