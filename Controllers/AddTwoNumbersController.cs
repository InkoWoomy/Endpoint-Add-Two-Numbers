using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CombineMini2.Services;

namespace CombineMini2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CombineMini2 : Controller
    {
        private readonly IAddTwoNumbers _addTwoNumbers;

        public CombineMini2(IAddTwoNumbers addTwoNumbers)
        {
            _addTwoNumbers = addTwoNumbers;
        }

        //Combine Mini Challenge 2
        [HttpGet]
        [Route("MiniChallenge2/{num1}/{num2}")]
        public string TwoNumbers(int num1, int num2)
        {
            return _addTwoNumbers.TwoNumbers(num1, num2);
        }
    }
}
