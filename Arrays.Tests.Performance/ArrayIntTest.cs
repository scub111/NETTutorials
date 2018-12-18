namespace Arrays.Tests.Performance
{
    public class ArrayIntTest : IArrayIntTest
    {
        private int[] _array;

        private int _index;

        public void SetCapacity(int count)
        {
            _array = new int[count];
        }

        public int Count => _index;

        public void Add(int value)
        {
            _array[_index] = value;
            _index++;
        }

        public int this[int index] => _array[index];
    }
}
