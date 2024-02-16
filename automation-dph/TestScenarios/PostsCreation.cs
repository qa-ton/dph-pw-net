using System;
using Microsoft.Playwright.MSTest;

namespace automation_dph.TestScenarios
{
	public class PostsCreation : BasePageDriver
	{
		public PostsCreation(IPage page, PageTest pageTest) : base(page, pageTest)
        {
            AddNewPostsPages = new(Page, PageTest);
        }
        private static readonly PostsDataConfiguration PostsDataConfiguration = new();

        public static string[] TestScenarios = new string[]
		{
            "4.1.1 Validate Motorcycle Post Creation",// [0]
            "4.1.2 Validate LD 10w Truck Post Creation",
            "4.1.3 Validate MPV Post Creation",
            "4.1.4 Validate Sedan Post Creation",
            "4.1.5 Validate Ten Wheeler Truck Post Creation",
            "4.1.6 Validate Truck Post Creation", //[5]
            "4.1.7 Validate Truck330 Post Creation",
            "4.1.8 Validate Van L300 Post Creation",
            "4.1.9 Validate Van Multicab Post Creation",
            "4.1.10 Validate Motorcycle Post Creation for Cebu Area",
            "4.1.11 Validate MPV Post Creation for Cebu Area", //[10]
            "4.1.12 Validate Sedan Post Creation for Cebu Area",
            "4.1.13 Validate Truck330 Post Creation for Cebu Area",
            "4.1.14 Validate Motorcycle Post Creation for Pampanga Area",
            "4.1.15 Validate LD 10w Truck Post Creation for Pampanga Area",
            "4.1.16 Validate MPV Post Creation for Pampanga Area", //[15]
            "4.1.17 Validate Sedan Post Creation for Pampanga Area",
            "4.1.18 Validate Ten Wheeler Truck Post Creation for Pampanga Area",
            "4.1.19 Validate Truck330 Post Creation for Pampanga Area",
            "4.1.20 Validate Van Multicab Post Creation for Pampanga Area",
            "4.1.21 Validate Canopy Multicab Vehicle Type not supported", //[20]
            "4.1.22 Validate Close Van Vehicle Type not supported",
            "4.1.23 Validate Close Van XS Vehicle Type not supported",
            "4.1.24 Validate Long Pickup Truck Vehicle Type not supported",
            "4.1.25 Validate Mini Dump Truck Vehicle Type not supported",
            "4.1.26 Validate Pickup Truck Vehicle Type not supported", //[25]
            "4.1.27 Validate Pickup Truck XS Vehicle Type not supported",
            "4.1.28 Validate Six Wheeler Forward Truck Vehicle Type not supported",
            "4.1.29 Validate Six Wheeler Forward XS Vehicle Type not supported",
            "4.1.30 Validate Small Pickup Vehicle Type not supported",
            "4.1.31 Validate Ten Wheeler Wing Van 32 Vehicle Type not supported", //[30]
            "4.1.32 Validate Ten Wheeler Truck Vehicle Type not supported",
            "4.1.33 Validate Wing Van 40 Vehicle Type not supported",
            "4.1.34 Validate Canopy Multicab Vehicle Type not supported for Cebu Area",
            "4.1.35 Validate Close Van Vehicle Type not supported for Cebu Area",
            "4.1.36 Validate Close Van XS Vehicle Type not supported for Cebu Area", //[35]
            "4.1.37 Validate LD 10w Truck Vehicle Type not supported for Cebu Area",
            "4.1.38 Validate Long Pickup Truck Vehicle Type not supported for Cebu Area",
            "4.1.39 Validate Mini Dump Truck Vehicle Type not supported for Cebu Area",
            "4.1.40 Validate Pickup Truck Vehicle Type not supported for Cebu Area",
            "4.1.41 Validate Pickup Truck XS Vehicle Type not supported for Cebu Area", //[40]
            "4.1.42 Validate Six Wheeler Forward Truck Vehicle Type not supported for Cebu Area",
            "4.1.43 Validate Six Wheeler Forward Truck XS Vehicle Type not supported for Cebu Area",
            "4.1.44 Validate Small Pickup Vehicle Type not supported for Cebu Area",
            "4.1.45 Validate Ten Wheeler Truck Vehicle Type not supported for Cebu Area",
            "4.1.46 Validate Ten Wheeler Wing Van 32 Vehicle Type not supported for Cebu Area", //[45]
            "4.1.47 Validate Truck Vehicle Type not supported for Cebu Area",
            "4.1.48 Validate Van L300 Vehicle Type not supported for Cebu Area",
            "4.1.49 Validate Van Multicab Vehicle Type not supported for Cebu Area",
            "4.1.50 Validate Wing Van 40 Vehicle Type not supported for Cebu Area",
            "4.1.51 Validate Canopy Multicab Vehicle Type not supported for Pampanga Area", //[50]
            "4.1.52 Validate Close Van Vehicle Type not supported for Pampanga Area",
            "4.1.53 Validate Close Van XS Vehicle Type not supported for Pampanga Area",
            "4.1.54 Validate Long Pickup Truck Vehicle Type not supported for Pampanga Area",
            "4.1.55 Validate Mini Dump Truck Vehicle Type not supported for Pampanga Area",
            "4.1.56 Validate Pickup Truck Vehicle Type not supported for Pampanga Area", //[55]
            "4.1.57 Validate Pickup Truck XS Vehicle Type not supported for Pampanga Area",
            "4.1.58 Validate Six Wheeler Forward Truck XS Vehicle Type not supported for Pampanga Area",
            "4.1.59 Validate Six Wheeler Forward Truck Vehicle Type not supported for Pampanga Area",
            "4.1.60 Validate Small Pickup Vehicle Type not supported for Pampanga Area", 
            "4.1.61 Validate Ten Wheeler Wing Van 32 Vehicle Type not supported for Pampanga Area", //[60]
            "4.1.62 Validate Truck Vehicle Type not supported for Pampanga Area",
            "4.1.63 Validate Van L300 Vehicle Type not supported for Pampanga Area",
            "4.1.64 Validate Wing Van 40 Vehicle Type not supported for Pampanga Area",
        };

        public static string[] TestScenariosForScheduled = new string[]
        {
            "4.5.1 Validate Prime Movers Post Creation",// [0]
            "4.5.2 Validate Libcap Post Creation",
            "4.5.3 Validate XDE Post Creation",
            "4.5.4 Validate Entrego Globe Post Creation",
            "4.5.5 Validate Nonpareil Post Creation",
            "4.5.6 Validate NinjaVan Post Creation", //[5]
            "4.5.7 Validate QuadX Post Creation",
            "4.5.8 Validate Prime Movers Non-serviceable pickup areas",
            "4.5.9 Validate Prime Movers Non-serviceable delivery areas",
            "4.5.10 Validate Libcap Non-serviceable pickup areas",
            "4.5.11 Validate Libcap Non-serviceable delivery areas", //[10]
            "4.5.12 Validate XDE Non-serviceable pickup areas",
            "4.5.13 Validate XDE Non-serviceable delivery areas",
            "4.5.14 Validate Entrego Globe Non-serviceable pickup areas",
            "4.5.15 Validate Entrego Globe Non-serviceable delivery areas",
            "4.5.16 Validate Nonpareil Non-serviceable pickup areas", //[15]
            "4.5.17 Validate Nonpareil Non-serviceable delivery areas",
            "4.5.18 Validate NinjaVan Non-serviceable pickup areas",
            "4.5.19 Validate NinjaVan Non-serviceable delivery areas",
            "4.5.20 Validate QuadX Non-serviceable pickup areas",
            "4.5.21 Validate QuadX Non-serviceable delivery areas", //[20]
        };


        public static string StepsToReplicatePostCreation
        {
            get
            {
                return "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click Add New Post button.<br>" +
                         "2. Select and click On Demand Delivery checkbox.<br>" +
                         "3. Click Next Step button.field.<br>" +
                         "4. Fill-out all required fields or; Click Auto-fill Pickup Details button.<br>" +
                         "5. Click Next Step button.<br>" +
                         "6. Fill-out all required fields or; Click Auto-fill Delivery Details button.<br>" +
                         "7. Click Next Step button.<br>" +
                         "8. Click Vehicle Type dropdown field.<br>" +
                        $"9. Select {EnvironmentVariableManager.GetValue(AddNewPostsPages.VehicleTypeSelectCourier_Label)} on the list.<br>" +
                        $"10. Select and click {EnvironmentVariableManager.GetValue(AddNewPostsPages.CourierNameSummary_Label)} checkbox.<br>" +
                         "11. Click Next Step button.<br>" +
                         "12. Fill-out required fields, if no required field to be fill out click Next Step button.<br>" +
                         "13. Click Save button.<br><br>" +
                         "<b>Expected Result:</b><br> Success notification should appear.<br>" +
                         "Created post should display in the dashboard.<br>" +
                         "Add New Post page should automatically exit.<br><br>";
            }
        }

        public static string StepsToReplicatePostCreationCebuPampangaAreas
        {
            get
            {
                return "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click Add New Post button.<br>" +
                         "2. Select and click On Demand Delivery checkbox.<br>" +
                         "3. Click Next Step button.field.<br>" +
                         "4. Fill-out all required fields or; Click Auto-fill Pickup Details button.<br>" +
                        $"5. Edit address location details to {EnvironmentVariableManager.GetValue(AddNewPostsPages.ProvincePickupSummary_Label)} area.<br>" +
                         "6. Click Next Step button.<br>" +
                         "7. Fill-out all required fields or; Click Auto-fill Delivery Details button.<br>" +
                        $"8. Edit address location details to {EnvironmentVariableManager.GetValue(AddNewPostsPages.ProvincePickupSummary_Label)} area.<br>" +
                         "9. Click Next Step button.<br>" +
                         "10. Click Vehicle Type dropdown field.<br>" +
                        $"11. Select {EnvironmentVariableManager.GetValue(AddNewPostsPages.VehicleTypeSelectCourier_Label)} on the list.<br>" +
                        $"12. Select and click {EnvironmentVariableManager.GetValue(AddNewPostsPages.CourierNameSummary_Label)} checkbox.<br>" +
                         "13. Click Next Step button.<br>" +
                         "14. Fill-out required fields, if no required field to be fill out click Next Step button.<br>" +
                         "15. Click Save button.<br><br>" +
                         "<b>Expected Result:</b><br> Success notification should appear.<br>" +
                         "Created post should display in the dashboard.<br>" +
                         "Add New Post page should automatically exit.<br><br>";
            }
        }

        public static string StepsToReplicatePostCreationNotSupported
        {
            get
            {
                return "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click Add New Post button.<br>" +
                         "2. Select and click On Demand Delivery checkbox.<br>" +
                         "3. Click Next Step button.field.<br>" +
                         "4. Fill-out all required fields or; Click Auto-fill Pickup Details button.<br>" +
                         "5. Click Next Step button.<br>" +
                         "6. Fill-out all required fields or; Click Auto-fill Delivery Details button.<br>" +
                         "7. Click Next Step button.<br>" +
                         "8. Click Vehicle Type dropdown field.<br>" +
                        $"9. Select {EnvironmentVariableManager.GetValue(AddNewPostsPages.VehicleTypeSelectCourier_Label)} on the list.<br>" +
                         $"10. Hover on {PostsDataConfiguration.Courier} checkbox card.<br><br>" +
                         "<b>Expected Result:</b><br> Information message should be Vehicle is not supported.<br>" +
                         "Courier card should disable<br><br>";
            }
        }

        public static string StepsToReplicatePostNotSupportedCebuPampangaAreas
        {
            get
            {
                return "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click Add New Post button.<br>" +
                         "2. Select and click On Demand Delivery checkbox.<br>" +
                         "3. Click Next Step button.field.<br>" +
                         "4. Fill-out all required fields or; Click Auto-fill Pickup Details button.<br>" +
                        $"5. Edit address location details to {EnvironmentVariableManager.GetValue(AddNewPostsPages.ProvincePickupSummary_Label)} area.<br>" +
                         "6. Click Next Step button.<br>" +
                         "7. Fill-out all required fields or; Click Auto-fill Delivery Details button.<br>" +
                        $"8. Edit address location details to {EnvironmentVariableManager.GetValue(AddNewPostsPages.ProvincePickupSummary_Label)} area.<br>" +
                         "9. Click Next Step button.<br>" +
                         "10. Click Vehicle Type dropdown field.<br>" +
                        $"11. Select {EnvironmentVariableManager.GetValue(AddNewPostsPages.VehicleTypeSelectCourier_Label)} on the list.<br>" +
                        $"12. Hover on {PostsDataConfiguration.Courier} checkbox card.<br><br>" +
                         "<b>Expected Result:</b><br> Information message should be Vehicle is not supported.<br>" +
                         "Courier card should disable<br><br>";
            }
        }

        // public static string[] StepsToReplicateFilters = new string[]
        //{

        //      // LALAMOVE 
        //      // 4.1.1
        //      "<b>Steps to Replicate:</b><br>" +
        //                   "1. On My Posts Page, click Add New Post button.<br>" +
        //                   "2. Select and click On Demand Delivery checkbox.<br>" +
        //                   "3. Click Next Step button.field.<br>" +
        //                   "4. Fill-out all required fields or; Click Auto-fill Pickup Details button.<br>" +
        //                   "5. Click Next Step button.<br>" +
        //                   "6. Fill-out all required fields or; Click Auto-fill Delivery Details button.<br>" +
        //                   "7. Click Next Step button.<br>" +
        //                   $"8. Select and click {AddNewPostsPages.GetValueOfCourierNameInSummaryPage} checkbox.<br>" +
        //                   "9. Click Next Step button.<br>" +
        //                   "10. Fill-out required fields, if no required field to be fill out click Next Step button.<br>" +
        //                   "11. Click Save button.<br><br>" +
        //                   "<b>Expected Result:</b><br> Success notification should appear.<br>"+
        //                   "Created post should display in the dashboard.<br>" +
        //                   "Add New Post page should automatically exit.<br><br>",
        //};

        protected static AddNewPostsPages AddNewPostsPages { get; private set; } = null!;
    }
}

