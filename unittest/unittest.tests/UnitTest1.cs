using System;
using Xunit;
using Microsoft.VisualStudio.TestPlatform.Utilities;
namespace unittest.tests
{
    public class UnitTest
    {
        triangle tr = new triangle();

        [Fact]

        public void Test1()
        {
            
            bool actual = tr.metodfalse(1, 2, 3);
            

            Assert.Equal(true, actual);
        }
        [Fact]
        public void Test2()
        {
            
            bool actual = tr.metodfalse(-1,1 , 3);


            Assert.Equal(true, actual);
        }
        [Fact]
        public void Test3()
        {

            bool actual = tr.metodfalse(10, 1, 1);
            

            Assert.Equal(true, actual);
        }
        [Fact]
        public void Test4()
        {

            bool actual = tr.metodfalse(-10, 1, 10);


            Assert.Equal(false, actual);
        }
        [Fact]
        public void Test5()
        {

            bool actual = tr.metodfalse(0, 1, 3);


            Assert.Equal(true, actual);
        }
        [Fact]
        public void Test6()
        {

            bool actual = tr.metodfalse(0, 1.5, 3);
            bool expected = false;

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test7()
        {

            bool actual = tr.metodfalse(2, 5, 3);


            Assert.Equal(true, actual);
        }
        [Fact]
        public void Test8()
        {

            bool actual = tr.metodfalse(4, 8, 5.88);

            Assert.Equal(true, actual);
        }
        [Fact]
        public void Test9()
        {

            bool actual = tr.metodfalse(0.19, -1, 0);


            Assert.Equal(false, actual);
        }
        [Fact]
        public void Test10()
        {

            bool actual = tr.metodfalse(4, 1, 3);


            Assert.Equal(true, actual);
        }
    }
}
