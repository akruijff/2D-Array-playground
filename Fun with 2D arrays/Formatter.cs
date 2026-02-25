namespace Fun_with_2D_arrays
{
    internal interface Formatter
    {
        public static Formatter DEFAULT { get;  } = new DefaultFormatter();

        ConsoleColor BoarderColor();
        ConsoleColor ContentColor();
    }
}
