namespace Arrays.Tests.Performance
{
    public interface IArrayIntTest
    {
        void SetCapacity(int count);

        int Count { get; }

        void Add(int value);

        int this[int index] { get; }
    }
}
