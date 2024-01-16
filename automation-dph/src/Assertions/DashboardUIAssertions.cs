
namespace automation_dph.src.Assertions
{
	public class DashboardUIAssertions : BasePageDriver
	{
		public DashboardUIAssertions(IPage page, PageTest pageTest) : base(page, pageTest)
		{
			MyPostsPages = new(Page, PageTest);
			DataConfiguration = new(Page, PageTest);
            DashboardUI = new(Page, PageTest);
		}

        protected MyPostsPages MyPostsPages { get; private set; }
        protected DataConfiguration DataConfiguration { get; private set; }
        protected DashboardUI DashboardUI { get; private set; }

        private ExtentTest test = null!;
        private Exception ex = null!;

        private void StepsToReplicateForReporting(ExtentTest test, string testScenariosDescription)
        {
            var DashboardUIScenarios = new Dictionary<string, Func<Task>>
            {
                { DashboardUI.VisibilityTestScenarios[0], () => { test.Info(DashboardUI.StepsToReplicate[0] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.VisibilityTestScenarios[1], () => { test.Info(DashboardUI.StepsToReplicate[3] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.VisibilityTestScenarios[2], () => { test.Info(DashboardUI.StepsToReplicate[6] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.VisibilityTestScenarios[3], () => { test.Info(DashboardUI.StepsToReplicate[9] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.VisibilityTestScenarios[4], () => { test.Info(DashboardUI.StepsToReplicate[12] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.VisibilityTestScenarios[5], () => { test.Info(DashboardUI.StepsToReplicate[15] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.VisibilityTestScenarios[6], () => { test.Info(DashboardUI.StepsToReplicate[18] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.VisibilityTestScenarios[7], () => { test.Info(DashboardUI.StepsToReplicate[20] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.VisibilityTestScenarios[8], () => { test.Info(DashboardUI.StepsToReplicate[23] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.VisibilityTestScenarios[9], () => { test.Info(DashboardUI.StepsToReplicate[26] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.VisibilityTestScenarios[10], () => { test.Info(DashboardUI.StepsToReplicate[29] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.VisibilityTestScenarios[11], () => { test.Info(DashboardUI.StepsToReplicate[31] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.VisibilityTestScenarios[12], () => { test.Info(DashboardUI.StepsToReplicate[33] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.VisibilityTestScenarios[13], () => { test.Info(DashboardUI.StepsToReplicate[35] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.VisibilityTestScenarios[14], () => { test.Info(DashboardUI.StepsToReplicate[37] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.VisibilityTestScenarios[15], () => { test.Info(DashboardUI.StepsToReplicate[39] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.VisibilityTestScenarios[16], () => { test.Info(DashboardUI.StepsToReplicate[41] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.VisibilityTestScenarios[17], () => { test.Info(DashboardUI.StepsToReplicate[43] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.VisibilityTestScenarios[18], () => { test.Info(DashboardUI.StepsToReplicate[45] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.VisibilityTestScenarios[19], () => { test.Info(DashboardUI.StepsToReplicate[48] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.VisibilityTestScenarios[20], () => { test.Info(DashboardUI.StepsToReplicate[49] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.FunctionalityTestScenarios[0], () => { test.Info(DashboardUI.StepsToReplicate[2] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.FunctionalityTestScenarios[1], () => { test.Info(DashboardUI.StepsToReplicate[4] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.FunctionalityTestScenarios[2], () => { test.Info(DashboardUI.StepsToReplicate[7] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.FunctionalityTestScenarios[3], () => { test.Info(DashboardUI.StepsToReplicate[10] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.FunctionalityTestScenarios[4], () => { test.Info(DashboardUI.StepsToReplicate[13] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.FunctionalityTestScenarios[5], () => { test.Info(DashboardUI.StepsToReplicate[16] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.FunctionalityTestScenarios[6], () => { test.Info(DashboardUI.StepsToReplicate[21] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.FunctionalityTestScenarios[7], () => { test.Info(DashboardUI.StepsToReplicate[24] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.FunctionalityTestScenarios[8], () => { test.Info(DashboardUI.StepsToReplicate[27] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.FunctionalityTestScenarios[9], () => { test.Info(DashboardUI.StepsToReplicate[46] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.LabelingTestScenarios[0], () => { test.Info(DashboardUI.StepsToReplicate[2] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.LabelingTestScenarios[1], () => { test.Info(DashboardUI.StepsToReplicate[19] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.LabelingTestScenarios[2], () => { test.Info(DashboardUI.StepsToReplicate[25] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.LabelingTestScenarios[3], () => { test.Info(DashboardUI.StepsToReplicate[28] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.LabelingTestScenarios[4], () => { test.Info(DashboardUI.StepsToReplicate[30] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.LabelingTestScenarios[5], () => { test.Info(DashboardUI.StepsToReplicate[32] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.LabelingTestScenarios[6], () => { test.Info(DashboardUI.StepsToReplicate[34] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.LabelingTestScenarios[7], () => { test.Info(DashboardUI.StepsToReplicate[36] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.LabelingTestScenarios[8], () => { test.Info(DashboardUI.StepsToReplicate[38] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.LabelingTestScenarios[9], () => { test.Info(DashboardUI.StepsToReplicate[40] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.LabelingTestScenarios[10], () => { test.Info(DashboardUI.StepsToReplicate[42] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.LabelingTestScenarios[11], () => { test.Info(DashboardUI.StepsToReplicate[44] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.ListingTestScenarios[0], () => { test.Info(DashboardUI.StepsToReplicate[5] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.ListingTestScenarios[1], () => { test.Info(DashboardUI.StepsToReplicate[11] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.ListingTestScenarios[2], () => { test.Info(DashboardUI.StepsToReplicate[14] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.ListingTestScenarios[3], () => { test.Info(DashboardUI.StepsToReplicate[17] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.ListingTestScenarios[4], () => { test.Info(DashboardUI.StepsToReplicate[22] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.ListingTestScenarios[5], () => { test.Info(DashboardUI.StepsToReplicate[47] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
                { DashboardUI.MaxLengthTestScenarios[0], () => { test.Info(DashboardUI.StepsToReplicate[8] + $"<b>Actual Result:</b> <br>{ex.Message}"); return Task.CompletedTask; } },
            };

            if (DashboardUIScenarios.TryGetValue(testScenariosDescription, out var action))
            {
                action.Invoke();
            }
        }

        public async Task ShouldBeVisible(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            ExtentReports Extent = GetInstance();
            test = Extent.CreateTest(testScenariosDescription);

            try
            {
                await TypeOfElementToBeVisible(testScenariosDescription);

                // Log a pass status with a discription
                test.Pass($"<b>PASSED.</b> Actual: Element is visible.");
            }
            catch (Exception e)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected visibility did not match.");
                ex = e;
                StepsToReplicateForReporting(test, testScenariosDescription);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        private async Task TypeOfElementToBeVisible(string reportDescription)
        {
            var scenarios = new Dictionary<string, Func<Task>>
            {
                { DashboardUI.VisibilityTestScenarios[0], async () => await PageTest.Expect(MyPostsPages.AddNewPosts_Button).ToBeVisibleAsync()},
                { DashboardUI.VisibilityTestScenarios[1], async () => await PageTest.Expect(MyPostsPages.SearchPost_Dropdown).ToBeVisibleAsync() },
                { DashboardUI.VisibilityTestScenarios[2], async () => await PageTest.Expect(MyPostsPages.Search_Textfield).ToBeVisibleAsync() },
                { DashboardUI.VisibilityTestScenarios[3], async () => await PageTest.Expect(MyPostsPages.Hubs_Dropdown).ToBeVisibleAsync() },
                { DashboardUI.VisibilityTestScenarios[4], async () => await PageTest.Expect(MyPostsPages.Status_Dropdown).ToBeVisibleAsync() },
                { DashboardUI.VisibilityTestScenarios[5], async () => await PageTest.Expect(MyPostsPages.PreferredPartner_Dropdown).ToBeVisibleAsync() },
                { DashboardUI.VisibilityTestScenarios[6], async () => await PageTest.Expect(MyPostsPages.MyPostsTitlePage_Label).ToBeVisibleAsync() },
                { DashboardUI.VisibilityTestScenarios[7], async () => await PageTest.Expect(MyPostsPages.Date_Dropdown).ToBeVisibleAsync() },
                { DashboardUI.VisibilityTestScenarios[8], async () => await PageTest.Expect(MyPostsPages.AllTab_Link).ToBeVisibleAsync() },
                { DashboardUI.VisibilityTestScenarios[9], async () => await PageTest.Expect(MyPostsPages.CancelledReturnedRejectedTab_Link).ToBeVisibleAsync() },
                { DashboardUI.VisibilityTestScenarios[10], async () => await PageTest.Expect(MyPostsPages.Reference_Label).ToBeVisibleAsync() },
                { DashboardUI.VisibilityTestScenarios[11], async () => await PageTest.Expect(MyPostsPages.CustomerName_Label).ToBeVisibleAsync() },
                { DashboardUI.VisibilityTestScenarios[12], async () => await PageTest.Expect(MyPostsPages.PreferredPartner_Label).ToBeVisibleAsync() },
                { DashboardUI.VisibilityTestScenarios[13], async () => await PageTest.Expect(MyPostsPages.Time_Label).ToBeVisibleAsync() },
                { DashboardUI.VisibilityTestScenarios[14], async () => await PageTest.Expect(MyPostsPages.PickupCity_Label).ToBeVisibleAsync() },
                { DashboardUI.VisibilityTestScenarios[15], async () => await PageTest.Expect(MyPostsPages.DeliveryCity_Label).ToBeVisibleAsync() },
                { DashboardUI.VisibilityTestScenarios[16], async () => await PageTest.Expect(MyPostsPages.Tags_Label).ToBeVisibleAsync() },
                { DashboardUI.VisibilityTestScenarios[17], async () => await PageTest.Expect(MyPostsPages.Completion_Label).ToBeVisibleAsync() },
                { DashboardUI.VisibilityTestScenarios[18], async () => await PageTest.Expect(MyPostsPages.MyPostsEllipsis_Button).ToBeVisibleAsync() },
                { DashboardUI.VisibilityTestScenarios[19], async () => await PageTest.Expect(MyPostsPages.MyPosts_Dashboard).ToBeVisibleAsync() },
                { DashboardUI.VisibilityTestScenarios[20], async () => await PageTest.Expect(MyPostsPages.PaginationPostsNumberDisplay_Label).ToBeVisibleAsync() }
            };

            if (scenarios.TryGetValue(reportDescription, out var action))
            {
                await action.Invoke();
            }
        }

        public async Task ShouldBeClickable(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            ExtentReports Extent = GetInstance();
            test = Extent.CreateTest(testScenariosDescription);

            try
            {
                await TypeOfElementToBeClickable(testScenariosDescription);
                // Log a pass status with a discription
                test.Pass($"<b>PASSED.</b> Actual: Element is working.");
            }
            catch (Exception e)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected visibility did not match.");
                ex = e;
                StepsToReplicateForReporting(test, testScenariosDescription);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        private async Task TypeOfElementToBeClickable(string testScenariosDescription)
        {
            var dropdownActions = new Dictionary<string, Func<Task>>
            {
                { DashboardUI.FunctionalityTestScenarios[1], async () =>
                    {
                    await MyPostsPages.SearchPost_Dropdown.ClickAsync();
                    await PageTest.Expect(MyPostsPages.SearchPostDropdown_List).ToBeEnabledAsync();
                    }
                },
                { DashboardUI.FunctionalityTestScenarios[3], async () => await PageTest.Expect(MyPostsPages.Hubs_Dropdown).ToBeEnabledAsync() },
                { DashboardUI.FunctionalityTestScenarios[4], async () => await PageTest.Expect(MyPostsPages.Status_Dropdown).ToBeEnabledAsync() },
                { DashboardUI.FunctionalityTestScenarios[5], async () => await PageTest.Expect(MyPostsPages.PreferredPartner_Dropdown).ToBeEnabledAsync() },
                { DashboardUI.FunctionalityTestScenarios[6], async () => await PageTest.Expect(MyPostsPages.Date_Dropdown).ToBeEnabledAsync() },
                { DashboardUI.FunctionalityTestScenarios[7], async () => await PageTest.Expect(MyPostsPages.AllTab_Link).ToBeEnabledAsync() },
                { DashboardUI.FunctionalityTestScenarios[8], async () => await PageTest.Expect(MyPostsPages.CancelledReturnedRejectedTab_Link).ToBeEnabledAsync() },
                { DashboardUI.FunctionalityTestScenarios[9], async () => await PageTest.Expect(MyPostsPages.MyPostsEllipsis_Button).ToBeEnabledAsync() },
             };

            if (dropdownActions.TryGetValue(testScenariosDescription, out var action))
            {
                await action.Invoke();
            }
        }

        public async Task ShouldContainTextInputted(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            ExtentReports Extent = GetInstance();
            test = Extent.CreateTest(testScenariosDescription);

            try
            {
                await TypeOfElementToBeContainInputtedText(testScenariosDescription);
                // Log a pass status with a discription
                string inputtedValue = await MyPostsPages.Search_Textfield.InputValueAsync();
                test.Pass($"<b>PASSED.</b> Actual: The inputted value is {inputtedValue}");
            }
            catch (Exception e)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected value did not match.");
                ex = e;
                StepsToReplicateForReporting(test, testScenariosDescription);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        private async Task TypeOfElementToBeContainInputtedText(string testScenariosDescription)
        {
            if (testScenariosDescription.Contains("3.2"))
            {
                await MyPostsPages.InputSearchValue(DataConfiguration.customerName);
                await PageTest.Expect(MyPostsPages.Search_Textfield).ToHaveValueAsync(DataConfiguration.customerName);
            }
        }

        public async Task ShouldCorrectLabeling(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            ExtentReports Extent = GetInstance();
            test = Extent.CreateTest(testScenariosDescription);

            try
            {
                await TypeOfElementLabeling(testScenariosDescription);

                // Log a pass status with a discription
                test.Pass($"<b>PASSED.</b> Actual: Correct Label.");
            }
            catch (Exception e)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected visibility did not match.");
                ex = e;
                StepsToReplicateForReporting(test, testScenariosDescription);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        private async Task TypeOfElementLabeling(string testScenariosDescription)
        {
            var labelingScenarios = new Dictionary<string, Func<Task>>
            {
                { DashboardUI.LabelingTestScenarios[0], async () => await PageTest.Expect(MyPostsPages.AddNewPosts_Button).ToHaveTextAsync("Add New Post") },
                { DashboardUI.LabelingTestScenarios[1], async () => await PageTest.Expect(MyPostsPages.MyPostsTitlePage_Label).ToHaveTextAsync("My Posts")},
                { DashboardUI.LabelingTestScenarios[2], async () => await PageTest.Expect(MyPostsPages.AllTab_Link).ToHaveTextAsync("All")},
                { DashboardUI.LabelingTestScenarios[3], async () => await PageTest.Expect(MyPostsPages.CancelledReturnedRejectedTab_Link).ToHaveTextAsync("Cancelled, Returned & Rejected") },
                { DashboardUI.LabelingTestScenarios[4], async () => await PageTest.Expect(MyPostsPages.Reference_Label).ToHaveTextAsync("Ref No.") },
                { DashboardUI.LabelingTestScenarios[5], async () => await PageTest.Expect(MyPostsPages.CustomerName_Label).ToHaveTextAsync("Customer") },
                { DashboardUI.LabelingTestScenarios[6], async () => await PageTest.Expect(MyPostsPages.PreferredPartner_Label).ToHaveTextAsync("Preferred Partner") },
                { DashboardUI.LabelingTestScenarios[7], async () => await PageTest.Expect(MyPostsPages.Time_Label).ToHaveTextAsync("Time") },
                { DashboardUI.LabelingTestScenarios[8], async () => await PageTest.Expect(MyPostsPages.PickupCity_Label).ToHaveTextAsync("Pickup City") },
                { DashboardUI.LabelingTestScenarios[9], async () => await PageTest.Expect(MyPostsPages.DeliveryCity_Label).ToHaveTextAsync("Delivery City") },
                { DashboardUI.LabelingTestScenarios[10], async () => await PageTest.Expect(MyPostsPages.Tags_Label).ToHaveTextAsync("Tags") },
                { DashboardUI.LabelingTestScenarios[11], async () => await PageTest.Expect(MyPostsPages.Completion_Label).ToHaveTextAsync("Completion Date") },
            };

            if (labelingScenarios.TryGetValue(testScenariosDescription, out var action))
            {
                await action.Invoke();
            }
        }

        public async Task ShouldHaveListDisplay(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            ExtentReports Extent = GetInstance();
            test = Extent.CreateTest(testScenariosDescription);

            try
            {
                await TypeOfElementToDisplayListItem(testScenariosDescription);
                // Log a pass status with a discription
                test.Pass($"<b>PASSED.</b> Actual: List of items display.");
            }
            catch (Exception e)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected visibility did not match.");
                ex = e;
                StepsToReplicateForReporting(test, testScenariosDescription);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        private async Task TypeOfElementToDisplayListItem(string testScenariosDescription)
        {
            var listOfItemScenarios = new Dictionary<string, Func<Task>>
            {
                { DashboardUI.LabelingTestScenarios[0], async () =>
                    {
                        await MyPostsPages.SearchPost_Dropdown.ClickAsync();
                        await PageTest.Expect(MyPostsPages.SearchPostDropdown_List).ToContainTextAsync("Customer Name");
                    }
                },
                { DashboardUI.LabelingTestScenarios[1], async () =>
                    {
                        await MyPostsPages.Hubs_Dropdown.ClickAsync();
                        await PageTest.Expect(MyPostsPages.HubsDropdown_List).ToContainTextAsync("QA Store");
                    }
                },
                { DashboardUI.LabelingTestScenarios[2], async () =>
                    {
                        await MyPostsPages.Status_Dropdown.ClickAsync();
                        await PageTest.Expect(MyPostsPages.StatusDropdown_List).ToContainTextAsync("Accepted");
                    }
                },
                { DashboardUI.LabelingTestScenarios[3], async () =>
                    {
                        await MyPostsPages.PreferredPartner_Dropdown.ClickAsync();
                        await PageTest.Expect(MyPostsPages.PreferredPartnerDropdown_List).ToContainTextAsync("All Preferred Partner");
                    }
                },
                { DashboardUI.LabelingTestScenarios[4], async () =>
                    {
                        await MyPostsPages.Date_Dropdown.ClickAsync();
                        await PageTest.Expect(MyPostsPages.DateDropdown_List).ToContainTextAsync("As of Today");
                    }
                },
                { DashboardUI.LabelingTestScenarios[5], async () =>
                    {
                        await MyPostsPages.MyPostsEllipsis_Button.ClickAsync();
                        await PageTest.Expect(MyPostsPages.MyPostsEllipsisButton_List).ToContainTextAsync("Mark As Returned");
                    }
                },
            };

            if (listOfItemScenarios.TryGetValue(testScenariosDescription, out var action))
            {
                await action.Invoke();
            }
        }

        public async Task ShouldLimitLengthText(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            ExtentReports Extent = GetInstance();
            test = Extent.CreateTest(testScenariosDescription);

            try
            {
                await TypeOfElementToBeLimitTextInput(testScenariosDescription);
                // Log a pass status with a discription
                test.Pass($"<b>PASSED.</b> Actual: Maximum length not exceeded");
            }
            catch (Exception e)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected length exceeded.");
                ex = e;
                StepsToReplicateForReporting(test, testScenariosDescription);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        private async Task TypeOfElementToBeLimitTextInput(string testScenariosDescription)
        {
            if (testScenariosDescription.Contains(DashboardUI.MaxLengthTestScenarios[0]))
            {
                await MyPostsPages.InputSearchValue(DataConfiguration.maxLength);
                string inputtedValue = await MyPostsPages.Search_Textfield.InputValueAsync();
                Assert.AreEqual(80, (int)inputtedValue.Length);
            }
        }

    }
}

