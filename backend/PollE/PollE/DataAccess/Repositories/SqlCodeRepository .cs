using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PollE.DataAccess.Entities;

namespace PollE.DataAccess.Repositories
{
    public class SqlCodeRepository : ICodeRepository
    {
        private DbSet<CodeEntity> Codes { get => _dbContext.Codes;}
        private readonly DBContext _dbContext;
        
        public SqlCodeRepository(DBContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task<CodeEntity> InsertCodeAsync(string value)
        {
            var code = new CodeEntity() {Code = value};
            await Codes.AddAsync(code);
            await _dbContext.SaveChangesAsync();
            return code;
        }
    }
}