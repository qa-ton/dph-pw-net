
namespace automation_dph.TestScenarios.AddNewPostModule
{
	public class Tags : BasePageDriver
	{
		public Tags(IPage page, PageTest pageTest) : base(page, pageTest)
		{

		}

		public static string[] TestScenariosPinnedLocations = new string[]
		{
            "4.29.1 Validate Add tags for Ondemand Pickup", //[0]
			"4.29.3 Validate Select tag for Ondemand Pickup",
            "4.29.4 Validate Select multiple tags for Ondemand Pickup",
            "4.29.6 Validate List of tags for Ondemand Pickup",
            "4.29.7 Validate Blank value in Tags for Ondemand Pickup",
            "4.29.8 Validate Max Length value in Tags for Ondemand Pickup", //[5]
			"4.29.9 Validate display Inputted value in pickup tags summary page for Ondemand Pickup",
            "4.29.10 Validate Invalid value in Tags for Ondemand Pickup",

            "4.30.1 Validate Add tags for Ondemand Delivery",
			"4.30.3 Validate Select tag for Ondemand Delivery",
            "4.30.4 Validate Select multiple tags for Ondemand Delivery", //[10]
            "4.30.6 Validate List of tags for Ondemand Delivery",
            "4.30.7 Validate Blank value in Tags for Ondemand Delivery",
            "4.30.8 Validate Max Length value in Tags for Ondemand Delivery",
			"4.30.9 Validate display Inputted value in delivery tags summary page for Ondemand Delivery",
            "4.30.10 Validate Invalid value in Tags for Ondemand Delivery", //[15]

            "4.33.1 Validate Add tags for Ondemand Pickup",
			"4.33.3 Validate Select tag for Ondemand Pickup",
            "4.33.4 Validate Select multiple tags for Ondemand Pickup",
            "4.33.6 Validate List of tags for Ondemand Pickup",
            "4.33.7 Validate Blank value in Tags for Ondemand Pickup", //[20]
            "4.33.8 Validate Max Length value in Tags for Ondemand Pickup",
			"4.33.9 Validate display Inputted value in pickup tags summary page for Ondemand Pickup",
            "4.33.10 Validate Invalid value in Tags for Ondemand Pickup",

            "4.34.1 Validate Add tags for Ondemand Delivery",
            "4.34.3 Validate Select tag for Ondemand Delivery", //[25]
            "4.34.4 Validate Select multiple tags for Ondemand Delivery",
            "4.34.6 Validate List of tags for Ondemand Delivery",
            "4.34.7 Validate Blank value in Tags for Ondemand Delivery",
            "4.34.8 Validate Max Length value in Tags for Ondemand Delivery",
            "4.34.9 Validate display Inputted value in delivery tags summary page for Ondemand Delivery", //[30]
            "4.34.10 Validate Invalid value in Tags for Ondemand Delivery",
        };

		public static string AddTags
		{
			get
			{
                return "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click Add New Posts button.<br>" +
                         "2. Click On Demand/Scheduled Delivery checkbox field.<br>" +
                         "3. Click Next Step button.<br>" +
                         "4. Input value in Tags dropdown field.<br><br>" +
                         "<b>Expected Result:</b><br> Inputted value should display.<br>" +
                                                "Added tags should display on the list of tags.<br><br>";
            }
		}

		public static string SelectTag
		{
			get
			{
                return "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click Add New Posts button.<br>" +
                         "2. Click On Demand/Scheduled Delivery checkbox field.<br>" +
                         "3. Click Next Step button.<br>" +
                         "4. Click Tags dropdown field and select any tags.<br><br>" +
                         "<b>Expected Result:</b><br> Selected value should display.<br><br>";
            }
		}

		public static string SelectMultipleTag
		{
			get
			{
                return "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click Add New Posts button.<br>" +
                         "2. Click On Demand/Scheduled Delivery checkbox field.<br>" +
                         "3. Click Next Step button.<br>" +
                         "4. Click Tags dropdown field and select multiple tags.<br><br>" +
                         "<b>Expected Result:</b><br> Selected value should display.<br><br>";
            }
		}

		public static string ListOfTags
		{
			get
			{
                return "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click Add New Posts button.<br>" +
                         "2. Click On Demand/Scheduled Delivery checkbox field.<br>" +
                         "3. Click Next Step button.<br>" +
                         "4. Click Tags dropdown field.<br>" +
                         "5. Verify List of tags.<br><br>" +
                         "<b>Expected Result:</b><br> All tag should display on the list.<br><br>";
            }
		}

		public static string BlankValue
		{
			get
			{
                return "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click Add New Posts button.<br>" +
                         "2. Click On Demand/Scheduled Delivery checkbox field.<br>" +
                         "3. Click Next Step button.<br>" +
                         "4. Input blank(spacebar) value in Tags dropdown field.<br><br>" +
                         "<b>Expected Result:</b><br> Inputted value should not display.<br>" +
                                                "Unable to input blank value.<br><br>";
            }
		}

        public static string MaxLengthValue
        {
            get
            {
                return "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click Add New Posts button.<br>" +
                         "2. Click On Demand/Scheduled Delivery checkbox field.<br>" +
                         "3. Click Next Step button.<br>" +
                         "4. Input max length value in Tags dropdown field.<br><br>" +
                         "<b>Expected Result:</b><br> Inputted value should display.<br>" +
                                                "Should not exceed max value.<br><br>";
            }
        }

        public static string DisplayInputtedValue
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
                         "7. Click Next Step button.br>" +
                         "8. Select any vehicle type in dropdown field.<br>" +
                         "9. Select any courier.<br>" +
                         "10. Click Next Step button.<br>" +
                         "11. Fill-out all required field, if no require field to fill-out click Next Step button.4. Click Tags dropdown field.<br>" +
                         "12. Verify inputted value in pickup tags.<br><br>" +
                         "<b>Expected Result:</b><br> Inputted value should display.<br><br>";
            }
        }

        public static string InvalidValue
        {
            get
            {
                return "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click Add New Posts button.<br>" +
                         "2. Click On Demand/Scheduled Delivery checkbox field.<br>" +
                         "3. Click Next Step button.<br>" +
                         "4. Input invalid value in Tags dropdown field.<br>" +
                         "5. Hit enter.<br><br>" +
                         "<b>Expected Result:</b><br> Inputted value should display.<br>" +
                                                "Added tags should display on the list of tags.<br><br>";
            }
        }

    }
}

