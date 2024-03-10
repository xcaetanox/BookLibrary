using AutoMapper;
using Domain.Model;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Mapping
{
    public class AutoMapping:Profile
    {
        public AutoMapping() 
        {
            CreateMap<Repository.Models.Books, Domain.Model.BooksDto>().ReverseMap(); 
        
        }

        
    }
}
