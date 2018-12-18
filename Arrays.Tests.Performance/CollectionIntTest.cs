using System.Collections.ObjectModel;

namespace Arrays.Tests.Performance
{
    public class CollectionIntTest : IArrayIntTest
    {
        private Collection<int> _array;

        public void SetCapacity(int count)
        {
            _array = new Collection<int>();
        }

        public int Count => _array.Count;

        public void Add(int value)
        {
            _array.Add(value);
        }

        public int this[int index] => _array[index];
    }
}
