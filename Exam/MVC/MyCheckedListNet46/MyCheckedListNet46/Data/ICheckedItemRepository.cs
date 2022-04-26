using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCheckedListNet46.Data
{
    public interface ICheckedItemRepository
    {
        List<CheckedItem> GetMemberCheckedItems();
    }
}
