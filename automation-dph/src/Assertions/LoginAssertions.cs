
namespace automation_dph.src.Assertions
{
    public class LoginAssertions : BasePageDriver
    {
        public LoginAssertions(IPage page, PageTest pageTest) : base(page, pageTest)
        {
            LoginPages = new(Page, PageTest);
            Login = new(Page, PageTest);
        }

        public LoginPages LoginPages { get; private set; }
        public Login Login { get; private set; }

        ExtentTest test = null!;
        Exception ex = null!;

        private void StepsToReplicateForReporting(string testScenariosDescription)
        {
            var loginScenarios = new Dictionary<string, Func<Task>>
            {
                { Login.TestScenarios[0], () => { test.Info(Login.StepsToReplicate[0] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { Login.TestScenarios[1], () => { test.Info(Login.StepsToReplicate[1] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { Login.TestScenarios[2], () => { test.Info(Login.StepsToReplicate[2] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { Login.TestScenarios[3], () => { test.Info(Login.StepsToReplicate[3] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { Login.TestScenarios[4], () => { test.Info(Login.StepsToReplicate[4] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { Login.TestScenarios[5], () => { test.Info(Login.StepsToReplicate[5] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { Login.TestScenarios[6], () => { test.Info(Login.StepsToReplicate[6] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { Login.TestScenarios[7], () => { test.Info(Login.StepsToReplicate[7] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { Login.TestScenarios[8], () => { test.Info(Login.StepsToReplicate[8] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { Login.TestScenarios[9], () => { test.Info(Login.StepsToReplicate[9] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
            };

            if (loginScenarios.TryGetValue(testScenariosDescription, out var action))
            {
                action.Invoke();
            }
        }

        public async Task ShouldBeSuccessNotification(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            // Create a test instance in ExtentReports
            ExtentReports Extent = GetInstance();
            test = Extent.CreateTest(testScenariosDescription);

            try
            {
                await PageTest.Expect(LoginPages.SuccessNotification.First).ToContainTextAsync("Successfully Logged in!");

                // Log a pass status with a discription
                test.Pass($"<b>PASSED.</b> User's {LoginPages.GetSuccessMessageNotification}");
            }
            catch (Exception e)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected notification did not match.");
                ex = e;
                StepsToReplicateForReporting(testScenariosDescription);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        public async Task ShouldBeErrorNotification(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            ExtentReports Extent = GetInstance();
            test = Extent.CreateTest(testScenariosDescription);

            try
            {
                await PageTest.Expect(LoginPages.ErrorNotification.First).ToContainTextAsync("Invalid Email/Password!");

                // Log a pass status with a discription
                test.Pass($"<b>PASSED.</b> Error notification {LoginPages.GetErrorMessageNotification} display.");
            }
            catch (Exception e)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected notification did not match.");
                ex = e;
                StepsToReplicateForReporting(testScenariosDescription);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        public async Task ShouldBeRemember(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            ExtentReports Extent = GetInstance();
            test = Extent.CreateTest(testScenariosDescription);

            try
            {
                await PageTest.Expect(LoginPages.LoginTextEmailUsername).ToHaveTextAsync("rm@qa.fleet.ph");

                // Log a pass status with a discription
                test.Pass($"<b>PASSED.</b> Inputted email {LoginPages.GetValueOfEmailText} display.");
            }
            catch (Exception e)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected email did not match.");
                ex = e;
                StepsToReplicateForReporting(testScenariosDescription);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        public async Task ShouldBeResetUrl(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            ExtentReports Extent = GetInstance();
            test = Extent.CreateTest(testScenariosDescription);

            try
            {
                await PageTest.Expect(Page).ToHaveURLAsync("https://staging.deliveries.ph/reset-password");

                // Log a pass status with a discription
                test.Pass($"<b>PASSED.</b> Web URL {Page.Url} display.");
            }
            catch (Exception e)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected url did not match.");
                ex = e;
                StepsToReplicateForReporting(testScenariosDescription);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        public async Task ShouldBeEmailErrorNotification(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            ExtentReports Extent = GetInstance();
            test = Extent.CreateTest(testScenariosDescription);

            try
            {
                await PageTest.Expect(LoginPages.EmailReset_Textfield).ToContainTextAsync("Invalid Email Format!");

                // Log a pass status with a discription
                test.Pass($"<b>PASSED.</b> Error notification {LoginPages.GetErrorMessageNotification} display.");
            }
            catch (Exception e)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected notification did not match.");
                ex = e;
                StepsToReplicateForReporting(testScenariosDescription);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }
    }
}