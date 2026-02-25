namespace Fun_with_2D_arrays
{
    public interface Fetcher<T>
    {
        internal T Fetch(int x, int y);
    }
}