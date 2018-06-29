using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong;

namespace PingPong.Tests
{
  [TestClass]
  public class PingPongGeneratorTest
  {
    [TestMethod]
    public void ConvertToPingPong_NumberDivisibleByThree()
    {
      PingPongGenerator testPingPong = new PingPongGenerator();
      Assert.AreEqual("Ping", testPingPong.ConvertToPingPong(3));
    }

    [TestMethod]
    public void ConvertToPingPong_NumberDivisibleByFive()
    {
      PingPongGenerator testPingPong = new PingPongGenerator();
      Assert.AreEqual("Pong", testPingPong.ConvertToPingPong(5));
    }

    [TestMethod]
    public void ConvertToPingPong_NumberDivisibleByThreeAndFive()
    {
      PingPongGenerator testPingPong = new PingPongGenerator();
      Assert.AreEqual("PingPong", testPingPong.ConvertToPingPong(15));
    }

    [TestMethod]
    public void ConvertToPingPong_NumberNotDivisiveByThreeOrFive()
    {
      PingPongGenerator testPingPong = new PingPongGenerator();
      Assert.AreEqual("22", testPingPong.ConvertToPingPong(22));
    }

    // [TestMethod]
    // public void PrintOutNumberList()
    // {
    //   PingPongCounter testPingPong = new PingPongCounter();
    //
    // }

  }
}
