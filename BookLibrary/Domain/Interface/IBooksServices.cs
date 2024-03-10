using Domain.Model;
using Domain.Service;
using Repository.Interfaces;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Domain.Interface.IBooksServices;

namespace Domain.Interface
{
    public interface IBooksServices:IGenericService<Books>
    {
        Task<IEnumerable<BooksDto>> GetBooksByTerms(string searchBy, string searchTerm);
    }
}
