
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

        private async Task SearchHubs(IEnumerable<object[]> searchHubs, string screenShotFolderName)
        {
            foreach (var itemData in searchHubs)
            {
                string hubsType = (string)itemData[0];
                string testScenariosDescription = (string)itemData[1];
                string screenShotFileName = (string)itemData[2];
                // Test Steps
                await MyPostsPages.ChangeFilterByHubs(hubsType);
                await SearchFilterAssertions.ShouldDisplayStore(
                    testScenariosDescription, screenShotFolderName, screenShotFileName);
            }
        }

        [TestMethod]
        [TestCategory("Search Status")]
        [Description("TC-3.1, TC-3.2, TC-3.3, TC-3.4, TC-3.5, TC-3.9, TC-3.10, TC-3.11")]
        public async Task Test_SearchStatus()
        {
            await SearchStatus(EnumsSearchFilter.Status(), "SearchFilter - Screenshot");
        }

        private async Task SearchStatus(IEnumerable<object[]> filterStatus, string screenShotFolderName)
        {
            foreach (var itemData in filterStatus)
            {
                string statusType = (string)itemData[0];
                string testScenariosDescription = (string)itemData[1];
                string screenShotFileName = (string)itemData[2];
                // Test Steps
                await Page.WaitForTimeoutAsync(6000);
                await MyPostsPages.ChangeFilterByStatus(statusType);
                await SearchFilterAssertions.ShouldDisplayStatusRecord(
                    testScenariosDescription, screenShotFolderName, screenShotFileName);
                await Page.ReloadAsync();
            }
        }

        [TestMethod]
        [TestCategory("Search Preferred Partner")]
        [Description("TC-4.1")]
        public async Task Test_SearchPreferredPartner()
        {
            await MyPostsPages.ChangeFilterByPartner(MyPostsElementNameList.PreferredPartner.MRSPEEDY);
            await SearchFilterAssertions.ShouldDisplayPreferredPartner(
                "4.1 Validate Search Preferred Partner",
                "SearchFilter - Screenshot", "SearchFilter: Test Case 4.1");
        }

        [TestMethod]
        [TestCategory("Search Date")]
        [Description("TC-5.1, TC-5.2, TC-5.3, TC-5.4, TC-5.5, TC-5.6, TC-5.7")]
        public async Task Test_SearchDate()
        {
            await SearchDate(EnumsSearchFilter.Date(), "SearchFilter - Screenshot");
        }

        private async Task SearchDate(IEnumerable<object[]> filterDate, string screenShotFolderName)
        {
            foreach (var itemData in filterDate)
            {
                string dateType = (string)itemData[0];
                string testScenariosDescription = (string)itemData[1];
                string screenShotFileName = (string)itemData[2];
                // Test Steps
                await MyPostsPages.ChangeFilterByDate(dateType);
                await SearchFilterAssertions.ShouldDisplayDateResult(
                    testScenariosDescription, screenShotFolderName, screenShotFileName);
            }
        }

        [TestMethod]
        [TestCategory("Search Date")]
        [Description("TC-5.8")]
        public async Task Test_SearchByCustomRange()
        {
            await MyPostsPages.ChangeFilterByDate(MyPostsElementNameList.DateFilter.CUSTOM_RANGE);
            await MyPostsPages.InputCustomDateRange("02/01/2023", "08/30/2023");
            await MyPostsPages.ApplyDate_Button.ClickAsync();
            await SearchFilterAssertions.ShouldDisplayDateResult(
                "5.8 Validate Search by Custom Range",
                "SearchFilter - Screenshot", "SearchFilter: Test Case 5.8");
        }

        [TestMethod]
        [TestCategory("Search Date")]
        [Description("TC-5.10")]
        public async Task Test_ApplyingDateTwice()
        {
            await MyPostsPages.ChangeFilterByDate(MyPostsElementNameList.DateFilter.YESTERDAY);
            await MyPostsPages.ChangeFilterByDate(MyPostsElementNameList.DateFilter.YESTERDAY); // click again
            await SearchFilterAssertions.ShouldDisplayDateResult(
                "5.10 Validate Applying date again (Yesterday)",
                "SearchFilter - Screenshot", "SearchFilter: Test Case 5.10");
        }

        [TestMethod]
        [TestCategory("Filters")]
        [Description("TC-6.1, TC-6.6, TC-6.11, TC-6.16, TC-6.17")]
        public async Task Test_SearchByTwoFilters()
        {
            await FiltersByTwo(EnumsSearchFilter.SearchByTwoFilters(), "SearchFilter - Screenshot");
        }

        private async Task FiltersByTwo(IEnumerable<object[]> twoFilters, string screenShotFolderName)
        {
            foreach (var itemData in twoFilters)
            {
                string searchType = (string)itemData[0];
                string inputValue = (string)itemData[1];
                string filterType = (string)itemData[2];
                string testScenariosDescription = (string)itemData[3];
                string screenShotFileName = (string)itemData[4];

                await MyPostsPages.ChangeFilterBySearch(searchType);
                await MyPostsPages.InputSearchValue(inputValue);
                // Data change
                if (filterType.Contains("QA Store")) { await MyPostsPages.ChangeFilterByHubs(filterType); }
                else if (filterType.Contains("Accepted")) { await MyPostsPages.ChangeFilterByStatus(filterType); }
                else if (filterType.Contains("Mr Speedy")) { await MyPostsPages.ChangeFilterByPartner(filterType); }
                else if (filterType.Contains("Yesterday")) { await MyPostsPages.ChangeFilterByDate(filterType); }

                await MyPostsPages.DashboardLatesPost_Button.First.ClickAsync();
                await SearchFilterAssertions.ShouldDisplayResult(
                    testScenariosDescription, screenShotFolderName, screenShotFileName);
                await MyPostsPages.RefreshBrowser();
            }
        }

        [TestMethod]
        [TestCategory("Filters")]
        [Description("TC-6.21, TC-6.25, TC-6.29, TC-6.30, TC-6.33")]
        public async Task Test_SearchByThreeFilters()
        {
            await FiltersByThree(EnumsSearchFilter.SearchByThreeFilters(), "SearchFilter - Screenshot");
        }

        private async Task FiltersByThree(IEnumerable<object[]> filters, string screenShotFolderName)
        {
            foreach (var itemData in filters)
            {
                string searchType = (string)itemData[0];
                string inputValue = (string)itemData[1];
                string hubType = (string)itemData[2];
                string filterType = (string)itemData[3];
                string testScenariosDescription = (string)itemData[4];
                string screenShotFileName = (string)itemData[5];

                await MyPostsPages.ChangeFilterBySearch(searchType);
                await MyPostsPages.InputSearchValue(inputValue);
                await MyPostsPages.ChangeFilterByHubs(hubType);

                switch (filterType)
                {
                    case "Accepted":
                        await MyPostsPages.ChangeFilterByStatus(MyPostsElementNameList.Status.ACCEPTED);
                        break;
                    case "Mr Speedy":
                        await MyPostsPages.ChangeFilterByPartner(MyPostsElementNameList.PreferredPartner.MRSPEEDY);
                        break;
                    case "Last 30 Days":
                        await MyPostsPages.ChangeFilterByDate(MyPostsElementNameList.DateFilter.LAST_30_DAYS);
                        break;
                    default:
                        break;
                }

                await MyPostsPages.DashboardLatesPost_Button.First.ClickAsync();
                await SearchFilterAssertions.ShouldDisplayPostTransaction(
                    testScenariosDescription, screenShotFolderName, screenShotFileName);
                await MyPostsPages.RefreshBrowser();
            }
        }

        [TestMethod]
        [TestCategory("Filters")]
        [Description("TC-6.36, TC-6.39, TC-6.41, TC-6.42, TC-6.44")]
        public async Task Test_SearchByFourFilters()
        {
            await FiltersByFour(EnumsSearchFilter.SearchByFourFilters(), "SearchFilter - Screenshot");
        }

        private async Task FiltersByFour(IEnumerable<object[]> filters, string screenShotFolderName)
        {
            foreach (var itemData in filters)
            {
                string searchType = (string)itemData[0];
                string inputValue = (string)itemData[1];
                string hubType = (string)itemData[2];
                string statusType = (string)itemData[3];
                //string courierType = (string)itemData[4];
                string testScenariosDescription = (string)itemData[5];
                string screenShotFileName = (string)itemData[6];

                await MyPostsPages.ChangeFilterBySearch(searchType);
                await MyPostsPages.InputSearchValue(inputValue);
                await MyPostsPages.ChangeFilterByHubs(hubType);
                await MyPostsPages.ChangeFilterByStatus(statusType);

                if (screenShotFileName.Contains("6.36") || screenShotFileName.Contains("6.42") || screenShotFileName.Contains("6.44"))
                {
                    await MyPostsPages.ChangeFilterByPartner(MyPostsElementNameList.PreferredPartner.MRSPEEDY);
                }
                else if (screenShotFileName.Contains("6.39") || screenShotFileName.Contains("6.41"))
                {
                    await MyPostsPages.ChangeFilterByDate(MyPostsElementNameList.DateFilter.LAST_30_DAYS);
                }

                await MyPostsPages.DashboardLatesPost_Button.First.ClickAsync();
                await SearchFilterAssertions.ShouldDisplayPostTransaction(
                    testScenariosDescription, screenShotFolderName, screenShotFileName);
                await MyPostsPages.RefreshBrowser();
            }
        }

        [TestMethod]
        [TestCategory("Filters")]
        [Description("TC-6.46, TC-6.47, TC-6.48, TC-6.49, TC-6.50")]
        public async Task Test_SearchByAllFilters()
        {
            await FiltersByAll(EnumsSearchFilter.SearchByAllFilters(), "SearchFilter - Screenshot");
        }

        private async Task FiltersByAll(IEnumerable<object[]> filters, string screenShotFolderName)
        {
            foreach (var itemData in filters)
            {
                string searchType = (string)itemData[0];
                string inputValue = (string)itemData[1];
                string hubType = (string)itemData[2];
                string statusType = (string)itemData[3];
                string courierType = (string)itemData[4];
                string dateType = (string)itemData[5];
                string testScenariosDescription = (string)itemData[6];
                string screenShotFileName = (string)itemData[7];

                await MyPostsPages.ChangeFilterBySearch(searchType);
                await MyPostsPages.InputSearchValue(inputValue);
                await MyPostsPages.ChangeFilterByHubs(hubType);
                await MyPostsPages.ChangeFilterByStatus(statusType);
                await MyPostsPages.ChangeFilterByPartner(courierType);
                await MyPostsPages.ChangeFilterByDate(dateType);

                await MyPostsPages.DashboardLatesPost_Button.First.ClickAsync();
                await SearchFilterAssertions.ShouldDisplayPostTransaction(
                    testScenariosDescription, screenShotFolderName, screenShotFileName);
                await MyPostsPages.RefreshBrowser();
            }
        }

        [TestMethod]
        [TestCategory("Exception Flows")]
        [Description("TC-6.51, TC-6.52, TC-6.53, TC-6.54, TC-6.55, TC-6.56")]
        public async Task Test_ExceptionFlows()
        {
            await NegativeScenarios(EnumsSearchFilter.NegativeScenarios(), "SearchFilter - Screenshot");
        }

        private async Task NegativeScenarios(IEnumerable<object[]> filters, string screenShotFolderName)
        {
            foreach (var itemData in filters)
            {
                string firstFilterType = (string)itemData[0];
                string secondFilterType = (string)itemData[1];
                string testScenariosDescription = (string)itemData[2];
                string screenShotFileName = (string)itemData[3];

                if (firstFilterType.Contains("QA Store") && secondFilterType.Contains("Accepted"))
                {
                    await MyPostsPages.ChangeFilterByHubs(firstFilterType);
                    await MyPostsPages.ChangeFilterByStatus(secondFilterType);
                }
                else if (firstFilterType.Contains("QA Store") && secondFilterType.Contains("Mr Speedy"))
                {
                    await MyPostsPages.ChangeFilterByHubs(firstFilterType);
                    await MyPostsPages.ChangeFilterByPartner(secondFilterType);
                }
                else if (firstFilterType.Contains("QA Store") && secondFilterType.Contains("Last 30 Days"))
                {
                    await MyPostsPages.ChangeFilterByHubs(firstFilterType);
                    await MyPostsPages.ChangeFilterByDate(secondFilterType);
                }
                else if (firstFilterType.Contains("All hubs") && secondFilterType.Contains("Accepted"))
                {
                    await MyPostsPages.ChangeFilterByHubs(firstFilterType);
                    await MyPostsPages.ChangeFilterByStatus(secondFilterType);
                }
                else if (firstFilterType.Contains("All hubs") && secondFilterType.Contains("Mr Speedy"))
                {
                    await MyPostsPages.ChangeFilterByHubs(firstFilterType);
                    await MyPostsPages.ChangeFilterByPartner(secondFilterType);
                }
                else if (firstFilterType.Contains("All hubs") && secondFilterType.Contains("Last 30 Days"))
                {
                    await MyPostsPages.ChangeFilterByHubs(firstFilterType);
                    await MyPostsPages.ChangeFilterByDate(secondFilterType);
                }
                else if (firstFilterType.Contains("Accepted") && secondFilterType.Contains("Mr Speedy"))
                {
                    await MyPostsPages.ChangeFilterByStatus(firstFilterType);
                    await MyPostsPages.ChangeFilterByPartner(secondFilterType);
                }
                else if (firstFilterType.Contains("Accepted") && secondFilterType.Contains("Last 30 Days"))
                {
                    await MyPostsPages.ChangeFilterByStatus(firstFilterType);
                    await MyPostsPages.ChangeFilterByDate(secondFilterType);
                }
                else if (firstFilterType.Contains("Mr Speedy") && secondFilterType.Contains("Last 30 Days"))
                {
                    await MyPostsPages.ChangeFilterByPartner(firstFilterType);
                    await MyPostsPages.ChangeFilterByDate(secondFilterType);
                }

                //await MyPostsPages.DashboardLatesPost_Button.First.ClickAsync();
                await SearchFilterAssertions.ShouldDisplayPostTransaction(
                    testScenariosDescription, screenShotFolderName, screenShotFileName);
                await MyPostsPages.RefreshBrowser();
            }
        }
    }

}

