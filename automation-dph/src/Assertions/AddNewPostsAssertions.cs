
namespace automation_dph.src.Assertions
{
	public class AddNewPostsAssertions : BasePageDriver
	{
		public AddNewPostsAssertions(IPage page, PageTest pageTest) : base(page, pageTest)
		{
            AddNewPosts = new(Page, PageTest);
            AddNewPostsPages = new(Page, PageTest);

        }

        private ExtentTest test = null!;
        private Exception ex = null!;

        protected AddNewPosts AddNewPosts { get; private set; }
        protected AddNewPostsPages AddNewPostsPages { get; private set; }

        private void StepsToReplicateForReporting(ExtentTest test, string testScenariosDescription)
        {
            string actualResultLabel = $"<b>Actual Result:<b> <br>{ex.Message}";
            var addNewPostScenarios = new Dictionary<string, Func<Task>>
            {
                { AddNewPosts.TestScenariosScheduledPosts[0], () => { test.Info(AddNewPosts.StepsToReplicateScheduledPost + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosScheduledPosts[1], () => { test.Info(AddNewPosts.StepsToReplicateScheduledPost + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosScheduledPosts[2], () => { test.Info(AddNewPosts.StepsToReplicateNoSelectedValuePost + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosScheduledPosts[3], () => { test.Info(AddNewPosts.StepsToReplicateSchedueldLinkPage + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[0], () => { test.Info(AddNewPosts.StepsToReplicateValidValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[1], () => { test.Info(AddNewPosts.StepsToReplicateValidValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[2], () => { test.Info(AddNewPosts.StepsToReplicateValidValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[3], () => { test.Info(AddNewPosts.StepsToReplicateValidValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[4], () => { test.Info(AddNewPosts.StepsToReplicateValidValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[5], () => { test.Info(AddNewPosts.StepsToReplicateValidValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[6], () => { test.Info(AddNewPosts.StepsToReplicateValidValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[7], () => { test.Info(AddNewPosts.StepsToReplicateValidValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[8], () => { test.Info(AddNewPosts.StepsToReplicateValidValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[9], () => { test.Info(AddNewPosts.StepsToReplicateValidValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[10], () => { test.Info(AddNewPosts.StepsToReplicateValidValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[11], () => { test.Info(AddNewPosts.StepsToReplicateValidValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[12], () => { test.Info(AddNewPosts.StepsToReplicateClearDropdownFunctionality + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[13], () => { test.Info(AddNewPosts.StepsToReplicateClearDropdownFunctionality + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[14], () => { test.Info(AddNewPosts.StepsToReplicateClearDropdownFunctionality + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[15], () => { test.Info(AddNewPosts.StepsToReplicatePreviousStepFunctionality + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[16], () => { test.Info(AddNewPosts.StepsToReplicatePickupDetailsHyperlink + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[17], () => { test.Info(AddNewPosts.StepsToReplicateInvalidValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[18], () => { test.Info(AddNewPosts.StepsToReplicateInvalidValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[19], () => { test.Info(AddNewPosts.StepsToReplicateInvalidValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[20], () => { test.Info(AddNewPosts.StepsToReplicateInvalidValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[21], () => { test.Info(AddNewPosts.StepsToReplicateInvalidValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[22], () => { test.Info(AddNewPosts.StepsToReplicateInvalidValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[23], () => { test.Info(AddNewPosts.StepsToReplicateBlankValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[24], () => { test.Info(AddNewPosts.StepsToReplicateBlankValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[25], () => { test.Info(AddNewPosts.StepsToReplicateBlankValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[26], () => { test.Info(AddNewPosts.StepsToReplicateBlankValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[27], () => { test.Info(AddNewPosts.StepsToReplicateBlankValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[28], () => { test.Info(AddNewPosts.StepsToReplicateBlankValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[29], () => { test.Info(AddNewPosts.StepsToReplicateBlankValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[30], () => { test.Info(AddNewPosts.StepsToReplicateBlankValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[31], () => { test.Info(AddNewPosts.StepsToReplicateBlankValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[32], () => { test.Info(AddNewPosts.StepsToReplicateMaxLengthValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[33], () => { test.Info(AddNewPosts.StepsToReplicateMaxLengthValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[34], () => { test.Info(AddNewPosts.StepsToReplicateMaxLengthValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[35], () => { test.Info(AddNewPosts.StepsToReplicateMaxLengthValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[36], () => { test.Info(AddNewPosts.StepsToReplicateMaxLengthValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[37], () => { test.Info(AddNewPosts.StepsToReplicateMaxLengthValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[38], () => { test.Info(AddNewPosts.StepsToReplicateMaxLengthValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[39], () => { test.Info(AddNewPosts.StepsToReplicateValidValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[40], () => { test.Info(AddNewPosts.StepsToReplicateValidValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[41], () => { test.Info(AddNewPosts.StepsToReplicateValidValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[42], () => { test.Info(AddNewPosts.StepsToReplicateValidValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[43], () => { test.Info(AddNewPosts.StepsToReplicateValidValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[44], () => { test.Info(AddNewPosts.StepsToReplicateValidValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[45], () => { test.Info(AddNewPosts.StepsToReplicateValidValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[46], () => { test.Info(AddNewPosts.StepsToReplicateValidValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[47], () => { test.Info(AddNewPosts.StepsToReplicateValidValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[48], () => { test.Info(AddNewPosts.StepsToReplicateValidValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[49], () => { test.Info(AddNewPosts.StepsToReplicateValidValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[50], () => { test.Info(AddNewPosts.StepsToReplicateValidValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[51], () => { test.Info(AddNewPosts.StepsToReplicateClearDropdownFunctionality + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[52], () => { test.Info(AddNewPosts.StepsToReplicateClearDropdownFunctionality + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[53], () => { test.Info(AddNewPosts.StepsToReplicateClearDropdownFunctionality + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[54], () => { test.Info(AddNewPosts.StepsToReplicatePreviousStepFunctionality + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[55], () => { test.Info(AddNewPosts.StepsToReplicatePickupDetailsHyperlink + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[56], () => { test.Info(AddNewPosts.StepsToReplicateInvalidValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[57], () => { test.Info(AddNewPosts.StepsToReplicateInvalidValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[58], () => { test.Info(AddNewPosts.StepsToReplicateInvalidValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[59], () => { test.Info(AddNewPosts.StepsToReplicateInvalidValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[60], () => { test.Info(AddNewPosts.StepsToReplicateInvalidValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[61], () => { test.Info(AddNewPosts.StepsToReplicateInvalidValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[62], () => { test.Info(AddNewPosts.StepsToReplicateBlankValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[63], () => { test.Info(AddNewPosts.StepsToReplicateBlankValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[64], () => { test.Info(AddNewPosts.StepsToReplicateBlankValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[65], () => { test.Info(AddNewPosts.StepsToReplicateBlankValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[66], () => { test.Info(AddNewPosts.StepsToReplicateBlankValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[67], () => { test.Info(AddNewPosts.StepsToReplicateBlankValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[68], () => { test.Info(AddNewPosts.StepsToReplicateBlankValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[69], () => { test.Info(AddNewPosts.StepsToReplicateBlankValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[70], () => { test.Info(AddNewPosts.StepsToReplicateBlankValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[71], () => { test.Info(AddNewPosts.StepsToReplicateMaxLengthValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[72], () => { test.Info(AddNewPosts.StepsToReplicateMaxLengthValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[73], () => { test.Info(AddNewPosts.StepsToReplicateMaxLengthValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[74], () => { test.Info(AddNewPosts.StepsToReplicateMaxLengthValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[75], () => { test.Info(AddNewPosts.StepsToReplicateMaxLengthValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[76], () => { test.Info(AddNewPosts.StepsToReplicateMaxLengthValue + actualResultLabel); return Task.CompletedTask; } },
                { AddNewPosts.TestScenariosPickupDetails[77], () => { test.Info(AddNewPosts.StepsToReplicateMaxLengthValue + actualResultLabel); return Task.CompletedTask; } },
            };

            if (addNewPostScenarios.TryGetValue(testScenariosDescription, out var action))
            {
                action.Invoke();
            }
        }

        public async Task ShouldDisplayOndemandCourier(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            // Create a test instance in ExtentReports
            ExtentReports Extent = GetInstance();
            test = Extent.CreateTest(testScenariosDescription);

            try
            {
                if (testScenariosDescription == AddNewPosts.TestScenariosScheduledPosts[0])
                {
                    await PageTest.Expect(AddNewPostsPages.OndemandCourierRow_List).ToContainTextAsync("Broadcast On-Demand Settings");
                    // Log a pass status with a discription
                    test.Pass($"<b>PASSED.</b> Actual Result: {AddNewPostsPages.GetValueOfCourierListInCourierPage}");
                }
                else if(testScenariosDescription == AddNewPosts.TestScenariosScheduledPosts[1])
                {
                    await PageTest.Expect(AddNewPostsPages.OndemandCourierRow_List).Not.ToContainTextAsync("Broadcast On-Demand Settings");
                    // Log a pass status with a discription
                    test.Pass($"<b>PASSED.</b> Actual Result: {AddNewPostsPages.GetValueOfCourierListInCourierPage}");
                }
                
            }
            catch (Exception e)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected list did not match.");
                ex = e;
                StepsToReplicateForReporting(test, testScenariosDescription);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        public async Task ShouldDisplayErrorNotification(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            {
                // Create a test instance in ExtentReports
                ExtentReports Extent = GetInstance();
                test = Extent.CreateTest(testScenariosDescription);

                try
                {
                    await PageTest.Expect(AddNewPostsPages.ErrorNotification_Toastify.First).ToBeVisibleAsync();
                    // Log a pass status with a discription
                    test.Pass($"<b>PASSED.</b> Actual Result: {AddNewPostsPages.GetValueOfErrorNotification}");

                }
                catch (Exception e)
                {
                    // Log a fail status with the exception message
                    test.Fail("<b>FAILED.</b> The expected list did not match.");
                    ex = e;
                    StepsToReplicateForReporting(test, testScenariosDescription);
                    await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
                }
                Extent.Flush();
            }
        }

        public async Task ShouldDisplayScheduledPostsPage(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            // Create a test instance in ExtentReports
            ExtentReports Extent = GetInstance();
            test = Extent.CreateTest(testScenariosDescription);

            try
            {
                await PageTest.Expect(AddNewPostsPages.ScheduledPostPage_Label.First).ToContainTextAsync("Schedule Post");
                // Log a pass status with a discription
                test.Pass($"<b>PASSED.</b> Actual Result: {AddNewPostsPages.GetValueOfScheduledPostPageLabel} Page display.");

            }
            catch (Exception e)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected list did not match.");
                ex = e;
                StepsToReplicateForReporting(test, testScenariosDescription);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        public async Task ShouldNotDisplayErrorMessage(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            // Create a test instance in ExtentReports
            ExtentReports Extent = GetInstance();
            test = Extent.CreateTest(testScenariosDescription);

            try
            {
                await Page.WaitForTimeoutAsync(2000); // wait for notificaiton to appear
                await PageTest.Expect(AddNewPostsPages.ErrorNotification_Toastify).Not.ToBeVisibleAsync();
                // Log a pass status with a discription
                test.Pass($"<b>PASSED.</b> Actual Result: Displayed Delivery Details Page. <br>");
            }
            catch (Exception e)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected notification did not match.");
                ex = e;
                StepsToReplicateForReporting(test, testScenariosDescription);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        public async Task ShouldProceedToNextPage(ILocator fieldLocator, string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            // Create a test instance in ExtentReports
            ExtentReports Extent = GetInstance();
            test = Extent.CreateTest(testScenariosDescription);

            try
            {
                await Page.WaitForTimeoutAsync(2000); // wait for notificaiton to appear
                string getValue = fieldLocator.InnerHTMLAsync().GetAwaiter().GetResult();
                await PageTest.Expect(fieldLocator).ToContainTextAsync(getValue);
                // Log a pass status with a discription
                test.Pass($"<b>PASSED.</b> Actual Result: Displayed {getValue} Page. <br>");
            }
            catch (Exception e)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected title page did not match.");
                ex = e;
                StepsToReplicateForReporting(test, testScenariosDescription);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        public async Task ShouldClearValue(ILocator fieldLocator, string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            // Create a test instance in ExtentReports
            ExtentReports Extent = GetInstance();
            test = Extent.CreateTest(testScenariosDescription);

            try
            {
                await Page.WaitForTimeoutAsync(2000); // wait for notificaiton to appear
                await PageTest.Expect(fieldLocator.First).ToContainTextAsync("Select...");

                // Log a pass status with a discription
                test.Pass($"<b>PASSED.</b> Actual Result: Empty dropdown field. <br>");
            }
            catch (Exception e)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected behaviour did not match.");
                ex = e;
                StepsToReplicateForReporting(test, testScenariosDescription);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        public async Task ShouldDisplayPreviousPage(ILocator fieldLocator, string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            // Create a test instance in ExtentReports
            ExtentReports Extent = GetInstance();
            test = Extent.CreateTest(testScenariosDescription);

            try
            {
                await Page.WaitForTimeoutAsync(2000); // wait for notificaiton to appear
                string getValue = fieldLocator.InnerHTMLAsync().GetAwaiter().GetResult();
                await PageTest.Expect(fieldLocator.First).ToContainTextAsync(getValue);

                // Log a pass status with a discription
                test.Pass($"<b>PASSED.</b> Actual Result: Display {getValue} page. <br>");
            }
            catch (Exception e)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected page did not match.");
                ex = e;
                StepsToReplicateForReporting(test, testScenariosDescription);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        public async Task ShouldValueNotExceeded(ILocator fieldLocator, string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            // Create a test instance in ExtentReports
            ExtentReports Extent = GetInstance();
            test = Extent.CreateTest(testScenariosDescription);

            try
            {
                await Page.WaitForTimeoutAsync(2000); // wait for notificaiton to appear
                string? getValue = await fieldLocator.First.GetAttributeAsync("value");
                int textCount = getValue.Length;
                if (testScenariosDescription.Contains("Reference")) { Assert.IsTrue(textCount <= 30); }
                else if (testScenariosDescription.Contains("Name")) { Assert.IsTrue(textCount <= 80); }
                else if (testScenariosDescription.Contains("Mobile")) { Assert.IsTrue(textCount <= 20); }
                else if (testScenariosDescription.Contains("Email")) { Assert.IsTrue(textCount <= 60); }
                else if (testScenariosDescription.Contains("Address")) { Assert.IsTrue(textCount <= 350); }
                else if (testScenariosDescription.Contains("Postal")) { Assert.IsTrue(textCount <= 4); }
                else if (testScenariosDescription.Contains("Quantity")) { Assert.IsTrue(textCount <= 15); }
                else if (testScenariosDescription.Contains("COD Amount")) { Assert.IsTrue(textCount <= 15); }
                else if (testScenariosDescription.Contains("Declared value")) { Assert.IsTrue(textCount <= 15); }
                //else if (testScenariosDescription.Contains("Length")) { Assert.IsTrue(textCount <= 7); }
                else if (testScenariosDescription.Contains("Width")) { Assert.IsTrue(textCount <= 7); }
                else if (testScenariosDescription.Contains("Height")) { Assert.IsTrue(textCount <= 7); }
                else if (testScenariosDescription.Contains("Depth")) { Assert.IsTrue(textCount <= 7); }
                else if (testScenariosDescription.Contains("Weight")) { Assert.IsTrue(textCount <= 7); }


                // Log a pass status with a discription
                test.Pass($"<b>PASSED.</b> Actual Result: Field length is {textCount}. <br>");
            }
            catch (AssertFailedException e)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected length did not match.");
                ex = e;
                StepsToReplicateForReporting(test, testScenariosDescription);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        public async Task ShouldNotExceededForTextArea(ILocator fieldLocator, string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            // Create a test instance in ExtentReports
            ExtentReports Extent = GetInstance();
            test = Extent.CreateTest(testScenariosDescription);

            try
            {
                await Page.WaitForTimeoutAsync(2000); // wait for notificaiton to appear
                string? getValueOfTextArea = await fieldLocator.First.TextContentAsync();
                int textCountOfTextArea = getValueOfTextArea.Length;
                if (testScenariosDescription.Contains("Item Description")) { Assert.IsTrue(textCountOfTextArea <= 350); }
                else if (testScenariosDescription.Contains("Remarks")) { Assert.IsTrue(textCountOfTextArea <= 350); }


                // Log a pass status with a discription
                test.Pass($"<b>PASSED.</b> Actual Result: Field length is {textCountOfTextArea}. <br>");
            }
            catch (AssertFailedException e)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected length did not match.");
                ex = e;
                StepsToReplicateForReporting(test, testScenariosDescription);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }


    }
}

