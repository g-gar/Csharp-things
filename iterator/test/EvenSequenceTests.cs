using System.Linq;
using NUnit.Framework;

namespace iterator.test{
    public class EvenSequenceTests{

        [Test]
        public void TestEvenNumbersLessThan10()
        {
            EvenSequence sequence = new EvenSequence(10);
            Assert.AreEqual(new int[]{0,2,4,6,8}, sequence.ToArray());
        }
        
    }
}