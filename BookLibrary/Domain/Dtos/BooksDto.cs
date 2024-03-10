using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class BooksDto
    {

        public int BookId { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TotalCopies { get; set; } = 0;
        public int CopiesInUse { get; set; } = 0;
        public string? Type { get; set; }
        public string? Isbn { get; set; }
        public string? Category { get; set; }
    }
}
