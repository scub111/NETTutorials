namespace Arrays.Tests.Performance
{
    public interface IArrayGenericTest<in T>
    {
        void SetCapacity(int count);

        int Count { get; }

        void Add(T value);
    }
}
