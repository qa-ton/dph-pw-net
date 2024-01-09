
namespace automation_dph.src.Tests
{
    // Pre-requisites:
    // must have a post data with a status of IN_TRANSIT_FOR_RETURN

    [TestClass]
    [TestCategory("MY POSTS - MARK AS RETURNED TEST SUITES")]
    public class Suites_MyPostsMarkAsReturnedTests : BasePageTest
	{
        [TestMethod]
        [TestCategory("Mark As Returned")]
        public async Task Test001_StatusDisplay()
        {
            await MyPostsPages.SelectMarkAsReturned();
            await SearchFilterAssertions.ShouldDisplayStatusRecord(
                "1.1 Validate The Status display for Mark as Returned",
                "MarkAsReturned - Screenshot", "MarkAsReturned: Test Case 1.1");
        }

        [TestMethod]
        [TestCategory("Mark As Returned")]
        public async Task Test002_StatusSelectedInDropdown()
        {
            await MyPostsPages.SelectMarkAsReturned();
            await MarkAsReturnedAssertions.ShouldDisplayNumberOfStatusSelected(
                "1.2 Validate Status selected in status dropdown field for Mark as Returned",
                "MarkAsReturned - Screenshot", "MarkAsReturned: Test Case 1.2");
        }

        [TestMethod]
        [TestCategory("Mark As Returned")]
        public async Task Test003_SelectSinglePost()
        {
            await MyPostsPages.SelectMarkAsReturned();
            await MyPostsPages.DashSinglePost_Checkbox.First.ClickAsync();
            await MarkAsReturnedAssertions.ShouldBeSelected(
                "1.3 Validate Single selection post for Mark as Returned",
                "MarkAsReturned - Screenshot", "MarkAsReturned: Test Case 1.3");
        }

        [TestMethod]
        [TestCategory("Mark As Returned")]
        public async Task Test004_SelectMultiplePost()
        {
            await MyPostsPages.SelectMarkAsReturned();
            await MyPostsPages.DashSinglePost_Checkbox.First.ClickAsync();
            await MyPostsPages.DashSinglePost_Checkbox.Nth(1).ClickAsync();
            await MarkAsReturnedAssertions.ShouldContainNumberOfPostSelected(
                "1.4 Validate Multiple selection post for Mark as Returned",
                "MarkAsReturned - Screenshot", "MarkAsReturned: Test Case 1.4");
        }

        [TestMethod]
        [TestCategory("Mark As Returned")]
        public async Task Test005_SelectAllPost()
        {
            await MyPostsPages.SelectMarkAsReturned();
            await MyPostsPages.DashSelecAllPost_Checkbox.ClickAsync();
            await MarkAsReturnedAssertions.ShouldContainNumberOfPostSelected(
                "1.5 Validate Select First 20 selection post for Mark as Returned",
                "MarkAsReturned - Screenshot", "MarkAsReturned: Test Case 1.5");
        }

        [TestMethod]
        [TestCategory("Mark As Returned")]
        public async Task Test006_ReturnedSinglePost()
        {
            await MyPostsPages.SelectMarkAsReturned();
            await MyPostsPages.DashSinglePost_Checkbox.First.ClickAsync();
            await MyPostsPages.MultipleMarkAsReturned_Button.ClickAsync();
            await MyPostsPages.Confirm_Button.ClickAsync();
            await MarkAsReturnedAssertions.ShouldBeSuccessful(
                "1.6 Validate Returned post for single post selected",
                "MarkAsReturned - Screenshot", "MarkAsReturned: Test Case 1.6");
        }

        [TestMethod]
        [TestCategory("Mark As Returned")]
        public async Task Test007_ReturnedMultiplePost()
        {
            await MyPostsPages.SelectMarkAsReturned();
            await MyPostsPages.DashSinglePost_Checkbox.First.ClickAsync();
            await MyPostsPages.DashSinglePost_Checkbox.Nth(1).ClickAsync();
            await MyPostsPages.MultipleMarkAsReturned_Button.ClickAsync();
            await MyPostsPages.Confirm_Button.ClickAsync();
            await MarkAsReturnedAssertions.ShouldBeSuccessful(
                "1.7 Validate Returned for multiple post selected",
                "MarkAsReturned - Screenshot", "MarkAsReturned: Test Case 1.7");
        }

        [TestMethod]
        [TestCategory("Mark As Returned")]
        public async Task Test008_ReturnedSelectAllPost()
        {
            await MyPostsPages.SelectMarkAsReturned();
            await MyPostsPages.DashSelecAllPost_Checkbox.ClickAsync();
            await MyPostsPages.MultipleMarkAsReturned_Button.ClickAsync();
            await MyPostsPages.Confirm_Button.ClickAsync();
            await MarkAsReturnedAssertions.ShouldBeSuccessful(
                "1.8 Validate Mark as Returned for Select First 20",
                "MarkAsReturned - Screenshot", "MarkAsReturned: Test Case 1.8");
        }

        [TestMethod]
        [TestCategory("Mark As Returned")]
        public async Task Test009_NoSelectedPost()
        {
            await MyPostsPages.SelectMarkAsReturned();
            await MyPostsPages.MultipleMarkAsReturned_Button.ClickAsync();
            await MarkAsReturnedAssertions.ShouldBeError(
                "1.9 Validate Mark as Returned for no selected post",
                "MarkAsReturned - Screenshot", "MarkAsReturned: Test Case 1.9");
        }
    }
}

