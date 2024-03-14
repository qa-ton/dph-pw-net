
namespace automation_dph.TestScenarios.AddNewPostModule
{
	public class SelectCourierPage : BasePageDriver
    {
		public SelectCourierPage(IPage page, PageTest pageTest) : base(page, pageTest)
		{

		}

        public static string[] TestScenariosSelectCourier = new string[]
        {
            "4.11.1 Validate Courier Pickup date for Lalamove", //[0]
            "4.11.2 Validate Courier Delivery time for Lalamove",
            "",
            "",
            "",
            "", //[5]
            "",
        };

        public static string StepsToReplicatePickupDateSelectCourier
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
                         "8. Verify Pickup date for Lalamove courier.<br><br>" +
                         "<b>Expected Result:</b><br> Pickup date display should based on pickup date and time selected.<br><br>";
            }
        }

        public static string StepsToReplicateDeliveryTimeSelectCourier
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
                         "8. Verify Delivery Time for Lalamove courier.<br><br>" +
                         "<b>Expected Result:</b><br> Delivery Time display should based on delivery date and time selected.<br><br>";
            }
        }

    }
}

