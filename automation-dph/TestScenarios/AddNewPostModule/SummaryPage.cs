
namespace automation_dph.TestScenarios.AddNewPostModule
{
	public class SummaryPage : BasePageDriver
	{
		public SummaryPage(IPage page, PageTest pageTest) : base(page, pageTest)
		{

		}

		public static string[] TestScenariosSummaryPage = new string[]
		{
            "4.15.1 Validate Inputted value from ondemand Pickup Customer name", //[0]
			"4.15.2 Validate Inputted value from ondemand Pickup Mobile",
            "4.15.3 Validate Inputted value from ondemand Pickup Email",
            "4.15.4 Validate Inputted value from ondemand Completion Pickup Date and Time",
            "4.15.5 Validate Inputted value from ondemand Pickup Address",
            "4.15.6 Validate Inputted value from ondemand Pickup Barangay", //[5]
			"4.15.7 Validate Inputted value from ondemand Pickup City",
            "4.15.8 Validate Inputted value from ondemand Pickup Province",
            "4.15.9 Validate Inputted value from ondemand Pickup Postal Address",
            "4.15.10 Validate Inputted value from ondemand Pickup Remarks",
            "4.15.11 Validate Inputted value from ondemand Delivery Customer Name", //[10]
			"4.15.12 Validate Inputted value from ondemand Delivery Mobile",
            "4.15.13 Validate Inputted value from ondemand Delivery Email",
            "4.15.14 Validate Inputted value from ondemand Completion Delivery Date and Time",
            "4.15.15 Validate Inputted value from ondemand Delivery Address",
            "4.15.16 Validate Inputted value from ondemand Delivery Barangay", //[15]
			"4.15.17 Validate Inputted value from ondemand Delivery City",
            "4.15.18 Validate Inputted value from ondemand Delivery Province",
            "4.15.19 Validate Inputted value from ondemand Delivery Postal Address",
            "4.15.20 Validate Inputted value from ondemand Delivery Quantity",
            "4.15.22 Validate Inputted value from ondemand Delivery Weight", //[20]
            "4.15.24 Validate Inputted value from ondemand Delivery COD Amount",
            "4.15.25 Validate Inputted value from ondemand Delivery Declared value",
            "4.15.29 Validate Inputted value from ondemand Delivery Item Description",
            "4.15.30 Validate Inputted value from ondemand Delivery Remarks",
            "4.15.31 Validate Inputted value from ondemand Pickup Reference Number", //[25]
			"4.15.32 Validate Selected value from ondemand Courier partner",
            "4.15.33 Validate Selected ondemand courier type",
            // scheduled
            "4.16.1 Validate Inputted value from scheduled Pickup Customer name",
            "4.16.2 Validate Inputted value from scheduled Pickup Mobile",
            "4.16.3 Validate Inputted value from scheduled Pickup Email", //[30]
            "4.16.4 Validate Inputted value from scheduled Completion Pickup Date and Time",
            "4.16.5 Validate Inputted value from scheduled Pickup Address",
            "4.16.6 Validate Inputted value from scheduled Pickup Barangay",
            "4.16.7 Validate Inputted value from scheduled Pickup City",
            "4.16.8 Validate Inputted value from scheduled Pickup Province", //[35]
            "4.16.9 Validate Inputted value from scheduled Pickup Postal Address",
            "4.16.10 Validate Inputted value from scheduled Pickup Remarks",
            "4.16.11 Validate Inputted value from scheduled Delivery Customer Name",
            "4.16.12 Validate Inputted value from scheduled Delivery Mobile",
            "4.16.13 Validate Inputted value from scheduled Delivery Email", //[40]
            "4.16.14 Validate Inputted value from scheduled Completion Delivery Date and Time",
            "4.16.15 Validate Inputted value from scheduled Delivery Address",
            "4.16.16 Validate Inputted value from scheduled Delivery Barangay",
            "4.16.17 Validate Inputted value from scheduled Delivery City",
            "4.16.18 Validate Inputted value from scheduled Delivery Province", //[45]
            "4.16.19 Validate Inputted value from scheduled Delivery Postal Address",
            "4.16.20 Validate Inputted value from scheduled Delivery Quantity",
            "4.16.22 Validate Inputted value from scheduled Delivery Weight",
            "4.16.24 Validate Inputted value from scheduled Delivery COD Amount",
            "4.16.25 Validate Inputted value from scheduled Delivery Declared value", //[50]
            "4.16.29 Validate Inputted value from scheduled Delivery Item Description",
            "4.16.30 Validate Inputted value from scheduled Delivery Remarks",
            "4.16.31 Validate Inputted value from scheduled Pickup Reference Number",
            "4.16.32 Validate Selected value from scheduled Courier partner",
            "4.16.33 Validate Selected scheduled courier type", //[55]
        };

		public static string StepsToReplicateSummaryPage
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
                         "10. Click Next Step button.<br>" +
                         "11. Fill-out all required field, if no require field to fill-out click Next Step button.<br>" +
                         "11. Verify inputted value in customer name.<br><br>" +
                         "<b>Expected Result:</b><br> Inputted value should display.<br><br>";
			}
		}

	}
}

