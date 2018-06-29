using System.Collections.Generic;
using System;

namespace WordCounter
{
  public class RepeatCounter
  {
    private string _inputWord;
    private string _inputSentence;

    public RepeatCounter(string inputWord, string inputSentence)
    {
      _inputWord = inputWord;
      _inputSentence = inputSentence;
    }

    public string GetInputWord()
    {
      return _inputWord;
    }
    public string GetInputSentence()
    {
      return _inputSentence;
    }
  //   public string[] InputSentenceToSplitArray()
  //   {
  //     string[] temp = _inputSentence.Split(' ');
  //   }
  // }
    public int CountMatching()
    {
      int count = 0;
      string[] temp = _inputSentence.Split(' ');
      for(int i = 0; i < temp.Length; i++)
      {
        if (_inputWord == temp[i])
        {
          count++;
        }
        
      }
      return count;
    }

// public class Program
//   {
//     public static void Main()
//     {
//       Console.WriteLine("Enter a word");
//       string inputWord = Console.ReadLine();
//
//        RepeatCounter inputWord = new RepeatCounter (Console.ReadLine(), "");
//        Console.WriteLine(this.GetUserInputWord());
//     }
//   }
// public class Program
//  {
//    public static void Main()
//    {
//      Console.WriteLine("Please enter a word:");
//      string word = Console.ReadLine();
//      Console.WriteLine("Please enter a sentence or list of words separate by space:");
//      string sentence = Console.ReadLine();
//      RepeatCounter repeatCounter = new RepeatCounter(word);
//      int count = repeatCounter.CountWordFrequency(sentence);
//      Console.WriteLine("The word " + word + " appears " + count + " times.");
//    }
 }


}
