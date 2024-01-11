
namespace automation_dph.src.Tests
{
    [TestClass]
    [TestCategory("MY POSTS - PRINT WAYBILL TEST SUITES")]
    public class Suites_MyPostsPrintWaybillTests : BasePageTest
	{
        [TestMethod]
        [TestCategory("Default Waybill")]
        public async Task Test001_DashboardDefaultWaybill()
        {
            await DashboardPrintWaybillButton(EnumsPrintWaybill.DashboardPrintButton(), "DefaultWaybill - Screenshot");
        }

        private async Task DashboardPrintWaybillButton(IEnumerable<object[]> buttonPrintWaybill, string screenShotFolderName)
        {
            foreach (var itemData in buttonPrintWaybill)
            {
                string status = (string)itemData[0];
                string testScenariosDescription = (string)itemData[1];
                string screenShotFileName = (string)itemData[2];

                await MyPostsPages.ChangeFilterByStatus(status);
                await MyPostsPages.DashboardLatesPost_Button.First.ClickAsync();
                await PrintWaybillAssertions.ShouldBeVisible(testScenariosDescription, screenShotFolderName, screenShotFileName);
                await MyPostsPages.RefreshBrowser();
            }
        }

        [TestMethod]
        [TestCategory("Default Waybill")]
        public async Task Test002_MultipleWaybillSelectedStatus()
        {
            await MyPostsPages.SelectMultiplePrintDefaultWaybill();
            await PrintWaybillAssertions.ShouldBeStatusSelected(
                PrintWaybill.TestScenarios[3], "DefaultWaybill - Screenshot", "DefaultWaybill: Test Case 1.4");
        }

        [TestMethod]
        [TestCategory("Default Waybill")]
        public async Task Test003_SingleSelectionMultipleWaybill()
        {
            await MyPostsPages.SelectMultiplePrintDefaultWaybill();
            await MyPostsPages.DashSinglePost_Checkbox.First.ClickAsync();
            await PrintWaybillAssertions.ShouldBeSelected(
                PrintWaybill.TestScenarios[4], "DefaultWaybill - Screenshot", "DefaultWaybill: Test Case 1.5");
        }

        [TestMethod]
        [TestCategory("Default Waybill")]
        public async Task Test004_SelectSinglePostMultipleWaybill()
        {
            await MyPostsPages.SelectMultiplePrintDefaultWaybill();
            await MyPostsPages.DashSinglePost_Checkbox.Nth(0).ClickAsync();
            await PrintWaybillAssertions.ShouldBeVisibleMultiplePrintButton(
                PrintWaybill.TestScenarios[5], "DefaultWaybill - Screenshot", "DefaultWaybill: Test Case 1.7");
        }

        [TestMethod]
        [TestCategory("Default Waybill")]
        public async Task Test005_NoSelectedPost()
        {
            await MyPostsPages.SelectMultiplePrintDefaultWaybill();
            await MyPostsPages.MultiplePrintDefaultWaybill_Button.ClickAsync();
            await PrintWaybillAssertions.ShouldBeErrorNotification(
                PrintWaybill.TestScenarios[5], "DefaultWaybill - Screenshot", "DefaultWaybill: Test Case 1.10");
        }

        [TestMethod]
        [TestCategory("Default Waybill")]
        public async Task Test006_DefaultWaybillPostsStatus()
        {
            await PostsStatusDefaultWaybill(EnumsPrintWaybill.PostsStatusDefaultWaybill(), "DefaultWaybill - Screenshot");
        }

        private async Task PostsStatusDefaultWaybill(IEnumerable<object[]> statusWaybill, string screenShotFolderName)
        {
            foreach (var itemData in statusWaybill)
            {
                string status = (string)itemData[0];
                string testScenariosDescription = (string)itemData[1];
                string screenShotFileName = (string)itemData[2];

                await MyPostsPages.ChangeFilterByStatus(status);
                await MyPostsPages.DashboardLatesPost_Button.First.ClickAsync();
                await PrintWaybillAssertions.ShouldNotVisible(testScenariosDescription, screenShotFolderName, screenShotFileName);
                await MyPostsPages.RefreshBrowser();
            }
        }

        [TestMethod]
        [TestCategory("Provider Waybill")]
        public async Task Test007_DashboardProviderWaybill()
        {
            await DashboardPrintProviderWaybillButton(EnumsPrintWaybill.DashboardProvidertWaybillButton(), "DefaultWaybill - Screenshot");
        }

        private async Task DashboardPrintProviderWaybillButton(IEnumerable<object[]> providerWaybill, string screenShotFolderName)
        {
            foreach (var itemData in providerWaybill)
            {
                string status = (string)itemData[0];
                string courier = (string)itemData[1];
                string testScenariosDescription = (string)itemData[2];
                string screenShotFileName = (string)itemData[3];

                await MyPostsPages.ChangeFilterByStatus(status);
                await MyPostsPages.ChangeFilterByPartner(courier);
                await MyPostsPages.DashboardLatesPost_Button.First.ClickAsync();
                await MyPostsPages.DashPrintWaybill_Button.First.ClickAsync();
                await PrintWaybillAssertions.ShouldBeProviderWaybillVisible(testScenariosDescription, screenShotFolderName, screenShotFileName);
                await MyPostsPages.RefreshBrowser();
            }
        }

        [TestMethod]
        [TestCategory("Provider Waybill")]
        public async Task Test008_MultipleProviderWaybillForSingleSelectPosts()
        {
            await MyPostsPages.SelectMultipleProviderDefaultWaybill();
            await MyPostsPages.ChangeFilterByPartner(MyPostsElementNameList.PreferredPartner.ENTREGO_GLOBE);
            await MyPostsPages.DashSinglePost_Checkbox.First.ClickAsync();
            await PrintWaybillAssertions.ShouldBeSelected(
                PrintWaybill.TestScenarios[19], "DefaultWaybill - Screenshot", "DefaultWaybill: Test Case 2.9");
        }

        [TestMethod]
        [TestCategory("Provider Waybill")]
        public async Task Test009_NoAvailableProviderWaybill()
        {
            await MyPostsPages.SelectMultipleProviderDefaultWaybill();
            await MyPostsPages.ChangeFilterByPartner(MyPostsElementNameList.PreferredPartner.SANDBOX_DX);
            await MyPostsPages.DashSinglePost_Checkbox.Nth(3).ClickAsync();
            await PrintWaybillAssertions.ShouldBeDisabled(
                PrintWaybill.TestScenarios[20], "DefaultWaybill - Screenshot", "DefaultWaybill: Test Case 2.14");
        }

        [TestMethod]
        [TestCategory("Provider Waybill")]
        public async Task Test010_NoSelectedPostProviderWaybill()
        {
            await MyPostsPages.SelectMultipleProviderDefaultWaybill();
            await MyPostsPages.ChangeFilterByPartner(MyPostsElementNameList.PreferredPartner.ENTREGO_GLOBE);
            await MyPostsPages.MultiplePrintProviderWaybill.ClickAsync();
            await PrintWaybillAssertions.ShouldBeErrorNotification(
                PrintWaybill.TestScenarios[21], "DefaultWaybill - Screenshot", "DefaultWaybill: Test Case 2.15");
        }

        [TestMethod]
        [TestCategory("Provider Waybill")]
        public async Task Test011_CloseMultiplePrintWaybill()
        {
            await MyPostsPages.SelectMultipleProviderDefaultWaybill();
            await MyPostsPages.CloseMultiplePrintDefaultWaybill_Button.ClickAsync();
            await PrintWaybillAssertions.ShouldNotVisibleMultipleProviderWaybillButton(
                PrintWaybill.TestScenarios[22], "DefaultWaybill - Screenshot", "DefaultWaybill: Test Case 2.17");
        }

        [TestMethod]
        [TestCategory("Provider Waybill Modal")]
        public async Task Test012_GenerateProviderWaybill()
        {
            await GenerateProviderWaybill(EnumsPrintWaybill.GeneratedWaybill(), "DefaultWaybill - Screenshot");
        }

        private async Task GenerateProviderWaybill(IEnumerable<object[]> generatedWaybill, string screenShotFolderName)
        {
            foreach (var itemData in generatedWaybill)
            {
                string status = (string)itemData[0];
                string courier = (string)itemData[1];
                string testScenariosDescription = (string)itemData[2];
                string screenShotFileName = (string)itemData[3];

                await MyPostsPages.ChangeFilterByStatus(status);
                await MyPostsPages.ChangeFilterByPartner(courier);
                await MyPostsPages.DashboardLatesPost_Button.First.ClickAsync();
                await MyPostsPages.DashPrintWaybill_Button.ClickAsync();
                await MyPostsPages.OptProviderWaybillDash_Button.ClickAsync();
                await Page.WaitForTimeoutAsync(3000); // wait for the canvas to load that takes 5 sec to generate
                await PrintWaybillAssertions.ShouldVisibleGeneratedWaybill(testScenariosDescription, screenShotFolderName, screenShotFileName);
                await MyPostsPages.RefreshBrowser();
            }
        }

        [TestMethod]
        [TestCategory("Provider Waybill Modal")]
        public async Task Test013_MultipleGeneratedWaybill()
        {
            await GenerateMultipleProviderWaybill(EnumsPrintWaybill.GeneratedMultipleWaybill(), "DefaultWaybill - Screenshot");
        }

        private async Task GenerateMultipleProviderWaybill(IEnumerable<object[]> generatedMultipleWaybill, string screenShotFolderName)
        {
            foreach (var itemData in generatedMultipleWaybill)
            {
                string courier = (string)itemData[0];
                string testScenariosDescription = (string)itemData[1];
                string screenShotFileName = (string)itemData[2];

                await MyPostsPages.SelectMultipleProviderDefaultWaybill();
                await MyPostsPages.ChangeFilterByPartner(courier);
                await MyPostsPages.DashSinglePost_Checkbox.First.ClickAsync();
                await MyPostsPages.DashSinglePost_Checkbox.Nth(1).ClickAsync();
                await MyPostsPages.MultiplePrintDefaultWaybill_Button.ClickAsync();
                await MyPostsPages.Confirm_Button.First.ClickAsync();
                await PrintWaybillAssertions.ShouldGenerateMultipleWaybill(testScenariosDescription, screenShotFolderName, screenShotFileName);
                await MyPostsPages.RefreshBrowser();
            }
        }

        [TestMethod]
        [TestCategory("Provider Waybill Modal")]
        public async Task Test014_NumberPaginationMultipleWaybill()
        {
            await MyPostsPages.SelectMultipleProviderDefaultWaybill();
            await MyPostsPages.ChangeFilterByPartner(MyPostsElementNameList.PreferredPartner.ENTREGO_GLOBE);
            await MyPostsPages.DashSinglePost_Checkbox.First.ClickAsync();
            await MyPostsPages.DashSinglePost_Checkbox.Nth(1).ClickAsync();
            await MyPostsPages.MultiplePrintDefaultWaybill_Button.ClickAsync();
            await MyPostsPages.Confirm_Button.First.ClickAsync();
            await MyPostsPages.WaybillNumberTwoPagination_Link.ClickAsync();
            await PrintWaybillAssertions.ShouldVisibleGeneratedWaybill(
                PrintWaybill.TestScenarios[33], "DefaultWaybill - Screenshot", "DefaultWaybill: Test Case 3.15");
        }

        [TestMethod]
        [TestCategory("Provider Waybill Modal")]
        public async Task Test015_NextPaginationMultipleWaybill()
        {
            await MyPostsPages.SelectMultipleProviderDefaultWaybill();
            await MyPostsPages.ChangeFilterByPartner(MyPostsElementNameList.PreferredPartner.ENTREGO_GLOBE);
            await MyPostsPages.DashSinglePost_Checkbox.First.ClickAsync();
            await MyPostsPages.DashSinglePost_Checkbox.Nth(1).ClickAsync();
            await MyPostsPages.MultiplePrintDefaultWaybill_Button.ClickAsync();
            await MyPostsPages.Confirm_Button.First.ClickAsync();
            await MyPostsPages.WaybillNextPagination_Link.ClickAsync();
            await PrintWaybillAssertions.ShouldVisibleGeneratedWaybill(
                PrintWaybill.TestScenarios[34], "DefaultWaybill - Screenshot", "DefaultWaybill: Test Case 3.16");
        }

        [TestMethod]
        [TestCategory("Provider Waybill Modal")]
        public async Task Test016_PreviousPaginationMultipleWaybill()
        {
            await MyPostsPages.SelectMultipleProviderDefaultWaybill();
            await MyPostsPages.ChangeFilterByPartner(MyPostsElementNameList.PreferredPartner.ENTREGO_GLOBE);
            await MyPostsPages.DashSinglePost_Checkbox.First.ClickAsync();
            await MyPostsPages.DashSinglePost_Checkbox.Nth(1).ClickAsync();
            await MyPostsPages.MultiplePrintDefaultWaybill_Button.ClickAsync();
            await MyPostsPages.Confirm_Button.First.ClickAsync();
            await MyPostsPages.WaybillNextPagination_Link.ClickAsync();
            await MyPostsPages.WaybillPreviousPagination_Link.ClickAsync();
            await PrintWaybillAssertions.ShouldVisibleGeneratedWaybill(
                PrintWaybill.TestScenarios[35], "DefaultWaybill - Screenshot", "DefaultWaybill: Test Case 3.17");
        }
    }
}

