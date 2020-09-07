using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using StockMarketLibrary;
using StockMarketApp.AdminService.Models;
using StockMarketApp.AdminService.Repository;
using StockMarketApp.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StockMarketApp.Tests.Unit
{
    [TestFixture]
    public class UnitTestStockPriceRepository
    {
        DbContextOptions<AdminContextDB> options = new DbContextOptionsBuilder<AdminContextDB>()
            .UseInMemoryDatabase("StockMarketDB")
            .Options;
        AdminContextDB context = null;

        [SetUp]
        public void Setup()
        {
            context = new AdminContextDB(options);
            context.StockPrice.AddRange(GetStockPriceList());
            context.SaveChanges();
        }

        private IEnumerable<StockPrice> GetStockPriceList()
        {
            var cse = new StockExchangeCompanies
            {
                CompanyId = 1,
                StockExchangeId = "BSE"
            };

            return new List<StockPrice>
            {
                new StockPrice
                {
                    Id = 1,
                    CurrentPrice = 100,
                    Date = new DateTime().ToShortDateString(),
                    Time = new DateTime().ToShortTimeString(),
                    StockExchangeCompanies = cse
                },
                new StockPrice
                {
                    Id = 2,
                    CurrentPrice = 101,
                    Date = new DateTime().ToShortDateString(),
                    Time = new DateTime().AddMinutes(1).ToShortTimeString(),
                    StockExchangeCompanies = cse
                }
            };
        }

        [TearDown]
        public void Teardown()
        {
            if (context != null)
            {
                context.Dispose();
            }
        }

        [Test]
        public void Test_Get_ShouldReturnStockPriceList()
        {
            //Arrange
            IRepository<StockPriceDto> repository = new StockpriceRepository(context);
            //Act
            var list = repository.Get();
            //Assert
            var actualCount = list.Count();
            Assert.That(actualCount, Is.EqualTo(GetStockPriceList().Count()),
                "Stock price List count does not match");
        }
    }
}