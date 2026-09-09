using System;
using System.Collections.Generic;
using System.Text;

namespace gym
{
    internal class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public MembershipType MembershipType { get; set; }
        public MembershipPrice MembershipPrice { get; set; }
    }
}
