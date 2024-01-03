
namespace automation_dph.src.Tests
{
    [TestClass]
    [TestCategory("LOGIN API TEST SUITES")]
    public class Suites_LoginAPITests : BaseLoginPage
	{
        [TestMethod]
        public async Task Test_loginValidCredentialsAPI()
        {
            await LoginApiPages.LoginToAPI(DataConfiguration.qaUsername, DataConfiguration.qaPassword, DataConfiguration.ApiStagingUrl);
            await LoginApiAssertions.SuccessResponse(LoginApi.TestScenarios[0]);
        }

        [TestMethod]
        public async Task Test_loginInvalidPasswordAPI()
        {
            await LoginApiPages.LoginToAPI(DataConfiguration.qaUsername, "invalid", DataConfiguration.ApiStagingUrl);
            await LoginApiAssertions.ErrorResponse(LoginApi.TestScenarios[1]);
        }

        [TestMethod]
        public async Task Test_loginInvalidEmailAPI()
        {
            await LoginApiPages.LoginToAPI("invalid", DataConfiguration.qaPassword, DataConfiguration.ApiStagingUrl);
            await LoginApiAssertions.ErrorResponse(LoginApi.TestScenarios[2]);
        }

        [TestMethod]
        public async Task Test_loginInvalidCredentialsAPI()
        {
            await LoginApiPages.LoginToAPI("invalid", "invalid", DataConfiguration.ApiStagingUrl);
            await LoginApiAssertions.ErrorResponse(LoginApi.TestScenarios[3]);
        }

        [TestMethod]
        public async Task Test_loginEmailApiBlankValue()
        {
            await LoginApiPages.LoginToAPI("", DataConfiguration.qaPassword, DataConfiguration.ApiStagingUrl);
            await LoginApiAssertions.ErrorResponse(LoginApi.TestScenarios[4]);
        }

        [TestMethod]
        public async Task Test_loginPasswordApiBlankValue()
        {
            await LoginApiPages.LoginToAPI(DataConfiguration.qaUsername, "", DataConfiguration.ApiStagingUrl);
            await LoginApiAssertions.ErrorResponse(LoginApi.TestScenarios[5]);
        }

        [TestMethod]
        public async Task Test_loginEmailApiMaxLengthValue()
        {
            await LoginApiPages.LoginToAPI("rm@qa.fleetfleetfleetfleetfleetfleetfleetfleetfleetfleetfleetfleetfleetfleet.ph", DataConfiguration.qaPassword, DataConfiguration.ApiStagingUrl);
            await LoginApiAssertions.ErrorResponse(LoginApi.TestScenarios[6]);
        }

        [TestMethod]
        public async Task Test_loginPasswordApiMaxLengthValue()
        {
            await LoginApiPages.LoginToAPI(DataConfiguration.qaUsername, "LMI@2020fleetfleetfleetfleetfleetfleetfleetfleetfleetfleetfleetfleet", DataConfiguration.ApiStagingUrl);
            await LoginApiAssertions.ErrorResponse(LoginApi.TestScenarios[7]);
        }
    }
}

