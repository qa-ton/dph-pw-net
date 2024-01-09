
using System.Text.RegularExpressions;

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
        
        protected MyPostsPages MyPostsPages { get; private set; }
        protected DataConfiguration DataConfiguration { get; private set; }
        protected SearchFilter SearchFilter { get; private set; }

        private ExtentTest test = null!;
        private Exception ex = null!;

        private void StepsToReplicateForReporting(ExtentTest test,string testScenariosDescription)
        {
            var searchFilterScenarios = new Dictionary<string, Func<Task>>
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
                { SearchFilter.TestScenarios[20], () => { test.Info(SearchFilter.FilterPreferredPartner + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[21], () => { test.Info(SearchFilter.FilterDate + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[22], () => { test.Info(SearchFilter.FilterDate + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[23], () => { test.Info(SearchFilter.FilterDate + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[24], () => { test.Info(SearchFilter.FilterDate + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[25], () => { test.Info(SearchFilter.FilterDate + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[26], () => { test.Info(SearchFilter.FilterDate + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[27], () => { test.Info(SearchFilter.FilterDate + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[29], () => { test.Info(SearchFilter.FilterDate + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[30], () => { test.Info(SearchFilter.SearchByTwoFilters + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[31], () => { test.Info(SearchFilter.SearchByTwoFilters + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[32], () => { test.Info(SearchFilter.SearchByTwoFilters + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[33], () => { test.Info(SearchFilter.SearchByTwoFilters + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[34], () => { test.Info(SearchFilter.SearchByTwoFilters + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[35], () => { test.Info(SearchFilter.StepsToReplicateFilters[5] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[36], () => { test.Info(SearchFilter.StepsToReplicateFilters[5] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[37], () => { test.Info(SearchFilter.StepsToReplicateFilters[5] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[38], () => { test.Info(SearchFilter.StepsToReplicateFilters[5] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[39], () => { test.Info(SearchFilter.StepsToReplicateFilters[5] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[40], () => { test.Info(SearchFilter.StepsToReplicateFilters[10] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[41], () => { test.Info(SearchFilter.StepsToReplicateFilters[11] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[42], () => { test.Info(SearchFilter.StepsToReplicateFilters[12] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[43], () => { test.Info(SearchFilter.StepsToReplicateFilters[13] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[44], () => { test.Info(SearchFilter.StepsToReplicateFilters[14] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[45], () => { test.Info(SearchFilter.StepsToReplicateFilters[15] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[46], () => { test.Info(SearchFilter.StepsToReplicateFilters[16] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[47], () => { test.Info(SearchFilter.StepsToReplicateFilters[17] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[48], () => { test.Info(SearchFilter.StepsToReplicateFilters[18] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[49], () => { test.Info(SearchFilter.StepsToReplicateFilters[19] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[50], () => { test.Info(SearchFilter.StepsToReplicateFilters[20] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[51], () => { test.Info(SearchFilter.StepsToReplicateFilters[21] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[52], () => { test.Info(SearchFilter.StepsToReplicateFilters[22] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[53], () => { test.Info(SearchFilter.StepsToReplicateFilters[23] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[54], () => { test.Info(SearchFilter.StepsToReplicateFilters[24] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[55], () => { test.Info(SearchFilter.StepsToReplicateFilters[25] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[56], () => { test.Info(SearchFilter.StepsToReplicateFilters[26] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[57], () => { test.Info(SearchFilter.StepsToReplicateFilters[27] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[58], () => { test.Info(SearchFilter.StepsToReplicateFilters[28] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { SearchFilter.TestScenarios[59], () => { test.Info(SearchFilter.StepsToReplicateFilters[29] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },

            };

            if (searchFilterScenarios.TryGetValue(testScenariosDescription, out var action))
            {
                action.Invoke();
            }
        }

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
                    await Page.WaitForTimeoutAsync(3000);
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
                    await Page.WaitForTimeoutAsync(3000);
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
                    await Page.WaitForTimeoutAsync(3000);
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
                    await Page.WaitForTimeoutAsync(3000);
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
                    await Page.WaitForTimeoutAsync(3000);
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
                StepsToReplicateForReporting(test, testScenariosDescription);
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
                StepsToReplicateForReporting(test, testScenariosDescription);
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
                StepsToReplicateForReporting(test, testScenariosDescription);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        public async Task ShouldDisplayStatusRecord(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            // Create a test instance in ExtentReports
            ExtentReports Extent = GetInstance();
            var test = Extent.CreateTest(testScenariosDescription);

            try
            {
                if (await MyPostsPages.DashboardLatesPost_Button.First.IsVisibleAsync())
                {
                    var testStatus = await Page.QuerySelectorAsync(".status-icon");
                    string? statusTest = await testStatus.GetAttributeAsync("status");

                    await PageTest.Expect(MyPostsPages.StatusIcon_Dashboard.First).ToContainTextAsync(statusTest); // arrived at hub should check too
                    test.Pass($"<b>PASSED.</b> Actual Result: Status {MyPostsPages.GetValueOfStatusInDashboard} display.");
                }
                else
                {
                    Assert.Inconclusive($"Transaction not exist. Try another data.");
                }
            }
            catch (Exception e)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected status did not match.");
                ex = e;
                StepsToReplicateForReporting(test, testScenariosDescription);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        public async Task ShouldDisplayPreferredPartner(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            // Create a test instance in ExtentReports
            ExtentReports Extent = GetInstance();
            test = Extent.CreateTest(testScenariosDescription);

            try
            {
                await PageTest.Expect(MyPostsPages.Couriername_Label.First).ToBeVisibleAsync();
                // Log a pass status with a discription
                test.Pass($"<b>PASSED.</b> Actual Result: Store {MyPostsPages.GetValueOfLatestPartnerInDashboard} display.");
            }
            catch (Exception e)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected preferred partner did not match.");
                ex = e;
                StepsToReplicateForReporting(test, testScenariosDescription);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        public async Task ShouldDisplayDateResult(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            // Create a test instance in ExtentReports
            ExtentReports Extent = GetInstance();
            var test = Extent.CreateTest(testScenariosDescription);

            try
            {
                // Get today's date
                List<DateTime> dateRange = new();
                DateTime today = DateTime.Now.Date;

                // Calculate date
                DateTime yesterday = today.AddDays(-1);
                DateTime lastSevenDays = today.AddDays(-7);
                DateTime lastThirtyDays = today.AddDays(-30);
                DateTime firstDayOfMonth = new(today.Year, today.Month, 1);
                DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
                DateTime firstDayOfLastMonth = firstDayOfMonth.AddMonths(-1);
                DateTime lastDayOfLastMonth = firstDayOfMonth.AddDays(-1);

                // Define the regular expression pattern to match dates in the format MM/DD/YYYY
                string CustomDatePattern = @"^(0[2-8]/(0[1-9]|[12][0-9]|30)/2023)$";

                if (testScenariosDescription.Contains("As of Today"))
                {
                    await PageTest.Expect(MyPostsPages.CompletionDate_Label.First).ToHaveTextAsync(today.ToString("MM/dd/yyyy"));
                    // Log a pass status with a discription
                    test.Pass($"<b>PASSED.</b> Actual Result: Completion Date is {MyPostsPages.GetValueOfCompletionDate} display.");
                }
                else if (testScenariosDescription.Contains("Today"))
                {
                    await PageTest.Expect(MyPostsPages.CompletionDate_Label.First).ToHaveTextAsync(today.ToString("MM/dd/yyyy"));
                    // Log a pass status with a discription
                    test.Pass($"<b>PASSED.</b> Actual Result: Completion Date is {MyPostsPages.GetValueOfCompletionDate} display.");
                }
                else if (testScenariosDescription.Contains("Yesterday"))
                {
                    await PageTest.Expect(MyPostsPages.CompletionDate_Label.First).ToHaveTextAsync(yesterday.ToString("MM/dd/yyyy"));
                    // Log a pass status with a discription
                    test.Pass($"<b>PASSED.</b> Actual Result: Completion Date is {MyPostsPages.GetValueOfCompletionDate} display.");
                }
                else if (testScenariosDescription.Contains("Last 7 Days"))
                {
                    DateTime targetDate = DateTime.Parse(MyPostsPages.GetValueOfCompletionDate);
                    if (targetDate >= lastSevenDays && targetDate <= today)
                    {
                        test.Pass($"<b>PASSED.</b> Actual Result: Completion Date is {MyPostsPages.GetValueOfCompletionDate} display.");
                    }
                    else
                    {
                        // Log a fail status with the exception message
                        test.Fail("<b>FAILED.</b> The expected date did not match.");
                        await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
                    }
                }
                else if (testScenariosDescription.Contains("Last 30 Days"))
                {
                    DateTime targetDate = DateTime.Parse(MyPostsPages.GetValueOfCompletionDate);
                    if (targetDate >= lastThirtyDays && targetDate <= today)
                    {
                        test.Pass($"<b>PASSED.</b> Actual Result: Completion Date is {MyPostsPages.GetValueOfCompletionDate} display.");
                    }
                    else
                    {
                        // Log a fail status with the exception message
                        test.Fail("<b>FAILED.</b> The expected date did not match.");
                        await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
                    }
                }
                else if (testScenariosDescription.Contains("This Month"))
                {
                    DateTime targetDate = DateTime.Parse(MyPostsPages.GetValueOfCompletionDate);
                    if (targetDate >= today && targetDate <= today)
                    {
                        test.Pass($"<b>PASSED.</b> Actual Result: Completion Date is {MyPostsPages.GetValueOfCompletionDate} display.");
                    }
                    else
                    {
                        // Log a fail status with the exception message
                        test.Fail("<b>FAILED.</b> The expected date did not match.");
                        await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
                    }
                }
                else if (testScenariosDescription.Contains("Last Month"))
                {
                    DateTime targetDate = DateTime.Parse(MyPostsPages.GetValueOfCompletionDate);
                    for (DateTime date = firstDayOfLastMonth; date <= lastDayOfLastMonth; date = date.AddDays(1))
                    {
                        //Console.WriteLine(date.ToString("MM/dd/yyyy"));
                        dateRange.Add(date);
                    }
                    string lastMonthDateRange = string.Join(", ", dateRange.Select(d => d.ToString("MM/dd/yyyy")));

                    if (lastMonthDateRange.Contains(MyPostsPages.GetValueOfCompletionDate))
                    {
                        test.Pass($"<b>PASSED.</b> Actual Result: Completion Date is {MyPostsPages.GetValueOfCompletionDate} display.");
                    }
                    else
                    {
                        // Log a fail status with the exception message
                        test.Fail("<b>FAILED.</b> The expected date did not match.");
                        await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
                    }
                }
                else if (testScenariosDescription.Contains("Custom Range"))
                {
                    if (await MyPostsPages.DashboardPostList_Container.IsVisibleAsync())
                    {
                        test.Pass($"<b>PASSED.</b> Actual Result: {MyPostsPages.GetValueOfDashboardListLabel}");
                    }
                    else
                    {
                        await PageTest.Expect(MyPostsPages.CompletionDate_Label.First).ToHaveTextAsync(new Regex(CustomDatePattern));
                        // Log a pass status with a discription
                        test.Pass($"<b>PASSED.</b> Actual Result: Completion Date is {MyPostsPages.GetValueOfCompletionDate} display.");
                    }

                }
            }
            catch (Exception e)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected date did not match.");
                ex = e;
                StepsToReplicateForReporting(test, testScenariosDescription);
                _logger.Debug(ex.Message); // identify message for this debug level.
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        public async Task ShouldDisplayPostTransaction(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            ExtentReports Extent = GetInstance();
            var test = Extent.CreateTest(testScenariosDescription);

            try
            {
                await PageTest.Expect(MyPostsPages.DashboardLatesPost_Button.First).ToHaveClassAsync("list-item");
                // Log a pass status with a discription
                test.Pass($"<b>PASSED.</b> Actual {MyPostsPages.GetValueOfTransactionRecord}.");
            }
            catch (Exception e)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected post transaction(s) did not display.");
                ex = e;
                StepsToReplicateForReporting(test, testScenariosDescription);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        

    }
}

