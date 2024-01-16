
namespace automation_dph.TestScenarios
{
	public class DashboardUI : BasePageDriver
    {
        public DashboardUI(IPage page, PageTest pageTest) : base(page, pageTest)
        {

        }

        public static string[] VisibilityTestScenarios = new string[]
        {
            "1.1 Validate Add New Post Button Visibility", //[0]
            "2.1 Validate Search Posts Dropdown Button Visibility",
            "3.1 Validate Search Posts Text Visibility",
            "4.1 Validate Hubs Dropdown Visibility",
            "5.1 Validate Status Dropdown Visibility",
            "6.1 Validate Preferred Courier Dropdown Visibility", //[5]
            "7.1 Validate My Posts Label Visibility",
            "8.1 Validate Date Dropdown Visibility",
            "9.1 Validate All Tab Link Text Visibility",
            "10.1 Validate Cancelled, Returned & Rejected Tab Link Text Visibility",
            "11.1 Validate Reference Number Label Visibility", //[10]
            "12.1 Validate Customer Name Label Visibility",
            "13.1 Validate Preferred Partner Label Visibility",
            "14.1 Validate Time Label Visibility",
            "15.1 Validate Pickup City Label Visibility",
            "16.1 Validate Delivery City Label Visibility", //[15]
            "17.1 Validate Tags Label Visibility",
            "18.1 Validate Completion Date Label Visibility",
            "19.1 Validate My Posts Ellipsis Button Visibility",
            "20.1 Validate Dashboard My Posts Visibility",
            "21.1 Validate Pagination Count Label Visibility", //[20]
        };

        public static string[] FunctionalityTestScenarios = new string[]
        {
            "1.2 Validate Add New Post Button Functionality", //[0]
            "2.2 Validate Search Posts Dropdown Button Functionality",
            "3.2 Validate Search Posts Text Functionality",
            "4.2 Validate Hubs Dropdown Functionality",
            "5.2 Validate Status Dropdown Functionality",
            "6.2 Validate Preferred Courier Dropdown Functionality", //[5]
            "8.2 Validate Date Dropdown Functionality",
            "9.2 Validate All Tab Link Text Functionality",
            "10.2 Validate Cancelled, Returned & Rejected Tab Link Text Functionality",
            "19.2 Validate My Posts Ellipsis Button Functionality",
        };

        public static string[] LabelingTestScenarios = new string[]
        {
            "1.3 Validate Add New Post Button Spelling/Grammar Label", //[0]
            "7.3 Validate My Posts Label Spelling/Grammar Label",
            "9.3 Validate All Tab Link Text Spelling/Grammar Label",
            "10.3 Validate Cancelled, Returned & Rejected Tab Link Text Spelling/Grammar Label",
            "11.3 Validate Reference Number Label Spelling/Grammar Label",
            "12.3 Validate Customer Name Label Spelling/Grammar Label", //[5]
            "13.3 Validate Preferred Partner Label Spelling/Grammar Label",
            "14.3 Validate Time Label Spelling/Grammar Label",
            "15.3 Validate Pickup City Label Spelling/Grammar Label",
            "16.3 Validate Delivery City Label Spelling/Grammar Label",
            "17.3 Validate Tags Label Spelling/Grammar Label", //[10]
            "18.3 Validate Completion Date Label Spelling/Grammar Label",
        };

        public static string[] ListingTestScenarios = new string[]
        {
            "2.3 Validate Search Posts Dropdown Button List of Item", //[0]
            "4.3 Validate Hubs Dropdown List of Item",
            "5.4 Validate Status Dropdown List of Item",
            "6.3 Validate Preferred Courier Dropdown List of Item",
            "8.3 Validate Date Dropdown List of Item",
            "19.3 Validate My Posts Ellipsis Button List of Item", //[5]
        };

        public static string[] MaxLengthTestScenarios = new string[]
        {
            "3.4 Validate Search Posts Text Max Length Value",
        };

        public string[] StepsToReplicate = new string[]
        {
            // 1.1 [0]
            "<b>Steps to Replicate:</b><br>" +
                        "1. Verify Add New Post button visibility.<br><br>" +
                        "<b>Expected Result:</b><br> Button should be visibility under my post page.<br><br> ",
            // 1.2
            "<b>Steps to Replicate:</b><br>" +
                        "1. Click Add New Post button.<br><br>" +
                         "<b>Expected Result:</b><br> Button should be clickable.<br> " +
                         "Add New Post page should display.<br><br>",
            // 1.3
            "<b>Steps to Replicate:</b><br>" +
                        "1. Verify the spelling/grammar label.<br><br>" +
                        "<b>Expected Result:</b><br> Text should be 'Add New Post'.<br><br> ",
            // 2.1
            "<b>Steps to Replicate:</b><br>" +
                        "1. Verify Search posts dropdown visibility.<br><br>" +
                        "<b>Expected Result:</b><br> Dropdown should be visibility beside searct posts text.<br><br> ",
            // 2.2
            "<b>Steps to Replicate:</b><br>" +
                        "1. Click Ref. No dropdown field.<br><br>" +
                         "<b>Expected Result:</b><br> Dropdown should be clickable.<br> " +
                         "Add New Post page should display.<br><br>",
            // 2.3 [5]
            "<b>Steps to Replicate:</b><br>" +
                        "1. Click Ref. No dropdown field.<br><br>" +
                         "<b>Expected Result:</b><br> List of items should be display.<br> " +
                         "Following list should be:\nRef. No\nCustomer Name\nPickup City\nPost Id\nDelivery Tracking Number<br><br>",
            // 3.1
            "<b>Steps to Replicate:</b><br>" +
                        "1. Verify Search posts text visibility.<br><br>" +
                        "<b>Expected Result:</b><br> Text field should be visible besides Ref. No dropdown.<br><br> ",
            // 3.2
            "<b>Steps to Replicate:</b><br>" +
                        "1. Click Search Posts text.<br><br>" +
                        "<b>Expected Result:</b><br> Text should be able to type.<br><br> ",
            // 3.4
            "<b>Steps to Replicate:</b><br>" +
                        "1. Fill-out max lenght value.<br><br>" +
                         "<b>Expected Result:</b><br> Inputted text should be display.<br> " +
                         "Max lenght value should be acceptable.<br><br>",
            // 4.1
            "<b>Steps to Replicate:</b><br>" +
                        "1. Verify Hubs dropdown visibility.<br><br>" +
                        "<b>Expected Result:</b><br> Dropdown should be visible.<br><br> ",
            // 4.2 [10]
            "<b>Steps to Replicate:</b><br>" +
                        "1. Click All hubs dropdown field.<br><br>" +
                        "<b>Expected Result:</b><br> Dropdown should be clickable.<br><br> ",
            // 4.3
            "<b>Steps to Replicate:</b><br>" +
                        "1. Click All hubs dropdown field.<br><br>" +
                        "<b>Expected Result:</b><br> List of items should be display.<br><br> ",
            // 5.1
            "<b>Steps to Replicate:</b><br>" +
                        "1. Verify Status dropdown visibility.<br><br>" +
                        "<b>Expected Result:</b><br> Dropdown should be visible.<br><br> ",
            // 5.2
            "<b>Steps to Replicate:</b><br>" +
                        "1. Click All Status dropdown field.<br><br>" +
                        "<b>Expected Result:</b><br> Dropdown should be clickable.<br><br> ",
            // 5.4
            "<b>Steps to Replicate:</b><br>" +
                        "1. Click All Status dropdown field.<br><br>" +
                        "<b>Expected Result:</b><br> List of items should be display.<br><br> ",
            // 6.1 [15]
            "<b>Steps to Replicate:</b><br>" +
                        "1. Verify Preferred Partner dropdown visibility.<br><br>" +
                        "<b>Expected Result:</b><br> Dropdown should be visible.<br><br> ",
            // 6.2
            "<b>Steps to Replicate:</b><br>" +
                        "1. Click All Preferred Partner dropdown field.<br><br>" +
                        "<b>Expected Result:</b><br> Dropdown should be clickable.<br><br> ",
            // 6.3
            "<b>Steps to Replicate:</b><br>" +
                        "1. Click All Preferred Partner dropdown field.<br><br>" +
                        "<b>Expected Result:</b><br> List of items should be display.<br><br> ",
            // 7.1
            "<b>Steps to Replicate:</b><br>" +
                        "1. Verify My Posts label visibility.<br><br>" +
                        "<b>Expected Result:</b><br> Label should be visible.<br><br> ",
            // 7.2
            "<b>Steps to Replicate:</b><br>" +
                        "1. Verify the spelling/grammar label.<br><br>" +
                        "<b>Expected Result:</b><br> Text should be 'My Posts'.<br><br> ",
            // 8.1 [20]
            "<b>Steps to Replicate:</b><br>" +
                        "1. Verify Date dropdown visibility.<br><br>" +
                        "<b>Expected Result:</b><br> Dropdown should be visible.<br><br> ",
            // 8.2
            "<b>Steps to Replicate:</b><br>" +
                        "1. Click As of Today dropdown field.<br><br>" +
                        "<b>Expected Result:</b><br> Dropdown should be clickable.<br><br> ",
            // 8.3
            "<b>Steps to Replicate:</b><br>" +
                        "1. Click As of Today dropdown field.<br><br>" +
                         "<b>Expected Result:</b><br> List of items should be display.<br> " +
                         "List of items should be clickable.<br><br>",
            // 9.1
            "<b>Steps to Replicate:</b><br>" +
                        "1. Verify All Tab Link text visibility.<br><br>" +
                        "<b>Expected Result:</b><br> Link text should be visible.<br><br> ",
            // 9.2
            "<b>Steps to Replicate:</b><br>" +
                        "1. Click Cancelled, Returned & Rejected tab link text.<br>" +
                        "2. Click All tab link text.<br><br>" +
                        "<b>Expected Result:</b><br> Link text should be clickable.<br><br> ",
            // 9.3 [25]
            "<b>Steps to Replicate:</b><br>" +
                        "1. Verify the spelling/grammar label.<br><br>" +
                        "<b>Expected Result:</b><br> Link text should be 'All'.<br><br> ",
            // 10.1
            "<b>Steps to Replicate:</b><br>" +
                        "1. Verify Cancelled, Returned & rejected Tab Link text visibility.<br><br>" +
                        "<b>Expected Result:</b><br> Link text should be visible.<br><br> ",
            // 10.2
            "<b>Steps to Replicate:</b><br>" +
                        "1. Click Cancelled, Returned & Rejected tab link text..<br><br>" +
                        "<b>Expected Result:</b><br> Link should be clickable.<br><br> ",
            // 10.3
            "<b>Steps to Replicate:</b><br>" +
                        "1. Verify the spelling/grammar label.<br><br>" +
                        "<b>Expected Result:</b><br> Link text should be 'Cancelled, Returned & Rejected'.<br><br> ",
            // 11.1
            "<b>Steps to Replicate:</b><br>" +
                        "1. Verify Reference Number label text visibility.<br><br>" +
                        "<b>Expected Result:</b><br> Label text should be visible.<br><br> ",
            // 11.3 [30]
            "<b>Steps to Replicate:</b><br>" +
                        "1. Verify the spelling/grammar label.<br><br>" +
                        "<b>Expected Result:</b><br> Label text should be 'Ref No.'.<br><br> ",
            // 12.1
            "<b>Steps to Replicate:</b><br>" +
                        "1. Verify Ceference Number label text visibility.<br><br>" +
                        "<b>Expected Result:</b><br> Label text should be visible.<br><br> ",
            // 12.3
            "<b>Steps to Replicate:</b><br>" +
                        "1. Verify the spelling/grammar label.<br><br>" +
                        "<b>Expected Result:</b><br> Label text should be 'Customer'.<br><br> ",
            // 13.1
            "<b>Steps to Replicate:</b><br>" +
                        "1. Verify Preferred Partner label text visibility.<br><br>" +
                        "<b>Expected Result:</b><br> Label text should be visible.<br><br> ",
            // 13.3
            "<b>Steps to Replicate:</b><br>" +
                        "1. Verify the spelling/grammar label.<br><br>" +
                        "<b>Expected Result:</b><br> Label text should be 'Preferred Partner'.<br><br> ",
            // 14.1 [35]
            "<b>Steps to Replicate:</b><br>" +
                        "1. Verify Time label text visibility.<br><br>" +
                        "<b>Expected Result:</b><br> Label text should be visible.<br><br> ",
            // 14.3
            "<b>Steps to Replicate:</b><br>" +
                        "1. Verify the spelling/grammar label.<br><br>" +
                        "<b>Expected Result:</b><br> Label text should be 'Time'.<br><br> ",
            // 15.1
            "<b>Steps to Replicate:</b><br>" +
                        "1. Verify Pickup City label text visibility.<br><br>" +
                        "<b>Expected Result:</b><br> Label text should be visible.<br><br> ",
            // 15.3
            "<b>Steps to Replicate:</b><br>" +
                        "1. Verify the spelling/grammar label.<br><br>" +
                        "<b>Expected Result:</b><br> Label text should be 'Pickup City'.<br><br> ",
            // 16.1
            "<b>Steps to Replicate:</b><br>" +
                        "1. Verify Delivery City label text visibility.<br><br>" +
                        "<b>Expected Result:</b><br> Label text should be visible.<br><br> ",
            // 16.3 [40]
            "<b>Steps to Replicate:</b><br>" +
                        "1. Verify the spelling/grammar label.<br><br>" +
                        "<b>Expected Result:</b><br> Label text should be 'Delivery City'.<br><br> ",
            // 17.1
            "<b>Steps to Replicate:</b><br>" +
                        "1. Verify Tags label text visibility.<br><br>" +
                        "<b>Expected Result:</b><br> Label text should be visible.<br><br> ",
            // 17.3
            "<b>Steps to Replicate:</b><br>" +
                        "1. Verify the spelling/grammar label.<br><br>" +
                        "<b>Expected Result:</b><br> Label text should be 'Tags'.<br><br> ",
            // 18.1
            "<b>Steps to Replicate:</b><br>" +
                        "1. Verify Completion Date label text visibility.<br><br>" +
                        "<b>Expected Result:</b><br> Label text should be visible.<br><br> ",
            // 18.3
            "<b>Steps to Replicate:</b><br>" +
                        "1. Verify the spelling/grammar label.<br><br>" +
                        "<b>Expected Result:</b><br> Label text should be 'Completion Date'.<br><br> ",
            // 19.1 [45]
            "<b>Steps to Replicate:</b><br>" +
                        "1. Verify My Posts Ellipsis button visibility.<br><br>" +
                        "<b>Expected Result:</b><br> Button should be visible.<br><br> ",
            // 19.2
            "<b>Steps to Replicate:</b><br>" +
                        "1. Click My Posts Ellipsis button field.<br><br>" +
                        "<b>Expected Result:</b><br> Button should be clickable.<br><br> ",
            // 19.3
            "<b>Steps to Replicate:</b><br>" +
                        "1. Click My Posts Ellipsis button field.<br><br>" +
                        "<b>Expected Result:</b><br> List of items should be display.<br><br> ",
            // 20.1
            "<b>Steps to Replicate:</b><br>" +
                        "1. Verify My Posts Dashboard visibility.<br><br>" +
                        "<b>Expected Result:</b><br> Dashboard should be visible.<br><br> ",
            // 21.1
            "<b>Steps to Replicate:</b><br>" +
                        "1. Verify Pagination Counter label text visibility.<br><br>" +
                        "<b>Expected Result:</b><br> Dashboard should be visible.<br><br> ",
        };
    }
}

