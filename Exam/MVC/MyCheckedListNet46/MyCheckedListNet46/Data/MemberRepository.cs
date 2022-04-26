using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyCheckedListNet46.Data
{
    public class MemberRepository : IMemberRepository
    {
        private MyCheckListContext _context;

        public MemberRepository(MyCheckListContext context)
        {
            _context = context;
        }

        public Member GetMemberProfile()
        {
            throw new NotImplementedException();
        }
    }
}