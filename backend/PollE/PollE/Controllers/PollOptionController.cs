using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PollE.Controllers.DTOs;
using PollE.DataAccess.DataService;
using PollE.Model;
using PollE.Services;

namespace PollE.Controllers
{
    [ApiController]
    [Route("polls/{code?}/options")]
    public class PollOptionController : ControllerBase
    {
        private readonly ILogger<PollOptionController> _logger;
        private readonly IOptionService _optionService;

        public PollOptionController(IOptionService optionService, ILogger<PollOptionController> logger)
        {
            _optionService = optionService;
            _logger = logger;
        }
        
        [HttpPost]
        public async Task<IActionResult> Create([FromRoute] string code, [FromQuery] string text)
        {
            var file = Request.Form.Files[0]; ;
            var fileName = Path.GetFileNameWithoutExtension(file.FileName);
            var extension = Path.GetExtension(file.FileName);
            var fileModel = new Image()
            {
                FileType = file.ContentType,
                Extension = extension,
                Name = fileName,
            };
            await using var dataStream = new MemoryStream();
            await file.CopyToAsync(dataStream);
            fileModel.Data = dataStream.ToArray();

            await _optionService.CreateOptionAsync(code, text, fileModel);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> List([FromRoute] string code)
        {
            var options = await _optionService.GetOptionsAsync(code);
            return Ok(options.Select(x => new Option(){Id = x.Id, Text = x.Text}));
        }

        [HttpGet]
        [Route("{id?}")]
        public async Task<IActionResult> GetImage([FromRoute] string code, [FromRoute] int id)
        {
            var file = await _optionService.GetImageAsync(code, id);
            return File(file.Data, file.FileType, file.Name+file.Extension);
        }
    }
}