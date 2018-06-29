using System.Collections.Generic;
using System;

namespace WordCounter
{
  public class RepeatCounter
  {
    private string _userInput;


    public RepeatCounter (string userInput)
    {
      _userInput = userInput;
    }
    // public void SetUserInput(string newUserInput)
    // {
    //   _userInput = newUserInput;
    // }
    public string GetUserInput()
    {
      return _userInput;
    }

  }

}
