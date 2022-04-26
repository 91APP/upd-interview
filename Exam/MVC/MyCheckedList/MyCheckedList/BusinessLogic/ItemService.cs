using MyCheckedList.Data;

namespace MyCheckedList.BusinessLogic
{
    public class ItemService
    {
        public readonly MyDbContext _context;

        public ItemService(MyDbContext context)
        {
            _context = context;
        }
    }
}
