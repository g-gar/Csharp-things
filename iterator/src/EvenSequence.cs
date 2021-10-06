using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace iterator{
    public class EvenSequence : IEnumerable<int>, IEnumerable {

        private readonly int _max;

        public EvenSequence(int max)
        {
            _max = max;
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (int i in Enumerable.Range(0, _max).Where(i => i%2 == 0))
            {
                yield return i;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}