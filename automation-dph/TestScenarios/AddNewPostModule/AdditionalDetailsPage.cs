
namespace automation_dph.TestScenarios.AddNewPostModule
{
	public class AdditionalDetailsPage : BasePageDriver
    {
        public AdditionalDetailsPage(IPage page, PageTest pageTest) : base(page, pageTest)
        {

        }

        public static string[] TestScenariosAdditionalDetails = new string[]
        {
            "4.13.1 Validate ondemand Additional details page", //[0]
            "4.13.2 Validate ondemand Previous Step functionality",
            "4.13.3 Validate a Courier that No additional details ondemand to display",
            "4.13.4 Validate ondemand Additional Details hyperlink",
            "4.13.5 Validate ondemand Additional Details hyperlink if selected courier has no metafields",
            "4.14.1 Validate scheduled Additional details page", //[5]
            "4.14.2 Validate scheduled Previous Step functionality",
            "4.14.3 Validate a Courier that No additional details scheduled to display",
            "4.14.4 Validate scheduled Additional Details hyperlink",
            "4.14.5 Validate scheduled Additional Details hyperlink if selected courier has no metafields",
        };

        public static string StepsToReplicateAdditionalDetailsPage
        {
            get
            {
                return "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click Add New Posts button.<br>" +
                         "2. Click On Demand/Scheduled Delivery checkbox field.<br>" +
                         "3. Click Next Step button.<br>" +
                         "4. Fill-out all required fields or; Click Auto-fill Pickup Details button.<br>" +
                         "5. Click Next Step button.<br>" +
                         "6. Fill-out all required fields or; Click Auto-fill Delivery Details button.<br>" +
                         "7. Click Next Step button.<br>" +
                         "8. Select any vehicle type in dropdown field.<br>" +
                         "9. Select any courier.<br>" +
                         "10. Click Next Step button.<br><br>" +
                         "<b>Expected Result:</b><br> Additional Details page should display.<br><br>";
            }
        }
    }
}

