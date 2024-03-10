using AutoMapper;
using Domain.Interface;
using Domain.Mapping;
using Domain.Service;
using Moq;
using Repository.Interfaces;
using Repository.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace BooksTests
{
    public class BookServicesTests
    {
        [Fact]
        public async Task GetBooksByTerms_ReturnsFilteredBooks()
        {
            // Arrange
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapping());
            });

            var mapper = new Mapper(mapperConfig);

            var mockRepository = new Mock<IRepositoryServices<Books>>();

            var books = new List<Books>
            {
                new Books { Title = "Title1", FirstName = "First1", LastName = "Last1", TotalCopies = 10, CopiesInUse = 5, Type = "Type1", Isbn = "ISBN1", Category = "Category1" },
                new Books { Title = "Title2", FirstName = "First2", LastName = "Last2", TotalCopies = 20, CopiesInUse = 10, Type = "Type2", Isbn = "ISBN2", Category = "Category2" }
            };

            mockRepository.Setup(repo => repo.GetAll()).Returns(books.AsQueryable());

            var bookServices = new BookServices(mockRepository.Object, mapper);

            // Act
            var result = await bookServices.GetBooksByTerms("Title", "Title1");

            // Assert
            Assert.Single(result);
            var bookDto = result.First();
            Assert.Equal("Title1", bookDto.Title);
            Assert.Equal("First1", bookDto.FirstName);
            Assert.Equal("Last1", bookDto.LastName);
            Assert.Equal(10, bookDto.TotalCopies);
            Assert.Equal(5, bookDto.CopiesInUse);
            Assert.Equal("Type1", bookDto.Type);
            Assert.Equal("ISBN1", bookDto.Isbn);
            Assert.Equal("Category1", bookDto.Category);
        }
    }
}
