namespace Fun_with_2D_arrays
{
    internal class DefaultFormatter : Formatter
    {
        public char BlankChar() => ' ';
        public ConsoleColor BoarderBackgrondColor() => ConsoleColor.Black;
        public ConsoleColor BoarderForegrondColor() => ConsoleColor.White;
        public ConsoleColor ContentBackgrondColor(int x, int y) => ConsoleColor.Black;
        public ConsoleColor ContentForegroundColor(int x, int y) => ConsoleColor.White;
        public char HorizontalChar() => '-';
        public char IntersectionChar() => '+';
        public char VerticalChar() => '|';
    }
}