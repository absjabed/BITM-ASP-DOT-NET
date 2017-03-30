using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookBorrowSystemApp.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }

        //public Member()
        //{
        //    Random rnd = new Random();
        //    int num = rnd.Next(100, 999); 
        //    MemberNumber = num+MemberName.Substring(0,3);
        //}
    }
}