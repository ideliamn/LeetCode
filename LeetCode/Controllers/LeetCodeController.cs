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

        [HttpPost("/RotateArray")]
        public IActionResult RotateArray([FromBody] RotateArrayRequest param)
        {
            RotateArray service = new RotateArray();
            service.Rotate(param.nums, param.k);
            return Ok(param.nums);
        }

        [HttpPost("/WordPattern")]
        public IActionResult WordPattern([FromBody] WordPatternRequest param)
        {
            WordPattern service = new WordPattern();
            bool result = service.FindWordPattern(param.pattern, param.s);
            return Ok(result);
        }
    }
}
