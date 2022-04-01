using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using flashCardBackend.Services;
using flashCardBackend.Models;

namespace flashCardBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CsharpController : ControllerBase
    {
        private readonly CsharpCardService _data;
        
        public CsharpController(CsharpCardService _dataFromController)
        {
            _data = _dataFromController;
        }

        [HttpGet("RandomCsharpId/{min}/{max}")]
        public int RandomCsharpId(int min, int max)
        {
            Random r = new Random();
            int rNum = r.Next(min, max);
            return rNum;
        }

        [HttpGet("GetAllCsharpFlashCards")]
        public IEnumerable<CsharpCardModel> GetAllCsharpFlashCards()
        {
            return _data.GetAllCsharpFlashCards();
        }

        [HttpGet("GetCsharpCardById/{id}")]
        public CsharpCardModel GetCsharpCardById(int id)
        {
            return _data.GetCsharpCardById(id);
        }
    }
}