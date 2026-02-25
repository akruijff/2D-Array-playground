namespace Fun_with_2D_arrays
{
    internal class ChesFormatter : Formatter
    {
        public char BlankChar() => Formatter.DEFAULT.BlankChar();
        public ConsoleColor BoarderBackgrondColor() => Formatter.DEFAULT.BoarderBackgrondColor();
        public ConsoleColor BoarderForegrondColor() => Formatter.DEFAULT.BoarderForegrondColor();
        public ConsoleColor ContentBackgrondColor(int x, int y) => 
            (x + y) % 2 == 0 ? ConsoleColor.Black : ConsoleColor.White;
        public ConsoleColor ContentForegroundColor(int x, int y) =>
            (x + y) % 2 == 0 ? ConsoleColor.White : ConsoleColor.Black;

        public char HorizontalChar() => Formatter.DEFAULT.HorizontalChar();
        public char IntersectionChar() => Formatter.DEFAULT.IntersectionChar();
        public char VerticalChar() => Formatter.DEFAULT.VerticalChar();
    }
}