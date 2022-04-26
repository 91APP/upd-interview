using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCheckedListNet46.Data;

namespace MyCheckedListNet46.BusinessLogic
{
    public interface IMemberService
    {
        Member GetMember(int memberId);

        Member GetMemberByName(string memberName);

        List<CheckedItem> GetMemberCheckedItems(int memberId);
    }
}
