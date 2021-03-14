using System.Threading.Tasks;

namespace SynchronousAsync.Lib
{
    public interface IProcessor
    {
        Task Process();
        Task<bool> ProcessWithResult();
        Task ProcessWithException(bool throws);
    }
}
