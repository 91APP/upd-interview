using System.Collections.Generic;
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
