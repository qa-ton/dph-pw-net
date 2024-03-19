
using automation_dph.TestScenarios.AddNewPostModule;

namespace automation_dph.src.Tests.AddNewPostsSuites
{
    [TestClass]
	[TestCategory("TAGS TEST SUITES")]
	public class Suites_TagsTests : BasePageTest
	{
		[TestMethod]
		[TestCategory("4.29 ONDEMAND PICKUP TAGS")]
		public async Task Test001_AddTags()
		{
			await TagsMethod(EnumsTags.AddTags(), "Tags - Screenshot");
        }

        [TestMethod]
		[TestCategory("4.29 ONDEMAND PICKUP TAGS")]
		public async Task Test002_SelectTags()
		{
            await TagsMethod(EnumsTags.SelectTags(), "Tags - Screenshot");
        }

		[TestMethod]
		[TestCategory("4.29 ONDEMAND PICKUP TAGS")]
		public async Task Test003_SelectMultipleTags()
		{
            foreach (var getData in EnumsTags.SelectMultipleTags())
            {
                string deliveryType = (string)getData[0];
                string addedTagValue = (string)getData[1];
                string testScenariosDescription = (string)getData[2];
                string screenShotFileName = (string)getData[3];

                await MyPostsPages.AddNewPosts_Button.ClickAsync();
                await AddNewPostsPages.SelectDeliveryType(deliveryType);

                if (testScenariosDescription.Contains("Delivery"))
                {
                    await AddNewPostsPages.PickupDetailsAutoFill("refno");
                }
                await AddNewPostsPages.Tags_Dropdown.ClickAsync();
                await Page.GetByText("RTS", new() { Exact = true }).ClickAsync();
                await Page.Locator(".css-1wy0on6 > div:nth-child(3)").ClickAsync();
                await Page.GetByText("API", new() { Exact = true }).ClickAsync();
                await AddNewPostsAssertions.ShouldDisplaySelectedValue(addedTagValue, testScenariosDescription,
                    "Tags - Screenshot", screenShotFileName);
                await Page.GotoAsync("https://staging.deliveries.ph/");
            }
        }

		[TestMethod]
		[TestCategory("4.29 ONDEMAND PICKUP TAGS")]
		public async Task Test004_ListOfTags()
		{
            await TagsMethod(EnumsTags.ListOfTags(), "Tags - Screenshot");
        }

		[TestMethod]
		[TestCategory("4.29 ONDEMAND PICKUP TAGS")]
		public async Task Test005_BlankValue()
		{
            await TagsMethod(EnumsTags.BlankValue(), "Tags - Screenshot");
        }

		[TestMethod]
		[TestCategory("4.29 ONDEMAND PICKUP TAGS")]
		public async Task Test006_MaxLengthValue()
		{
            await TagsMethod(EnumsTags.MaxLengthValue(), "Tags - Screenshot");
        }

		[TestMethod]
		[TestCategory("4.29 ONDEMAND PICKUP TAGS")]
		public async Task Test007_DisplayInputtedValue()
		{
            await MyPostsPages.AddNewPosts_Button.ClickAsync();
            await AddNewPostsPages.SelectDeliveryType("Ondemand");
			await AddNewPostsPages.ReferenceNumber_Textbox.FillAsync("refno");
            await AddNewPostsPages.UseLastProfilePickup_Button.ClickAsync();
            await AddNewPostsPages.Tags_Dropdown.ClickAsync();
            await Page.GetByText("Encoded", new() { Exact = true }).ClickAsync();
			await AddNewPostsPages.NextStepPickupDelivery_Button.ClickAsync();
			await AddNewPostsPages.DeliveryDetailsAutoFill();
			await AddNewPostsPages.SelectCourier("Lalamove");
			await AddNewPostsPages.FillOutMetafields("Lalamove");
            await AddNewPostsAssertions.ShouldDisplayBasedOnInputtedValue(AddNewPostsPages.SummaryPickupTags_Label, "Encoded",
                    Tags.TestScenariosPinnedLocations[6], "Tags: Test Case 4.29.9", "Tags - Screenshot");
        }

        [TestMethod]
        [TestCategory("4.29 ONDEMAND PICKUP TAGS")]
        public async Task Test008_InvalidValue()
        {
            await TagsMethod(EnumsTags.InvalidValue(), "Tags - Screenshot");
        }

        private async Task TagsMethod(IEnumerable<object[]> dataDetails, string screenShotFolderName)
        {
            foreach (var getData in dataDetails)
            {
                string deliveryType = (string)getData[0];
                string addedTagValue = (string)getData[1];
                string testScenariosDescription = (string)getData[2];
                string screenShotFileName = (string)getData[3];


                await MyPostsPages.AddNewPosts_Button.ClickAsync();
                await AddNewPostsPages.SelectDeliveryType(deliveryType);

                if (testScenariosDescription.Contains("Add"))
                {
                    ILocator tagDropdown = (ILocator)getData[4];
                    if (testScenariosDescription.Contains("Pickup"))
                    {
                        await AddTags(tagDropdown, addedTagValue);
                        await AddNewPostsAssertions.ShouldDisplayTagsOnTheList(addedTagValue, testScenariosDescription,
                            screenShotFolderName, screenShotFileName);
                    }
                    else if (testScenariosDescription.Contains("Delivery"))
                    {
                        await AddNewPostsPages.PickupDetailsAutoFill("refno");
                        await AddTags(tagDropdown, addedTagValue);
                        await AddNewPostsAssertions.ShouldDisplayTagsOnTheList(addedTagValue, testScenariosDescription,
                            screenShotFolderName, screenShotFileName);
                    }
                }
                else if (testScenariosDescription.Contains("Select"))
                {
                    if(testScenariosDescription.Contains("Delivery"))
                    {
                        await AddNewPostsPages.PickupDetailsAutoFill("refno");
                    }
                    await AddNewPostsPages.Tags_Dropdown.ClickAsync();
                    await Page.GetByText(addedTagValue, new() { Exact = true }).ClickAsync();
                    await AddNewPostsAssertions.ShouldDisplaySelectedValue(addedTagValue, testScenariosDescription,
                        screenShotFolderName, screenShotFileName);
                }
                else if (testScenariosDescription.Contains("List"))
                {
                    if (testScenariosDescription.Contains("Delivery"))
                    {
                        await AddNewPostsPages.PickupDetailsAutoFill(addedTagValue);
                    }
                    await AddNewPostsPages.Tags_Dropdown.ClickAsync();
                    await AddNewPostsAssertions.ShouldDisplayListOfTags(testScenariosDescription, screenShotFolderName, screenShotFileName);
                }
                else if (testScenariosDescription.Contains("Blank") || testScenariosDescription.Contains("Max"))
                {
                    if (testScenariosDescription.Contains("Delivery"))
                    {
                        await AddNewPostsPages.PickupDetailsAutoFill("refNo");
                        await Page.Locator("#react-select-3-input").FillAsync(addedTagValue);
                    }
                    else if (testScenariosDescription.Contains("Pickup"))
                    {
                        await Page.Locator("#react-select-2-input").FillAsync(addedTagValue);
                    }

                    //await Page.Locator("div").Filter(new() { HasTextRegex = new Regex("^Type and enter to add new tag$") }).Nth(2).ClickAsync();
                    await AddNewPostsAssertions.ShouldNotAbleToInputValue(testScenariosDescription, screenShotFolderName, screenShotFileName);
                }
                else if (testScenariosDescription.Contains("Invalid"))
                {
                    ILocator tagDropdown = (ILocator)getData[4];
                    if (testScenariosDescription.Contains("Pickup"))
                    {
                        await AddTags(tagDropdown, addedTagValue);
                    }
                    else if (testScenariosDescription.Contains("Delivery"))
                    {
                        await AddNewPostsPages.PickupDetailsAutoFill("refno");
                        await AddTags(tagDropdown, addedTagValue);
                    }
                    await AddNewPostsAssertions.ShouldDisplayTagsOnTheList(addedTagValue, testScenariosDescription, screenShotFolderName, screenShotFileName);
                }

                await Page.GotoAsync("https://staging.deliveries.ph/");
            }
        }

        private async Task AddTags(ILocator tagDropdown, string addedTagValue)
        {
            await tagDropdown.FillAsync(addedTagValue);
            await Page.Keyboard.PressAsync("Enter");
            await Page.Locator(".creatable-tags__multi-value__remove").First.ClickAsync(); // x close button tag element
            await Page.Locator("div").Filter(new() { HasTextRegex = new Regex("^Type and enter to add new tag$") }).First.ClickAsync();
        }

    }
}

