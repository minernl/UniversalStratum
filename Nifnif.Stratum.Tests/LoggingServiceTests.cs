using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nifnif.Stratum.Services;
using System.Diagnostics;

namespace Nifnif.Stratum.Tests
{
    [TestClass]
    public class TraceLoggingServiceTests
    {
        public TestTraceListener traceListener = new TestTraceListener();
        [TestInitialize]
        public void TestInitialize() {
            Trace.Listeners.Add(traceListener);
        }
        [TestMethod]
        public void TraceInfoShouldWriteMessageToTrace()
        {
            var message = "testmessage";
            var loggingService = new TraceLoggingService();
            loggingService.LogInfo(message);
            Assert.AreEqual(message, traceListener.WrittenValue);
        }

        [TestMethod]
        public void TraceErrorShouldWriteMessageToTrace()
        {
            var message = "testmessage";
            var loggingService = new TraceLoggingService();
            loggingService.LogError(message);
            Assert.AreEqual(message, traceListener.WrittenValue);
        }

        [TestMethod]
        public void TraceWarningShouldWriteMessageToTrace()
        {
            var message = "testmessage";
            var loggingService = new TraceLoggingService();
            loggingService.LogWarning(message);
            Assert.AreEqual(message, traceListener.WrittenValue);
        }
    }
}
