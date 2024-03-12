
using automation_dph.TestScenarios;

namespace automation_dph.src.Tests.AddNewPostsSuites
{
    [TestClass]
    [TestCategory("ADDITIONAL DETAILS TEST SUITES")]
    public class Suites_AdditionalDetailsTests : BasePageTest
	{
        [TestMethod]
        [TestCategory("4.13 ONDEMAND DELIVERY DETAILS (METAFIELDS)")]
        [Ignore]
        public async Task Test001_AdditionalDetailsPage()
        {
            await PostCreation(EnumsAdditionalDetails.MetafieldPage(), "AdditionalDetails - Screenshot");
        }

        [TestMethod]
        [TestCategory("4.13 ONDEMAND DELIVERY DETAILS (METAFIELDS)")]
        public async Task Test002_AdditionalDetailsPreviousStep()
        {
            await PostCreation(EnumsAdditionalDetails.PreviousStep(), "AdditionalDetails - Screenshot");
        }

        [TestMethod]
        [TestCategory("4.13 ONDEMAND DELIVERY DETAILS (METAFIELDS)")]
        public async Task Test003_NoAdditionalDetailsToDisplay()
        {
            await PostCreation(EnumsAdditionalDetails.NoAdditionalDetailsDisplay(), "AdditionalDetails - Screenshot");
        }

        [TestMethod]
        [TestCategory("4.13 ONDEMAND DELIVERY DETAILS (METAFIELDS)")]
        [Ignore]
        public async Task Test004_AdditionalDetailsHyperlink()
        {
            await PostCreation(EnumsAdditionalDetails.Hyperlink(), "AdditionalDetails - Screenshot");
        }

        [TestMethod]
        [TestCategory("4.13 ONDEMAND DELIVERY DETAILS (METAFIELDS)")]
        public async Task Test005_NoAdditionalDetailsHyperlinkDisplay()
        {
            await PostCreation(EnumsAdditionalDetails.HyperlinkNoDisplay(), "AdditionalDetails - Screenshot");
        }

        private async Task PostCreation(IEnumerable<object[]> additionalDetails, string screenShotFolderName)
        {
            foreach(var getData in additionalDetails)
            {
                string deliveryType = (string)getData[0];
                string courierType = (string)getData[1];
                string testScenariosDescription = (string)getData[2];
                string screenShotFileName = (string)getData[3];

                // Test steps
                await MyPostsPages.AddNewPosts_Button.ClickAsync();
                await AddNewPostsPages.SelectDeliveryType(deliveryType);
                await AddNewPostsPages.PickupDetailsAutoFill("refNo");
                await AddNewPostsPages.DeliveryDetailsAutoFill();
                await AddNewPostsPages.SelectCourier(courierType);

                if (screenShotFileName.Contains("4.13.1") || screenShotFileName.Contains("4.14.1"))
                {
                    await AddNewPostsAssertions.ShouldDisplayAdditionalPage(
                        testScenariosDescription, screenShotFolderName, screenShotFileName);
                }
                else if(screenShotFileName.Contains("4.13.2") || screenShotFileName.Contains("4.14.2"))
                {
                    ILocator labelLocator = (ILocator)getData[4];
                    await AddNewPostsPages.PreviousStepPickupDetails_Button.ClickAsync();
                    await AddNewPostsAssertions.ShouldDisplayPreviousPage(labelLocator,
                        testScenariosDescription, screenShotFolderName, screenShotFileName);
                }

                else if (screenShotFileName.Contains("4.13.3") || screenShotFileName.Contains("4.14.3"))
                {
                    await AddNewPostsAssertions.ShouldDisplaySummaryPage(
                        testScenariosDescription, screenShotFolderName, screenShotFileName);
                }

                else if (screenShotFileName.Contains("4.13.4") || screenShotFileName.Contains("4.14.4"))
                {
                    await Page.WaitForTimeoutAsync(2000);
                    await AddNewPostsPages.NextStepSelectCourier_Button.ClickAsync();
                    await AddNewPostsPages.AdditionalDetails_Link.ClickAsync();
                    await AddNewPostsAssertions.ShouldDisplayAdditionalPage(
                        testScenariosDescription, screenShotFolderName, screenShotFileName);
                }

                else if (screenShotFileName.Contains("4.13.5") || screenShotFileName.Contains("4.14.5"))
                {
                    await Page.WaitForTimeoutAsync(2000);
                    await AddNewPostsPages.NextStepSelectCourier_Button.ClickAsync();
                    await AddNewPostsPages.AdditionalDetails_Link.ClickAsync();
                    await AddNewPostsAssertions.ShouldDisplaySelectedCourier(
                        testScenariosDescription, screenShotFolderName, screenShotFileName);
                }

                await Page.GotoAsync("https://staging.deliveries.ph/");
            }
        }
    }
}

