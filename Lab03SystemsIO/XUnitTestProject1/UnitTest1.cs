using System;
using Xunit;
using static Lab03SystemsIO.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {

        [Fact]
        public void TestViewNames()
        {
            string test = "michael";
            Assert.Equal(test, viewNames("../../../myFile.txt", test));
        }

        [Fact]
        public void TestingNamesNotinList()
        {
            string test = "john";
            Assert.Equal(test, viewNames("../../../myFile.txt", test));
        }


        [Fact]
        public void TestingNamesAdded()
        {
            string test = "test";
            Assert.Equal(test, addName("../../../myFile.txt", test));
        }


    }
}
