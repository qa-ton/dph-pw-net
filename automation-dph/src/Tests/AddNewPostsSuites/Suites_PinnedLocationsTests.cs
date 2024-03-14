
using automation_dph.TestScenarios.AddNewPostModule;

namespace automation_dph.src.Tests.AddNewPostsSuites
{
	[TestClass]
	[TestCategory("PINNED LOCATION PAGE TEST SUITES")]
	public class Suites_PinnedLocationsTests : BasePageTest
	{
		[TestMethod]
		[TestCategory("4.21 ONDEMAND PICKUP PIN LOCATIONS")]
		public async Task Test001_SavePinLocations()
		{
            await PinLocations(EnumsPinLocations.SavePinLocation(), "PinnedLocations - Screenshot");
		}

        [TestMethod]
		[TestCategory("4.21 ONDEMAND PICKUP PIN LOCATIONS")]
		public async Task Test002_RemovePinLocations()
		{
            await PinLocations(EnumsPinLocations.RemovePinLocation(), "PinnedLocations - Screenshot");
        }

        [TestMethod]
		[TestCategory("4.21 ONDEMAND PICKUP PIN LOCATIONS")]
		public async Task Test003_EditPinLocations()
		{
            await PinLocations(EnumsPinLocations.EditPinLocation(), "PinnedLocations - Screeshot");
        }

		[TestMethod]
		[TestCategory("4.21 ONDEMAND PICKUP PIN LOCATIONS")]
		public async Task Test004_AutoSuggestLocation()
		{
            await PinLocations(EnumsPinLocations.AutoSuggest(), "PinnedLocations - Screenshot");
        }

		[TestMethod]
		[TestCategory("4.21 ONDEMAND PICKUP PIN LOCATIONS")]
		public async Task Test005_InvalidValueLocations()
		{
            await PinLocations(EnumsPinLocations.InvalidValueLocation(), "PinnedLocations - Screenshot");
        }

		[TestMethod]
		[TestCategory("4.21 ONDEMAND PICKUP PIN LOCATIONS")]
		public async Task Test006_BlankValueLocations()
		{
            await PinLocations(EnumsPinLocations.BlankValueLocation(), "PinnedLocations - Screenshot");
        }

        [TestMethod]
        [TestCategory("4.21 ONDEMAND PICKUP PIN LOCATIONS")]
        public async Task Test007_CloseModal()
        {
            await PinLocations(EnumsPinLocations.CloseModal(), "PinnedLocations - Screenshot");
        }

        [TestMethod]
        [TestCategory("4.21 ONDEMAND PICKUP PIN LOCATIONS")]
        [Ignore]
        public async Task Test008_ClearPinLocation()
        {
            await MyPostsPages.AddNewPosts_Button.ClickAsync();
            await AddNewPostsPages.SelectDeliveryType("Ondemand");
            await AddNewPostsPages.Address_Textbox.FillAsync("Comfac Global Group Technology Center");
            await AddNewPostsPages.Pin_Button.ClickAsync();
            await AddNewPostsPages.SavePin_Button.ClickAsync();
            await AddNewPostsPages.Address_Textbox.ClearAsync();
            await Page.WaitForTimeoutAsync(2000);
            await AddNewPostsAssertions.ShouldDisplayInformationNotification(PinnedLocations.TestScenariosPinnedLocations[7],
                "PinnedLocations: Test Case 4.21.13", "PinnedLocations - Screenshot");
        }

        private async Task PinLocations(IEnumerable<object[]> fieldDetails, string screenShotFolderName)
        {
            foreach (var getData in fieldDetails)
            {
                string deliveryType = (string)getData[0];
                string addressValue = (string)getData[1];
                string testScenariosDescription = (string)getData[2];
                string screenShotFileName = (string)getData[3];

                if (testScenariosDescription.Contains("Save"))
                {
                    if (testScenariosDescription.Contains("pickup"))
                    {
                        await PinningLocation(deliveryType, addressValue);
                    }
                    else
                    {
                        await PinningDeliveryLocation(deliveryType, addressValue);
                    }
                    await AddNewPostsAssertions.ShouldDisplaySuccessNotification(testScenariosDescription, screenShotFileName, screenShotFolderName);
                }
                else if (testScenariosDescription.Contains("Remove"))
                {
                    if (testScenariosDescription.Contains("pickup"))
                    {
                        await PinningLocation(deliveryType, addressValue);
                    }
                    else
                    {
                        await PinningDeliveryLocation(deliveryType, addressValue);
                    }
                    await AddNewPostsPages.RemovePin_Button.ClickAsync();
                    await AddNewPostsAssertions.ShouldNotDisplayPinnedLabel(testScenariosDescription, screenShotFileName, screenShotFolderName);
                }
                else if (testScenariosDescription.Contains("Edit"))
                {
                    string updatedAddressValue = (string)getData[4];

                    if (testScenariosDescription.Contains("pickup"))
                    {
                        await PinningLocation(deliveryType, addressValue);
                        await AddNewPostsPages.Pin_Button.ClickAsync();
                        await AddNewPostsPages.CompleteAddress_Textbox.FillAsync(updatedAddressValue);
                        await AddNewPostsPages.SavePin_Button.ClickAsync();
                    }
                    else
                    {
                        await PinningDeliveryLocation(deliveryType, addressValue);
                        await AddNewPostsPages.Pin_Button.ClickAsync();
                        await AddNewPostsPages.CompleteAddress_Textbox.FillAsync(updatedAddressValue);
                        await AddNewPostsPages.SavePin_Button.ClickAsync();
                    }

                    await AddNewPostsAssertions.ShouldDisplayUpdatedValue(updatedAddressValue, testScenariosDescription, screenShotFileName, screenShotFolderName);
                }
                else if (testScenariosDescription.Contains("Auto"))
                {
                    string updatedAddressValue = (string)getData[4];
                    await MyPostsPages.AddNewPosts_Button.ClickAsync();
                    await AddNewPostsPages.SelectDeliveryType(deliveryType);

                    if (testScenariosDescription.Contains("delivery"))
                    {
                        //await PinningDeliveryLocation(deliveryType, addressValue);
                        await AddNewPostsPages.PickupDetailsAutoFill("refNo");
                    }

                    await AddNewPostsPages.Address_Textbox.FillAsync(addressValue);
                    await AddNewPostsPages.Pin_Button.ClickAsync();
                    await Page.WaitForTimeoutAsync(2000);
                    await AddNewPostsPages.CompleteAddress_Textbox.ClickAsync();
                    await AddNewPostsPages.CompleteAddress_Textbox.FillAsync(updatedAddressValue);
                    await AddNewPostsAssertions.ShouldDisplayAutoSuggestLocation(testScenariosDescription, screenShotFileName, screenShotFolderName);
                }
                else if (testScenariosDescription.Contains("Invalid"))
                {
                    string updatedAddressValue = (string)getData[4];
                    await MyPostsPages.AddNewPosts_Button.ClickAsync();
                    await AddNewPostsPages.SelectDeliveryType(deliveryType);

                    if (testScenariosDescription.Contains("delivery"))
                    {
                        await AddNewPostsPages.PickupDetailsAutoFill("refNo");
                    }
                    await Page.WaitForTimeoutAsync(3000);
                    await AddNewPostsPages.Address_Textbox.FillAsync(addressValue);
                    await AddNewPostsPages.Pin_Button.ClickAsync();
                    await Page.WaitForTimeoutAsync(2000);
                    await AddNewPostsPages.CompleteAddress_Textbox.ClearAsync();
                    await AddNewPostsPages.CompleteAddress_Textbox.FillAsync(updatedAddressValue);
                    await AddNewPostsAssertions.ShouldDisplayErrorLocations(testScenariosDescription, screenShotFileName, screenShotFolderName);
                }
                else if (testScenariosDescription.Contains("Blank"))
                {
                    string updatedAddressValue = (string)getData[4];
                    await MyPostsPages.AddNewPosts_Button.ClickAsync();
                    await AddNewPostsPages.SelectDeliveryType(deliveryType);

                    if (testScenariosDescription.Contains("delivery"))
                    {
                        await AddNewPostsPages.PickupDetailsAutoFill("refNo");
                    }
                    await Page.WaitForTimeoutAsync(3000);
                    await AddNewPostsPages.Address_Textbox.FillAsync(addressValue);
                    await AddNewPostsPages.Pin_Button.ClickAsync();
                    await Page.WaitForTimeoutAsync(2000);
                    await AddNewPostsPages.CompleteAddress_Textbox.ClearAsync();
                    await AddNewPostsPages.CompleteAddress_Textbox.FillAsync(updatedAddressValue);
                    await AddNewPostsAssertions.ShouldDisplayErrorLocations(testScenariosDescription, screenShotFileName, screenShotFolderName);
                }
                else if (testScenariosDescription.Contains("Close"))
                {
                    await MyPostsPages.AddNewPosts_Button.ClickAsync();
                    await AddNewPostsPages.SelectDeliveryType(deliveryType);

                    if (testScenariosDescription.Contains("delivery"))
                    {
                        await AddNewPostsPages.PickupDetailsAutoFill("refNo");
                    }
                    await AddNewPostsPages.Address_Textbox.FillAsync(addressValue);
                    await AddNewPostsPages.Pin_Button.ClickAsync();
                    await AddNewPostsPages.PinLocationClose_Button.First.ClickAsync();
                    await AddNewPostsAssertions.ShouldCloseModalWindow(testScenariosDescription, screenShotFileName, screenShotFolderName);
                }
                await Page.GotoAsync("https://staging.deliveries.ph/");
            }
        }

        private async Task PinningDeliveryLocation(string deliveryType, string addressValue)
        {
            await MyPostsPages.AddNewPosts_Button.ClickAsync();
            await AddNewPostsPages.SelectDeliveryType(deliveryType);
            await AddNewPostsPages.PickupDetailsAutoFill("refNo");
            await AddNewPostsPages.Address_Textbox.FillAsync(addressValue);
            await AddNewPostsPages.Pin_Button.ClickAsync();
            await AddNewPostsPages.SavePin_Button.ClickAsync();
        }

        private async Task PinningLocation(string deliveryType, string addressValue)
        {
            await MyPostsPages.AddNewPosts_Button.ClickAsync();
            await AddNewPostsPages.SelectDeliveryType(deliveryType);
            await AddNewPostsPages.Address_Textbox.FillAsync(addressValue);
            await AddNewPostsPages.Pin_Button.ClickAsync();
            await AddNewPostsPages.SavePin_Button.ClickAsync();
        }


    }
}

