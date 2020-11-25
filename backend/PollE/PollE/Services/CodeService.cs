using System;
using System.Threading.Tasks;

namespace PollE.Services
{
    public class CodeService: ICodeService
    {
        public Task<string> GenerateCode()
        {
            string code = String.Empty;
            Random r = new Random();
            
            for (int i = 0; i < 6; i++)
            {
                int generated = r.Next() % 10;

                code += generated.ToString();
            }

            return Task.FromResult(code);
        }
    }
}