
namespace automation_dph.src.Tests
{
    [TestClass]
    [TestCategory("MY POSTS PAGINATION TEST SUITES")]
    public class Suites_MyPostsPaginationTests : BasePageTest
    {
        [TestMethod]
        [TestCategory("My Posts Pagination")]
        public async Task Test001_DefaultNumberPostsDisplay()
        {
            await MyPostsPages.PaginationPostsNumberDisplay_Label.ClickAsync();
            await PaginationAssertions.ShouldDisplayNumberOfPosts(
                MyPostsPagination.TestScenarios[0], "Pagination - Screenshot", "Pagination: Test Case 1.1");
        }

        [TestMethod]
        [TestCategory("My Posts Pagination")]
        public async Task Test002_TotalNumberPostsDisplayForNextPage()
        {
            await MyPostsPages.NextPageIcon_Button.ClickAsync();
            await PaginationAssertions.ShouldDisplayNumberOfPosts(
                MyPostsPagination.TestScenarios[1], "Pagination - Screenshot", "Pagination: Test Case 1.2");
        }

        [TestMethod]
        [TestCategory("My Posts Pagination")]
        public async Task Test003_TotalNumberPostsDisplayForPreviousPage()
        {
            await MyPostsPages.NextPageIcon_Button.ClickAsync();
            await MyPostsPages.PreviousPageIcon_Button.ClickAsync();
            await PaginationAssertions.ShouldDisplayNumberOfPosts(
                MyPostsPagination.TestScenarios[2], "Pagination - Screenshot", "Pagination: Test Case 1.3");
        }

        [TestMethod]
        [TestCategory("My Posts Pagination")]
        public async Task Test004_DisabledLeftPagination()
        {
            await PaginationAssertions.ShouldBeDisable(
                MyPostsPagination.TestScenarios[3], "Pagination - Screenshot", "Pagination: Test Case 1.6");
        }

        [TestMethod]
        [TestCategory("My Posts Pagination")]
        public async Task Test005_NextPaginationNumberCount()
        {
            await MyPostsPages.NextPageIcon_Button.ClickAsync();
            await PaginationAssertions.ShouldDisplayMoreThanTheFirstCount(
                MyPostsPagination.TestScenarios[4], "Pagination - Screenshot", "Pagination: Test Case 1.8");
        }

        [TestMethod]
        [TestCategory("My Posts Pagination")]
        public async Task Test006_PreviousPaginationNumberCount()
        {
            await MyPostsPages.NextPageIcon_Button.ClickAsync();
            await MyPostsPages.PreviousPageIcon_Button.ClickAsync();
            await PaginationAssertions.ShouldDisplayTheFirstCount(
                MyPostsPagination.TestScenarios[5], "Pagination - Screenshot", "Pagination: Test Case 1.9");
        }

        [TestMethod]
        [TestCategory("My Posts Pagination")]
        public async Task Test007_NoResultPostDisplay()
        {
            await MyPostsPages.ChangeFilterByHubs(MyPostsElementNameList.Hubs.GRACEL);
            await PaginationAssertions.ShouldDisplayNoResult(
                MyPostsPagination.TestScenarios[6], "Pagination - Screenshot", "Pagination: Test Case 1.10");
        }

        [TestMethod]
        [TestCategory("My Posts Pagination")]
        public async Task Test008_SearchPostsPagination()
        {
            await MyPostsPages.ChangeFilterBySearch(MyPostsElementNameList.SearchType.REFERENCE_NUMBER);
            await MyPostsPages.InputSearchValue("test813");
            if (await MyPostsPages.NextPageIcon_Button.IsDisabledAsync())
            {
                await PaginationAssertions.ShouldBeDisableRightPagination(
                "Assert 2: " + MyPostsPagination.TestScenarios[7], "Pagination - Screenshot", "Pagination: Test Case 1.11");
            }
            else
            {
                await PaginationAssertions.ShouldDisplayNumberOfPosts(
                "Assert 1: " + MyPostsPagination.TestScenarios[7], "Pagination - Screenshot", "Pagination: Test Case 1.11");

            }
        }

        [TestMethod]
        [TestCategory("My Posts Pagination")]
        public async Task Test009_FilterHubsPagination()
        {
            await MyPostsPages.ChangeFilterByHubs(MyPostsElementNameList.Hubs.QA_STORE);
            if (await MyPostsPages.NextPageIcon_Button.IsDisabledAsync())
            {
                await PaginationAssertions.ShouldBeDisableRightPagination(
                "Assert 2: " + MyPostsPagination.TestScenarios[8], "Pagination - Screenshot", "Pagination: Test Case 1.12");
            }
            else
            {
                await PaginationAssertions.ShouldDisplayNumberOfPosts(
                "Assert 1: " + MyPostsPagination.TestScenarios[8], "Pagination - Screenshot", "Pagination: Test Case 1.12");

            }
        }

        [TestMethod]
        [TestCategory("My Posts Pagination")]
        public async Task Test010_FilterStatusPagination()
        {
            await MyPostsPages.ChangeFilterByStatus(MyPostsElementNameList.Status.ACCEPTED);
            if (await MyPostsPages.NextPageIcon_Button.IsDisabledAsync())
            {
                await PaginationAssertions.ShouldBeDisableRightPagination(
                "Assert 2: " + MyPostsPagination.TestScenarios[9], "Pagination - Screenshot", "Pagination: Test Case 1.13");
            }
            else
            {
                await PaginationAssertions.ShouldDisplayNumberOfPosts(
                "Assert 1: " + MyPostsPagination.TestScenarios[9], "Pagination - Screenshot", "Pagination: Test Case 1.13");

            }
        }

        [TestMethod]
        [TestCategory("My Posts Pagination")]
        public async Task Test011_FilterPreferrredPartnerPagination()
        {
            await MyPostsPages.ChangeFilterByPartner(MyPostsElementNameList.PreferredPartner.MRSPEEDY);
            if (await MyPostsPages.NextPageIcon_Button.IsDisabledAsync())
            {
                await PaginationAssertions.ShouldBeDisableRightPagination(
                "Assert 2: " + MyPostsPagination.TestScenarios[10], "Pagination - Screenshot", "Pagination: Test Case 1.14");
            }
            else
            {
                await PaginationAssertions.ShouldDisplayNumberOfPosts(
                "Assert 1: " + MyPostsPagination.TestScenarios[10], "Pagination - Screenshot", "Pagination: Test Case 1.14");

            }
        }

        [TestMethod]
        [TestCategory("My Posts Pagination")]
        public async Task Test012_FilterDatePagination()
        {
            await MyPostsPages.ChangeFilterByDate(MyPostsElementNameList.DateFilter.LAST_30_DAYS);
            if (await MyPostsPages.NextPageIcon_Button.IsDisabledAsync())
            {
                await PaginationAssertions.ShouldBeDisableRightPagination(
                "Assert 2: " + MyPostsPagination.TestScenarios[11], "Pagination - Screenshot", "Pagination: Test Case 1.15");
            }
            else
            {
                await PaginationAssertions.ShouldDisplayNumberOfPosts(
                "Assert 1: " + MyPostsPagination.TestScenarios[11], "Pagination - Screenshot", "Pagination: Test Case 1.15");

            }
        }

        [TestMethod]
        [TestCategory("My Posts Pagination")]
        public async Task Test013_MarkAsReturnedPagination()
        {
            await MyPostsPages.SelectMarkAsReturned();
            if (await MyPostsPages.NextPageIcon_Button.IsEnabledAsync())
            {
                await PaginationAssertions.ShouldBeEnableRightPagination(
                "Assert 2: " + MyPostsPagination.TestScenarios[12], "Pagination - Screenshot", "Pagination: Test Case 1.16");
            }
            else
            {
                await PaginationAssertions.ShouldDisplayNumberOfPosts(
                "Assert 1: " + MyPostsPagination.TestScenarios[12], "Pagination - Screenshot", "Pagination: Test Case 1.16");

            }
        }

        [TestMethod]
        [TestCategory("My Posts Pagination")]
        public async Task Test014_MultipleDefaultWaybillPagination()
        {
            await MyPostsPages.SelectMultiplePrintDefaultWaybill();
            if (await MyPostsPages.NextPageIcon_Button.IsVisibleAsync())
            {
                await PaginationAssertions.ShouldBeEnableRightPagination(
                "Assert 2: " + MyPostsPagination.TestScenarios[13], "Pagination - Screenshot", "Pagination: Test Case 1.17");
            }
            else
            {
                await PaginationAssertions.ShouldDisplayNumberOfPosts(
                "Assert 1: " + MyPostsPagination.TestScenarios[13], "Pagination - Screenshot", "Pagination: Test Case 1.17");

            }
        }

        [TestMethod]
        [TestCategory("My Posts Pagination")]
        public async Task Test015_MultipleProviderWaybillPagination()
        {
            await MyPostsPages.SelectMultipleProviderDefaultWaybill();
            if (await MyPostsPages.NextPageIcon_Button.IsVisibleAsync())
            {
                await PaginationAssertions.ShouldBeEnableRightPagination(
                "Assert 2: " + MyPostsPagination.TestScenarios[14], "Pagination - Screenshot", "Pagination: Test Case 1.18");
            }
            else
            {
                await PaginationAssertions.ShouldDisplayNumberOfPosts(
                "Assert 1: " + MyPostsPagination.TestScenarios[14], "Pagination - Screenshot", "Pagination: Test Case 1.18");

            }
        }

        [TestMethod]
        [TestCategory("Cancelled, Returned & Rejected Pagination")]
        public async Task Test016_DefaultNumberCancelledReturnedRejectedDisplay()
        {
            await MyPostsPages.CancelledReturnedRejectedTab_Link.ClickAsync();
            await MyPostsPages.PaginationPostsNumberDisplay_Label.ClickAsync();
            //await Page.WaitForTimeoutAsync(4000);
            await PaginationAssertions.ShouldDisplayNumberOfPosts(
                MyPostsPagination.TestScenarios[15], "Pagination - Screenshot", "Pagination: Test Case 2.1");
        }

        [TestMethod]
        [TestCategory("Cancelled, Returned & Rejected Pagination")]
        public async Task Test017_TotalNumberCancelledReturnedRejectedDisplayForNextPage()
        {
            await MyPostsPages.NextPageIcon_Button.ClickAsync();
            await PaginationAssertions.ShouldDisplayNumberOfPosts(
                MyPostsPagination.TestScenarios[16], "Pagination - Screenshot", "Pagination: Test Case 2.2");
        }

        [TestMethod]
        [TestCategory("Cancelled, Returned & Rejected Pagination")]
        public async Task Test018_TotalNumberCancelledReturnedRejectedDisplayForPreviousPage()
        {
            await MyPostsPages.CancelledReturnedRejectedTab_Link.ClickAsync();
            await MyPostsPages.NextPageIcon_Button.ClickAsync();
            await MyPostsPages.PreviousPageIcon_Button.ClickAsync();
            await PaginationAssertions.ShouldDisplayNumberOfPosts(
                MyPostsPagination.TestScenarios[17], "Pagination - Screenshot", "Pagination: Test Case 2.3");
        }

        [TestMethod]
        [TestCategory("Cancelled, Returned & Rejected Pagination")]
        public async Task Test019_CancelledReturnedRejectedDisabledLeftPagination()
        {
            await MyPostsPages.CancelledReturnedRejectedTab_Link.ClickAsync();
            await PaginationAssertions.ShouldBeDisable(
                MyPostsPagination.TestScenarios[18], "Pagination - Screenshot", "Pagination: Test Case 2.4");
        }

        [TestMethod]
        [TestCategory("Cancelled, Returned & Rejected Pagination")]
        public async Task Test020_CancelledReturnedRejectedNextPaginationNumberCount()
        {
            await MyPostsPages.CancelledReturnedRejectedTab_Link.ClickAsync();
            await MyPostsPages.NextPageIcon_Button.ClickAsync();
            await PaginationAssertions.ShouldDisplayMoreThanTheFirstCount(
                MyPostsPagination.TestScenarios[19], "Pagination - Screenshot", "Pagination: Test Case 2.7");
        }

        [TestMethod]
        [TestCategory("Cancelled, Returned & Rejected Pagination")]
        public async Task Test021_CancelledReturnedRejectedPreviousPaginationNumberCount()
        {
            await MyPostsPages.CancelledReturnedRejectedTab_Link.ClickAsync();
            await MyPostsPages.NextPageIcon_Button.ClickAsync();
            await MyPostsPages.PreviousPageIcon_Button.ClickAsync();
            await PaginationAssertions.ShouldDisplayTheFirstCount(
                MyPostsPagination.TestScenarios[20], "Pagination - Screenshot", "Pagination: Test Case 2.8");
        }

        [TestMethod]
        [TestCategory("Cancelled, Returned & Rejected Pagination")]
        public async Task Test022_NoResultCancelledReturnedRejectedDisplay()
        {
            await MyPostsPages.CancelledReturnedRejectedTab_Link.ClickAsync();
            await MyPostsPages.ChangeFilterByHubs(MyPostsElementNameList.Hubs.GRACEL);
            await PaginationAssertions.ShouldDisplayNoResult(
                MyPostsPagination.TestScenarios[21], "Pagination - Screenshot", "Pagination: Test Case 2.9");
        }

        [TestMethod]
        [TestCategory("Cancelled, Returned & Rejected Pagination")]
        public async Task Test023_SearchCancelledReturnedRejectedPagination()
        {
            await MyPostsPages.CancelledReturnedRejectedTab_Link.ClickAsync();
            await MyPostsPages.ChangeFilterBySearch(MyPostsElementNameList.SearchType.REFERENCE_NUMBER);
            await MyPostsPages.InputSearchValue("test813");
            if (await MyPostsPages.NextPageIcon_Button.IsDisabledAsync())
            {
                await PaginationAssertions.ShouldBeDisableRightPagination(
                "Assert 2: " + MyPostsPagination.TestScenarios[22], "Pagination - Screenshot", "Pagination: Test Case 2.10");
            }
            else
            {
                await PaginationAssertions.ShouldDisplayNumberOfPosts(
                "Assert 1: " + MyPostsPagination.TestScenarios[22], "Pagination - Screenshot", "Pagination: Test Case 2.10");

            }
        }

        [TestMethod]
        [TestCategory("Cancelled, Returned & Rejected Pagination")]
        public async Task Test024_CancelledReturnedRejectedFilterHubsPagination()
        {
            await MyPostsPages.CancelledReturnedRejectedTab_Link.ClickAsync();
            await MyPostsPages.ChangeFilterByHubs(MyPostsElementNameList.Hubs.QA_STORE);
            if (await MyPostsPages.NextPageIcon_Button.IsDisabledAsync())
            {
                await PaginationAssertions.ShouldBeDisableRightPagination(
                "Assert 2: " + MyPostsPagination.TestScenarios[23], "Pagination - Screenshot", "Pagination: Test Case 2.11");
            }
            else
            {
                await PaginationAssertions.ShouldDisplayNumberOfPosts(
                "Assert 1: " + MyPostsPagination.TestScenarios[23], "Pagination - Screenshot", "Pagination: Test Case 2.11");

            }
        }

        [TestMethod]
        [Ignore]
        [TestCategory("Cancelled, Returned & Rejected Pagination")]
        public async Task Test025_CancelledReturnedRejectedFilterStatusPagination()
        {
            await MyPostsPages.CancelledReturnedRejectedTab_Link.ClickAsync();
            await MyPostsPages.ChangeFilterByStatus(MyPostsElementNameList.Status.ACCEPTED); // change to cancelled
            if (await MyPostsPages.NextPageIcon_Button.IsDisabledAsync())
            {
                await PaginationAssertions.ShouldBeDisableRightPagination(
                "Assert 2: " + MyPostsPagination.TestScenarios[24], "Pagination - Screenshot", "Pagination: Test Case 2.12");
            }
            else
            {
                await PaginationAssertions.ShouldDisplayNumberOfPosts(
                "Assert 1: " + MyPostsPagination.TestScenarios[24], "Pagination - Screenshot", "Pagination: Test Case 2.12");

            }
        }

        [TestMethod]
        [TestCategory("Cancelled, Returned & Rejected Pagination")]
        public async Task Test026_CancelledReturnedRejectedFilterPreferrredPartnerPagination()
        {
            await MyPostsPages.CancelledReturnedRejectedTab_Link.ClickAsync();
            await MyPostsPages.ChangeFilterByPartner(MyPostsElementNameList.PreferredPartner.MRSPEEDY);
            if (await MyPostsPages.NextPageIcon_Button.IsDisabledAsync())
            {
                await PaginationAssertions.ShouldBeDisableRightPagination(
                "Assert 2: " + MyPostsPagination.TestScenarios[25], "Pagination - Screenshot", "Pagination: Test Case 2.13");
            }
            else
            {
                await PaginationAssertions.ShouldDisplayNumberOfPosts(
                "Assert 1: " + MyPostsPagination.TestScenarios[25], "Pagination - Screenshot", "Pagination: Test Case 2.13");

            }
        }

        [TestMethod]
        [TestCategory("Pagination")]
        public async Task Test_CancelledReturnedRejectedFilterDatePagination()
        {
            await MyPostsPages.CancelledReturnedRejectedTab_Link.ClickAsync();
            await MyPostsPages.ChangeFilterByDate(MyPostsElementNameList.DateFilter.LAST_30_DAYS);
            if (await MyPostsPages.NextPageIcon_Button.IsDisabledAsync())
            {
                await PaginationAssertions.ShouldBeDisableRightPagination(
                "Assert 2: " + MyPostsPagination.TestScenarios[26], "Pagination - Screenshot", "Pagination: Test Case 2.14");
            }
            else
            {
                await PaginationAssertions.ShouldDisplayNumberOfPosts(
                "Assert 1: " + MyPostsPagination.TestScenarios[26], "Pagination - Screenshot", "Pagination: Test Case 2.14");

            }
        }
    }
}

