using MyCheckedListNet46.Data;
using System.Collections.Generic;
using System.Linq;

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