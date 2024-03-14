
namespace automation_dph.TestScenarios.AddNewPostModule
{
	public class PinnedLocations : BasePageDriver
	{
		public PinnedLocations(IPage page, PageTest pageTest) : base(page, pageTest)
		{
		}


		public static string[] TestScenariosPinnedLocations = new string[]
		{
            "4.21.2 Validate Save Pin locations for ondemand pickup", //[0]
			"4.21.3 Validate Remove Pin locations for ondemand pickup",
            "4.21.4 Validate Edit Pin locations for ondemand pickup",
            "4.21.5 Validate Auto suggest location for ondemand pickup",
            "4.21.10 Validate Invalid value in Locate address text field for ondemand pickup",
            "4.21.11 Validate Blank value in Locate address text field for ondemand pickup", //[5]
			"4.21.12 Validate Close modal functionality for ondemand pickup",
            "4.21.13 Validate Clear Pin location for ondemand pickup",

            "4.22.2 Validate Save Pin locations for ondemand delivery",
			"4.22.3 Validate Remove Pin locations for ondemand delivery",
            "4.22.4 Validate Edit Pin locations for ondemand delivery", //[10]
            "4.22.5 Validate Auto suggest location for ondemand delivery",
            "4.22.10 Validate Invalid value in Locate address text field for ondemand delivery",
            "4.22.11 Validate Blank value in Locate address text field for ondemand delivery",
			"4.22.12 Validate Close modal functionality for ondemand delivery",
            "4.22.13 Validate Clear Pin location for ondemand delivery", //[15]

            "4.25.2 Validate Save Pin locations for ondemand pickup",
			"4.25.3 Validate Remove Pin locations for ondemand pickup",
            "4.25.4 Validate Edit Pin locations for ondemand pickup",
            "4.25.5 Validate Auto suggest location for ondemand pickup",
            "4.25.10 Validate Invalid value in Locate address text field for ondemand pickup", //[20]
            "4.25.11 Validate Blank value in Locate address text field for ondemand pickup",
			"4.25.12 Validate Close modal functionality for ondemand pickup",
            "4.25.13 Validate Clear Pin location for ondemand pickup",

            "4.26.2 Validate Save Pin locations for ondemand delivery",
            "4.26.3 Validate Remove Pin locations for ondemand delivery", //[25]
            "4.26.4 Validate Edit Pin locations for ondemand delivery",
            "4.26.5 Validate Auto suggest location for ondemand delivery",
            "4.26.10 Validate Invalid value in Locate address text field for ondemand delivery",
            "4.26.11 Validate Blank value in Locate address text field for ondemand delivery",
            "4.26.12 Validate Close modal functionality for ondemand delivery", //[30]
            "4.26.13 Validate Clear Pin location for ondemand delivery",
        };

		public static string SavePinLocation
		{
			get
			{
				return "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click Add New Posts button.<br>" +
                         "2. Click On Demand/Scheduled Delivery checkbox field.<br>" +
                         "3. Click Next Step button.<br>" +
                         "4. Input value in Address textbox field.<br>" +
                         "5. Click Pin button.<br>" +
                         "6. Input value in Complete Address textbox field.<br>" +
                         "7. Click Save Pin button.<br><br>" +
                         "<b>Expected Result:</b><br> Success notification should display.<br>" +
                                                "\"Pinned\" button should display.<br><br>";
            }
		}

        public static string RemovePinLocation
        {
            get
            {
                return "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click Add New Posts button.<br>" +
                         "2. Click On Demand/Scheduled Delivery checkbox field.<br>" +
                         "3. Click Next Step button.<br>" +
                         "4. Input value in Address textbox field.<br>" +
                         "5. Click Pin button.<br>" +
                         "6. Input value in Complete Address textbox field.<br>" +
                         "7. Click Save Pin button.<br>" +
                         "8. Click Pinned button.<br>" +
                         "9. Click Remove Pin button.<br><br>" +
                         "<b>Expected Result:</b><br> Success notification should display.<br>" +
                                                "\"Pinned\" button should display.<br><br>";
            }
        }

        public static string EditPinLocation
        {
            get
            {
                return "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click Add New Posts button.<br>" +
                         "2. Click On Demand/Scheduled Delivery checkbox field.<br>" +
                         "3. Click Next Step button.<br>" +
                         "4. Input value in Address textbox field.<br>" +
                         "5. Click Pin button.<br>" +
                         "6. Input value in Complete Address textbox field.<br>" +
                         "7. Click Save Pin button.<br>" +
                         "8. Click Pinned button.<br>" +
                         "9. Edit value in complete address textbox field.<br>" +
                         "10. Click Save Pin button.<br><br>" +
                         "<b>Expected Result:</b><br> Success notification should display.<br>" +
                                                "Updated value should display in address textboxt field.<br><br>";
            }
        }

        public static string AutoSuggestLocations
        {
            get
            {
                return "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click Add New Posts button.<br>" +
                         "2. Click On Demand/Scheduled Delivery checkbox field.<br>" +
                         "3. Click Next Step button.<br>" +
                         "4. Input value in Address textbox field.<br>" +
                         "5. Click Pin button.<br>" +
                         "6. Input value in Complete Address textbox field.<br>" +
                         "7. Verify the auto suggestions.<br><br>" +
                         "<b>Expected Result:</b><br> List suggested addresses should display.<br><br>";
            }
        }

        public static string InvalidValueLocation
        {
            get
            {
                return "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click Add New Posts button.<br>" +
                         "2. Click On Demand/Scheduled Delivery checkbox field.<br>" +
                         "3. Click Next Step button.<br>" +
                         "4. Input value in Address textbox field.<br>" +
                         "5. Click Pin button.<br>" +
                         "6. Input invalid value in Complete Address textbox field.<br><br>" +
                         "<b>Expected Result:</b><br> Error notification message should appear.<br><br>";
            }
        }

        public static string BlankValueLocation
        {
            get
            {
                return "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click Add New Posts button.<br>" +
                         "2. Click On Demand/Scheduled Delivery checkbox field.<br>" +
                         "3. Click Next Step button.<br>" +
                         "4. Input value in Address textbox field.<br>" +
                         "5. Click Pin button.<br>" +
                         "6. Input blank(spacebar) value in Complete Address textbox field.<br><br>" +
                         "<b>Expected Result:</b><br> Error notification message should appear.<br><br>";
            }
        }

        public static string CloseModal
        {
            get
            {
                return "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click Add New Posts button.<br>" +
                         "2. Click On Demand/Scheduled Delivery checkbox field.<br>" +
                         "3. Click Next Step button.<br>" +
                         "4. Input value in Address textbox field.<br>" +
                         "5. Click Pin button.<br>" +
                         "6. Click Close x button.<br><br>" +
                         "<b>Expected Result:</b><br> Locate address window should close.<br><br>";
            }
        }

        public static string ClearPinLocation
        {
            get
            {
                return "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click Add New Posts button.<br>" +
                         "2. Click On Demand/Scheduled Delivery checkbox field.<br>" +
                         "3. Click Next Step button.<br>" +
                         "4. Input value in Address textbox field.<br>" +
                         "5. Click Pin button.<br>" +
                         "6. Input value in Complete Address textbox field.<br>" +
                         "5. Click Pin button.<br>" +
                         "6. Click Close x button.<br><br>" +
                         "<b>Expected Result:</b><br> Locate address window should close.<br><br>";
            }
        }

    }
}

