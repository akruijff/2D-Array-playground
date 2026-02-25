namespace Fun_with_2D_arrays
{
    internal interface Formatter
    {
        public static Formatter DEFAULT { get;  } = new DefaultFormatter();

        char BlankChar();
        ConsoleColor BoarderBackgrondColor();
        ConsoleColor BoarderForegrondColor();
        ConsoleColor ContentBackgrondColor(int x, int y);
        ConsoleColor ContentForegroundColor(int x, int y);
        char HorizontalChar();
        char IntersectionChar();
        char VerticalChar();
    }
}
