using System;
using Xunit;
using Microsoft.VisualStudio.TestPlatform.Utilities;
namespace unittest.tests
{
    public class Triangletest
    {
        triangle tr = new triangle();
        [Fact]
        public void test1()
        {

            bool actual = tr.metodfalse(1, 2, 3);
            bool expected = true;

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void test2()
        {
            
            bool actual = tr.metodfalse(-1,1 , 3);
            bool expected = false;

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void test3()
        {

            bool actual = tr.metodfalse(10, 1, 1);
            bool expected = false;

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void test4()
        {

            bool actual = tr.metodfalse(-10, 1, 10);
            bool expected = true;

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void test5()
        {

            bool actual = tr.metodfalse(0, 1, 3);
            bool expected = false;

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void test6()
        {

            bool actual = tr.metodfalse(0, 0, 3);
            bool expected = false;

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void test7()
        {

            bool actual = tr.metodfalse(2, 5, 3);
            bool expected = true;

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void test8()
        {

            bool actual = tr.metodfalse(4, 8, 5);
            bool expected = true;

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void test9()
        {

            bool actual = tr.metodfalse(10, -1, 0);
            bool expected = false;

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void test10()
        {

            bool actual = tr.metodfalse(4, 1, 3);
            bool expected = true;

            Assert.Equal(expected, actual);
        }
    }
}
