namespace _2D_Array_playground
{
    public interface Fetcher<T>
    {
        internal T Fetch(int x, int y);
    }
}