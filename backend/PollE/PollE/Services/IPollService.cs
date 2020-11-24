using System.Threading.Tasks;
using PollE.DataAccess.Entities;
using PollE.Model;

namespace PollE.DataAccess.DataService
{
    public interface IPollService
    {
        public Task<Poll> GetPollByCode(string code);
        
        public Task<string> CreatePoll(string title, string category);

    }
}