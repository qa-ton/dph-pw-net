


namespace automation_dph.src.Assertions
{
	public partial class PaginationAssertions : BasePageDriver
	{
		public PaginationAssertions(IPage page, PageTest pageTest) : base(page, pageTest)
		{
			MyPostsPages = new(Page, PageTest);
            MyPostsPagination = new(Page, PageTest);
		}

        protected MyPostsPages MyPostsPages { get; private set; }
        protected MyPostsPagination MyPostsPagination { get; private set; }

        private ExtentTest test = null!;
        private Exception ex = null!;

        private void StepsToReplicateForReporting(ExtentTest test, string testScenariosDescription)
        {
            var MyPostsPaginationScenarios = new Dictionary<string, Func<Task>>
            {
                { MyPostsPagination.TestScenarios[0], () => { test.Info(MyPostsPagination.StepsToReplicate + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { MyPostsPagination.TestScenarios[1], () => { test.Info(MyPostsPagination.StepsToReplicate + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { MyPostsPagination.TestScenarios[2], () => { test.Info(MyPostsPagination.StepsToReplicate + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { MyPostsPagination.TestScenarios[3], () => { test.Info(MyPostsPagination.StepsToReplicate + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { MyPostsPagination.TestScenarios[4], () => { test.Info(MyPostsPagination.StepsToReplicate + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { MyPostsPagination.TestScenarios[5], () => { test.Info(MyPostsPagination.StepsToReplicate + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { MyPostsPagination.TestScenarios[6], () => { test.Info(MyPostsPagination.StepsToReplicate + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { MyPostsPagination.TestScenarios[7], () => { test.Info(MyPostsPagination.StepsToReplicate + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { MyPostsPagination.TestScenarios[8], () => { test.Info(MyPostsPagination.StepsToReplicate + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { MyPostsPagination.TestScenarios[9], () => { test.Info(MyPostsPagination.StepsToReplicate + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { MyPostsPagination.TestScenarios[10], () => { test.Info(MyPostsPagination.StepsToReplicate + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { MyPostsPagination.TestScenarios[11], () => { test.Info(MyPostsPagination.StepsToReplicate + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { MyPostsPagination.TestScenarios[12], () => { test.Info(MyPostsPagination.StepsToReplicate + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { MyPostsPagination.TestScenarios[13], () => { test.Info(MyPostsPagination.StepsToReplicate + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { MyPostsPagination.TestScenarios[14], () => { test.Info(MyPostsPagination.StepsToReplicate + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { MyPostsPagination.TestScenarios[15], () => { test.Info(MyPostsPagination.StepsToReplicate + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { MyPostsPagination.TestScenarios[16], () => { test.Info(MyPostsPagination.StepsToReplicate + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { MyPostsPagination.TestScenarios[17], () => { test.Info(MyPostsPagination.StepsToReplicate + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { MyPostsPagination.TestScenarios[20], () => { test.Info(MyPostsPagination.StepsToReplicate + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { MyPostsPagination.TestScenarios[21], () => { test.Info(MyPostsPagination.StepsToReplicate + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { MyPostsPagination.TestScenarios[22], () => { test.Info(MyPostsPagination.StepsToReplicate + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { MyPostsPagination.TestScenarios[23], () => { test.Info(MyPostsPagination.StepsToReplicate + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { MyPostsPagination.TestScenarios[24], () => { test.Info(MyPostsPagination.StepsToReplicate + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { MyPostsPagination.TestScenarios[25], () => { test.Info(MyPostsPagination.StepsToReplicate + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { MyPostsPagination.TestScenarios[26], () => { test.Info(MyPostsPagination.StepsToReplicate + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },

            };

            if (MyPostsPaginationScenarios.TryGetValue(testScenariosDescription, out var action))
            {
                action.Invoke();
            }
        }

        public async Task ShouldDisplayNumberOfPosts(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            // Create a test instance in ExtentReports
            ExtentReports Extent = GetInstance();
            test = Extent.CreateTest(testScenariosDescription);

            await Page.WaitForTimeoutAsync(3000); // wait to load list of posts on the dashboard
            try
            {
                var parentDiv = await Page.QuerySelectorAsync(".items-wrapper");
                var childDivs = await parentDiv?.QuerySelectorAllAsync(".list-item-container")!;
                var labelDivs = await Page.QuerySelectorAsync(".tw-font-semibold.tw-text-dark-2.tw-text-xs");

                // Get the count of the selected child divs
                var count = childDivs.Count;

                // Get the inner text of the element
                var labelText = await labelDivs.InnerTextAsync();

                // Use regular expression to extract the number pattern
                var match = MyRegex().Match(labelText);

                await PageTest.Expect(MyPostsPages.PaginationPostsNumberDisplay_Label).ToContainTextAsync($"{match} out of");

                // Log a pass status with a discription
                test.Pass($"<b>PASSED.</b> {MyPostsPages.GetValueOfNumberOfPostsDisplay}");
            }
            catch (Exception e)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected number did not match.");
                ex = e;
                //StepsToReplicateForReporting(testScenariosDescription);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        public async Task ShouldBeDisable(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            // Create a test instance in ExtentReports
            ExtentReports Extent = GetInstance();
            test = Extent.CreateTest(testScenariosDescription);

            await Page.WaitForTimeoutAsync(4000);
            try
            {
                await PageTest.Expect(MyPostsPages.PreviousPageIcon_Button).ToBeDisabledAsync();
                // Log a pass status with a discription
                test.Pass($"<b>PASSED.</b> Left button is Disabled.");
            }
            catch (Exception e)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected button status did not match.");
                ex = e;
                //StepsToReplicateForReporting(testScenariosDescription);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        public async Task ShouldDisplayMoreThanTheFirstCount(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            ExtentReports Extent = GetInstance();
            test = Extent.CreateTest(testScenariosDescription);

            await Page.WaitForTimeoutAsync(4000);
            try
            {
                await PageTest.Expect(MyPostsPages.PaginationPostsNumberDisplay_Label).ToContainTextAsync("51");
                // Log a pass status with a discription
                test.Pass($"<b>PASSED.</b> {MyPostsPages.GetValueOfNumberOfPostsDisplay}");
            }
            catch (Exception e)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected number did not match.");
                ex = e;
                //StepsToReplicateForReporting(testScenariosDescription);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        public async Task ShouldDisplayTheFirstCount(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            ExtentReports Extent = GetInstance();
            test = Extent.CreateTest(testScenariosDescription);

            await Page.WaitForTimeoutAsync(4000);
            try
            {
                await PageTest.Expect(MyPostsPages.PaginationPostsNumberDisplay_Label).ToContainTextAsync("50");
                // Log a pass status with a discription
                test.Pass($"<b>PASSED.</b> {MyPostsPages.GetValueOfNumberOfPostsDisplay}");
            }
            catch (Exception e)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected number did not match.");
                ex = e;
                //StepsToReplicateForReporting(testScenariosDescription);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        public async Task ShouldDisplayNoResult(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            ExtentReports Extent = GetInstance();
            test = Extent.CreateTest(testScenariosDescription);

            await Page.WaitForTimeoutAsync(4000);
            try
            {
                await PageTest.Expect(MyPostsPages.PaginationPostsNumberDisplay_Label).ToHaveTextAsync("0 - 0 out of 0 Posts");
                // Log a pass status with a discription
                test.Pass($"<b>PASSED.</b> {MyPostsPages.GetValueOfNumberOfPostsDisplay}");
            }
            catch (Exception e)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected number did not match.");
                ex = e;
                //StepsToReplicateForReporting(testScenariosDescription);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        public async Task ShouldBeDisableRightPagination(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            ExtentReports Extent = GetInstance();
            test = Extent.CreateTest(testScenariosDescription);

            await Page.WaitForTimeoutAsync(4000);
            try
            {
                await PageTest.Expect(MyPostsPages.NextPageIcon_Button).ToBeDisabledAsync();
                // Log a pass status with a discription
                test.Pass($"<b>PASSED.</b> {MyPostsPages.GetValueOfNumberOfPostsDisplay}. Right button is Disabled due to number of posts are less than 50.");
            }
            catch (Exception e)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected button status did not match.");
                ex = e;
                //StepsToReplicateForReporting(testScenariosDescription);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        public async Task ShouldBeEnableRightPagination(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            ExtentReports Extent = GetInstance();
            test = Extent.CreateTest(testScenariosDescription);

            await Page.WaitForTimeoutAsync(4000);
            try
            {
                await PageTest.Expect(MyPostsPages.NextPageIcon_Button).ToBeEnabledAsync();
                // Log a pass status with a discription
                test.Pass($"<b>PASSED.</b> {MyPostsPages.GetValueOfNumberOfPostsDisplay}. Right button is enabled.");
            }
            catch (Exception e)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected button status did not match.");
                ex = e;
                //StepsToReplicateForReporting(testScenariosDescription);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        [GeneratedRegex("(\\d+ - \\d+)")]
        private static partial Regex MyRegex();
    }
}

