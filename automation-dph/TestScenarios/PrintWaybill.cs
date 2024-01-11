
namespace automation_dph.TestScenarios
{
	public class PrintWaybill : BasePageDriver
	{
		public PrintWaybill(IPage page, PageTest pageTest) : base(page, pageTest)
		{

		}

        public static string[] TestScenarios = new string[]
        {
            "1.1 Validate Print Waybill for Accepted Status", //[0]
            "1.2 Validate Print Waybill for Assiging Rider Status",
            "1.3 Validate Print Waybill for Started Status",
            "1.4 Validate Selected Status of Multiple Print Waybill",
            "1.5 Validate Single selection post for Multiple Waybill",
            "1.7 Validate Multiple Print Waybill for single post selected", //[5]
            "1.10 Validate Multiple Print Waybill for no selected post",
            "1.12 Validate Print Waybill for Queued Status",
            "1.13 Validate Print Waybill for Assigned Status",
            "1.14 Validate Print Waybill for In transit for return Status",
            "1.15 Validate Print Waybill for Failed Delivery Status", //[10]
            "1.16 Validate Print Waybill for Failed Pickup Status",
            "1.17 Validate Print Waybill for Failed Return Status",
            "2.1 Validate Provider Waybill for Entrego Express Globe and the status is Accepted",
            "2.2 Validate Provider Waybill for Entrego Express Globe and the status is Started",
            "2.4 Validate Provider Waybill for Ninjavan and the status is Started", //[15]
            "2.6 Validate Provider Waybill for QuadX and the status is Started",
            "2.7 Validate Provider Waybill for WSI and the status is Accepted",
            "2.8 Validate Provider Waybill for WSI and the status is Started",
            "2.9 Validate Single selection post for Multiple Provider Waybill",
            "2.14 Validate Provider Waybill that are not available", //[20]
            "2.15 Validate Multiple Print Waybill for no selected post",
            "2.17 Validate Close Print Provider Waybill functionality",
            "3.1 Validate Generated Waybil for Entrego Globe with status Accepted",
            "3.2 Validate Generated Waybill for Entrego Globe with status Started",
            "3.3 Validate Generated Waybill for NinjaVan with status Started", //[25]
            "3.4 Validate Generated Waybill for QuadX with status Started",
            "3.5 Validate Generated Waybill for WSI with status Accepted",
            "3.6 Validate Generated Waybill for WSI with status Started",
            "3.7 Validate Generated Multiple Waybill for Entrego Globe",
            "3.8 Validate Generated Multiple Waybill for NinjaVan", //[30]
            "3.9 Validate Generated Multiple Waybill for QuadX",
            "3.10 Validate Generated Multiple Waybill for WSI",
            "3.15 Validate Number Pagination for Multiple Waybill",
            "3.16 Validate Next Pagination for Multiple Waybill",
            "3.17 Validate Previous Pagination for Multiple Waybill",
        };

        public string[] StepsToReplicate = new string[]
        {
            // 1.1
            "<b>Steps to Replicate:</b><br>" +
                        "1. On My Posts Page, click All Status dropdown field.<br>" +
                        "2. Select and click Accepted status.<br>" +
                        "3. Click the first post on the dashboard.<br>" +
                        "4. Click Print Waybill button.<br><br>" +
                        "<b>Expected Result:</b><br> Print area window should appear.<br><br> ",
            // 1.2
            "<b>Steps to Replicate:</b><br>" +
                        "1. On My Posts Page, click All Status dropdown field.<br>" +
                        "2. Select and click Assigning Rider status.<br>" +
                        "3. Click the first post on the dashboard.<br>" +
                        "4. Click Print Waybill button.<br><br>" +
                        "<b>Expected Result:</b><br> Print area window should appear.<br><br> ",
            // 1.3
            "<b>Steps to Replicate:</b><br>" +
                        "1. On My Posts Page, click All Status dropdown field.<br>" +
                        "2. Click Print Default Waybill options.<br><br>" +
                         "<b>Expected Result:</b><br> User should not be login.<br> " +
                         "Error notification should display.<br><br>",
            // 1.4
            "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click the Three Dots on the right side.<br>" +
                         "2. Enter Invalid password in password textfield.<br>" +
                         "3. Click login button.<br><br>" +
                         "<b>Expected Result:</b><br> All posts with status ACCEPTED, ASSIGNING RIDER and STARTED should only display.<br> " +
                         "Above list status should be checked.<br><br>",
            // 1.5
            "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click the Three Dots on the right side.<br>" +
                         "2. Click Print Default Waybill options.<br>" +
                         "3. Select 1 post in the dashboard and click the checkbox.<br><br>" +
                         "<b>Expected Result:</b><br> Checkbox should be checked.<br>" +
                         "Number of post should be the same based on selected post.<br><br>",
            // 1.7
            "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click the Three Dots on the right side.<br>" +
                         "2. Click Print Default Waybill options.<br>" +
                         "3. Select 1 post in the dashboard and click the checkbox.<br>" +
                         "4. Click Print Default Waybill button.<br><br>" +
                         "<b>Expected Result:</b><br> Print area window should appear.<br> " +
                         "Number of post to be print should be the same based on selected posts.<br><br>",
            // 1.10
            "<b>Steps to Replicate:</b><br>" +
                         "1. Click Forgot Password? hyper link.<br>" +
                         "2. Enter value in email textfield.<br>" +
                         "3. Click Reset Password button.<br><br>" +
                         "<b>Expected Result:</b><br> Error notification should display.<br><br>",
            // 1.12
            "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click All Status dropdown field.<br>" +
                         "2. Select and click Queued status.<br>" +
                         "3. Click the first post on the dashboard.<br>" +
                         "4. Verify Print Waybill button.<br><br>" +
                         "<b>Expected Result:</b><br> Button should not visible.<br><br>",
            // 1.13
            "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click All Status dropdown field.<br>" +
                         "2. Select and click Assigned status.<br>" +
                         "3. Click the first post on the dashboard.<br>" +
                         "4. Verify Print Waybill button.<br><br>" +
                         "<b>Expected Result:</b><br> Button should not visible.<br><br>",
            // 1.14
            "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click All Status dropdown field.<br>" +
                         "2. Select and click In transit for return status.<br>" +
                         "3. Click the first post on the dashboard.<br>" +
                         "4. Verify Print Waybill button.<br><br>" +
                         "<b>Expected Result:</b><br> Button should not visible.<br><br>",
           // 1.15
            "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click All Status dropdown field.<br>" +
                         "2. Select and click Failed Delivery status.<br>" +
                         "3. Click the first post on the dashboard.<br>" +
                         "4. Verify Print Waybill button.<br><br>" +
                         "<b>Expected Result:</b><br> Button should not visible.<br><br>",
           // 1.16
            "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click All Status dropdown field.<br>" +
                         "2. Select and click Failed Pickup status.<br>" +
                         "3. Click the first post on the dashboard.<br>" +
                         "4. Verify Print Waybill button.<br><br>" +
                         "<b>Expected Result:</b><br> Button should not visible.<br><br>",
           // 1.17
            "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click All Status dropdown field.<br>" +
                         "2. Select and click Failed Return status.<br>" +
                         "3. Click the first post on the dashboard.<br>" +
                         "4. Verify Print Waybill button.<br><br>" +
                         "<b>Expected Result:</b><br> Button should not visible.<br><br>",
            // 2.1
            "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click All Status dropdown field.<br>" +
                         "2. Select and click Accepted status.<br>" +
                         "3. Click All Preferred Partner dropdown field.<br>" +
                         "4. Select and click Entrego Express Globe.<br>" +
                         "5. Click the first post on the dashboard.<br>" +
                         "6. Click Print Waybill button.<br>" +
                         "7. Click Provider Waybill button.<br><br>" +
                         "<b>Expected Result:</b><br> Provider Waybill window should appear.<br><br>",
            // 2.2
            "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click All Status dropdown field.<br>" +
                         "2. Select and click Started status.<br>" +
                         "3. Click All Preferred Partner dropdown field.<br>" +
                         "4. Select and click Entrego Express Globe.<br>" +
                         "5. Click the first post on the dashboard.<br>" +
                         "6. Click Print Waybill button.<br>" +
                         "7. Click Provider Waybill button.<br><br>" +
                         "<b>Expected Result:</b><br> Provider Waybill window should appear.<br><br>",
            // 2.4
            "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click All Status dropdown field.<br>" +
                         "2. Select and click Started status.<br>" +
                         "3. Click All Preferred Partner dropdown field.<br>" +
                         "4. Select and click Ninjavan.<br>" +
                         "5. Click the first post on the dashboard.<br>" +
                         "6. Click Print Waybill button.<br>" +
                         "7. Click Provider Waybill button.<br><br>" +
                         "<b>Expected Result:</b><br> Provider Waybill window should appear.<br><br>",
            // 2.6
            "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click All Status dropdown field.<br>" +
                         "2. Select and click Started status.<br>" +
                         "3. Click All Preferred Partner dropdown field.<br>" +
                         "4. Select and click QuadX.<br>" +
                         "5. Click the first post on the dashboard.<br>" +
                         "6. Click Print Waybill button.<br>" +
                         "7. Click Provider Waybill button.<br><br>" +
                         "<b>Expected Result:</b><br> Provider Waybill window should appear.<br><br>",
            // 2.7
            "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click All Status dropdown field.<br>" +
                         "2. Select and click Accepted status.<br>" +
                         "3. Click All Preferred Partner dropdown field.<br>" +
                         "4. Select and click Select and click Worklink Services Inc..<br>" +
                         "5. Click the first post on the dashboard.<br>" +
                         "6. Click Print Waybill button.<br>" +
                         "7. Click Provider Waybill button.<br><br>" +
                         "<b>Expected Result:</b><br> Provider Waybill window should appear.<br><br>",
            // 2.8
            "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click All Status dropdown field.<br>" +
                         "2. Select and click Started status.<br>" +
                         "3. Click All Preferred Partner dropdown field.<br>" +
                         "4. Select and click Select and click Worklink Services Inc..<br>" +
                         "5. Click the first post on the dashboard.<br>" +
                         "6. Click Print Waybill button.<br>" +
                         "7. Click Provider Waybill button.<br><br>" +
                         "<b>Expected Result:</b><br> Provider Waybill window should appear.<br><br>",
            // 2.9
            "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click the Three Dots on the right side.<br>" +
                         "2. Click Print Provider Waybill options.<br>" +
                         "3. Click All Preferred Partner dropdown field.<br>" +
                         "4. Select and click any of this provider Entrego Express Globe, Ninjavan, QuadX & Worklink Services Inc.<br>" +
                         "5. Select 1 post in the dashboard and click the checkbox.<br><br>" +
                         "<b>Expected Result:</b><br> Checkbox should be checked.<br> " +
                         "Number of post should be the same based on selected post.<br><br>",
            // 2.14
            "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click the Three Dots on the right side.<br>" +
                         "2. Click Print Provider Waybill options.<br>" +
                         "3. Select and click any provider except the following: Entrego Express Globe, Ninjavan, QuadX & Worklink Services Inc.<br>" +
                         "4. Select 1 post in the dashboard and click the checkbox.<br>" +
                         "5. Click Print Provider Waybill button.<br><br>" +
                         "<b>Expected Result:</b><br> Button should be disable and unable to click.<br><br>",
            // 2.15
            "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click the Three Dots on the right side.<br>" +
                         "2. Click Print Provider Waybill options.<br>" +
                         "3. Select and click any of this provider Entrego Express Globe, Ninjavan, QuadX & Worklink Services Inc.<br>" +
                         "4. Click Print Provider Waybill button.<br><br>" +
                         "<b>Expected Result:</b><br> Button should be disable and unable to click.<br><br>",
            // 2.17
            "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click the Three Dots on the right side.<br>" +
                         "2. Click Print Provider Waybill options.<br>" +
                         "3. On the right side, click x button.<br><br>" +
                         "<b>Expected Result:</b><br> Checkbox should be checked.<br>" +
                         "Print Provider Waybill functionality should disappear.<br><br>",
            // 3.1
            "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click All Status dropdown field.<br>" +
                         "2. Select and click Accepted status.<br>" +
                         "3. Click All Preferred Partner dropdown field.<br>" +
                         "4. Select and click Entrego Express Globe.<br>" +
                         "5. Click the first post on the dashboard.<br>" +
                         "6. Click Print Waybill dropdown button<br>" +
                         "7. Click Provider Waybill option button.<br><br>" +
                         "<b>Expected Result:</b><br> Generated Waybill should display.<br> " +
                         "Provider Waybill window should appear.<br><br>",
            // 3.2
            "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click All Status dropdown field.<br>" +
                         "2. Select and click Started status.<br>" +
                         "3. Click All Preferred Partner dropdown field.<br>" +
                         "4. Select and click Entrego Express Globe.<br>" +
                         "5. Click the first post on the dashboard.<br>" +
                         "6. Click Print Waybill dropdown button<br>" +
                         "7. Click Provider Waybill option button.<br><br>" +
                         "<b>Expected Result:</b><br> Generated Waybill should display.<br> " +
                         "Provider Waybill window should appear.<br><br>",
            // 3.3
            "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click All Status dropdown field.<br>" +
                         "2. Select and click Started status.<br>" +
                         "3. Click All Preferred Partner dropdown field.<br>" +
                         "4. Select and click NinjaVan.<br>" +
                         "5. Click the first post on the dashboard.<br>" +
                         "6. Click Print Waybill dropdown button<br>" +
                         "7. Click Provider Waybill option button.<br><br>" +
                         "<b>Expected Result:</b><br> Generated Waybill should display.<br> " +
                         "Provider Waybill window should appear.<br><br>",
            // 3.4
            "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click All Status dropdown field.<br>" +
                         "2. Select and click Started status.<br>" +
                         "3. Click All Preferred Partner dropdown field.<br>" +
                         "4. Select and click QuadX.<br>" +
                         "5. Click the first post on the dashboard.<br>" +
                         "6. Click Print Waybill dropdown button.<br>" +
                         "7. Click Provider Waybill option button.<br><br>" +
                         "<b>Expected Result:</b><br> Generated Waybill should display.<br> " +
                         "Provider Waybill window should appear.<br><br>",
            // 3.5
            "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click All Status dropdown field.<br>" +
                         "2. Select and click Accepted status.<br>" +
                         "3. Click All Preferred Partner dropdown field.<br>" +
                         "4. Select and click WSI.<br>" +
                         "5. Click the first post on the dashboard.<br>" +
                         "6. Click Print Waybill dropdown button.<br>" +
                         "7. Click Provider Waybill option button.<br><br>" +
                         "<b>Expected Result:</b><br> Generated Waybill should display.<br> " +
                         "Provider Waybill window should appear.<br><br>",
            // 3.6
            "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click All Status dropdown field.<br>" +
                         "2. Select and click Started status.<br>" +
                         "3. Click All Preferred Partner dropdown field.<br>" +
                         "4. Select and click WSI.<br>" +
                         "5. Click the first post on the dashboard.<br>" +
                         "6. Click Print Waybill dropdown button.<br>" +
                         "7. Click Provider Waybill option button.<br><br>" +
                         "<b>Expected Result:</b><br> Generated Waybill should display.<br> " +
                         "Provider Waybill window should appear.<br><br>",
            // 3.7
            "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click All Status dropdown field.<br>" +
                         "2. Click Print Provider Waybill options.<br>" +
                         "3. Click All Preferred Partner dropdown field.<br>" +
                         "4. Select and click Entrego Express Globe.<br>" +
                         "5. Select 2 or more post in the dashboard by clicking the checkbox.<br>" +
                         "6. Click Print Provider Waybill button.<br>" +
                         "7. Click Confirm button.<br><br>" +
                         "<b>Expected Result:</b><br> Provider Waybill window should appear.<br> " +
                         "Multiple generated Waybill should display.<br><br>",
            // 3.8
            "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click All Status dropdown field.<br>" +
                         "2. Click Print Provider Waybill options.<br>" +
                         "3. Click All Preferred Partner dropdown field.<br>" +
                         "4. Select and click NinajaVan.<br>" +
                         "5. Select 2 or more post in the dashboard by clicking the checkbox.<br>" +
                         "6. Click Print Provider Waybill button.<br>" +
                         "7. Click Confirm button.<br><br>" +
                         "<b>Expected Result:</b><br> Provider Waybill window should appear.<br> " +
                         "Multiple generated Waybill should display.<br><br>",
            // 3.9
            "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click All Status dropdown field.<br>" +
                         "2. Click Print Provider Waybill options.<br>" +
                         "3. Click All Preferred Partner dropdown field.<br>" +
                         "4. Select and click QuadX.<br>" +
                         "5. Select 2 or more post in the dashboard by clicking the checkbox.<br>" +
                         "6. Click Print Provider Waybill button.<br>" +
                         "7. Click Confirm button.<br><br>" +
                         "<b>Expected Result:</b><br> Provider Waybill window should appear.<br> " +
                         "Multiple generated Waybill should display.<br><br>",
            // 3.10
            "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click All Status dropdown field.<br>" +
                         "2. Click Print Provider Waybill options.<br>" +
                         "3. Click All Preferred Partner dropdown field.<br>" +
                         "4. Select and click WSI.<br>" +
                         "5. Select 2 or more post in the dashboard by clicking the checkbox.<br>" +
                         "6. Click Print Provider Waybill button.<br>" +
                         "7. Click Confirm button.<br><br>" +
                         "<b>Expected Result:</b><br> Provider Waybill window should appear.<br> " +
                         "Multiple generated Waybill should display.<br><br>",
            // 3.15
            "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click All Status dropdown field.<br>" +
                         "2. Click Print Provider Waybill options.<br>" +
                         "3. Click All Preferred Partner dropdown field.<br>" +
                         "4. Select and click WSI.<br>" +
                         "5. Select 2 or more post in the dashboard by clicking the checkbox.<br>" +
                         "6. Click Print Provider Waybill button.<br>" +
                         "7. Click Confirm button.<br>" +
                         "8. Click and select any number page in pagination.<br><br>" +
                         "<b>Expected Result:</b><br> Selected page number should be highlights.<br> " +
                         "Should display a different waybill details.<br><br>",
            // 3.16
            "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click All Status dropdown field.<br>" +
                         "2. Click Print Provider Waybill options.<br>" +
                         "3. Click All Preferred Partner dropdown field.<br>" +
                         "4. Select and click WSI.<br>" +
                         "5. Select 2 or more post in the dashboard by clicking the checkbox.<br>" +
                         "6. Click Print Provider Waybill button.<br>" +
                         "7. Click Confirm button.<br>" +
                         "8. Click Next page icon in pagination.<br><br>" +
                         "<b>Expected Result:</b><br> Selected next page should be highlights.<br> " +
                         "Should display a different waybill details.<br><br>",
            // 3.17
            "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click All Status dropdown field.<br>" +
                         "2. Click Print Provider Waybill options.<br>" +
                         "3. Click All Preferred Partner dropdown field.<br>" +
                         "4. Select and click WSI.<br>" +
                         "5. Select 2 or more post in the dashboard by clicking the checkbox.<br>" +
                         "6. Click Print Provider Waybill button.<br>" +
                         "7. Click Confirm button.<br>" +
                         "8. Click Next page icon in pagination.<br>" +
                         "9. Click Previous page icon in pagination.<br><br>" +
                         "<b>Expected Result:</b><br> Selected previous page should be highlights.<br> " +
                         "Should display a different waybill details.<br><br>",
        };
    }
}

