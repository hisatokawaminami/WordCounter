using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;
using System.Collections.Generic;
using System;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void GetDescription_UserInput()
    {
      //Arrange
      string userInput = "hello";
      RepeatCounter newRepeatCounter = new RepeatCounter(userInput);

      //Act
      string result = newRepeatCounter.GetUserInput();

      Console.WriteLine(userInput);
      Console.WriteLine(result);

      //Assert
      Assert.AreEqual(userInput, result);
      Assert.AreEqual(true, false);


    }
  }
}
