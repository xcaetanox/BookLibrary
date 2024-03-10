using AutoMapper;
using Domain.Interface;
using Domain.Model;
using Repository.Interfaces;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service
{

    public class BookServices : GenericService<Books>, IBooksServices
    {
        private readonly IMapper _mapper;
        public BookServices(IRepositoryServices<Books> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }



        public async Task<IEnumerable<BooksDto>> GetBooksByTerms(string searchBy, string searchTerm)
        {
            var books = await GetAll();

            List<BooksDto> bookDtos = _mapper.Map<List<BooksDto>>(books);

            

            if (searchBy.ToUpper() == "Title".ToUpper())
            {
                bookDtos = bookDtos.Where(x => x.Title.Contains(searchTerm)).ToList();
            }
            if (searchBy.ToUpper() == "FirstName".ToUpper())
            {
                bookDtos = bookDtos.Where(x => x.FirstName.Contains(searchTerm)).ToList();
            }
            if (searchBy.ToUpper() == "LastName".ToUpper())
            {
                bookDtos = bookDtos.Where(x => x.LastName.Contains(searchTerm)).ToList();
            }
            if (searchBy.ToUpper() == "TotalCopies".ToUpper())
            {
                bookDtos = bookDtos.Where(x => x.TotalCopies == int.Parse(searchTerm)).ToList();
            }
            if (searchBy.ToUpper() == "CopiesInUse".ToUpper())  
            {
                bookDtos = bookDtos.Where(x => x.CopiesInUse == int.Parse(searchTerm)).ToList();
            }
            if (searchBy.ToUpper() == "Type".ToUpper())
            {
                bookDtos = bookDtos.Where(x => x.Type.Contains(searchTerm)).ToList();
            }
            if (searchBy.ToUpper() == "Isbn".ToUpper())
            {
                bookDtos = bookDtos.Where(x => x.Isbn.Contains(searchTerm)).ToList();
            }
            if (searchBy.ToUpper() == "Category".ToUpper())
            {
                bookDtos = bookDtos.Where(x => x.Category.Contains(searchTerm)).ToList();
            }




            return bookDtos;
        }
    }
}
