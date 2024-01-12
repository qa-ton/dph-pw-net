
namespace automation_dph.TestScenarios
{
	public class MyPostsPagination : BasePageDriver
	{
		public MyPostsPagination(IPage page, PageTest pageTest) : base(page, pageTest)
		{

		}

		public static string[] TestScenarios = new string[]
		{
            "1.1 Validate Default total number of post display", //[0]
            "1.2 Validate total number of post display for Next pagination",
            "1.3 Validate total number of post display for Previous pagination",
            "1.6 Validate Disabled left pagination in first page",
            "1.8 Validate Next Pagination number",
            "1.9 Validate Previous Pagination number", //[5]
            "1.10 Validate No result post display",
            "1.11 Validate Pagination functionality of search posts",
            "1.12 Validate Pagination functionality of hubs/store",
            "1.13 Validate Pagination functionality of status",
            "1.14 Validate Pagination functionality of preferred partner", //[10]
            "1.15 Validate Pagination functionality of date",
            "1.16 Validate Pagination functionality for Mark as returned",
            "1.17 Validate Pagination functionality for Multiple Print Default Waybill",
            "1.18 Validate Pagination functionality for Multiple Print Provider Waybill",
            "2.1 Validate Default total number of Cancelled, Returned & Rejected display", //[15]
            "2.2 Validate total number of Cancelled, Returned & Rejected display for Next pagination",
            "2.3 Validate total number of Cancelled, Returned & Rejected display for Previous pagination",
            "2.4 Validate total number of Cancelled, Returned & Rejected display for Last pagination",
            "2.7 Validate Next Pagination number",
            "2.8 Validate Previous Pagination number", //[20]
            "2.9 Validate No result Cancelled, Returned & Rejected display",
            "2.10 Validate Pagination functionality of search Cancelled, Returned & Rejected",
            "2.11 Validate Pagination functionality of hubs/store",
            "2.12 Validate Pagination functionality of status",
            "2.13 Validate Pagination functionality of preferred partner", //[25]
            "2.14 Validate Pagination functionality of date",
        };

		public string[] StepsToReplicate = new string[]
		{
			// 1.1
            "<b>Steps to Replicate:</b><br>" +
                        "1. On My Posts Page, verify the number of posts display.<br><br>" +
                        "<b>Expected Result:</b><br> Number of post should be based on the list in the dashboard.<br><br> ",
			// 1.2
            "<b>Steps to Replicate:</b><br>" +
                        "1. On My Posts Page, click > (next) pagination button.<br>" +
                        "2. Verify the number of posts display.<br><br>" +
                        "<b>Expected Result:</b><br> Number of post should be based on the list in the dashboard.<br><br> ",
			// 1.3
            "<b>Steps to Replicate:</b><br>" +
                        "1. On My Posts Page, click > (next) pagination button.<br>" +
                        "2. Click < (previous) pagination button.<br>" +
                        "3. Verify the number of posts display.<br><br>" +
                        "<b>Expected Result:</b><br> Number of post should be based on the list in the dashboard.<br><br> ",
			// 1.6
            "<b>Steps to Replicate:</b><br>" +
                        "1. On My Posts Page, verify left (<) pagination icon.<br><br>" +
                        "<b>Expected Result:</b><br> Left pagination should be disable.<br><br> ",
			// 1.8
            "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click > (next) pagination button.<br><br>" +
                         "<b>Expected Result:</b><br> Next page should display the list of post.<br> " +
                         "Pagination number should increment based on the number of click.<br><br>",
			// 1.9
            "<b>Steps to Replicate:</b><br>" +
                        "1. On My Posts Page, click the > (next) pagination button 2 or more times.<br>" +
                        "2. Click < (left) pagination button.<br><br>" +
                         "<b>Expected Result:</b><br> Previous page should display the list of posts.<br> " +
                         "Pagination number should decrement based on the number of click.<br><br>",
			// 1.10
            "<b>Steps to Replicate:</b><br>" +
                        "1. On My Posts page, click All hubs dropdown field.<br>" +
                        "2. Select 'Gracel' hubs and click.<br>" +
                        "3. Verify pagination result.<br><br>" +
                        "<b>Expected Result:</b><br> Result should be 0 posts.<br><br> ",
			// 1.11
            "<b>Steps to Replicate:</b><br>" +
                        "1. On My Posts page, input a value in search posts textfield.<br>" +
                        "2. Verify Pagination button.<br><br>" +
                         "<b>Expected Result:</b><br> Pagination button should be clickable.<br> " +
                         "If number of posts in the dashboard are less than 50 next page button should disable.<br><br>",
			// 1.12
            "<b>Steps to Replicate:</b><br>" +
                        "1. On My Posts page, click and select any hubs in dropdown field.<br>" +
                        "2. Verify Pagination button.<br><br>" +
                         "<b>Expected Result:</b><br> Pagination button should be clickable.<br> " +
                         "If number of posts in the dashboard are less than 50 next page button should disable.<br><br>",
			// 1.13
            "<b>Steps to Replicate:</b><br>" +
                        "1. On My Posts page, click and select any status in dropdown field.<br>" +
                        "2. Verify Pagination button.<br><br>" +
                         "<b>Expected Result:</b><br> Pagination button should be clickable.<br> " +
                         "If number of posts in the dashboard are less than 50 next page button should disable.<br><br>",
			// 1.14
            "<b>Steps to Replicate:</b><br>" +
                        "1. On My Posts page, click and select any preferred partner in dropdown field.<br>" +
                        "2. Verify Pagination button.<br><br>" +
                         "<b>Expected Result:</b><br> Pagination button should be clickable.<br> " +
                         "If number of posts in the dashboard are less than 50 next page button should disable.<br><br>",
			// 1.15
            "<b>Steps to Replicate:</b><br>" +
                        "1. On My Posts page, click and select any date in dropdown field.<br>" +
                        "2. Verify Pagination button.<br><br>" +
                         "<b>Expected Result:</b><br> Pagination button should be clickable.<br> " +
                         "If number of posts in the dashboard are less than 50 next page button should disable.<br><br>",
			// 1.16
            "<b>Steps to Replicate:</b><br>" +
                        "1. On My Posts Page, click the Three Dots on the right side.<br>" +
                        "2. Click Mask as Returned options.<br>" +
                        "3. Verify Pagination button.<br><br>" +
                         "<b>Expected Result:</b><br> Pagination button should be clickable.<br> " +
                         "If number of posts in the dashboard are less than 50 next page button should disable.<br><br>",
			// 1.17
            "<b>Steps to Replicate:</b><br>" +
                        "1. On My Posts Page, click the Three Dots on the right side.<br>" +
                        "2. Click Print Default Waybill options.<br>" +
                        "3. Verify Pagination button.<br><br>" +
                         "<b>Expected Result:</b><br> Pagination button should be clickable.<br> " +
                         "If number of posts in the dashboard are less than 50 next page button should disable.<br><br>",
			// 1.18
            "<b>Steps to Replicate:</b><br>" +
                        "1. On My Posts Page, click the Three Dots on the right side.<br>" +
                        "2. Click Print Provider Waybill options.<br>" +
                        "3. Verify Pagination button.<br><br>" +
                         "<b>Expected Result:</b><br> Pagination button should be clickable.<br> " +
                         "If number of posts in the dashboard are less than 50 next page button should disable.<br><br>",
			// 2.1
            "<b>Steps to Replicate:</b><br>" +
                        "1. On My Posts Page, click Cancelled, Returned & Rejected tab link.<br>" +
                        "2. Verify the number of posts display.<br><br>" +
                        "<b>Expected Result:</b><br> Number of post should be based on the list in the dashboard.<br><br> ",
			// 2.2
            "<b>Steps to Replicate:</b><br>" +
                        "1. On My Posts Page, click Cancelled, Returned & Rejected tab link.<br>" +
                        "2. Click > (next) pagination button.<br>" +
                        "3. Verify the number of posts display.<br><br>" +
                        "<b>Expected Result:</b><br> Number of post should be based on the list in the dashboard.<br><br> ",
			// 2.3
            "<b>Steps to Replicate:</b><br>" +
                        "1. On My Posts Page, click Cancelled, Returned & Rejected tab link.<br>" +
                        "2. Click > (next) pagination button.<br>" +
                        "3. Click < (previous) pagination button.<br>" +
                        "4. Verify the number of posts display.<br><br>" +
                        "<b>Expected Result:</b><br> Number of post should be based on the list in the dashboard.<br><br> ",
			// 2.4
            "<b>Steps to Replicate:</b><br>" +
                        "1. On My Posts Page, click Cancelled, Returned & Rejected tab link.<br>" +
                        "2. On My Posts Page, click the > (next) pagination button multiple times until it reach the last page.<br>" +
                        "3. Verify the number of posts display.<br><br>" +
                        "<b>Expected Result:</b><br> Number of post should be based on the list in the dashboard.<br><br> ",
			// 2.7
            "<b>Steps to Replicate:</b><br>" +
                        "1. On My Posts Page, click Cancelled, Returned & Rejected tab link.<br>" +
                        "2. On My Posts Page, click > (next) pagination button.<br><br>" +
                         "<b>Expected Result:</b><br> Next page should display the list of post.<br> " +
                         "Pagination number should increment based on the number of click.<br><br>",
			// 2.8
            "<b>Steps to Replicate:</b><br>" +
                        "1. On My Posts Page, click Cancelled, Returned & Rejected tab link.<br>" +
                        "2. Click the > (next) pagination button 2 or more times.<br>" +
                        "3. Click < (left) pagination button.<br><br>" +
                         "<b>Expected Result:</b><br> Previous page should display the list of posts.<br> " +
                         "Pagination number should decrement based on the number of click.<br><br>",
			// 2.9
            "<b>Steps to Replicate:</b><br>" +
                        "1. On My Posts Page, click Cancelled, Returned & Rejected tab link.<br>" +
                        "2. Click All hubs dropdown field.<br>" +
                        "3. Select 'Gracel' hubs and click.<br>" +
                        "4. Verify pagination result.<br><br>" +
                        "<b>Expected Result:</b><br> Result should be 0 posts.<br><br> ",
			// 2.10
            "<b>Steps to Replicate:</b><br>" +
                        "1. On My Posts Page, click Cancelled, Returned & Rejected tab link.<br>" +
                        "2. Input a value in search posts textfield.<br>" +
                        "3. Verify Pagination button.<br><br>" +
                         "<b>Expected Result:</b><br> Pagination button should be clickable.<br> " +
                         "If number of posts in the dashboard are less than 50 next page button should disable.<br><br>",
			// 2.11
            "<b>Steps to Replicate:</b><br>" +
                        "1. On My Posts Page, click Cancelled, Returned & Rejected tab link.<br>" +
                        "2. Click and select any hubs in dropdown field.<br>" +
                        "3. Verify Pagination button.<br><br>" +
                         "<b>Expected Result:</b><br> Pagination button should be clickable.<br> " +
                         "If number of posts in the dashboard are less than 50 next page button should disable.<br><br>",
			// 2.12
            "<b>Steps to Replicate:</b><br>" +
                        "1. On My Posts Page, click Cancelled, Returned & Rejected tab link.<br>" +
                        "2. Click and select any status in dropdown field.<br>" +
                        "3. Verify Pagination button.<br><br>" +
                         "<b>Expected Result:</b><br> Pagination button should be clickable.<br> " +
                         "If number of posts in the dashboard are less than 50 next page button should disable.<br><br>",
			// 2.13
            "<b>Steps to Replicate:</b><br>" +
                        "1. On My Posts Page, click Cancelled, Returned & Rejected tab link.<br>" +
                        "2. Click and select any preferred partner in dropdown field.<br>" +
                        "3. Verify Pagination button.<br><br>" +
                         "<b>Expected Result:</b><br> Pagination button should be clickable.<br> " +
                         "If number of posts in the dashboard are less than 50 next page button should disable.<br><br>",
			// 2.14
            "<b>Steps to Replicate:</b><br>" +
                        "1. On My Posts Page, click Cancelled, Returned & Rejected tab link.<br>" +
                        "2. Click and select any date in dropdown field.<br>" +
                        "3. Verify Pagination button.<br><br>" +
                         "<b>Expected Result:</b><br> Pagination button should be clickable.<br> " +
                         "If number of posts in the dashboard are less than 50 next page button should disable.<br><br>",
        };

    }
}

