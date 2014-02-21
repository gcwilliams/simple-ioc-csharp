using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IOC.Builder;
using IOC;

namespace IOCTest
{
    [TestClass]
    public class IOCBuilderTest
    {
        [TestMethod]
        public void NoDependencies()
        {
            // arrange
            IOCBuilder builder = IOCBuilder.NewInstance();
            builder.Bind<IDao>().To<Dao>();

            IIOC ioc = builder.Build();

            // act
            IDao dao = ioc.Resolve<IDao>();

            // assert
            Assert.IsInstanceOfType(dao, typeof(IDao));
        }

        [TestMethod]
        public void OneDependency()
        {
            // arrange
            IOCBuilder builder = IOCBuilder.NewInstance();
            builder.Bind<IDao>().To<Dao>();
            builder.Bind<IValidator>().To<Validator>();

            IIOC ioc = builder.Build();

            // act
            IValidator dao = ioc.Resolve<IValidator>();

            // assert
            Assert.IsInstanceOfType(dao, typeof(IValidator));
        }

        [TestMethod]
        public void TwoDependencies()
        {
            // arrange
            IOCBuilder builder = IOCBuilder.NewInstance();
            builder.Bind<IDao>().To<Dao>();
            builder.Bind<IValidator>().To<Validator>();
            builder.Bind<IService>().To<Service>();

            IIOC ioc = builder.Build();

            // act
            IService dao = ioc.Resolve<IService>();

            // assert
            Assert.IsInstanceOfType(dao, typeof(IService));
        }

        [TestMethod]
        [ExpectedException(typeof(BindingException))]
        public void MissingDependency()
        {
            // arrange
            IOCBuilder builder = IOCBuilder.NewInstance();
            builder.Bind<IDao>().To<Dao>();
            builder.Bind<IService>().To<Service>();

            IIOC ioc = builder.Build();

            // act
            IService dao = ioc.Resolve<IService>();
        }
    }
}
