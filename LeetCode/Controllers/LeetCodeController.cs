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

        [HttpPost("/ValidAnagram")]
        public IActionResult ValidAnagram([FromBody] ValidAnagramRequest param)
        {
            ValidAnagram service = new ValidAnagram();
            bool result = service.IsAnagram(param.s, param.t);
            return Ok(result);
        }

        [HttpPost("/IsIsomorphic")]
        public IActionResult IsIsomorphic([FromBody] ValidAnagramRequest param)
        {
            IsIsomorphic service = new IsIsomorphic();
            bool result = service.FindIsIsomorphic(param.s, param.t);
            return Ok(result);
        }

        [HttpPost("/RomanToInteger")]
        public IActionResult RomanToInteger([FromBody] ReverseWordInAStringRequest param)
        {
            RomanToInteger service = new RomanToInteger();
            int result = service.RomanToInt(param.s);
            return Ok(result);
        }

        [HttpPost("/ValidPalindrome")]
        public IActionResult ValidPalindrome([FromBody] ReverseWordInAStringRequest param)
        {
            ValidPalindrome service = new ValidPalindrome();
            bool result = service.IsPalindrome(param.s);
            return Ok(result);
        }
        [HttpPost("/PalindromeNumber")]
        public IActionResult PalindromeNumber([FromBody] PalindromeNumberRequest param)
        {
            PalindromeNumber service = new PalindromeNumber();
            bool result = service.IsPalindrome(param.x);
            return Ok(result);
        }
        [HttpPost("/SingleNumber")]
        public IActionResult SingleNumber([FromBody] SingleNumberRequest param)
        {
            SingleNumber service = new SingleNumber();
            int result = service.FindSingleNumber(param.nums);
            return Ok(result);
        }
        [HttpPost("/RansomNote")]
        public IActionResult RansomNote([FromBody] RansomNoteRequest param)
        {
            RansomNote service = new RansomNote();
            bool result = service.CanConstruct(param.ransomNote, param.magazine);
            return Ok(result);
        }
    }
}
