using LeetCode.DTO.Request;
using LeetCode.Services;
using Microsoft.AspNetCore.Mvc;

namespace LeetCode.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LeetCodeController : ControllerBase
    {
        [HttpPost("/ReverseWordInAString")]
        public IActionResult ReverseWords([FromBody] ReverseWordInAStringRequest param)
        {
            ReverseWordInAString service = new ReverseWordInAString();
            string result = service.ReverseWords(param.s);
            return Ok(result);
        }
    }
}
