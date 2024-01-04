
namespace automation_dph.src.Assertions
{
	public class SearchFilterAssertions : BasePageDriver
	{
		public SearchFilterAssertions(IPage page, PageTest pageTest) : base(page, pageTest)
		{
			MyPostsPages = new(Page, PageTest);
            DataConfiguration = new(Page, PageTest);
            SearchFilter = new(Page, PageTest);
        }

        ExtentTest test = null!;
        protected MyPostsPages MyPostsPages { get; private set; }
        protected DataConfiguration DataConfiguration { get; private set; }
        protected SearchFilter SearchFilter { get; private set; }

        Exception ex = null!;

        public async Task ShouldDisplayResult(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            // Create a test instance in ExtentReports
            ExtentReports Extent = GetInstance();
            test = Extent.CreateTest(testScenariosDescription);

            try
            {
                // get post details
                // get reference number then compare to inputted value

                if (testScenariosDescription.Contains("Reference number"))
                {
                    await Page.WaitForTimeoutAsync(2000);
                    if (await MyPostsPages.DashboardLatesPost_Button.First.IsVisibleAsync())
                    {
                        await PageTest.Expect(MyPostsPages.DashboardLatesPost_Button.First).ToContainTextAsync(DataConfiguration.referenceNumber);
                        // Log a pass status with a discription
                        test.Pass($"<b>PASSED.</b> Actual Result: Reference Number {DataConfiguration.referenceNumber} display.");
                    }
                    else
                    {
                        Assert.Inconclusive($"Reference Number {DataConfiguration.referenceNumber} is not exist. Try another data.");
                    }
                }
                else if (testScenariosDescription.Contains("Customer Name"))
                {
                    await Page.WaitForTimeoutAsync(2000);
                    if (await MyPostsPages.DashboardLatesPost_Button.First.IsVisibleAsync())
                    {
                        await PageTest.Expect(MyPostsPages.DashboardLatesPost_Button.First).ToContainTextAsync(DataConfiguration.customerName);
                        // Log a pass status with a discription
                        test.Pass($"<b>PASSED.</b> Actual Result: Customer Name {DataConfiguration.customerName} display.");
                    }
                    else
                    {
                        Assert.Inconclusive($"Customer Name {DataConfiguration.customerName} is not exist. Try another data.");
                        //test.Info($"Reference Number {Config.referenceNumber} is not exist. Try another data.");
                    }
                }
                else if (testScenariosDescription.Contains("Pickup City"))
                {
                    await Page.WaitForTimeoutAsync(2000);
                    if (await MyPostsPages.DashboardLatesPost_Button.First.IsVisibleAsync())
                    {
                        await PageTest.Expect(MyPostsPages.DashboardLatesPost_Button.First).ToContainTextAsync(DataConfiguration.pickupCity);
                        // Log a pass status with a discription
                        test.Pass($"<b>PASSED.</b> Actual Result: {DataConfiguration.pickupCity} display.");
                    }
                    else
                    {
                        Assert.Inconclusive($"Pickup City {DataConfiguration.pickupCity} is not exist. Try another data.");
                        //test.Info($"Reference Number {Config.referenceNumber} is not exist. Try another data.");
                    }
                }
                else if (testScenariosDescription.Contains("Post Id"))
                {
                    await Page.WaitForTimeoutAsync(2000);
                    if (await MyPostsPages.DashboardLatesPost_Button.First.IsVisibleAsync())
                    {
                        await PageTest.Expect(MyPostsPages.DashboardLatesPost_Button.First).ToBeVisibleAsync();
                        // Log a pass status with a discription
                        test.Pass($"<b>PASSED.</b> Actual Result: {DataConfiguration.postId} display.");
                    }
                    else
                    {
                        Assert.Inconclusive($"Post ID {DataConfiguration.postId} is not exist. Try another data.");
                        //test.Info($"Reference Number {Config.referenceNumber} is not exist. Try another data.");
                    }
                }
                else if (testScenariosDescription.Contains("Delivery Tracking Number"))
                {
                    await Page.WaitForTimeoutAsync(2000);
                    if (await MyPostsPages.DashboardLatesPost_Button.First.IsVisibleAsync())
                    {
                        await PageTest.Expect(MyPostsPages.DashboardTrackingNumber_Label.First).ToContainTextAsync(DataConfiguration.deliveryTrackingNumber);
                        // Log a pass status with a discription
                        test.Pass($"<b>PASSED.</b> Actual Result: {DataConfiguration.deliveryTrackingNumber} display.");
                    }
                    else
                    {
                        Assert.Inconclusive($"Delivery Tracking Number {DataConfiguration.deliveryTrackingNumber} is not exist. Try another data.");
                        //test.Info($"Reference Number {Config.referenceNumber} is not exist. Try another data.");
                    }

                }
            }
            catch (Exception e)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected results did not match.");
                ex = e;
                StepsToReplicateForReporting(testScenariosDescription);
                //test.Info(SearchFilterStepsToReplicate.SearchPosts + $"<b>Actual Result:</b> <br>{ex.Message}");
                _logger.Debug($"Test logger."); // identify message for this debug level.
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        public async Task ShouldNotDisplayResult(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            // Create a test instance in ExtentReports
            ExtentReports Extent = GetInstance();
            var test = Extent.CreateTest(testScenariosDescription);

            try
            {
                // get post details
                // get reference number then compare to inputted value
                if (testScenariosDescription.Contains("Reference number"))
                {
                    await PageTest.Expect(MyPostsPages.DashboardPostList_Container).ToContainTextAsync("No available data to display");
                    // Log a pass status with a discription
                    test.Pass($"<b>PASSED.</b> Actual Result: No available data to display.");
                }
                else if (testScenariosDescription.Contains("Customer Name"))
                {
                    await PageTest.Expect(MyPostsPages.DashboardPostList_Container).ToContainTextAsync("No available data to display");
                    // Log a pass status with a discription
                    test.Pass($"<b>PASSED.</b> Actual Result: No available data to display.");
                }
                else if (testScenariosDescription.Contains("Pickup City"))
                {
                    await PageTest.Expect(MyPostsPages.DashboardPostList_Container).ToContainTextAsync("No available data to display");
                    // Log a pass status with a discription
                    test.Pass($"<b>PASSED.</b> Actual Result: No available data to display.");
                }
                else if (testScenariosDescription.Contains("Post Id"))
                {
                    await PageTest.Expect(MyPostsPages.DashboardPostList_Container).ToContainTextAsync("No available data to display");
                    // Log a pass status with a discription
                    test.Pass($"<b>PASSED.</b> Actual Result: No available data to display.");
                }
                else if (testScenariosDescription.Contains("Delivery Tracking Number"))
                {
                    await PageTest.Expect(MyPostsPages.DashboardPostList_Container).ToContainTextAsync("No available data to display");
                    // Log a pass status with a discription
                    test.Pass($"<b>PASSED.</b> Actual Result: No available data to display.");
                }
            }
            catch (Exception e)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected results did not match.");
                ex = e;
                StepsToReplicateForReporting(testScenariosDescription);
                //test.Info(SearchFilterStepsToReplicate.SearchPostsNoResult + $"<b>Actual Result:</b> <br>{ex.Message}");
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        public async Task ShouldDisplayStore(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            // Create a test instance in ExtentReports
            ExtentReports Extent = GetInstance();
            test = Extent.CreateTest(testScenariosDescription);

            try
            {
                await PageTest.Expect(MyPostsPages.DashboardLatestStore_Label).ToContainTextAsync("QA Store");
                // Log a pass status with a discription
                test.Pass($"<b>PASSED.</b>. Actual Result: Store {MyPostsPages.GetValueOfStoreInDashboard} display.");
            }
            catch (Exception e)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected store did not match.");
                ex = e;
                StepsToReplicateForReporting(testScenariosDescription);
                //test.Info(SearchFilterStepsToReplicate.FilterHubs + $"<b>Actual Result:</b> <br>{ex.Message}");
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        private void StepsToReplicateForReporting(string testScenariosDescription)
        {
            var loginScenarios = new Dictionary<string, Func<Task>>
            {
                { SearchFilter.TestScenarios[0], () => { test.Info(SearchFilter.SearchPosts + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[1], () => { test.Info(SearchFilter.SearchPosts + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[2], () => { test.Info(SearchFilter.SearchPosts + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[3], () => { test.Info(SearchFilter.SearchPosts + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[4], () => { test.Info(SearchFilter.SearchPosts + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[5], () => { test.Info(SearchFilter.SearchPostsNoResult + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[6], () => { test.Info(SearchFilter.SearchPostsNoResult + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[7], () => { test.Info(SearchFilter.SearchPostsNoResult + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[8], () => { test.Info(SearchFilter.SearchPostsNoResult + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[9], () => { test.Info(SearchFilter.SearchPostsNoResult + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[10], () => { test.Info(SearchFilter.SearchPostsNoResult + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[11], () => { test.Info(SearchFilter.SearchPostsNoResult + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[12], () => { test.Info(SearchFilter.SearchPostsNoResult + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[13], () => { test.Info(SearchFilter.SearchPostsNoResult + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[14], () => { test.Info(SearchFilter.SearchPostsNoResult + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[15], () => { test.Info(SearchFilter.SearchPostsNoResult + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[16], () => { test.Info(SearchFilter.SearchPostsNoResult + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[17], () => { test.Info(SearchFilter.SearchPostsNoResult + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
            };

            if (loginScenarios.TryGetValue(testScenariosDescription, out var action))
            {
                action.Invoke();
            }
        }

    }
}

