
using System.Text.RegularExpressions;

namespace automation_dph.src.Assertions
{
	public partial class MarkAsReturnedAssertions : BasePageDriver
	{
        public MarkAsReturnedAssertions(IPage page, PageTest pageTest) : base(page, pageTest)
        {
            MyPostsPages = new(Page, PageTest);
            LoginPages = new(Page, PageTest);
            MarkAsReturned = new(Page, PageTest);
        }

        protected MyPostsPages MyPostsPages { get; private set; }
        protected LoginPages LoginPages { get; private set; }
        protected MarkAsReturned MarkAsReturned { get; private set; }

        private ExtentTest test = null!;
        private Exception ex = null!;
        [GeneratedRegex("\\d+")]
        private static partial Regex MyRegex();

        private void StepsToReplicateForReporting(ExtentTest test, string testScenariosDescription)
        {
            var searchFilterScenarios = new Dictionary<string, Func<Task>>
            {
                { MarkAsReturned.TestScenarios[0], () => { test.Info(MarkAsReturned.StepsToReplicate[0] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { MarkAsReturned.TestScenarios[1], () => { test.Info(MarkAsReturned.StepsToReplicate[1] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { MarkAsReturned.TestScenarios[2], () => { test.Info(MarkAsReturned.StepsToReplicate[2] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { MarkAsReturned.TestScenarios[3], () => { test.Info(MarkAsReturned.StepsToReplicate[3] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { MarkAsReturned.TestScenarios[4], () => { test.Info(MarkAsReturned.StepsToReplicate[4] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { MarkAsReturned.TestScenarios[5], () => { test.Info(MarkAsReturned.StepsToReplicate[5] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { MarkAsReturned.TestScenarios[6], () => { test.Info(MarkAsReturned.StepsToReplicate[6] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { MarkAsReturned.TestScenarios[7], () => { test.Info(MarkAsReturned.StepsToReplicate[7] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { MarkAsReturned.TestScenarios[8], () => { test.Info(MarkAsReturned.StepsToReplicate[8] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },

            };

            if (searchFilterScenarios.TryGetValue(testScenariosDescription, out var action))
            {
                action.Invoke();
            }
        }

        public async Task ShouldDisplayNumberOfStatusSelected(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            ExtentReports Extent = GetInstance();
            test = Extent.CreateTest(testScenariosDescription);

            try
            {
                await PageTest.Expect(MyPostsPages.Status_Dropdown).ToContainTextAsync("1 status selected");
                // Log a pass status with a discription
                test.Pass($"PASSED. Actual Result: {MyPostsPages.GetValueOfStatusDropdownfield} display.");
            }
            catch (Exception e)
            {
                // Log a fail status with the exception message
                test.Fail("FAILED. The expected status did not match.");
                ex = e;
                StepsToReplicateForReporting(test, testScenariosDescription);
                //test.Info(MarkAsReturned.StepsToReplicate[] + $"<b>Actual Result:</b> <br>{ex.Message}");
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        public async Task ShouldBeSelected(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            ExtentReports Extent = GetInstance();
            var test = Extent.CreateTest(testScenariosDescription);

            try
            {
                await PageTest.Expect(MyPostsPages.DashSinglePost_Checkbox.First).ToBeCheckedAsync();
                // Log a pass status with a discription
                test.Pass($"PASSED. Actual Result: {MyPostsPages.GetValueOfSelectedCheckboxLabel} post(s) display.");
            }
            catch (Exception e)
            {
                // Log a fail status with the exception message
                test.Fail("FAILED. The expected status did not match.");
                ex = e;
                StepsToReplicateForReporting(test, testScenariosDescription);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        public async Task ShouldContainNumberOfPostSelected(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            ExtentReports Extent = GetInstance();
            var test = Extent.CreateTest(testScenariosDescription);

            try
            {
                await PageTest.Expect(MyPostsPages.NumberOfSelectedCheckbox_Label).ToContainTextAsync("Selected");
                //var parentDiv = await Page.QuerySelectorAsync(".items-wrapper");
                //var childDivs = await parentDiv?.QuerySelectorAllAsync(".list-item-container")!;

                //// Get the count of the selected child divs
                //int DashboardCount = childDivs.Count;

                //// Use regular expression to extract the number
                //// Then convert to int
                //Match match = MyRegex().Match(MyPostsPages.GetValueOfSelectedCheckboxLabel);
                //int labelCount = int.Parse(match.Value);

                //Assert.AreEqual(3, labelCount);
                test.Pass($"PASSED. Actual Result: {MyPostsPages.GetValueOfSelectedCheckboxLabel} post(s) display.");
            }
            catch (Exception e)
            {
                // Log a fail status with the exception message
                test.Fail("FAILED. The expected number of selected post did not match.");
                ex = e;
                StepsToReplicateForReporting(test, testScenariosDescription);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        public async Task ShouldBeSuccessful(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            ExtentReports Extent = GetInstance();
            var test = Extent.CreateTest(testScenariosDescription);

            try
            {
                await PageTest.Expect(LoginPages.SuccessNotification).ToContainTextAsync("Post successfully mark as returned.");
                // Log a pass status with a discription
                test.Pass($"PASSED. {LoginPages.GetSuccessMessageNotification}");
            }
            catch (Exception e)
            {
                // Log a fail status with the exception message
                test.Fail("FAILED. The expected notification did not match.");
                ex = e;
                StepsToReplicateForReporting(test, testScenariosDescription);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        public async Task ShouldBeError(string reportDescription, string testCaseFolderName, string testCaseName)
        {
            ExtentReports Extent = GetInstance();
            var test = Extent.CreateTest(reportDescription);

            try
            {
                await PageTest.Expect(LoginPages.ErrorNotification).ToContainTextAsync("No selected item.");
                // Log a pass status with a discription
                test.Pass($"PASSED. {LoginPages.GetErrorMessageNotification}");
            }
            catch (Exception ex)
            {
                // Log a fail status with the exception message
                test.Fail("FAILED. The expected notification did not match.");
                test.Info(ex.Message);
                await TakeAScreenshot($"{testCaseFolderName}", $"{testCaseName} - FAILED");
            }
            Extent.Flush();
        }

    }
}

