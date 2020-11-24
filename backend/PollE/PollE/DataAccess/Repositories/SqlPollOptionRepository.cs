using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PollE.DataAccess.Entities;
using PollE.DataAccess.Utils;
using PollE.Model;
using static PollE.DataAccess.Utils.Converter;

namespace PollE.DataAccess.Repositories
{
    class SqlPollOptionRepository : IPollOptionRepository
    {
        private readonly PollEDbContext _pollEDbContext;
        private DbSet<PollOptionEntity> Options;

        public SqlPollOptionRepository(PollEDbContext pollEDbContext)
        {
            _pollEDbContext = pollEDbContext;
        }

        public async Task InsertOptionWithImageAsync(Poll poll, PollOption option, Image image)
        {
            var imageEntity = new PollOptionImageEntity()
            {
                Data = image.Data,
                Extension = image.Extension,
                FileType = image.FileType,
                Name = image.Name
            };
            imageEntity = (await _pollEDbContext.AddAsync(imageEntity)).Entity;
            var pollEntity = new PollOptionEntity()
            {
                Image = imageEntity,
                Poll = _pollEDbContext.Polls.Single(x => x.Id==poll.Id),
                Text = option.Text
            };
            await _pollEDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<PollOption>> GetOptionsForPoll(Poll poll)
        {
            var options = await Options
                .Where(x => x.Poll.Id == poll.Id)
                .ToListAsync();
            return options.Select(x => x.ToModel());
        }

        public async Task<PollOption> GetOptionsForPollWithId(Poll poll, int id)
        {
            var option = await Options
                .SingleOrDefaultAsync(x => x.Id == id && x.Poll.Id == poll.Id);
            return option?.ToModel();
        }

        public async Task<Image> GetImageForOption(PollOption option)
        {
            var optionEntity = await Options
                .Include(x => x.Image)
                .SingleOrDefaultAsync(x => x.Id == option.Id);
            return optionEntity.Image.ToModel();
        }
    }
}