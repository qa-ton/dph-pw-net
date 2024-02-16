
namespace automation_dph.src.Assertions
{
	public class ManualPostsCreationAssertions : BasePageDriver
	{
		public ManualPostsCreationAssertions(IPage page, PageTest pageTest) : base(page, pageTest)
		{
            LoginPages = new(Page, PageTest);
            PostsCreation = new(Page, PageTest);
            AddNewPostsPages = new(Page, PageTest);
		}

        private ExtentTest test = null!;
        private Exception ex = null!;

        protected LoginPages LoginPages { get; private set; }
        protected PostsCreation PostsCreation { get; private set; }
        protected AddNewPostsPages AddNewPostsPages { get; private set; }

        private void StepsToReplicateForReporting(ExtentTest test, string testScenariosDescription)
        {
            string actualResultLabel = $"<b>Actual Result:</b> <br>{ex.Message}";
            var postCreationScenarios = new Dictionary<string, Func<Task>>
            {
                { PostsCreation.TestScenarios[0], () => { test.Info(PostsCreation.StepsToReplicatePostCreation + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[1], () => { test.Info(PostsCreation.StepsToReplicatePostCreation + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[2], () => { test.Info(PostsCreation.StepsToReplicatePostCreation + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[3], () => { test.Info(PostsCreation.StepsToReplicatePostCreation + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[4], () => { test.Info(PostsCreation.StepsToReplicatePostCreation + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[5], () => { test.Info(PostsCreation.StepsToReplicatePostCreation + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[6], () => { test.Info(PostsCreation.StepsToReplicatePostCreation + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[7], () => { test.Info(PostsCreation.StepsToReplicatePostCreation + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[8], () => { test.Info(PostsCreation.StepsToReplicatePostCreation + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[9], () => { test.Info(PostsCreation.StepsToReplicatePostCreationCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[10], () => { test.Info(PostsCreation.StepsToReplicatePostCreationCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[11], () => { test.Info(PostsCreation.StepsToReplicatePostCreationCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[12], () => { test.Info(PostsCreation.StepsToReplicatePostCreationCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[13], () => { test.Info(PostsCreation.StepsToReplicatePostCreationCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[14], () => { test.Info(PostsCreation.StepsToReplicatePostCreationCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[15], () => { test.Info(PostsCreation.StepsToReplicatePostCreationCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[16], () => { test.Info(PostsCreation.StepsToReplicatePostCreationCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[17], () => { test.Info(PostsCreation.StepsToReplicatePostCreationCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[18], () => { test.Info(PostsCreation.StepsToReplicatePostCreationCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[19], () => { test.Info(PostsCreation.StepsToReplicatePostCreationCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[20], () => { test.Info(PostsCreation.StepsToReplicatePostCreationNotSupported + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[21], () => { test.Info(PostsCreation.StepsToReplicatePostCreationNotSupported + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[22], () => { test.Info(PostsCreation.StepsToReplicatePostCreationNotSupported + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[23], () => { test.Info(PostsCreation.StepsToReplicatePostCreationNotSupported + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[24], () => { test.Info(PostsCreation.StepsToReplicatePostCreationNotSupported + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[25], () => { test.Info(PostsCreation.StepsToReplicatePostCreationNotSupported + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[26], () => { test.Info(PostsCreation.StepsToReplicatePostCreationNotSupported + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[27], () => { test.Info(PostsCreation.StepsToReplicatePostCreationNotSupported + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[28], () => { test.Info(PostsCreation.StepsToReplicatePostCreationNotSupported + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[29], () => { test.Info(PostsCreation.StepsToReplicatePostCreationNotSupported + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[30], () => { test.Info(PostsCreation.StepsToReplicatePostCreationNotSupported + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[31], () => { test.Info(PostsCreation.StepsToReplicatePostCreationNotSupported + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[32], () => { test.Info(PostsCreation.StepsToReplicatePostCreationNotSupported + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[33], () => { test.Info(PostsCreation.StepsToReplicatePostNotSupportedCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[34], () => { test.Info(PostsCreation.StepsToReplicatePostNotSupportedCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[35], () => { test.Info(PostsCreation.StepsToReplicatePostNotSupportedCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[36], () => { test.Info(PostsCreation.StepsToReplicatePostNotSupportedCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[37], () => { test.Info(PostsCreation.StepsToReplicatePostNotSupportedCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[38], () => { test.Info(PostsCreation.StepsToReplicatePostNotSupportedCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[39], () => { test.Info(PostsCreation.StepsToReplicatePostNotSupportedCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[40], () => { test.Info(PostsCreation.StepsToReplicatePostNotSupportedCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[41], () => { test.Info(PostsCreation.StepsToReplicatePostNotSupportedCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[42], () => { test.Info(PostsCreation.StepsToReplicatePostNotSupportedCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[43], () => { test.Info(PostsCreation.StepsToReplicatePostNotSupportedCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[44], () => { test.Info(PostsCreation.StepsToReplicatePostNotSupportedCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[45], () => { test.Info(PostsCreation.StepsToReplicatePostNotSupportedCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[46], () => { test.Info(PostsCreation.StepsToReplicatePostNotSupportedCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[47], () => { test.Info(PostsCreation.StepsToReplicatePostNotSupportedCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[48], () => { test.Info(PostsCreation.StepsToReplicatePostNotSupportedCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[49], () => { test.Info(PostsCreation.StepsToReplicatePostNotSupportedCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[50], () => { test.Info(PostsCreation.StepsToReplicatePostNotSupportedCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[51], () => { test.Info(PostsCreation.StepsToReplicatePostNotSupportedCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[52], () => { test.Info(PostsCreation.StepsToReplicatePostNotSupportedCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[53], () => { test.Info(PostsCreation.StepsToReplicatePostNotSupportedCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[54], () => { test.Info(PostsCreation.StepsToReplicatePostNotSupportedCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[55], () => { test.Info(PostsCreation.StepsToReplicatePostNotSupportedCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[56], () => { test.Info(PostsCreation.StepsToReplicatePostNotSupportedCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[57], () => { test.Info(PostsCreation.StepsToReplicatePostNotSupportedCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[58], () => { test.Info(PostsCreation.StepsToReplicatePostNotSupportedCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[59], () => { test.Info(PostsCreation.StepsToReplicatePostNotSupportedCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[60], () => { test.Info(PostsCreation.StepsToReplicatePostNotSupportedCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[61], () => { test.Info(PostsCreation.StepsToReplicatePostNotSupportedCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[62], () => { test.Info(PostsCreation.StepsToReplicatePostNotSupportedCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenarios[63], () => { test.Info(PostsCreation.StepsToReplicatePostNotSupportedCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenariosForScheduled[63], () => { test.Info(PostsCreation.StepsToReplicatePostNotSupportedCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenariosForScheduled[63], () => { test.Info(PostsCreation.StepsToReplicatePostNotSupportedCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenariosForScheduled[63], () => { test.Info(PostsCreation.StepsToReplicatePostNotSupportedCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenariosForScheduled[63], () => { test.Info(PostsCreation.StepsToReplicatePostNotSupportedCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenariosForScheduled[63], () => { test.Info(PostsCreation.StepsToReplicatePostNotSupportedCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenariosForScheduled[63], () => { test.Info(PostsCreation.StepsToReplicatePostNotSupportedCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
                { PostsCreation.TestScenariosForScheduled[63], () => { test.Info(PostsCreation.StepsToReplicatePostNotSupportedCebuPampangaAreas + actualResultLabel); return Task.CompletedTask; } },
            };
            if(postCreationScenarios.TryGetValue(testScenariosDescription, out var action))
            {
                action.Invoke();
            }
        }

        public async Task ShouldSuccessNotificationAppear(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            // Create a test instance in ExtentReports
            ExtentReports Extent = GetInstance();
            test = Extent.CreateTest(testScenariosDescription);

            try
            {
                await Page.WaitForTimeoutAsync(2000); // wait for notificaiton to appear
                await PageTest.Expect(LoginPages.SuccessNotification).ToContainTextAsync("Post successfully saved.");
                // Log a pass status with a discription
                test.Pass($"<b>PASSED.</b> Actual Result: Notification display. {LoginPages.GetSuccessMessageNotification} <br>" +
                    $"{EnvironmentVariableManager.GetValue(AddNewPostsPages.ProvincePickupSummary_Label)}, " +
                    $"{EnvironmentVariableManager.GetValue(AddNewPostsPages.VehicleTypeSelectCourier_Label)}, " +
                    $"{EnvironmentVariableManager.GetValue(AddNewPostsPages.CourierNameSummary_Label)}");
            }
            catch (Exception e)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected notificaiton did not match.");
                ex = e;
                StepsToReplicateForReporting(test, testScenariosDescription);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }

        public async Task ShouldInformationMessageDisplay(string testScenariosDescription, string screenShotFolderName, string screenShotFileName)
        {
            // Create a test instance in ExtentReports
            ExtentReports Extent = GetInstance();
            test = Extent.CreateTest(testScenariosDescription);

            try
            {
                await Page.WaitForTimeoutAsync(2000); // wait for notificaiton to appear
                await PageTest.Expect(AddNewPostsPages.HoverCourierMessage_Label).ToContainTextAsync("Vehicle Type is not supported.");
                // Log a pass status with a discription
                test.Pass($"<b>PASSED.</b> Actual Result: {EnvironmentVariableManager.GetValue(AddNewPostsPages.VehicleTypeSelectCourier_Label)}. <br>" +
                     $"{AddNewPostsPages.GetValueOfHoverMessageInCourierPage}");
            }
            catch (Exception e)
            {
                // Log a fail status with the exception message
                test.Fail("<b>FAILED.</b> The expected notificaiton did not match.");
                ex = e;
                StepsToReplicateForReporting(test, testScenariosDescription);
                await TakeAScreenshot($"{screenShotFolderName}", $"{screenShotFileName} - FAILED");
            }
            Extent.Flush();
        }
    }
}

