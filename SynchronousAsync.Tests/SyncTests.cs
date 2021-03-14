using NUnit.Framework;
using SynchronousAsync.Lib;
using System;
using System.Threading.Tasks;

namespace SynchronousAsync.Tests
{
    public class SyncTests
    {
        private readonly IProcessor processor = new SyncProcessor();

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
        public void TestProcessWithExceptionThrown()
        {
            Assert.That(() => processor.ProcessWithException(true), Throws.InstanceOf<ArgumentException>());
        }

        [Test]
        public void TestProcessWithExceptionReturned()
        {
            var task = processor.ProcessWithException(false);
            Assert.That(async () => await task, Throws.InstanceOf<ArgumentException>());
        }
    }
}