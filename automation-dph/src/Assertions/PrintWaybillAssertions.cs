
namespace automation_dph.src.Assertions
{
	public class PrintWaybillAssertions : BasePageDriver
	{
		public PrintWaybillAssertions(IPage page, PageTest pageTest) : base(page, pageTest)
		{
			MyPostsPages = new(Page, PageTest);
			LoginPages = new(Page, PageTest);
            PrintWaybill = new(Page, PageTest);
        }

        protected MyPostsPages MyPostsPages { get; private set; }
        protected LoginPages LoginPages { get; private set; }
        protected PrintWaybill PrintWaybill { get; private set; }

        private ExtentTest test = null!;
        private Exception ex = null!;

        private void StepsToReplicateForReporting(ExtentTest test, string testScenariosDescription)
        {
            var searchFilterScenarios = new Dictionary<string, Func<Task>>
            {
                { PrintWaybill.TestScenarios[0], () => { test.Info(PrintWaybill.StepsToReplicate[0] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { PrintWaybill.TestScenarios[1], () => { test.Info(PrintWaybill.StepsToReplicate[1] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { PrintWaybill.TestScenarios[2], () => { test.Info(PrintWaybill.StepsToReplicate[2] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { PrintWaybill.TestScenarios[3], () => { test.Info(PrintWaybill.StepsToReplicate[3] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { PrintWaybill.TestScenarios[4], () => { test.Info(PrintWaybill.StepsToReplicate[4] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },

            };

            if (searchFilterScenarios.TryGetValue(testScenariosDescription, out var action))
            {
                action.Invoke();
            }
        }

        public async Task ShouldBeVisible(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            ExtentReports Extent = GetInstance();
            var test = Extent.CreateTest(testScenariosDescription);

            try
            {
                await PageTest.Expect(MyPostsPages.DashPrintWaybill_Button.First).ToBeVisibleAsync();

                // Log a pass status with a discription
                test.Pass($"<b>PASSED.</b> Print Waybill button is visible.");
            }
            catch (Exception ex)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected button visibility did not match.");
                test.Info(ex.Message);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        public async Task ShouldBeSelected(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            ExtentReports Extent = GetInstance();
            test = Extent.CreateTest(testScenariosDescription);

            try
            {
                await PageTest.Expect(MyPostsPages.DashSinglePost_Checkbox.First).ToBeCheckedAsync();
                // Log a pass status with a discription
                test.Pass($"<b>PASSED.</b> Actual Result: {MyPostsPages.GetValueOfSelectedCheckboxLabel} post(s) display.");
            }
            catch (Exception e)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected post did not selected.");
                ex = e;
                StepsToReplicateForReporting(test, testScenariosDescription);
                //test.Info(SearchFilterStepsToReplicate.PostsSelected + $"<b>Actual Result:</b> <br>{ex.Message}");
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        public async Task ShouldBeStatusSelected(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            ExtentReports Extent = GetInstance();
            test = Extent.CreateTest(testScenariosDescription);

            try
            {
                await PageTest.Expect(MyPostsPages.Status_Dropdown).ToContainTextAsync("4 status selected");
                // Log a pass status with a discription
                test.Pass($"<b>PASSED.</b> Actual Result: {MyPostsPages.GetValueOfStatusDropdownfield} display.");
            }
            catch (Exception e)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected status did not selected.");
                ex = e;
                StepsToReplicateForReporting(test, testScenariosDescription);
                //test.Info(SearchFilterStepsToReplicate.PostsSelected + $"<b>Actual Result:</b> <br>{ex.Message}");
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        public async Task ShouldBeVisibleMultiplePrintButton(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            ExtentReports Extent = GetInstance();
            var test = Extent.CreateTest(testScenariosDescription);

            try
            {
                await PageTest.Expect(MyPostsPages.MultiplePrintDefaultWaybill_Button.First).ToBeVisibleAsync();

                // Log a pass status with a discription
                test.Pass($"<b>PASSED.</b> Multiple Print Waybill button is visible.");
            }
            catch (Exception ex)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected button visibility did not match.");
                test.Info(ex.Message);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        public async Task ShouldBeErrorNotification(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            ExtentReports Extent = GetInstance();
            var test = Extent.CreateTest(testScenariosDescription);

            try
            {
                await PageTest.Expect(LoginPages.ErrorNotification.First).ToBeVisibleAsync();

                // Log a pass status with a discription
                test.Pass($"<b>PASSED.</b> {LoginPages.GetErrorMessageNotification}");
            }
            catch (Exception ex)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected notification did not match.");
                test.Info(ex.Message);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        public async Task ShouldNotVisible(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            ExtentReports Extent = GetInstance();
            var test = Extent.CreateTest(testScenariosDescription);

            try
            {
                await PageTest.Expect(MyPostsPages.DashPrintWaybill_Button.First).Not.ToBeVisibleAsync();

                // Log a pass status with a discription
                test.Pass($"<b>PASSED.</b> Print Waybill button is not visible.");
            }
            catch (Exception ex)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected button visibility did not match.");
                test.Info(ex.Message);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        public async Task ShouldBeProviderWaybillVisible(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            ExtentReports Extent = GetInstance();
            var test = Extent.CreateTest(testScenariosDescription);

            try
            {
                await PageTest.Expect(MyPostsPages.OptProviderWaybillDash_Button).ToBeVisibleAsync();

                // Log a pass status with a discription
                test.Pass($"<b>PASSED.</b> Provider Waybill button is visible.");
            }
            catch (Exception ex)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected button visibility did not match.");
                test.Info(ex.Message);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        public async Task ShouldBeDisabled(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            ExtentReports Extent = GetInstance();
            var test = Extent.CreateTest(testScenariosDescription);

            try
            {
                await PageTest.Expect(MyPostsPages.MultiplePrintProviderWaybill).ToBeDisabledAsync();

                // Log a pass status with a discription
                test.Pass($"<b>PASSED.</b> Print Provider Waybill button is not clickable.");
            }
            catch (Exception ex)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected button behavior did not match.");
                test.Info(ex.Message);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        public async Task ShouldNotVisibleMultipleProviderWaybillButton(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            ExtentReports Extent = GetInstance();
            var test = Extent.CreateTest(testScenariosDescription);

            try
            {
                await PageTest.Expect(MyPostsPages.CloseMultiplePrintDefaultWaybill_Button.First).Not.ToBeVisibleAsync();

                // Log a pass status with a discription
                test.Pass($"<b>PASSED.</b> Print Waybill button is not visible.");
            }
            catch (Exception ex)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected button visibility did not match.");
                test.Info(ex.Message);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        public async Task ShouldBeEnabled(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            ExtentReports Extent = GetInstance();
            var test = Extent.CreateTest(testScenariosDescription);

            try
            {
                await PageTest.Expect(MyPostsPages.MultiplePrintProviderWaybill).ToBeEnabledAsync();

                // Log a pass status with a discription
                test.Pass($"<b>PASSED.</b> Print Provider Waybill button is clickable.");
            }
            catch (Exception ex)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected button behavior did not match.");
                test.Info(ex.Message);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        public async Task ShouldVisibleGeneratedWaybill(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            ExtentReports Extent = GetInstance();
            var test = Extent.CreateTest(testScenariosDescription);

            try
            {
                await PageTest.Expect(MyPostsPages.GeneratedWaybill_Canvas).ToBeVisibleAsync();

                // Log a pass status with a discription
                test.Pass($"<b>PASSED.</b> Generated waybill is visible.");
            }
            catch (Exception ex)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected waybill visibility did not appear.");
                test.Info(ex.Message);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        internal async Task ShouldGenerateMultipleWaybill(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            ExtentReports Extent = GetInstance();
            var test = Extent.CreateTest(testScenariosDescription);

            try
            {
                await Page.WaitForTimeoutAsync(3000); // wait for the canvas to load that takes 5 sec to generate
                await PageTest.Expect(MyPostsPages.ProviderWaybillModalFooter_Label.First).ToContainTextAsync("12");

                // Log a pass status with a discription
                test.Pass($"<b>PASSED.</b> Generated multiple waybill {MyPostsPages.GetValueOfProviderWaybillModalFooter} is visible.");
            }
            catch (Exception ex)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected multiple waybill visibility did not appear.");
                test.Info(ex.Message);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }
    }
}

