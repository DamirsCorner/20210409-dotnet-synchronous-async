using System;
using System.Threading.Tasks;

namespace SynchronousAsync.Lib
{
    public class SyncProcessor : IProcessor
    {
        public Task Process()
        {
            return Task.CompletedTask;
        }

        public Task ProcessWithException(bool throws)
        {
            if (throws)
            {
                throw new ArgumentException();
            }
            else
            {
                return Task.FromException(new ArgumentException());
            }
        }

        public Task<bool> ProcessWithResult()
        {
            return Task.FromResult(true);
        }
    }
}
