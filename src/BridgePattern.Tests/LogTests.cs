using Xunit;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.Tests
{
    public class LogTests
    {
        [Theory(DisplayName = "桥接模式(Bridge)")]
        [InlineData("tom", "你好!")]
        [InlineData("lili", "你也好!")]
        public void SaveTest(string name, string message)
        {
            new Log(new DbLog(), name, message).Save();
            new Log(new FileLog(), name, message).Save();
        }
    }
}