using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookBorrowSystemApp.Models
{
    public class BookBorrowed
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int MemberId { get; set; }
        public bool Status { get; set; }
    }
}