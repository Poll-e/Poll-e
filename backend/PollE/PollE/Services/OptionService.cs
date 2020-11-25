using System.Collections.Generic;
using System.Threading.Tasks;
using PollE.DataAccess.Repositories;
using PollE.Model;

namespace PollE.Services
{
    public class OptionService : IOptionService
    {
        private readonly IPollRepository _pollRepository; 
        private readonly IPollOptionRepository _optionRepository;

        public OptionService(IPollOptionRepository optionRepository, IPollRepository pollRepository)
        {
            this._optionRepository = optionRepository;
            this._pollRepository = pollRepository;
        }

        public async Task<IEnumerable<PollOption>> GetOptionsAsync(string code)
        {
            var poll = await _pollRepository.GetPollByCodeAsync(code);
            return await _optionRepository.GetOptionsForPoll(poll);
        }

        public async Task CreateOptionAsync(string code, string text, Image image)
        {
            var poll = await _pollRepository.GetPollByCodeAsync(code);
            await _optionRepository.InsertOptionWithImageAsync(poll, new PollOption() {Text = text}, image);
        }

        public async Task<Image> GetImageAsync(string code, int id)
        {
            var poll = await _pollRepository.GetPollByCodeAsync(code);
            var option = await _optionRepository.GetOptionForPollWithId(poll, id);
            return await _optionRepository.GetImageForOption(option);
        }
    }
}