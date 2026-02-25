namespace _2D_Array_playground
{
    internal class Grid<T>
    {
        private T[,] data;

        public Grid(int width, int height)
        {
            data = new T[width, height];
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
