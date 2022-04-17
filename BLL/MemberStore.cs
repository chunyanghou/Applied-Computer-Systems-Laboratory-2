using System;
using System.Collections.Generic;

namespace LibraryManager.BLL
{
    public sealed class MemberStore: MemberSearch
    {
        public List<Member> members { get; set; }

        private static readonly MemberStore instance = new MemberStore();

        static MemberStore()
        {

        }

        private MemberStore()
        {
            members = new List<Member>();
        }

        public static MemberStore Instance
        {
            get
            {
                return instance;
            }
        }

        public List<Member> SearchByPerson(Person name)
        {
            return this.GetMembersByName(Person.name);
        }

        public List<Member> GetMembersByName(String name)
        {
            return members.FindAll(m => m.person.name == name);
        }

        public Member GetMembersByID(String id)
        {
            return members.Find(m => m.id == id);
        }

        public void AddNewMember(String id, Person name)
        {
            if (!members.Exists(m => m.id == id))
            {
                Member member = new Member(id, person);
                members.Add(member);
            }
        }

        public void RemoveMember(Member member)
        {
            if (members.Contains(member))
            {
                _ = members.Remove(member);
            }
        }
    }
}
