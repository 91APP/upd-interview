using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyCheckedListNet46.Data
{
    public class ItemRepository : IItemRepository
    {
        private MyCheckListContext _context;

        public ItemRepository(MyCheckListContext context)
        {
            _context = context;
        }

        public Item GetItemById()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetItems()
        {
            return _context.Items.ToList();
        }
    }
}