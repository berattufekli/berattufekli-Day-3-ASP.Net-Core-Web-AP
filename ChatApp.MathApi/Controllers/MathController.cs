using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ChatApp.MathApi.Controllers
{
    [Route("Math")]
    [ApiController]
    public class MathController : ControllerBase
    {
        [HttpGet("Add")]
        public IActionResult Add(double num1, double num2)
        {
            return Ok(num1 + num2);
        }

        [HttpGet("Sub")]
        public IActionResult Substract(double num1, double num2)
        {
            return Ok(num1 - num2);
        }

        [HttpGet("Mult")]
        public IActionResult Multiply(double num1, double num2)
        {
            return Ok(num1 * num2);
        }

        [HttpGet("Div")]
        public IActionResult Divide(double num1, double num2)
        {
            if(num2 == 0)
            {
                return BadRequest("num2 cannot equal 0");
            }
            return Ok(num1 / num2);
        }

        [HttpGet("Mod")]
        public IActionResult Mod(double num1, double num2)
        {
            return Ok(num1 % num2);
        }

        [HttpGet("Pwr")]
        public IActionResult Power(double num1, double num2)
        {
            return Ok(Math.Pow(num1, num2));
        }

        [HttpGet("Sqrt")]
        public IActionResult SquareRoot(double num1)
        {
            return Ok(Math.Sqrt(num1));
        }
    }
}
