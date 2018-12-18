using System.Collections.Generic;

namespace Arrays.Tests.Performance
{
    public class ListIntTest : IArrayIntTest
    {
        private List<int> _array;
        public void SetCapacity(int count)
        {
            _array = new List<int>(count);
            //_array = new List<int>(0);
        }

        public int Count => _array.Count;

        public void Add(int value)
        {
            _array.Add(value);
        }

        public int this[int index] => _array[index];
    }
}
