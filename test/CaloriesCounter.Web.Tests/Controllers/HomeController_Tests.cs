using System.Threading.Tasks;
using CaloriesCounter.Models.TokenAuth;
using CaloriesCounter.Web.Controllers;
using Shouldly;
using Xunit;

namespace CaloriesCounter.Web.Tests.Controllers
{
    public class HomeController_Tests: CaloriesCounterWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}