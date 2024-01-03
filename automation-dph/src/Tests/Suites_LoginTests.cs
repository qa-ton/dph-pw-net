
namespace automation_dph.src.Tests
{
	[TestClass]
	[TestCategory("LOGIN TEST SUITES")]
    public class Suites_LoginTests : BaseLoginPage
    {
		[TestMethod]
		public async Task Test_loginValidCredentials()
		{
			await LoginPages.LoginToWebApplication(DataConfiguration.qaUsername,DataConfiguration.qaPassword);
			await LoginAssertions.ShouldBeSuccessNotification(
				Login.TestScenarios[0], Login.ScreenShotFolderName, "Login: Test Case 1.1");
		}

        [TestMethod]
        public async Task Test_loginInValidEmailCredetials()
        {
            await LoginPages.LoginToWebApplication("invalid", DataConfiguration.qaPassword);
            await LoginAssertions.ShouldBeErrorNotification(
                Login.TestScenarios[1], Login.ScreenShotFolderName, "Login: Test Case 1.2");
        }

        [TestMethod]
        public async Task Test_loginInValidPasswordCredetials()
        {
            await LoginPages.LoginToWebApplication(DataConfiguration.qaUsername, "invalid");
            await LoginAssertions.ShouldBeErrorNotification(
                Login.TestScenarios[2], Login.ScreenShotFolderName, "Login: Test Case 1.3");
        }

        [TestMethod]
        public async Task Test_loginInValidCredetials()
        {
            await LoginPages.LoginToWebApplication("invalid", "invalid");
            await LoginAssertions.ShouldBeErrorNotification(
                Login.TestScenarios[3], Login.ScreenShotFolderName, "Login: Test Case 1.4");
        }

        [TestMethod]
        public async Task Test_loginRememberUsername()
        {
            await LoginPages.LoginToWebApplication(DataConfiguration.qaUsername, DataConfiguration.qaPassword);
            await LoginPages.RememberUsername_Checkbox.ClickAsync();
            await MyPostsPages.LogoutToWebApplication();
            await LoginAssertions.ShouldBeRemember(
                Login.TestScenarios[4], Login.ScreenShotFolderName, "Login: Test Case 1.5");
        }

        [TestMethod]
        public async Task Test_loginForgotPassword()
        {
            await LoginPages.GoToForgotPassword();
            await LoginAssertions.ShouldBeResetUrl(
                Login.TestScenarios[5], Login.ScreenShotFolderName, "Login: Test Case 1.6");
        }

        [TestMethod]
        public async Task Test_ResetPassword()
        {
            await LoginPages.ForgotPassword_Hyperlink.ClickAsync();
            await LoginPages.EmailReset_Textfield.FillAsync(DataConfiguration.qaUsername);
            await LoginPages.ResetPassword_Button.ClickAsync();
            await LoginAssertions.ShouldBeSuccessNotification(
                Login.TestScenarios[6], Login.ScreenShotFolderName, "Login: Test Case 1.7");
        }

        [TestMethod]
        public async Task Test_loginEmailBlankValue()
        {
            await LoginPages.LoginToWebApplication(" ", DataConfiguration.qaPassword);
            await LoginAssertions.ShouldBeErrorNotification(
                Login.TestScenarios[7], Login.ScreenShotFolderName, "Login: Test Case 1.8");
        }

        [TestMethod]
        public async Task Test_loginPasswordBlankValue()
        {
            await LoginPages.LoginToWebApplication(DataConfiguration.qaUsername, " ");
            await LoginAssertions.ShouldBeErrorNotification(
                Login.TestScenarios[8], Login.ScreenShotFolderName, "Login: Test Case 1.9");
        }

        [TestMethod]
        public async Task Test_loginResetEmailBlankValue()
        {
            await LoginPages.GoToForgotPassword();
            await LoginPages.EmailReset_Textfield.FillAsync(" ");
            await LoginPages.ResetPassword_Button.ClickAsync();
            await LoginAssertions.ShouldBeEmailErrorNotification(
                Login.TestScenarios[9], Login.ScreenShotFolderName, "Login: Test Case 1.12");
        }
    }
}

