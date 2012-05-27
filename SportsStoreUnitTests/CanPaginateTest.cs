using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using NUnit.Framework;
using Moq;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using SportsStore.WebUI.Controllers;

namespace SportsStoreUnitTests
{
    [TestFixture]
    public class CanPaginateTest
    {
        [Test]
        public void Can_Paginate()
        {
            Mock<IProductRepository> mock = new Mock<IProductRepository>();

            mock.Setup(m => m.Products).Returns(new List<Product>{
                new Product {ProductID = 1, Name ="P1"},
                new Product {ProductID = 2, Name ="P2"},
                new Product {ProductID = 3, Name ="P3"},
                new Product {ProductID = 4, Name ="P4"},
                new Product {ProductID = 5, Name ="P5"}
            }.AsQueryable());

            ProductController controller = new ProductController(mock.Object);
            controller.PageSize = 3;

            IEnumerable<Product> result = (IEnumerable<Product>)controller.List(2).Model;

            Product[] prodArray = result.ToArray();
            Assert.IsTrue(prodArray.Length == 2);
            Assert.AreEqual(prodArray[0].Name, "P4");
        }
    }
}
