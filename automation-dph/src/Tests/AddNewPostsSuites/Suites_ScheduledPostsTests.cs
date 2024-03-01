
namespace automation_dph.src.Tests.AddNewPostsSuites
{
    [TestClass]
    [TestCategory("POST CREATIONS TEST SUITES")]
    public class Suites_ScheduledPostsTests : BasePageTest
    {
        [TestMethod]
        [TestCategory("TS-4.6 SCHEDULED POSTS ONDEMAND/SCHEDULED")]
        public async Task Test001_ScheduledPostPageForOndemand()
        {
            await CreateAutofillPosts("Ondemand", "referenceNumber");
            await Page.WaitForTimeoutAsync(5000);
            await AddNewPostsAssertions.ShouldDisplayOndemandCourier(AddNewPosts.TestScenariosScheduledPosts[0],
                "ScheduledPost: Test Case 4.6.1", "ScheduledPost - Screenshot");
        }

        [TestMethod]
        [TestCategory("TS-4.6 SCHEDULED POSTS ONDEMAND/SCHEDULED")]
        public async Task Test002_ScheduledPostPageForScheduled()
        {
            await CreateAutofillPosts("Scheduled", "referenceNumber");
            await Page.WaitForTimeoutAsync(5000);
            await AddNewPostsAssertions.ShouldDisplayOndemandCourier(AddNewPosts.TestScenariosScheduledPosts[1],
                "ScheduledPost: Test Case 4.6.2", "ScheduledPost - Screenshot");
        }

        [TestMethod]
        [TestCategory("TS-4.6 SCHEDULED POSTS ONDEMAND/SCHEDULED")]
        public async Task Test003_NoSelectedScheduledDeliveryPost()
        {
            await MyPostsPages.AddNewPosts_Button.ClickAsync();
            await AddNewPostsPages.NextStepSchedulePost_Button.ClickAsync();
            await AddNewPostsAssertions.ShouldDisplayErrorNotification(AddNewPosts.TestScenariosScheduledPosts[2],
                "ScheduledPost: Test Case 4.6.3", "ScheduledPost - Screenshot");
        }

        [TestMethod]
        [TestCategory("TS-4.6 SCHEDULED POSTS ONDEMAND/SCHEDULED")]
        public async Task Test004_ScheduledPostHyperlink()
        {
            await MyPostsPages.AddNewPosts_Button.ClickAsync();
            await AddNewPostsPages.SelectDeliveryType("Ondemand");
            await AddNewPostsPages.ScheduledPost_Link.ClickAsync();
            await AddNewPostsAssertions.ShouldDisplayScheduledPostsPage(AddNewPosts.TestScenariosScheduledPosts[3],
                "ScheduledPost: Test Case 4.6.4", "ScheduledPost - Screenshot");
        }

        private async Task CreateAutofillPosts(string deliveryType, string refNo)
        {
            await MyPostsPages.AddNewPosts_Button.ClickAsync();
            await AddNewPostsPages.SelectDeliveryType(deliveryType);
            await AddNewPostsPages.PickupDetailsAutoFill(refNo);
            await AddNewPostsPages.DeliveryDetailsAutoFill();
        }
    }
}

