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
    public class HtmlController : ControllerBase
    {
        private readonly HtmlCardService _data;

        public HtmlController(HtmlCardService _dataFromController)
        {
            _data = _dataFromController;
        }

        [HttpGet("GetAllHtmlFlashCards")]
        public IEnumerable<HtmlCardModel> GetHtmlFlashCards()
        {
            return _data.GetHtmlFlashCards();
        }

        [HttpGet("GetHtmlCardById/{id}")]
        public HtmlCardModel GetHtmlCardById(int id)
        {
            return _data.GetHtmlCardById(id);
        }

        [HttpGet("RandomHtmlId/{min}/{max}")]
        public int RandomHtmlId(int min, int max)
        {
            Random r = new Random();
            int rNum = r.Next(min, max);
            return rNum;
        }

        //route for adding an object or a question for HTML
        [HttpPost("AddHtmlFlashCard")]
        public bool AddHtmlFlashCard(HtmlCardModel newHtmlFlashCard)
        {
            return _data.AddHtmlFlashCard(newHtmlFlashCard);
        }
    }
}