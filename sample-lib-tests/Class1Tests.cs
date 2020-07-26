using System;
using Xunit;
using sample_lib;

namespace sample_lib_tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
          //Arange
          string expected = "Hello.";
          //Act
          string actual = Class1.SayHello();
          //Assert
          Assert.Equal(expected, actual);
        }
    }
}
