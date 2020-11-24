using System.Collections.Generic;
using System.Threading.Tasks;
using PollE.Model;

namespace PollE.DataAccess.DataService
{
    public interface IOptionService
    {
        Task<IEnumerable<PollOption>> GetOptionsAsync(string code);
        Task CreateOptionAsync(string code, string text, Image image);
        public Task<Image> GetImageAsync(string code, int id);
    }
}