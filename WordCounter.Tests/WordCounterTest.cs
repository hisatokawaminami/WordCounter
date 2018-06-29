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
    public void GetInputWord_Return()
    {
      //Arrange
      string inputWord = "hello";
      string inputSentence = "hello world hello";
      RepeatCounter newRepeatCounter = new RepeatCounter(inputWord, inputSentence);

      //Act
      string resultWord = newRepeatCounter.GetInputWord();
      string resultSentence = newRepeatCounter.GetInputSentence();

      Console.WriteLine(inputWord);
      Console.WriteLine(resultWord);
      Console.WriteLine(inputSentence);
      Console.WriteLine(resultSentence);

      //Assert
      Assert.AreEqual(inputWord, resultWord);
      // Assert.AreEqual(inputSentence, resultSentence);

      // Assert.AreEqual(true, false);
    }
    //
    // [TestMethod]
    // public void CountMatchingWords()
    // {
    //   //Arrange
    //   string inputWord = "hello";
    //   string inputSentence = "hello world hello"
    //   int count = 2;
    //   RepeatCounter newRepeatCounter = new RepeatCounter(inputWord);
    //
    //   //Act
    //   string result = newRepeatCounter.GetInputWord();
    //
    //   Console.WriteLine(inputWord);
    //   Console.WriteLine(result);
    //
    //   //Assert
    //   Assert.AreEqual(result);
    //   // Assert.AreEqual(true, false);
    // }

  }
}
