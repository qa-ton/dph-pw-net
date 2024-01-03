using AventStack.ExtentReports;

namespace automation_dph.src.Assertions
{
    public class LoginApiAssertions : BasePageDriver
    {
        public LoginApiAssertions(IPage page, PageTest pageTest) : base(page, pageTest)
        {
            LoginApi = new(Page, PageTest);
        }

        private static readonly ExtentTest test = null!;
        private static AssertFailedException ex = null!;

        public LoginApi LoginApi { get; private set; }

        private static void StepsToReplicateForReporting(string testScenariosDescription)
        {
            var loginApiScenarios = new Dictionary<string, Func<Task>>
            {
                { LoginApi.TestScenarios[0], () => { test.Info(LoginApi.StepsToReplicate[0] + $"<b>Actual Result:</b> <br>{ex.Message}{LoginResponseField.ResponseResults}"); return Task.CompletedTask; } },
                { LoginApi.TestScenarios[1], () => { test.Info(LoginApi.StepsToReplicate[1] + $"<b>Actual Result:</b> <br>{ex.Message}{LoginResponseField.ResponseResults}"); return Task.CompletedTask; } },
                { LoginApi.TestScenarios[2], () => { test.Info(LoginApi.StepsToReplicate[2] + $"<b>Actual Result:</b> <br>{ex.Message}{LoginResponseField.ResponseResults}"); return Task.CompletedTask; } },
                { LoginApi.TestScenarios[3], () => { test.Info(LoginApi.StepsToReplicate[3] + $"<b>Actual Result:</b> <br>{ex.Message}{LoginResponseField.ResponseResults}"); return Task.CompletedTask; } },
                { LoginApi.TestScenarios[4], () => { test.Info(LoginApi.StepsToReplicate[4] + $"<b>Actual Result:</b> <br>{ex.Message}{LoginResponseField.ResponseResults}"); return Task.CompletedTask; } },
                { LoginApi.TestScenarios[5], () => { test.Info(LoginApi.StepsToReplicate[5] + $"<b>Actual Result:</b> <br>{ex.Message}{LoginResponseField.ResponseResults}"); return Task.CompletedTask; } },
                { LoginApi.TestScenarios[6], () => { test.Info(LoginApi.StepsToReplicate[6] + $"<b>Actual Result:</b> <br>{ex.Message}{LoginResponseField.ResponseResults}"); return Task.CompletedTask; } },
                { LoginApi.TestScenarios[7], () => { test.Info(LoginApi.StepsToReplicate[7] + $"<b>Actual Result:</b> <br>{ex.Message}{LoginResponseField.ResponseResults}"); return Task.CompletedTask; } },
            };

            if (loginApiScenarios.TryGetValue(testScenariosDescription, out var action))
            {
                action.Invoke();
            }
        }

        public static Task SuccessResponse(string testScenariosDescription)
        {
            // Create a test instance in ExtentReports
            ExtentReports Extent = GetInstance();
            var test = Extent.CreateTest(testScenariosDescription);

            try
            {
                Assert.IsTrue(LoginResponseField.Success);

                // Log a pass status with a discription
                test.Pass($"PASSED. {LoginResponseField.Success}. {LoginResponseField.ClientId}");
                _logger.Info($"Success:{LoginResponseField.Success}. Results: {LoginResponseField.ResponseResults}");
            }
            catch (AssertFailedException e)
            {
                // Log a fail status with the exception message
                test.Fail("FAILED. The expected response did not match.");
                ex = e;
                StepsToReplicateForReporting(testScenariosDescription);
            }
            Extent.Flush();
            return Task.CompletedTask;
        }

        public static Task ErrorResponse(string testScenariosDescription)
        {
            ExtentReports Extent = GetInstance();
            var test = Extent.CreateTest(testScenariosDescription);

            try
            {
                Assert.IsFalse(LoginResponseField.Success);

                // Log a pass status with a discription
                test.Pass($"PASSED. {LoginResponseField.Success}. {LoginResponseField.ResponseResults}");
                _logger.Info($"Success:{LoginResponseField.Success}. Results: {LoginResponseField.ResponseResults}");
            }
            catch (AssertFailedException e)
            {
                // Log a fail status with the exception message
                test.Fail("FAILED. The expected response did not match.");
                ex = e;
                StepsToReplicateForReporting(testScenariosDescription);
            }
            Extent.Flush();
            return Task.CompletedTask;
        }
    }
}