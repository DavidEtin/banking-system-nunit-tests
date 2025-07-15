using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTProject.lab1;

namespace TestUTProject.lab1
{
    public class MathUtilTests
    {
        private MathUtil mathUtil;

        [SetUp]
        public void SetUp()
        {
            mathUtil = new MathUtil();
        }

        [Test]
        [TestCase(2, 2)]  // Input 2, expected sum 2 (only prime number 2)
        [TestCase(4, 5)]  // Input 4, expected sum 5 (2+3)
        public void TestSumOfPrimes(int input, int expectedSum)
        {
            Assert.That(mathUtil.SumOfPrimes(input), Is.EqualTo(expectedSum));
        }
    }
}
