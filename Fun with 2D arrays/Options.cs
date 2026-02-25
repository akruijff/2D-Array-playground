namespace Fun_with_2D_arrays
{
    internal class Options(params string[] prefix)
    {
        private const int OPTION_ABORT = 0;
        private int count = 0;
        private readonly List<int> list = [0];
        private readonly Dictionary<int, (string, Action)> map = new() { { OPTION_ABORT, ("Abort", () => { }) } };

        public void Add(string msg, Action action)
        {
            int option = ++count;
            list.Add(option);
            map.Add(option, (msg, action));
        }

        internal void Execute()
        {
            while (true)
            {
                WritePrefixToConsole();
                WriteBodyToConsole();
                int option = AskForOption();
                if (option < 0)
                    continue;
                if (option == OPTION_ABORT)
                    break;
                Invoke(option);
            }
        }

        private void WritePrefixToConsole()
        {
            foreach (string s in prefix)
                Console.WriteLine(s);
        }

        private void WriteBodyToConsole()
        {
            Console.WriteLine("Please pick an option.");
            foreach (int option in list)
            {
                (string msg, _) = map.GetValueOrDefault(option);
                Console.WriteLine($"{option} - {msg}");
            }
        }

        private int AskForOption()
        {
            char c = Console.ReadKey(true).KeyChar;
            int option = (int)Char.GetNumericValue(c);
            if (option <= count)
                return option;
            return -1;
        }

        private void Invoke(int option)
        {
            Console.WriteLine();
            (string msg, Action action) = map[option];
            action.Invoke();            
        }
    }
}
