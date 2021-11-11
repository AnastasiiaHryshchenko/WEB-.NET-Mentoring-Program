using System.Collections.Generic;
using System.Threading.Tasks;
using Moq;
using Northwind.MVC.Controllers;
using NorthwindBL;
using NPOI.SS.Formula.Functions;
using NUnit.Framework;
using Xunit;

namespace Northwind.Test
{
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        //[Test]
        //public void Test1()
        //{
        //    Assert.Pass();
        //}

        [Fact]
        public async Task Categories_ReturnsAViewResult__WithAListOfCategories()
        {
            var mokRepo = new Mock<IDatabaseManipulation>();
            //mokRepo.Setup(repo => repo.CategoryList()).ReturnsAsync(GetTestSessions());
            var categorycontroller = new CategoriesController(mokRepo.Object);

        }
        //private List<DatabaseManipulation> GetTestSessions()
        //{
        //    return
        //}
    }
}