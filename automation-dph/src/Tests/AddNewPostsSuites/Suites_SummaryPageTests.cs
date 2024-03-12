
using automation_dph.TestScenarios.AddNewPostModule;

namespace automation_dph.src.Tests.AddNewPostsSuites
{
	[TestClass]
	[TestCategory("SUMMARY PAGE TEST SUITES")]
	public class Suites_SummaryPageTests : BasePageTest
	{
		[TestMethod]
		[TestCategory("4.15 ONDEMAND SUMMARY DETAILS")]
		public async Task Test001_VerifyOndemandInputtedValue()
		{
			await PostCreation(EnumsSummaryPage.OndemandInputtedValue(), "SummaryPage - Screenshot");
		}

        [TestMethod]
        [TestCategory("4.15 ONDEMAND SUMMARY DETAILS")]
        public async Task Test002_VerifyCourierPostType()
        {
            await StepsForPickupDetails("Ondemand");
            //await AddNewPostsPages.NextStepPickupDelivery_Button.ClickAsync();
            await StepsForDeliveryDetailsToSummaryPage("Lalamove");
            await AddNewPostsAssertions.ShouldDisplayBasedOnInputtedValue(AddNewPostsPages.SummaryCourierDeliveryType_Label, "On Demand",
                SummaryPage.TestScenariosSummaryPage[27], "SummaryPage - Screenshot", "AdditionalDetails: Test Case 4.15.33");
        }

        [TestMethod]
        [TestCategory("4.16 SCHEDULED SUMMARY DETAILS")]
        public async Task Test003_VerifyScheduledInputtedValue()
        {
            await PostCreation(EnumsSummaryPage.ScheduledInputtedValue(), "SummaryPage - Screenshot");
        }

        [TestMethod]
        [TestCategory("4.16 SCHEDULED SUMMARY DETAILS")]
        public async Task Test004_VerifyCourierPostType()
        {
            await StepsForPickupDetails("Scheduled");
            //await AddNewPostsPages.NextStepPickupDelivery_Button.ClickAsync();
            await StepsForDeliveryDetailsToSummaryPage(MyPostsElementNameList.PreferredPartner.PRIME_MOVERS);
            await AddNewPostsAssertions.ShouldDisplayBasedOnInputtedValue(AddNewPostsPages.SummaryCourierDeliveryType_Label, "Scheduled",
                SummaryPage.TestScenariosSummaryPage[55], "SummaryPage - Screenshot", "AdditionalDetails: Test Case 4.16.33");
        }

        private async Task PostCreation(IEnumerable<object[]> dataDetails, string screenShotFolderName)
        {
            foreach(var getData in dataDetails)
			{
                string deliveryType = (string)getData[0];
                string courierType = (string)getData[1];
				string testScenariosDescription = (string)getData[2];
                string screenShotFileName = (string)getData[3];
                string stringPath = (string)getData[4];
                ILocator locatorPath = (ILocator)getData[5];

                await StepsForPickupDetails(deliveryType);

                if (testScenariosDescription.Contains("Pickup"))
                {
                    //await StepsForPickupDetails(deliveryType);

                    if (screenShotFileName.Contains("4.15.6") || screenShotFileName.Contains("4.15.7") || screenShotFileName.Contains("4.15.8") ||
                        screenShotFileName.Contains("4.16.6") || screenShotFileName.Contains("4.16.7") || screenShotFileName.Contains("4.16.8"))
                    {
                        ILocator dropdownElement = Page.Locator(stringPath);
                        string? getDropdownValue = dropdownElement.InnerTextAsync().GetAwaiter().GetResult();

                        await StepsForDeliveryDetailsToSummaryPage(courierType);
                        await AddNewPostsAssertions.ShouldDisplayBasedOnInputtedValue(locatorPath, getDropdownValue,
                                testScenariosDescription, screenShotFolderName, screenShotFileName);
                    }
                    else if (screenShotFileName.Contains("4.15.10") || screenShotFileName.Contains("4.16.10"))
                    {
                        ILocator dropdownElement = Page.Locator(stringPath);
                        string? getDropdownValue = await dropdownElement.First.TextContentAsync();

                        await StepsForDeliveryDetailsToSummaryPage(courierType);
                        await AddNewPostsAssertions.ShouldDisplayBasedOnInputtedValue(locatorPath, getDropdownValue,
                                testScenariosDescription, screenShotFolderName, screenShotFileName);
                    }
                    else
                    {
                        //get value of element field
                        var setValue = await Page.QuerySelectorAsync(stringPath);
                        string? getValue = await setValue.GetAttributeAsync("value");

                        await StepsForDeliveryDetailsToSummaryPage(courierType);
                        await AddNewPostsAssertions.ShouldDisplayBasedOnInputtedValue(locatorPath, getValue,
                                testScenariosDescription, screenShotFolderName, screenShotFileName);
                    }
                }
                else if(testScenariosDescription.Contains("Delivery"))
                {
                    if(screenShotFileName.Contains("4.15.16") || screenShotFileName.Contains("4.15.17") || screenShotFileName.Contains("4.15.18"))
                    {
                        await AddNewPostsPages.NextStepPickupDelivery_Button.ClickAsync();
                        await AddNewPostsPages.DeliveryDetailsAutoFillWithOutClickingNextStep();

                        //get value of element field
                        ILocator dropdownElement = Page.Locator(stringPath);
                        string? getDropdownValue = dropdownElement.InnerTextAsync().GetAwaiter().GetResult();

                        await AddNewPostsPages.NextStepPickupDelivery_Button.ClickAsync();
                        await AddNewPostsPages.SelectCourier(courierType);
                        await AddNewPostsPages.FillOutMetafields(courierType);
                        await AddNewPostsAssertions.ShouldDisplayBasedOnInputtedValue(locatorPath, getDropdownValue,
                                testScenariosDescription, screenShotFolderName, screenShotFileName);
                    }
                    else if (screenShotFileName.Contains("4.15.29") || screenShotFileName.Contains("4.15.30"))
                    {
                        await AddNewPostsPages.NextStepPickupDelivery_Button.ClickAsync();
                        await AddNewPostsPages.DeliveryDetailsAutoFillWithOutClickingNextStep();

                        //get value of element field
                        ILocator dropdownElement = Page.Locator(stringPath);
                        string? getDropdownValue = await dropdownElement.First.TextContentAsync();

                        await AddNewPostsPages.NextStepPickupDelivery_Button.ClickAsync();
                        await AddNewPostsPages.SelectCourier(courierType);
                        await AddNewPostsPages.FillOutMetafields(courierType);
                        await AddNewPostsAssertions.ShouldDisplayBasedOnInputtedValue(locatorPath, getDropdownValue,
                                testScenariosDescription, screenShotFolderName, screenShotFileName);
                    }
                    else
                    {
                        await AddNewPostsPages.NextStepPickupDelivery_Button.ClickAsync();
                        await AddNewPostsPages.DeliveryDetailsAutoFillWithOutClickingNextStep();

                        //get value of element field
                        var setValue = await Page.QuerySelectorAsync(stringPath);
                        string? getValue = await setValue.GetAttributeAsync("value");

                        await AddNewPostsPages.NextStepPickupDelivery_Button.ClickAsync();
                        await AddNewPostsPages.SelectCourier(courierType);
                        await AddNewPostsPages.FillOutMetafields(courierType);
                        await AddNewPostsAssertions.ShouldDisplayBasedOnInputtedValue(locatorPath, getValue,
                                testScenariosDescription, screenShotFolderName, screenShotFileName);
                    }

                }
                else
                {
                    await AddNewPostsPages.NextStepPickupDelivery_Button.ClickAsync();
                    await StepsForDeliveryDetailsToSummaryPage(courierType);
                    await AddNewPostsAssertions.ShouldDisplayBasedOnInputtedValue(locatorPath, courierType,
                            testScenariosDescription, screenShotFolderName, screenShotFileName);
                }


                await Page.GotoAsync("https://staging.deliveries.ph/");
            }
        }

        private async Task StepsForDeliveryDetailsToSummaryPage(string courierType)
        {
            await AddNewPostsPages.NextStepPickupDelivery_Button.ClickAsync();
            await AddNewPostsPages.DeliveryDetailsAutoFill();
            await AddNewPostsPages.SelectCourier(courierType);
            await AddNewPostsPages.FillOutMetafields(courierType);
        }

        private async Task StepsForPickupDetails(string deliveryType)
        {
            await MyPostsPages.AddNewPosts_Button.ClickAsync();
            await AddNewPostsPages.SelectDeliveryType(deliveryType);
            await AddNewPostsPages.PickupDetailsAutoFillWithOutClickingNextStep("refNo");
        }
    }
}

