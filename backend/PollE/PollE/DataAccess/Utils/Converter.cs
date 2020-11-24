using PollE.DataAccess.Entities;
using PollE.DataAccess.Repositories;
using PollE.Model;

namespace PollE.DataAccess.Utils
{
    public static class Converter
    {
        public static Poll ToModel(this PollEntity pollEntity)
        {
            return new Poll()
            {
                Title = pollEntity.Title,
                Category = pollEntity.Category,
                Code = pollEntity.Code,
                Id = pollEntity.Id
            };
        }
        
        public static PollOption ToModel(this PollOptionEntity pollOptionEntity)
        {
            return new PollOption()
            {
                Id = pollOptionEntity.Id,
                Text = pollOptionEntity.Text
            };
        }

        public static Image ToModel(this PollOptionImageEntity optionImageEntity)
        {
            return new Image()
            {
                Name = optionImageEntity.Name,
                Data = optionImageEntity.Data,
                Extension = optionImageEntity.Extension,
                FileType = optionImageEntity.FileType
            };
        }
    }
}