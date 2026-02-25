namespace Fun_with_2D_arrays
{
    internal class Grid<T>(int width, int height)
    {
        public int Width { get; init; } = width;
        public int Height { get; init; } = height;
        private T[,] data = new T[width, height];

        public void Initialize(Fetcher<T> fetcher)
        {
            for (int y = 0; y < Height; ++y)
                for (int x = 0; x < Width; ++x)
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
