using NUnit.Framework;
using SynchronousAsync.Lib;
using System;
using System.Threading.Tasks;

namespace SynchronousAsync.Tests
{
    public class AsyncTests
    {
        private readonly IProcessor processor = new AsyncProcessor();

        [Test]
        public async Task TestProcess()
        {
            await processor.Process();
            Assert.Pass();
        }

        [Test]
        public async Task TestProcessWithResult()
        {
            var result = await processor.ProcessWithResult();
            Assert.That(result, Is.True);
        }

        [Test]
        public void TestProcessWithException()
        {
            var task = processor.ProcessWithException(false);
            Assert.That(async () => await task, Throws.InstanceOf<ArgumentException>());
        }
    }
}