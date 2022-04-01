using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using flashCardBackend.Models;
using flashCardBackend.Services.Context;

namespace flashCardBackend.Services
{
    public class HtmlCardService
    {
        private readonly DataContext _context;
        public HtmlCardService(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<HtmlCardModel> GetHtmlFlashCards()
        {
            return _context.HtmlFlashCards;
        }

         public HtmlCardModel GetHtmlCardById(int id)
        {
            return _context.HtmlFlashCards.SingleOrDefault(HtmlFlashCard => HtmlFlashCard.Id == id );
            
        }

        public bool AddHtmlFlashCard(HtmlCardModel newHtmlFlashCard)
        {
            _context.Add(newHtmlFlashCard);
            return _context.SaveChanges() != 0;
        }
    }
}