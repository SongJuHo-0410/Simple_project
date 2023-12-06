using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_Program_LMP_
{
    internal class Book
    {
        public string Isbn { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public int Page { get; set; }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public bool IsBorrowed { get; set; }
        public DateTime BorrowedAt { get; set; }
    }
}
