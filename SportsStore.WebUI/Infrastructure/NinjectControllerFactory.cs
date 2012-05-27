using System;
using System.Web.Mvc;
using Ninject;
using SportsStore.Domain.Abstract;
using Moq;
using SportsStore.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using SportsStore.Domain.Concrete;

namespace SportsStore.WebUI.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            return controllerType == null
                ? null
                : (IController)ninjectKernel.Get(controllerType);
        }

        private void AddBindings()
        {
            // add bindings

            // Mock implementation of the IProductRepository Interface
            //Mock<IProductRepository> mock = new Mock<IProductRepository>();
            //mock.Setup(m => m.Products).Returns(new List<Product>{
            //    new Product { Name = "Fotball", Price = 25 },
            //    new Product { Name = "Surf board", Price = 179 },
            //    new Product { Name = "Running shoes ", Price = 79 }}.AsQueryable());
            //ninjectKernel.Bind<IProductRepository>().ToConstant(mock.Object);

            ninjectKernel.Bind<IProductRepository>().To<EFProductRepository>();



        }
    }
}