using System.Collections;

namespace Arrays.Tests.Performance
{
    public class ArrayListIntTest : IArrayIntTest
    {
        private ArrayList _array;

        public void SetCapacity(int count)
        {
            _array = new ArrayList(count);
        }

        public int Count => _array.Count;

        public void Add(int value)
        {
            _array.Add(value);
        }

        public int this[int index] => (int) _array[index];

    }
}
