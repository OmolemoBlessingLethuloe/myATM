using System.Threading.Tasks;
using myATM.Models.TokenAuth;
using myATM.Web.Controllers;
using Shouldly;
using Xunit;

namespace myATM.Web.Tests.Controllers
{
    public class HomeController_Tests: myATMWebTestBase
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