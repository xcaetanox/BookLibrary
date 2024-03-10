using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class Books
    {
        [Key]
        public int BookId { get; set; }

        [MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }

        public int TotalCopies { get; set; } = 0;
        public int CopiesInUse { get; set; } = 0;
        [MaxLength(50)]
        public string? Type { get; set; }
        [MaxLength(80)]
        public string? Isbn { get; set; }
        [MaxLength(450)]
        public string? Category { get; set; }
    }
}
