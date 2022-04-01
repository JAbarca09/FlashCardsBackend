using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using flashCardBackend.Models;
using flashCardBackend.Services.Context;

namespace flashCardBackend.Services
{
    public class CsharpCardService
    {
        private readonly DataContext _context;
        public CsharpCardService(DataContext context)
        {
            _context = context;
        }
        
        public IEnumerable<CsharpCardModel> GetAllCsharpFlashCards()
        {
            return _context.CsharpFlashCards;
        }

        public CsharpCardModel GetCsharpCardById(int id)
        {
            return _context.CsharpFlashCards.SingleOrDefault(CsharpCard => CsharpCard.Id == id);
        }
    }
}