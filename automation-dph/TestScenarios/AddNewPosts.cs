
namespace automation_dph.TestScenarios
{
	public class AddNewPosts : BasePageDriver
	{
		public AddNewPosts(IPage page, PageTest pageTest) : base(page, pageTest)
		{

        }


        public static string[] TestScenariosScheduledPosts = new string[]
		{
            "4.6.1 Validate Ondemand Post List of vehicles",
            "4.6.2 Validate Scheduled Post List of vehicles",
            "4.6.3 Validate No selected schedule post",
            "4.6.4 Validate Schedule Post hyperlink",
        };


        public static string[] TestScenariosPickupDetails = new string[]
        {
            "4.7.1 Validate Valid value in ondemand pickup Reference Number", //[0]
            "4.7.2 Validate Valid value in ondemand pickup Sender Name",
            "4.7.3 Validate Valid value in ondemand pickup Mobile Number",
            "4.7.4 Validate Valid value in ondemand pickup Email Address",
            "4.7.5 Validate Valid value in ondemand pickup Address",
            "4.7.6 Validate Valid value in ondemand pickup Province", //[5]
            "4.7.7 Validate Valid value in ondemand pickup City",
            "4.7.8 Validate Valid value in ondemand pickup Barangay",
            "4.7.9 Validate Valid value in ondemand pickup Postal Code",
            "4.7.10 Validate Valid value in ondemand Pickup Date & Time",
            "4.7.11 Validate Valid value in ondemand pickup Hub", //[10]
            "4.7.12 Validate Valid value in ondemand pickup Remarks",
            "4.7.13 Validate Clear functionality of ondemand pickup Province dropdown field",
            "4.7.14 Validate Clear functionality of ondemand pickup City dropdow field",
            "4.7.15 Validate Clear functionality of ondemand pickup Barangay dropdown field",
            "4.7.16 Validate ondemand pickup Previous Step functionality", //[15]
            "4.7.18 Validate ondemand Pickup Details hyperlink",
            "4.7.24 Validate Invalid value in ondemand pickup Reference Number",
            "4.7.25 Validate Invalid value in ondemand pickup Sender Name",
            "4.7.26 Validate Invalid value in ondemand pickup Mobile Number",
            "4.7.27 Validate Invalid value in ondemand pickup Email Address", //[20]
            "4.7.29 Validate Invalid value in ondemand pickup Postal Code", // negative sscenarios
            "4.7.30 Validate Invalid value in ondemand pickup Remarks",
            "4.7.31 Validate Blank value in ondemand pickup Reference Number",
            "4.7.32 Validate Blank value in ondemand pickup Sender Name",
            "4.7.33 Validate Blank value in ondemand pickup Mobile Number", //[25]
            "4.7.34 Validate Blank value in ondemand pickup Email Address",
            "4.7.36 Validate Blank value in ondemand pickup Province",
            "4.7.37 Validate Blank value in ondemand pickup City",
            "4.7.38 Validate Blank value in ondemand pickup Barangay",
            "4.7.39 Validate Blank value in ondemand pickup Postal Code", //[30]
            "4.7.40 Validate Blank value in ondemand pickup Remarks",
            "4.7.41 Validate Max Length value in ondemand pickup Reference Number",
            "4.7.42 Validate Max Length value in ondemand pickup Sender Name",
            "4.7.43 Validate Max Length value in ondemand pickup Mobile Number",
            "4.7.44 Validate Max Length value in ondemand pickup Email Address", //[35]
            "4.7.45 Validate Max Length value in ondemand pickup Address",
            "4.7.46 Validate Max Length value in ondemand pickup Postal Code",
            "4.7.47 Validate Max Length in ondemand pickup Remarks",
            "4.8.1 Validate Valid value in scheduled pickup Reference Number",
            "4.8.2 Validate Valid value in scheduled pickup Sender Name", //[40]
            "4.8.3 Validate Valid value in scheduled pickup Mobile Number",
            "4.8.4 Validate Valid value in scheduled pickup Email Address",
            "4.8.5 Validate Valid value in scheduled pickup Address",
            "4.8.6 Validate Valid value in scheduled pickup Province",
            "4.8.7 Validate Valid value in scheduled pickup City", //[45]
            "4.8.8 Validate Valid value in scheduled pickup Barangay",
            "4.8.9 Validate Valid value in scheduled pickup Postal Code",
            "4.8.10 Validate Valid value in scheduled Pickup Date & Time",
            "4.8.11 Validate Valid value in scheduled pickup Hub",
            "4.8.12 Validate Valid value in scheduled pickup Remarks", //[50]
            "4.8.13 Validate Clear functionality of scheduled pickup Province dropdown field",
            "4.8.14 Validate Clear functionality of scheduled pickup City dropdow field",
            "4.8.15 Validate Clear functionality of scheduled pickup Barangay dropdown field",
            "4.8.16 Validate scheduled pickup Previous Step functionality",
            "4.8.18 Validate scheduled Pickup Details hyperlink", //[55]
            "4.8.24 Validate Invalid value in scheduled pickup Reference Number",
            "4.8.25 Validate Invalid value in scheduled pickup Sender Name",
            "4.8.26 Validate Invalid value in scheduled pickup Mobile Number",
            "4.8.27 Validate Invalid value in scheduled pickup Email Address",
            "4.8.29 Validate Invalid value in scheduled pickup Postal Code", //[60]
            "4.8.30 Validate Invalid value in scheduled pickup Remarks",
            "4.8.31 Validate Blank value in scheduled pickup Reference Number",
            "4.8.32 Validate Blank value in scheduled pickup Sender Name",
            "4.8.33 Validate Blank value in scheduled pickup Mobile Number",
            "4.8.34 Validate Blank value in scheduled pickup Email Address", //[65]
            "4.8.36 Validate Blank value in scheduled pickup Province",
            "4.8.37 Validate Blank value in scheduled pickup City",
            "4.8.38 Validate Blank value in scheduled pickup Barangay",
            "4.8.39 Validate Blank value in scheduled pickup Postal Code",
            "4.8.40 Validate Blank value in scheduled pickup Remarks", //[70]
            "4.8.41 Validate Max Length value in scheduled pickup Reference Number",
            "4.8.42 Validate Max Length value in scheduled pickup Sender Name",
            "4.8.43 Validate Max Length value in scheduled pickup Mobile Number",
            "4.8.44 Validate Max Length value in scheduled pickup Email Address",
            "4.8.45 Validate Max Length value in scheduled pickup Address", //[75]
            "4.8.46 Validate Max Length value in scheduled pickup Postal Code",
            "4.8.47 Validate Max Length in scheduled pickup Remarks",
        };


        public static string StepsToReplicateScheduledPost
		{
			get
			{
                return "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click Add New Post button.<br>" +
                         "2. Select and click On Demand Delivery/Scheduled Delivery checkbox.<br>" +
                         "3. Click Next Step button.field.<br>" +
                         "4. Fill-out all required fields or; Click Auto-fill Pickup Details button.<br>" +
                         "5. Click Next Step button.<br>" +
                         "6. Fill-out all required fields or; Click Auto-fill Delivery Details button.<br>" +
                         "7. Click Next Step button.<br>" +
                         "8. Verify Ondemand/Scheduled couriers.<br><br>" +
                         "<b>Expected Result:</b><br> List of ondemand/scheduled courier should display.<br><br>";
            }
		}
        
        public static string StepsToReplicateNoSelectedValuePost
        {
            get
            {
                return "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click Add New Post button.<br>" +
                         "2. Dont click any Delivery type checkbox.<br>" +
                         "3. Click Next Step button.<br><br>" +
                         "<b>Expected Result:</b><br> Error message should appear.<br><br>";
            }
        }

        public static string StepsToReplicateSchedueldLinkPage
        {
            get
            {
                return "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click Add New Post button.<br>" +
                         "2. Select and click any Delivery type checkbox.<br>" +
                         "3. Dont click any Delivery type checkbox.<br>" +
                         "4. Click Next Step button.<br><br>" +
                         "<b>Expected Result:</b><br> Click Scheduled Post hyperlink.<br><br>";
            }
        }


        public static string StepsToReplicateValidValue
        {
            get
            {
                return "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click Add New Post button.<br>" +
                         "2. Select and click On Demand or Scheduled Delivery checkbox.<br>" +
                         "3. Click Next Step button.field.<br>" +
                         "4. Fill-out all required fields or; Click Auto-fill Pickup Details button.<br>" +
                         "5. Input an valid value.<br>" +
                         "6. Click Next Step button.<br><br>" +
                         "<b>Expected Result:</b><br> Delivery Details page should display.<br>" +
                         "Should able to proceed to next step without any errors..<br><br>";
            }
        }

        public static string StepsToReplicateClearDropdownFunctionality
        {
            get
            {
                return "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click Add New Post button.<br>" +
                         "2. Click On Demand or Scheduled Delivery checkbox field.<br>" +
                         "3. Click Next Step button.<br>" +
                         "4. Fill-out all required fields or; Click Auto-fill Pickup Details button.<br>" +
                         "5. Click x inside Province dropdown field.<br><br>" +
                         "<b>Expected Result:</b><br> Selected value inside Province, City and Barangay dropdown field should be clear.<br><br>";
            }
        }

        public static string StepsToReplicatePreviousStepFunctionality
        {
            get
            {
                return "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click Add New Post button.<br>" +
                         "2. Click On Demand or Scheduled Delivery checkbox field.<br>" +
                         "3. Click Next Step button.field.<br>" +
                         "4. Click Previous Step button field.<br><br>" +
                         "<b>Expected Result:</b><br> Scheduled Post page should display.<br>" +
                         "Should able to back to previous step without any errors.<br><br>";
            }
        }

        public static string StepsToReplicatePickupDetailsHyperlink
        {
            get
            {
                return "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click Add New Post button.<br>" +
                         "2. Click On Demand or Scheduled Delivery checkbox field.<br>" +
                         "3. Click Next Step button.<br>" +
                         "4. Fill-out all required fields or; Click Auto-fill Pickup Details button.<br>" +
                         "5. Click Next Step button.<br>" +
                         "6. Click Pickup Details hyperlink.<br><br>" +
                         "<b>Expected Result:</b><br> Pickup Details page should display.<br><br>";
            }
        }

        public static string StepsToReplicateInvalidValue
        {
            get
            {
                return "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click Add New Post button.<br>" +
                         "2. Select and click On Demand or Scheduled Delivery checkbox.<br>" +
                         "3. Click Next Step button.field.<br>" +
                         "4. Fill-out all required fields or; Click Auto-fill Pickup Details button.<br>" +
                         "5. Input an invalid value.<br>" +
                         "6. Click Next Step button.<br><br>" +
                         "<b>Expected Result:</b><br> Delivery Details page should display.<br>" +
                         "Should able to proceed to next step without any errors.<br><br>";
            }
        }

        public static string StepsToReplicateBlankValue
        {
            get
            {
                return "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click Add New Post button.<br>" +
                         "2. Select and click On Demand or Scheduled Delivery checkbox.<br>" +
                         "3. Click Next Step button.field.<br>" +
                         "4. Fill-out all required fields or; Click Auto-fill Pickup Details button.<br>" +
                         "5. Input an invalid value.<br>" +
                         "6. Click Next Step button.<br><br>" +
                         "<b>Expected Result:</b><br> Delivery Details page should display.<br>" +
                         "Should able to proceed to next step without any errors.<br><br>";
            }
        }

        public static string StepsToReplicateMaxLengthValue
        {
            get
            {
                return "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click Add New Post button.<br>" +
                         "2. Select and click On Demand or Scheduled Delivery checkbox.<br>" +
                         "3. Click Next Step button.field.<br>" +
                         "4. Input max length value in Remarks text field.<br><br>" +
                         "<b>Expected Result:</b><br> Delivery Details page should display.<br>" +
                         "Should able to proceed to next step without any errors.<br><br>";
            }
        }

        public static string[] TestScenariosDeliveryDetails = new string[]
        {
            "4.9.1 Validate Valid value in ondemand delivery Recipient Name", //[0]
            "4.9.2 Validate Valid value in ondemand delivery Mobile Number",
            "4.9.3 Validate Valid value in ondemand delivery Email Address",
            "4.9.4 Validate Valid value in ondemand delivery Address",
            "4.9.5 Validate Valid value in ondemand delivery Province",
            "4.9.6 Validate Valid value in ondemand delivery City", //[5]
            "4.9.7 Validate Valid value in ondemand delivery Barangay",
            "4.9.8 Validate Valid value in ondemand delivery Postal Code",
            "4.9.9 Validate Valid value in ondemand delivery Quantity",
            "4.9.10 Validate Valid value in ondemand delivery COD Amount",
            "4.9.11 Validate Valid value in ondemand delivery Declared Value", //[10]
            "4.9.12 Validate Valid value in ondemand delivery Length",
            "4.9.13 Validate Valid value in ondemand delivery Width",
            "4.9.14 Validate Valid value in ondemand delivery Height",
            "4.9.15 Validate Valid value in ondemand delivery Depth",
            "4.9.16 Validate Valid value in ondemand delivery Weight", //[15]
            "4.9.17 Validate Valid value in ondemand delivery Item Description",
            "4.9.18 Validate Valid value in ondemand delivery Remarks",
            "4.9.19 Validate Clear functionality of ondemand delivery Province dropdown field",
            "4.9.20 Validate Clear functionality of ondemand delivery City dropdown field",
            "4.9.21 Validate Clear functionality of ondemand delivery Barangay dropdown field", //[20]
            "4.9.22 Validate ondemand delivery Previous Step functionality",
            "4.9.24 Validate ondemand Delivery Details hyperlink",
            "4.9.30 Validate Invalid value in ondemand delivery Recipient Name",
            "4.9.31 Validate Invalid value in ondemand delivery Mobile Number",
            "4.9.32 Validate Invalid value in ondemand delivery Email Address", //[25]
            "4.9.34 Validate Invalid value in ondemand delivery Postal Code",
            "4.9.35 Validate Invalid value in ondemand delivery Quantity",
            "4.9.36 Validate Invalid value in ondemand delivery COD Amount",
            "4.9.37 Validate Invalid value in ondemand delivery Declared Value",
            "4.9.38 Validate Invalid value in ondemand delivery Length", //[30]
            "4.9.39 Validate Invalid value in ondemand delivery Width",
            "4.9.40 Validate Invalid value in ondemand delivery Height",
            "4.9.41 Validate Invalid value in ondemand delivery Depth",
            "4.9.42 Validate Invalid value in ondemand delivery Weight",
            "4.9.43 Validate Invalid value in ondemand delivery Item Description", //[35]
            "4.9.44 Validate Invalid value in ondemand delivery Remarks",
            "4.9.45 Validate Blank value in ondemand delivery Recipient Name",
            "4.9.46 Validate Blank value in ondemand delivery Mobile Number",
            "4.9.47 Validate Blank value in ondemand delivery Email Address",
            "4.9.49 Validate Blank value in ondemand delivery Province", //[40]
            "4.9.50 Validate Blank value in ondemand delivery City",
            "4.9.51 Validate Blank value in ondemand delivery Barangay",
            "4.9.52 Validate Blank value in ondemand delivery Postal Code",
            "4.9.53 Validate Blank value in ondemand delivery Quantity",
            "4.9.54 Validate Blank value in ondemand delivery COD Amount", //[45]
            "4.9.55 Validate Blank value in ondemand delivery Declared Value",
            "4.9.56 Validate Blank value in ondemand delivery Length",
            "4.9.57 Validate Blank value in ondemand delivery Width",
            "4.9.58 Validate Blank value in ondemand delivery Height",
            "4.9.59 Validate Blank value in ondemand delivery Depth", //[50]
            "4.9.60 Validate Blank value in ondemand delivery Weight",
            "4.9.61 Validate Blank value in ondemand delivery Item Description",
            "4.9.62 Validate Blank value in ondemand delivery Remarks",
            "4.9.63 Validate Max Length value in ondemand delivery Recipient Name",
            "4.9.64 Validate Max Length value in ondemand delivery Mobile Number", //[55]
            "4.9.65 Validate Max Length value in ondemand delivery Email Address",
            "4.9.66 Validate Max Length value in ondemand delivery Address",
            "4.9.67 Validate Max Length value in ondemand delivery Postal Code",
            "4.9.68 Validate Max Length value in ondemand delivery Quantity",
            "4.9.69 Validate Max Length value in ondemand delivery COD Amount", //[60]
            "4.9.70 Validate Max Length value in ondemand delivery Declared value",
            "4.9.71 Validate Max Length value in ondemand delivery Length",
            "4.9.72 Validate Max Length value in ondemand delivery Width",
            "4.9.73 Validate Max Length value in ondemand delivery Height",
            "4.9.74 Validate Max Length value in ondemand delivery Depth", //[65]
            "4.9.75 Validate Max Length value in ondemand delivery Weight",
            "4.9.76 Validate Max Length value in ondemand delivery Item Description",
            "4.9.77 Validate Max Length value in ondemand delivery Remarks",
            "4.10.1 Validate Valid value in scheduled delivery Recipient Name", 
            "4.10.2 Validate Valid value in scheduled delivery Mobile Number", //[70]
            "4.10.3 Validate Valid value in scheduled delivery Email Address",
            "4.10.4 Validate Valid value in scheduled delivery Address",
            "4.10.5 Validate Valid value in scheduled delivery Province",
            "4.10.6 Validate Valid value in scheduled delivery City", 
            "4.10.7 Validate Valid value in scheduled delivery Barangay", //[75]
            "4.10.8 Validate Valid value in scheduled delivery Postal Code",
            "4.10.9 Validate Valid value in scheduled delivery Quantity",
            "4.10.10 Validate Valid value in scheduled delivery COD Amount",
            "4.10.11 Validate Valid value in scheduled delivery Declared Value", 
            "4.10.12 Validate Valid value in scheduled delivery Length", //[80]
            "4.10.13 Validate Valid value in scheduled delivery Width",
            "4.10.14 Validate Valid value in scheduled delivery Height",
            "4.10.15 Validate Valid value in scheduled delivery Depth",
            "4.10.16 Validate Valid value in scheduled delivery Weight", 
            "4.10.17 Validate Valid value in scheduled delivery Item Description", //[85]
            "4.10.18 Validate Valid value in scheduled delivery Remarks",
            "4.10.19 Validate Clear functionality of scheduled delivery Province dropdown field",
            "4.10.20 Validate Clear functionality of scheduled delivery City dropdown field",
            "4.10.21 Validate Clear functionality of scheduled delivery Barangay dropdown field", 
            "4.10.22 Validate scheduled delivery Previous Step functionality", //[90]
            "4.10.24 Validate scheduled Delivery Details hyperlink",
            "4.10.30 Validate Invalid value in scheduled delivery Recipient Name",
            "4.10.31 Validate Invalid value in scheduled delivery Mobile Number",
            "4.10.32 Validate Invalid value in scheduled delivery Email Address", 
            "4.10.34 Validate Invalid value in scheduled delivery Postal Code", //[95]
            "4.10.35 Validate Invalid value in scheduled delivery Quantity",
            "4.10.36 Validate Invalid value in scheduled delivery COD Amount",
            "4.10.37 Validate Invalid value in scheduled delivery Declared Value",
            "4.10.38 Validate Invalid value in scheduled delivery Length", 
            "4.10.39 Validate Invalid value in scheduled delivery Width", //[100]
            "4.10.40 Validate Invalid value in scheduled delivery Height",
            "4.10.41 Validate Invalid value in scheduled delivery Depth",
            "4.10.42 Validate Invalid value in scheduled delivery Weight",
            "4.10.43 Validate Invalid value in scheduled delivery Item Description", 
            "4.10.44 Validate Invalid value in scheduled delivery Remarks", //[105]
            "4.10.45 Validate Blank value in scheduled delivery Recipient Name",
            "4.10.46 Validate Blank value in scheduled delivery Mobile Number",
            "4.10.47 Validate Blank value in scheduled delivery Email Address",
            "4.10.49 Validate Blank value in scheduled delivery Province", 
            "4.10.50 Validate Blank value in scheduled delivery City", //[110]
            "4.10.51 Validate Blank value in scheduled delivery Barangay",
            "4.10.52 Validate Blank value in scheduled delivery Postal Code",
            "4.10.53 Validate Blank value in scheduled delivery Quantity",
            "4.10.54 Validate Blank value in scheduled delivery COD Amount", 
            "4.10.55 Validate Blank value in scheduled delivery Declared Value", //[115]
            "4.10.56 Validate Blank value in scheduled delivery Length",
            "4.10.57 Validate Blank value in scheduled delivery Width",
            "4.10.58 Validate Blank value in scheduled delivery Height",
            "4.10.59 Validate Blank value in scheduled delivery Depth", 
            "4.10.60 Validate Blank value in scheduled delivery Weight", //[120]
            "4.10.61 Validate Blank value in scheduled delivery Item Description",
            "4.10.62 Validate Blank value in scheduled delivery Remarks",
            "4.10.63 Validate Max Length value in scheduled delivery Recipient Name",
            "4.10.64 Validate Max Length value in scheduled delivery Mobile Number", 
            "4.10.65 Validate Max Length value in scheduled delivery Email Address", //[125]
            "4.10.66 Validate Max Length value in scheduled delivery Address",
            "4.10.67 Validate Max Length value in scheduled delivery Postal Code",
            "4.10.68 Validate Max Length value in scheduled delivery Quantity",
            "4.10.69 Validate Max Length value in scheduled delivery COD Amount", 
            "4.10.70 Validate Max Length value in scheduled delivery Declared value", //[130]
            "4.10.71 Validate Max Length value in scheduled delivery Length",
            "4.10.72 Validate Max Length value in scheduled delivery Width",
            "4.10.73 Validate Max Length value in scheduled delivery Height",
            "4.10.74 Validate Max Length value in scheduled delivery Depth", 
            "4.10.75 Validate Max Length value in scheduled delivery Weight", //[135]
            "4.10.76 Validate Max Length value in scheduled delivery Item Description",
            "4.10.77 Validate Max Length value in scheduled delivery Remarks",
        };


    }
}

