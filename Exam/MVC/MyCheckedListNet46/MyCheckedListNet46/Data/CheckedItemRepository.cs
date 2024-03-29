﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyCheckedListNet46.Data
{
    public class CheckedItemRepository : ICheckedItemRepository
    {
        private MyCheckListContext _context;

        public CheckedItemRepository(MyCheckListContext context)
        {
            _context = context;
        }

        public List<CheckedItem> GetCheckedItemsByMemberId(int memberId)
        {
            return _context.CheckedItems.Where(x => x.MemberId == memberId).ToList();
        }
    }
}