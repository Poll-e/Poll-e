using System.Threading.Tasks;

namespace PollE.Services
{
    public interface ICodeService
    {
        public Task<string> GenerateCode();
    }
}