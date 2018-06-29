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
      Assert.AreEqual(inputSentence, resultSentence);

      // Assert.AreEqual(true, false);
    }

    // [TestMethod]
    // public void InputSentenceToSplitArray_True()
    // {
    //   //Arrange
    //   string inputSentence = "hello world hello";
    //   RepeatCounter newRepeatCounter = new RepeatCounter("", inputSentence);
    //
    //   //Act
    //   string[] result = newRepeatCounter.InputSentenceToSplitArray();
    //   string[] expected = {"hello", "world", "hello"};
    //   // Console.WriteLine(inputSentence);
    //   // Console.WriteLine(result);
    //
    //   //Assert
    //   Assert.AreEqual(result, expected);
    //   // Assert.AreEqual(true, false);
    // }


    [TestMethod]
    public void CountMatching_True()
    {
      //Arrange
      string inputWord = "hello";
      string inputSentence = "hello world hello";
      RepeatCounter newRepeatCounter = new RepeatCounter(inputWord, inputSentence);

      //Act
      int count = newRepeatCounter.CountMatching();
      int expected = 2;

      Console.WriteLine(count);

      //Assert
      Assert.AreEqual(count, expected);
      Assert.AreEqual(true, false);
    }
  }
}
