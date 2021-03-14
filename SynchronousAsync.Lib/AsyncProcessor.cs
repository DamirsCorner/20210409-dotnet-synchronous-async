using System;
using System.Threading.Tasks;

namespace SynchronousAsync.Lib
{
    public class AsyncProcessor : IProcessor
    {
        public async Task Process()
        {
            //await Task.Yield();
        }

        public async Task ProcessWithException(bool throws)
        {
            await Task.Yield();
            throw new ArgumentException();
        }

        public async Task<bool> ProcessWithResult()
        {
            await Task.Yield();
            return true;
        }
    }
}
