
namespace automation_dph.src.Tests
{
	[TestClass]
	[TestCategory("LOGIN TEST SUITES")]
    public class Suites_LoginTests : BaseLoginPage
    {
		[TestMethod]
		public async Task Test_loginValidCredentials()
		{
			await LoginPages.LoginToWebApplication("username","password");
		}
	}
}

