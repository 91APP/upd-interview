using MyCheckedListNet46.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCheckedListNet46.BusinessLogic
{
    public interface IItemService
    {
        List<Item> GetItems();
    }
}
