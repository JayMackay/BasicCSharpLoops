using NUnit.Framework;
using System;
using TestLoopProgram;

namespace MethodLoopsUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void LowestForLoopMethodTest()
        {
            //ACT
            int[] nums = { 5, 10, 15, 16, 5, 2 };
            var result = LoopMethods.LowestForLoop(nums);
            //ASSERT
            Assert.AreEqual(2, result);
        }

        [Test]
        public void ForEachTest()
        {
            //ACT
            int[] nums = { 1, 2, 3, 4, 5 };
            var result = LoopMethods.LowestForEach(nums);
            //ASSERT
            Assert.AreEqual(1, result);

        }

        [TestCase(2,0)]
        [Test]
        public void calcDiv(int num1, int num2)
        {
            //ACT
            var exception = Assert.Throws<ArgumentException>(() =>
            LoopMethods.calcDiv(num1, num2));
            //ASSERT
            Assert.AreEqual($"Can not divide by {num2}", exception);
        }

    }
}