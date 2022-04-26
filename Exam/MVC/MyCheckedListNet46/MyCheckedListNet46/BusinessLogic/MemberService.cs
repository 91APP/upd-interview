using MyCheckedListNet46.Data;
using System;
using System.Collections.Generic;

namespace MyCheckedListNet46.BusinessLogic
{
    public class MemberService : IMemberService
    {
        private readonly IMemberRepository _memberRepository;

        public MemberService(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }

        public Member GetMember(int memberId)
        {
            return _memberRepository.GetMemberProfile(memberId);
        }

        public Member GetMemberByName(string memberName)
        {
            return _memberRepository.GetMemberProfile(memberName);
        }

        public List<CheckedItem> GetMemberCheckedItems(int memberId)
        {
            throw new NotImplementedException();
        }
    }
}