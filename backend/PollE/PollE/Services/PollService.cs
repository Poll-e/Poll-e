using System;
using System.Threading.Tasks;
using PollE.DataAccess.DataService;
using PollE.DataAccess.Repositories;
using Poll = PollE.Model.Poll;

namespace PollE.Services
{
    public class PollService : IPollService
    {
        private readonly IPollRepository _pollRepository;
        private readonly ICodeService _codeService;

        public PollService(IPollRepository pollRepository, ICodeService codeService)
        {
            this._pollRepository = pollRepository ?? throw new ArgumentNullException(nameof(pollRepository));
            this._codeService = codeService ?? throw new ArgumentNullException(nameof(codeService));
        }
        
        public Task<Poll> GetPollByCode(string code)
        {
            return _pollRepository.GetPollByCodeAsync(code);
        }

        public async Task<string> CreatePoll(string title, string category)
        {
            var code = await _codeService.GenerateCode();
            
            var poll = new Poll
            {
                Title = title,
                Category = category,
                Code = code
            };
            
            await _pollRepository.InsertPollAsync(poll);

            return code;
        }
    }
}