using System.Threading.Tasks;
using PollE.Model;

namespace PollE.Services
{
    public interface IPollService
    {
        public Task<Poll> GetPollByCode(string code);
        
        public Task<string> CreatePoll(string title, string category);

    }
}