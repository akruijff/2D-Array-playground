namespace Fun_with_2D_arrays
{
    internal class RandomIntGenerator(int min, int max) : Fetcher<int>
    {
        private readonly int min = min, max = max;
        private readonly Random random = new Random();

        int Fetcher<int>.Fetch(int x, int y) => random.Next(min, max);
    }
}
