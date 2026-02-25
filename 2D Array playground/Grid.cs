namespace _2D_Array_playground
{
    internal class Grid<T>(int width, int height)
    {
        private readonly int width = width, height = height;
        private T[,] data = new T[width, height];

        public void Initialize(Fetcher<T> fetcher)
        {
            for (int y = 0; y < height; ++y)
                for (int x = 0; x < width; ++x)
                    data[x, y] = fetcher.Fetch(x, y);
        }

        public T Get(int x, int y)
        {
            return data[x, y];
        }

        public void Set(int x, int y, T value)
        {
            data[x, y] = value;
        }
    }
}
