
namespace automation_dph.src.Tests
{
    [TestClass]
    [TestCategory("MY POSTS SEARCH FILTER TEST SUITES")]
    public class Suites_MyPostsSearchFilterTests : BasePageTest
	{
        [TestMethod]
        [TestCategory("Search Posts")]
        [Description("TC-1.1, TC-1.2, TC-1.3, TC-1.4, TC-1.5")]
        public async Task Test_SearchPosts()
        {
            await SearchPosts(EnumsSearchFilter.SearchType(), "SearchFilter - Screenshot");
        }

        private async Task SearchPosts(IEnumerable<object[]> searchPosts, string screenShotFolderName)
        {
            foreach (var itemData in searchPosts)
            {
                string searchPostsType = (string)itemData[0];
                string searcValue = (string)itemData[1];
                string testScenariosDescription = (string)itemData[2];
                string screenShotFileName = (string)itemData[3];
                // Test Steps
                await MyPostsPages.ChangeFilterBySearch(searchPostsType);
                await MyPostsPages.InputSearchValue(searcValue);
                await MyPostsPages.DashboardLatesPost_Button.First.ClickAsync();
                await SearchFilterAssertions.ShouldDisplayResult(
                    testScenariosDescription, screenShotFolderName, screenShotFileName);
            }
        }

        [TestMethod]
        [TestCategory("Search Posts")]
        [Description("TC-1.6, TC-1.7, TC-1.8, TC-1.9, TC-1.10")]
        public async Task Test_SearchPostsNoResults()
        {
            await SearchPostsNoResults(EnumsSearchFilter.SearchTypeNoResults(), "SearchFilter - Screenshot");
        }

        private async Task SearchPostsNoResults(IEnumerable<object[]> searchPosts, string screenShotFolderName)
        {
            foreach (var itemData in searchPosts)
            {
                string searchPostsType = (string)itemData[0];
                string searcValue = (string)itemData[1];
                string testScenariosDescription = (string)itemData[2];
                string screenShotFileName = (string)itemData[3];
                // Test Steps
                await MyPostsPages.ChangeFilterBySearch(searchPostsType);
                await MyPostsPages.InputSearchValue(searcValue);
                await SearchFilterAssertions.ShouldNotDisplayResult(
                    testScenariosDescription, screenShotFolderName, screenShotFileName);
            }
        }

        [TestMethod]
        [TestCategory("Search Hubs")]
        [Description("TC-2.1")]
        public async Task Test_SearchHubs()
        {
            await SearchHubs(EnumsSearchFilter.Hubs(), "SearchFilter - Screenshot");
        }

        private async Task SearchHubs(IEnumerable<object[]> searchHubs, string testCaseFolderName)
        {
            foreach (var itemData in searchHubs)
            {
                string hubsType = (string)itemData[0];
                string reportDescription = (string)itemData[1];
                string testCaseName = (string)itemData[2];
                // Test Steps
                await MyPostsPages.ChangeFilterByHubs(hubsType);
                await SearchFilterAssertions.ShouldDisplayStore(
                    reportDescription, testCaseFolderName, testCaseName);
            }
        }
    }
}

