using System;
using Xunit;
using sample_lib;

namespace sample_lib_tests
{
  public class Class1Tests
  {
    [Fact]
    public void SayHello_ReturnHello()
    {
      //Arange
      string expected = "Hello.";
      //Act
      string actual = Class1.SayHello();
      //Assert
      Assert.Equal(expected, actual);
    }
    [Fact]
    public void Sum_ReturnSum()
    {
      //Arange
      int expected = 3;
      //Act
      int actual = Class1.Sum(1, 2);
      //Assert
      Assert.Equal(expected, actual);
    }
  }
}
