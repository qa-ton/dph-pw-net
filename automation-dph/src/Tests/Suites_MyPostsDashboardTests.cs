
namespace automation_dph.src.Tests
{
    [TestClass]
    [TestCategory("MY POSTS DASHBOARD UI TEST SUITES")]
    public class Suites_MyPostsDashboardTests : BasePageTest
	{
        [TestMethod]
        [TestCategory("Element Visibility")]
        public async Task Test001_ElementVisibility()
        {
            await Element(EnumsDashboardUI.ElementVisibility(), "Dashboard UI - Screenshot");
        }

        [TestMethod]
        [TestCategory("Element Functionality")]
        public async Task Test002_ElementFunctionality()
        {
            await Element(EnumsDashboardUI.ElementFunctionality(), "Dashboard UI - Screenshot");
        }

        [TestMethod]
        [TestCategory("Element Labeling")]
        public async Task Test003_ElementLabeling()
        {
            await Element(EnumsDashboardUI.Elementlabeling(), "Dashboard UI - Screenshot");
        }

        [TestMethod]
        [TestCategory("Element List Item")]
        public async Task Test004_ElementListing()
        {
            await Element(EnumsDashboardUI.ElementListing(), "Dashboard UI - Screenshot");
        }

        [TestMethod]
        [TestCategory("Element Max Length")]
        public async Task Test005_ElementMaxLength()
        {
            await Element(EnumsDashboardUI.ElementMaxLength(), "Dashboard UI - Screenshot");
        }

        private async Task Element(IEnumerable<object[]> testCase, string screenShotFolderName)
        {
            foreach (var getData in testCase)
            {
                string testScenariosDescription = (string)getData[0];
                string screenShotFileName = (string)getData[1];

                if (testScenariosDescription.Contains("Visibility"))
                {
                    await DashboardUIAssertions.ShouldBeVisible(testScenariosDescription, screenShotFolderName, screenShotFileName);
                }
                else if (testScenariosDescription.Contains("Functionality"))
                {
                    if (testScenariosDescription.Contains("3.2"))
                    {
                        await DashboardUIAssertions.ShouldContainTextInputted(testScenariosDescription, screenShotFolderName, screenShotFileName);
                    }
                    else
                    {
                        await DashboardUIAssertions.ShouldBeClickable(testScenariosDescription, screenShotFolderName, screenShotFileName);
                    }

                }
                else if (testScenariosDescription.Contains("Spelling/Grammar"))
                {
                    await DashboardUIAssertions.ShouldCorrectLabeling(testScenariosDescription, screenShotFolderName, screenShotFileName);
                }
                else if (testScenariosDescription.Contains("List of Item"))
                {
                    await DashboardUIAssertions.ShouldHaveListDisplay(testScenariosDescription, screenShotFolderName, screenShotFileName);
                }
                else if (testScenariosDescription.Contains("Max Length"))
                {
                    await DashboardUIAssertions.ShouldLimitLengthText(testScenariosDescription, screenShotFolderName, screenShotFileName);
                }
                //await Page.ReloadAsync();
            }
        }
    }
}

