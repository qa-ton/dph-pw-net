

namespace automation_dph.src.Utils
{
	public class BasePageTest
	{
        protected IPage? Page { get; private set; }
        protected PageTest? PageTest { get; private set; }
        protected DataConfiguration DataConfiguration { get; private set; } = null!;
        protected LoginPages LoginPages { get; private set; } = null!;
        protected MyPostsPages MyPostsPages { get; private set; } = null!;
        protected SearchFilterAssertions SearchFilterAssertions { get; private set; } = null!;
        protected SearchFilter SearchFilter { get; private set; } = null!;
        protected MarkAsReturnedAssertions MarkAsReturnedAssertions { get; private set; } = null!;
        protected PrintWaybillAssertions PrintWaybillAssertions { get; private set; } = null!;
        protected PaginationAssertions PaginationAssertions { get; private set; } = null!;
        protected DashboardUIAssertions DashboardUIAssertions { get; private set; } = null!;
        protected AddNewPostsPages AddNewPostsPages { get; private set; } = null!;
        protected ManualPostsCreationAssertions ManualPostsCreationAssertions { get; private set; } = null!;
        protected PostsCreation PostsCreation { get; private set; } = null!;
        protected AddNewPostsAssertions AddNewPostsAssertions { get; private set; } = null!;
        protected EnumsPostFieldDetails EnumsPostFieldDetails { get; private set; } = null!;
        protected EnumsAdditionalDetails EnumsAdditionalDetails { get; private set; } = null!;
        protected EnumsSummaryPage EnumsSummaryPage { get; private set; } = null!;
        protected EnumsPinLocations EnumsPinLocations { get; private set; } = null!;


        [TestInitialize]
        public async Task TestPageInit()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(
                new BrowserTypeLaunchOptions
                {
                    Headless = true
                });

            Page = await browser.NewPageAsync();
            await Page.GotoAsync("https://Staging.deliveries.ph/");

            // Page Object Model
            PageTest = new PageTest();
            DataConfiguration = new(Page, PageTest);
            LoginPages = new(Page, PageTest);
            MyPostsPages = new(Page, PageTest);
            SearchFilterAssertions = new(Page, PageTest);
            SearchFilter = new(Page, PageTest);
            MarkAsReturnedAssertions = new(Page, PageTest);
            PrintWaybillAssertions = new(Page, PageTest);
            PaginationAssertions = new(Page, PageTest);
            DashboardUIAssertions = new(Page, PageTest);
            AddNewPostsPages = new(Page, PageTest);
            ManualPostsCreationAssertions = new(Page, PageTest);
            PostsCreation = new(Page, PageTest);
            AddNewPostsAssertions = new(Page, PageTest);
            EnumsPostFieldDetails = new(Page, PageTest);
            EnumsAdditionalDetails = new(Page, PageTest);
            EnumsSummaryPage = new(Page, PageTest);
            EnumsPinLocations = new(Page, PageTest);

            // Login
            await LoginPages.LoginToWebApplication(DataConfiguration.qaUsername, DataConfiguration.qaPassword);

        }

        [TestCleanup]
        public async Task TestPageCleanUp()
        {
            if (Page != null && !Page.IsClosed)
            {
                try
                {
                    await Page.CloseAsync();
                }
                catch (PlaywrightException ex)
                {
                    Console.WriteLine($"Error occured during page close: {ex.Message}");
                }
            }
        }

    }
}

