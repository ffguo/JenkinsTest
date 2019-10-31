using Leon.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leon.Test.ServicesTest
{
    [TestClass]
    public class UserServiceTest
    {
        private IServiceProvider _serviceProvider;

        public UserServiceTest()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddScoped<IUserService, UserService>();
            _serviceProvider = services.BuildServiceProvider();
        }

        [TestMethod]
        public void Test_GetUser_Return_RightUser()
        {
            var userService = _serviceProvider.GetService<IUserService>();
            var user = userService.GetUser(1);
            Assert.IsNotNull(user);
            Assert.AreEqual("ffg", user.Name);
        }

        [TestMethod]
        public void Test_GetUser_Return_Null()
        {
            var userService = _serviceProvider.GetService<IUserService>();
            var user = userService.GetUser(3);
            Assert.IsNull(user);
        }
    }
}
