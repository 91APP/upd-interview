namespace MyCheckedList.Data
{
    public class Member
    {
        public int MemberId { get; set; }

        public string? MemberName { get; set; }

        public ICollection<CheckedItem>? CheckedItems { get; set; }
    }
}
