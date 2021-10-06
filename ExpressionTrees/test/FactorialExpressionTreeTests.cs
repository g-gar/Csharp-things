using System;
using System.Linq;
using NUnit.Framework;

namespace ExpressionTrees.test{
    public class FactorialExpressionTreeTests{

        private FactorialExpressionTree expression;
        
        [SetUp]
        public void SetUp()
        {
            expression = new FactorialExpressionTree();
        }
        
        [Test]
        public void Test0_10()
        {
            
            int expected = 1;
            foreach (int i in Enumerable.Range(1, 10))
            {
                expected *= i;
                int actual = expression.execute(i);
                Assert.AreEqual(expected, actual);
            }
        }
        
    }
}