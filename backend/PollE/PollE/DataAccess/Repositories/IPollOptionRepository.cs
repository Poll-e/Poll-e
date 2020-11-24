using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using PollE.Controllers.DTOs;
using PollE.Model;
using Poll = PollE.Model.Poll;

namespace PollE.DataAccess.Repositories
{
    public interface IPollOptionRepository
    {
        Task InsertOptionWithImageAsync(Poll poll, PollOption option, Image image);

        Task<IEnumerable<PollOption>> GetOptionsForPoll(Poll poll);

        Task<PollOption> GetOptionsForPollWithId(Poll poll, int Id);

        Task<Image> GetImageForOption(PollOption option);
    }
}