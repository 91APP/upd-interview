using MyCheckedListNet46.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyCheckedListNet46.BusinessLogic
{
    public class ItemService : IItemService
    {
        private IItemRepository _itemRepository;

        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public List<Item> GetItems()
        {
            return _itemRepository.GetItems().ToList();
        }
    }
}