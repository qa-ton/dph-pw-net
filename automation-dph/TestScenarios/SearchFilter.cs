
using automation_dph.src.Assertions;

namespace automation_dph.TestScenarios
{
	public class SearchFilter : BasePageDriver
	{
        protected static MyPostsPages MyPostsPages { get; private set; } = null!;


        public SearchFilter(IPage page, PageTest pageTest) : base(page, pageTest)
		{
            MyPostsPages = new(Page, PageTest);
        }

        public static string[] TestScenarios = new string[]
		{
            "1.1 Validate Search Post for Reference number",// [0]
            "1.2 Validate Search Post for Customer Name",
            "1.3 Validate Search Post for Pickup City",
            "1.4 Validate Search Post for Post Id",
            "1.5 Validate Search Post for Delivery Tracking Number",
            "1.6 Validate No results for Reference number",
            "1.7 Validate No results for Customer Name",
            "1.8 Validate No results for Pickup City",
            "1.9 Validate No results for Post Id",
            "1.10 Validate No results for Delivery Tracking Number",
            "2.1 Validate Search Hubs", // [10]
            "3.1 Validate Search posts by Queued Status",
            "3.2 Validate Search posts by Assigned Status",
            "3.3 Validate Search posts by Accepted Status",
            "3.4 Validate Search posts by Assigning Rider Status",
            "3.5 Validate Search posts by Started Pickup Status",
            "3.8 Validate Search posts by In transit for return Status",
            "3.9 Validate Search posts by Failed Delivery Status",
            "3.10 Validate Search posts by Failed Pickup Status",
            "3.11 Validate Search posts by Failed Return Status",
            "4.1 Validate Search Preferred Partner", // [20]
            "5.1 Validate Search by As of Today",
            "5.2 Validate Search by Today",
            "5.3 Validate Search by Yesterday",
            "5.4 Validate Search by Last 7 Days",
            "5.5 Validate Search by Last 30 Days",
            "5.6 Validate Search by This Month",
            "5.7 Validate Search by Last Month",
            "5.8 Validate Search by Custom Range",
            "5.10 Validate Applying date again (Yesterday)",
            "6.1 Validate Filter by Reference number and Hubs", // [30]
            "6.6 Validate Filter by Customer Name and Status",
            "6.11 Validate Filter by Pickup City and Preferred Partner",
            "6.16 Validate Filter by Post Id and Date",
            "6.17 Validate Filter by Delivery Tracking Number and Hubs",
            "6.21 Validate Filter by Reference Number, Hubs and Status",
            "6.25 Validate Filter by Customer Name, Hubs and Preferred Partner",
            "6.29 Validate Filter by Pickup City, Hubs and Date",
            "6.30 Validate Filter by Post Id, Hubs and Status",
            "6.33 Validate Filter by Delivery Tracking Number, Hubs and Status",
            "6.36 Validate Filter by Reference Number, Hubs, Status and Preferred Partner", // [40]
            "6.39 Validate Filter by Customer Name, Hubs, Status and Date",
            "6.41 Validate Filter by Pickup City, Hubs, Status and Date",
            "6.42 Validate Filter by Post Id, Hubs, Status and Preferred Partner",
            "6.44 Validate Filter by Delivery Tracking Number, Hubs, Status and Preferred Partner",
            "6.46 Validate Filter by Reference Number, Hubs, Status, Preferred Partner and Date",
            "6.47 Validate Filter by Customer Name, Hubs, Status, Preferred Partner and Date",
            "6.48 Validate Filter by Pickup City, Hubs, Status, Preferred Partner and Date",
            "6.49 Validate Filter by Post Id, Hubs, Status, Preferred Partner and Date",
            "6.50 Validate Filter by Delivery Tracking Number, Hubs, Status, Preferred Partner and Date",
            "6.51 Validate Filter by Hubs and Status", // [50]
            "6.52 Validate Filter by Hubs and Preferred Partner",
            "6.53 Validate Filter by Hubs and Date",
            "6.54 Validate Filter by Status and Preferred Partner",
            "6.55 Validate Filter by Status and Date",
            "6.56 Validate Filter by Preferred Partner and Date",
            "6.57 Validate Filter by Hubs, Status, Preferred Partner and Date",
            "6.58 Validate Filter by Hubs, Status and Preferred Partner",
            "6.59 Validate Filter by Status, Preferred Partner and Date",
            "6.60 Validate Filter by Hubs, Preferred Partner and Date", // [59]
        };

        // SEARCH POSTS
        // 1.1, 1.2, 1.3, 1.4, 1.5
        public static string SearchPosts
        {
            get
            {
                return "<b>Steps to Replicate:</b><br>" +
                         $"1. Click and enter {MyPostsPages.GetValueOfSearchPostDropdownfield} in search posts textfield.<br>" +
                         "2. Verify search posts.<br><br>" +
                         "<b>Expected Result:</b><br> Search posts should display based on inputted value.<br><br>";
            }
        }

        // 1.6, 1.7, 1.8, 1.9, 1.10
        public static string SearchPostsNoResult
        {
            get
            {
                return "<b>Steps to Replicate:</b><br>" +
                         $"1. Click and enter a no record of {MyPostsPages.GetValueOfSearchPostDropdownfield} in search posts textfield.<br>" +
                         "2. Verify search posts.<br><br>" +
                         "<b>Expected Result:</b> \"No available data to display\" should display in my posts dashboard.<br><br>";
            }
        }

        // 2.1
        public static string FilterHubs
        {
            get
            {
                return "<b>Steps to Replicate:</b><br>" +
                         "1. Click All hubs dropdown field.<br>" +
                         "2. Click any hubs/store name.<br><br>" +
                         "<b>Expected Result:</b> Selected hubs should display.<br>" +
                         "All post under selected hubs/store should display.<br><br>";
            }
        }

        // 3.1, 3.2, 3.3, 3.4, 3.5, 3.8, 3.9, 3.10, 3.11
        public string FilterStatus
        {
            get
            {
                return "<b>Steps to Replicate:</b><br>" +
                         "1. Click All status dropdown field.<br>" +
                         $"2. Click {MyPostsPages.GetValueOfStatusInDashboard} status option.<br><br>" +
                         "<b>Expected Result:</b> Selected status should be checked.<br>" +
                         "All posts under selected status should display.<br><br>";
            }
        }

        // 4.1
        public static string FilterPreferredPartner
        {
            get
            {
                return "<b>Steps to Replicate:</b><br>" +
                         "1. Click All Preferred Partner dropdown field.<br>" +
                         "2. Click any Preferred Partner.<br><br>" +
                         "<b>Expected Result:</b> Selected Preferred Partner should display.<br>" +
                         "All post under selected Preferred Partner should display.<br><br>";
            }
        }

        // 5.1, 5.2, 5.3, 5.4, 5.5, 5.6, 5.7, 5.8, 5.10
        public static string FilterDate
        {
            get
            {
                return "<b>Steps to Replicate:</b><br>" +
                         "1. Click As of Today dropdown field.<br>" +
                         $"2. Click {MyPostsPages.GetValueOfDateDropdownfield} button.<br><br>" +
                         $"<b>Expected Result:</b> Completion Date should be display based on selected date.<br><br>";
            }
        }

        // 6.1, 6.6, 6.11, 6.16, 6.17
        public static string SearchByTwoFilters
        {
            get
            {
                return "<b>Steps to Replicate:</b><br>" +
                         $"1. Click and enter {MyPostsPages.GetValueOfSearchPostDropdownfield} in search posts textfield.<br>" +
                         $"2. Click All hubs dropdown field.<br>" +
                         $"3. Click {MyPostsPages.GetValueOfHubsDropdownfield} name.<br><br>" +
                         $"<b>Expected Result:</b> All post under selected filter should display.<br><br>";
            }
        }

        public static string DisplayNumberOfStatusSelected
        {
            get
            {
                return "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click the Three Dots on the right side.<br>" +
                         "2. Click Mark as Returned options.<br>" +
                         "3. Verify and Click All Status dropdown field.<br><br>" +
                         "<b>Expected Result:</b> Dropdown field name should display '1 Status Selected' by default.<br>" +
                         "IN_TRANSIT_FOR_RETURN should be checked.<br><br>";
            }
        }

        public static string PostsSelected
        {
            get
            {
                return "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click the Three Dots on the right side.<br>" +
                         "2. Click Mark as Returned options.<br>" +
                         "3. Select 1 post in the dashboard and click the checkbox.<br><br>" +
                         "<b>Expected Result:</b> Checkbox should be checked.<br>" +
                         "Number of post should be the same based on selected post.<br><br>";
            }
        }

        public static string ContainNumberOfPostSelected
        {
            get
            {
                return "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click the Three Dots on the right side.<br>" +
                         "2. Click Mark as Returned options.<br>" +
                         "3. Select 2 or more post in the dashboard by clicking the checkbox.<br><br>" +
                         "<b>Expected Result:</b> Selected checkbox should be checked.<br>" +
                         "Number of post should be the same based on selected post.<br><br>";
            }
        }

        public static string[] StepsToReplicateFilters = new string[]
        {
             // FILTERS
             // 6.1
             "<b>Steps to Replicate:</b><br>" +
                          "1. Click and enter reference number in search posts textfield.<br>" +
                          "2. Click All hubs dropdown field.<br>" +
                          "3. Click any hubs/store name.<br><br>" +
                          "<b>Expected Result:</b><br> Selected hubs should display.<br>"+
                          "Number of post should be the same based on selected post.<br><br>",
             // 6.6
             "<b>Steps to Replicate:</b><br>" +
                          "1. Click and enter Customer Name in search posts textfield.<br>" +
                          "2. Click All Status dropdown field.<br>" +
                          "3. Click any status.<br><br>" +
                          "<b>Expected Result:</b><br> Selected status should be checked.<br>"+
                          "All post under selected filter should display.<br><br>",
             // 6.11
             "<b>Steps to Replicate:</b><br>" +
                          "1. Click and enter Pickup City in search posts textfield.<br>" +
                          "2. Click All Preferred Partner dropdown field.<br>" +
                          "3. Click any preferred partner.<br><br>" +
                          "<b>Expected Result:</b><br> Selected preferred partner should be display.<br> " +
                          "All post under selected filter should display.<br><br>",
             // 6.16
             "<b>Steps to Replicate:</b><br>" +
                          "1. Click and enter Post Id in search posts textfield.<br>" +
                          "2. Click As of Today dropdown field.<br>" +
                          "3. Click any date.<br><br>" +
                          "<b>Expected Result:</b><br> Selected date should be display.<br> " +
                          "All post under selected filter should display.<br><br>",
             // 6.17
             "<b>Steps to Replicate:</b><br>" +
                          "1. Click and enter Delivery Tracking Number in search posts textfield.<br>" +
                          "2. Click All hubs dropdown field.<br>" +
                          "3. Click any hubs/store name.<br><br>" +
                          "<b>Expected Result:</b><br> Selected hubs should display.<br> " +
                          "All post under selected filter should display.<br><br>",
             // 6.18 [5]
             "<b>Steps to Replicate:</b><br>" +
                          "1. Click and enter reference number in search posts textfield.<br>" +
                          "2. Click All hubs dropdown field.<br>" +
                          "3. Click any hubs/store name.<br>" +
                          "4. Click All Status dropdown field.<br>" +
                          "5. Click any status.<br><br>" +
                          "<b>Expected Result:</b><br> Selected status should be checked.<br> " +
                          "All post under selected filter should display.<br><br>",
             // 6.25
             "<b>Steps to Replicate:</b><br>" +
                          "1. Click and enter Customer Name in search posts textfield.<br>" +
                          "2. Click All hubs dropdown field.<br>" +
                          "3. Click any hubs/store name.<br>" +
                          "4. Click All Preferred Partner dropdown field.<br>" +
                          "5. Click any preferred partner.<br><br>" +
                          "<b>Expected Result:</b><br> Selected preferred partner should be display.<br> " +
                          "All post under selected filter should display.<br><br>",
             // 6.29
             "<b>Steps to Replicate:</b><br>" +
                          "1. Click and enter Pickup City in search posts textfield.<br>" +
                          "2. Click All hubs dropdown field.<br>" +
                          "3. Click any hubs/store name.<br>" +
                          "4. Click As of Today dropdown field.<br>" +
                          "5. Click any date.<br><br>" +
                          "<b>Expected Result:</b><br> Selected date should be display.<br> " +
                          "All post under selected filter should display.<br><br>",
             // 6.30
             "<b>Steps to Replicate:</b><br>" +
                          "1. Click and enter Post Id in search posts textfield.<br>" +
                          "2. Click All hubs dropdown field.<br>" +
                          "3. Click any hubs/store name.<br>" +
                          "4. Click All Status dropdown field.<br>" +
                          "5. Click any status.<br><br>" +
                          "<b>Expected Result:</b><br> Selected status should be checked.<br> " +
                          "All post under selected filter should display.<br><br>",
             // 6.33
             "<b>Steps to Replicate:</b><br>" +
                          "1. Click and enter Delivery Tracking Number in search posts textfield.<br>" +
                          "2. Click All hubs dropdown field.<br>" +
                          "3. Click any hubs/store name.<br>" +
                          "4. Click All Status dropdown field.<br>" +
                          "5. Click any status.<br><br>" +
                          "<b>Expected Result:</b><br> Selected status should be checked.<br> " +
                          "All post under selected filter should display.<br><br>",
             // 6.36 [10]
             "<b>Steps to Replicate:</b><br>" +
                          "1. Click and enter reference number in search posts textfield.<br>" +
                          "2. Click All hubs dropdown field.<br>" +
                          "3. Click any hubs/store name.<br>" +
                          "4. Click All Status dropdown field.<br>" +
                          "5. Click any status.<br>" +
                          "6. Click any preferred partner.<br><br>" +
                          "<b>Expected Result:</b><br> Selected preferred partner should be display.<br> " +
                          "All post under selected filter should display.<br><br>",
             // 6.39
             "<b>Steps to Replicate:</b><br>" +
                          "1. Click and enter Customer Name in search posts textfield.<br>" +
                          "2. Click All hubs dropdown field.<br>" +
                          "3. Click any hubs/store name.<br>" +
                          "4. Click As of Today dropdown field.<br>" +
                          "5. Click any date.<br><br>" +
                          "<b>Expected Result:</b><br> Selected date should be display.<br> " +
                          "All post under selected filter should display.<br><br>",
             // 6.41
             "<b>Steps to Replicate:</b><br>" +
                          "1. Click and enter Pickup City in search posts textfield.<br>" +
                          "2. Click All hubs dropdown field.<br>" +
                          "3. Click any hubs/store name.<br>" +
                          "4. Click As of Today dropdown field.<br>" +
                          "5. Click any date.<br><br>" +
                          "<b>Expected Result:</b><br> Selected date should be display.<br> " +
                          "All post under selected filter should display.<br><br>",
             // 6.42
             "<b>Steps to Replicate:</b><br>" +
                          "1. Click and enter Post Id in search posts textfield.<br>" +
                          "2. Click All hubs dropdown field.<br>" +
                          "3. Click any hubs/store name.<br>" +
                          "4. Click All Status dropdown field.<br>" +
                          "5. Click any status.<br>" +
                          "6. Click any preferred partner.<br><br>" +
                          "<b>Expected Result:</b><br> Selected preferred partner should be display.<br> " +
                          "All post under selected filter should display.<br><br>",
             // 6.44
             "<b>Steps to Replicate:</b><br>" +
                          "1. Click and enter Delivery Tracking Number in search posts textfield.<br>" +
                          "2. Click All hubs dropdown field.<br>" +
                          "3. Click any hubs/store name.<br>" +
                          "4. Click All Status dropdown field.<br>" +
                          "5. Click any status.<br>" +
                          "6. Click any preferred partner.<br><br>" +
                          "<b>Expected Result:</b><br> Selected preferred partner should be display.<br> " +
                          "All post under selected filter should display.<br><br>",
             // 6.46 [15]
             "<b>Steps to Replicate:</b><br>" +
                          "1. Click and enter Reference Number in search posts textfield.<br>" +
                          "2. Click All hubs dropdown field.<br>" +
                          "3. Click any hubs/store name.<br>" +
                          "4. Click All Status dropdown field.<br>" +
                          "5. Click any status.<br>" +
                          "6. Click All Preferred Partner dropdown field.<br>" +
                          "7. Click any preferred partner.<br>" +
                          "8. Click As of Today dropdown field.<br>" +
                          "9. Click any date.<br><br>" +
                          "<b>Expected Result:</b><br> Selected date should be display.<br> " +
                          "All post under selected filter should display.<br><br>",
             // 6.47
             "<b>Steps to Replicate:</b><br>" +
                          "1. Click and enter Customer Name in search posts textfield.<br>" +
                          "2. Click All hubs dropdown field.<br>" +
                          "3. Click any hubs/store name.<br>" +
                          "4. Click All Status dropdown field.<br>" +
                          "5. Click any status.<br>" +
                          "6. Click All Preferred Partner dropdown field.<br>" +
                          "7. Click any preferred partner.<br>" +
                          "8. Click As of Today dropdown field.<br>" +
                          "9. Click any date.<br><br>" +
                          "<b>Expected Result:</b><br> Selected date should be display.<br> " +
                          "All post under selected filter should display.<br><br>",
             // 6.48
             "<b>Steps to Replicate:</b><br>" +
                          "1. Click and enter Pickup City in search posts textfield.<br>" +
                          "2. Click All hubs dropdown field.<br>" +
                          "3. Click any hubs/store name.<br>" +
                          "4. Click All Status dropdown field.<br>" +
                          "5. Click any status.<br>" +
                          "6. Click All Preferred Partner dropdown field.<br>" +
                          "7. Click any preferred partner.<br>" +
                          "8. Click As of Today dropdown field.<br>" +
                          "9. Click any date.<br><br>" +
                          "<b>Expected Result:</b><br> Selected date should be display.<br> " +
                          "All post under selected filter should display.<br><br>",
             // 6.49
             "<b>Steps to Replicate:</b><br>" +
                          "1. Click and enter Post Id in search posts textfield.<br>" +
                          "2. Click All hubs dropdown field.<br>" +
                          "3. Click any hubs/store name.<br>" +
                          "4. Click All Status dropdown field.<br>" +
                          "5. Click any status.<br>" +
                          "6. Click All Preferred Partner dropdown field.<br>" +
                          "7. Click any preferred partner.<br>" +
                          "8. Click As of Today dropdown field.<br>" +
                          "9. Click any date.<br><br>" +
                          "<b>Expected Result:</b><br> Selected date should be display.<br> " +
                          "All post under selected filter should display.<br><br>",
             // 6.50
             "<b>Steps to Replicate:</b><br>" +
                          "1. Click and enter Delivery Tracking Number in search posts textfield.<br>" +
                          "2. Click All hubs dropdown field.<br>" +
                          "3. Click any hubs/store name.<br>" +
                          "4. Click All Status dropdown field.<br>" +
                          "5. Click any status.<br>" +
                          "6. Click All Preferred Partner dropdown field.<br>" +
                          "7. Click any preferred partner.<br>" +
                          "8. Click As of Today dropdown field.<br>" +
                          "9. Click any date.<br><br>" +
                          "<b>Expected Result:</b><br> Selected date should be display.<br> " +
                          "All post under selected filter should display.<br><br>",
             // 6.51 [20]
             "<b>Steps to Replicate:</b><br>" +
                          "1. Click All hubs dropdown field.<br>" +
                          "2. Click any hubs/store name.<br>" +
                          "3. Click All Status dropdown field.<br>" +
                          "4. Click any status.<br><br>" +
                          "<b>Expected Result:</b><br> Selected status should be checked.<br> " +
                          "All post under selected filter should display.<br><br>",
             // 6.52
             "<b>Steps to Replicate:</b><br>" +
                          "1. Click All hubs dropdown field.<br>" +
                          "2. Click any hubs/store name.<br>" +
                          "3. Click All Preferred Partner dropdown field.<br>" +
                          "4. Click any preferred partner.<br><br>" +
                          "<b>Expected Result:</b><br> Selected preferred partner should be display.<br> " +
                          "All post under selected filter should display.<br><br>",
             // 6.53
             "<b>Steps to Replicate:</b><br>" +
                          "1. Click All hubs dropdown field.<br>" +
                          "2. Click any hubs/store name.<br>" +
                          "3. Click As of Today dropdown field.<br>" +
                          "4. Click any date.<br><br>" +
                          "<b>Expected Result:</b><br> Selected date should be display.<br> " +
                          "All post under selected filter should display.<br><br>",
             // 6.54
             "<b>Steps to Replicate:</b><br>" +
                          "1. Click All Status dropdown field.<br>" +
                          "2. Click any status.<br>" +
                          "3. Click All Preferred Partner dropdown field.<br>" +
                          "4. Click any preferred partner.<br><br>" +
                          "<b>Expected Result:</b><br> Selected preferred partner should be display.<br> " +
                          "All post under selected filter should display.<br><br>",
             // 6.55
             "<b>Steps to Replicate:</b><br>" +
                          "1. Click All Status dropdown field.<br>" +
                          "2. Click any status.<br>" +
                          "3. Click As of Today dropdown field.<br>" +
                          "4. Click any date.<br><br>" +
                          "<b>Expected Result:</b><br> Selected date should be display.<br> " +
                          "All post under selected filter should display.<br><br>",
             // 6.56 [25]
             "<b>Steps to Replicate:</b><br>" +
                          "1. Click All Preferred Partner dropdown field.<br>" +
                          "2. Click any preferred partner.<br>" +
                          "3. Click As of Today dropdown field.<br>" +
                          "4. Click any date.<br><br>" +
                          "<b>Expected Result:</b><br> Selected date should be display.<br> " +
                          "All post under selected filter should display.<br><br>",
             // 6.57
             "<b>Steps to Replicate:</b><br>" +
                          "1. Click All hubs dropdown field.<br>" +
                          "2. Click any hubs/store name.<br>" +
                          "3. Click All Status dropdown field.<br>" +
                          "4. Click any status.<br>" +
                          "5. Click All Preferred Partner dropdown field.<br>" +
                          "6. Click any preferred partner.<br>" +
                          "7. Click As of Today dropdown field.<br>" +
                          "8. Click any date.<br><br>" +
                          "<b>Expected Result:</b><br> Selected date should be display.<br> " +
                          "All post under selected filter should display.<br><br>",
             // 6.58
             "<b>Steps to Replicate:</b><br>" +
                          "1. Click All hubs dropdown field.<br>" +
                          "2. Click any hubs/store name.<br>" +
                          "3. Click All Status dropdown field.<br>" +
                          "4. Click any status.<br>" +
                          "5. Click All Preferred Partner dropdown field.<br>" +
                          "6. Click any preferred partner.<br><br>" +
                          "<b>Expected Result:</b><br> Selected preferred partner should be display.<br> " +
                          "All post under selected filter should display.<br><br>",
             // 6.59
             "<b>Steps to Replicate:</b><br>" +
                          "1. Click All Status dropdown field.<br>" +
                          "2. Click any status.<br>" +
                          "3. Click All Preferred Partner dropdown field.<br>" +
                          "4. Click any preferred partner.<br>" +
                          "5. Click As of Today dropdown field.<br>" +
                          "6. Click any date.<br><br>" +
                          "<b>Expected Result:</b><br> Selected date should be display.<br> " +
                          "All post under selected filter should display.<br><br>",
             // 6.60 [29]
             "<b>Steps to Replicate:</b><br>" +
                          "1. Click All hubs dropdown field.<br>" +
                          "2. Click any hubs/store name.<br>" +
                          "3. Click All Preferred Partner dropdown field.<br>" +
                          "4. Click any preferred partner.<br>" +
                          "5. Click As of Today dropdown field.<br>" +
                          "6. Click any date.<br><br>" +
                          "<b>Expected Result:</b><br> Selected date should be display.<br> " +
                          "All post under selected filter should display.<br><br>",
        };


    }
}

