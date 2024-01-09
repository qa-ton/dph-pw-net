
namespace automation_dph.TestScenarios
{
	public class MarkAsReturned : BasePageDriver
	{
		public MarkAsReturned(IPage page, PageTest pageTest) : base(page, pageTest)
		{

		}

        public string[] TestScenarios = new string[]
        {
            "1.1 Validate The Status display for Mark as Returned",
            "1.2 Validate Status selected in status dropdown field for Mark as Returned",
            "1.3 Validate Single selection post for Mark as Returned",
            "1.4 Validate Multiple selection post for Mark as Returned",
            "1.5 Validate Select First 20 selection post for Mark as Returned",
            "1.6 Validate Returned post for single post selected",
            "1.7 Validate Returned for multiple post selected",
            "1.8 Validate Mark as Returned for Select First 20",
            "1.9 Validate Mark as Returned for no selected post",
        };

        public string[] StepsToReplicate = new string[]
        {
            // 1.1
            "<b>Steps to Replicate:</b><br>" +
                        "1. On My Posts Page, click the Three Dots on the right side.<br>" +
                        "2. Click Mark as Returned options.<br><br>" +
                        "<b>Expected Result:</b><br> All posts with status INTRANSITFOR_RETURN should only display.<br><br> ",

            // 1.2
            "<b>Steps to Replicate:</b><br>" +
                        "1. On My Posts Page, click the Three Dots on the right side.<br>" +
                        "2. Click Mark as Returned options.<br>" +
                        "3. Verify and Click All Status dropdown field.<br><br>" +
                        "<b>Expected Result:</b><br> Dropdown field name should display '1 Status Selected' by default.<br> " +
                        "IN_TRANSIT_FOR_RETURN should be checked.<br><br>",

            // 1.3
            "<b>Steps to Replicate:</b><br>" +
                        "1. On My Posts Page, click the Three Dots on the right side.<br>" +
                        "2. Click Mark as Returned options.<br>" +
                        "3. Select 1 post in the dashboard and click the checkbox.<br><br>" +
                        "<b>Expected Result:</b><br> Checkbox should be checked.<br> " +
                        "Number of post should be the same based on selected post.<br><br>",
            // 1.4
            "<b>Steps to Replicate:</b><br>" +
                        "1. On My Posts Page, click the Three Dots on the right side.<br>" +
                        "2. Click Mark as Returned options.<br>" +
                        "3. Select 2 or more post in the dashboard by clicking the checkbox.<br><br>" +
                        "<b>Expected Result:</b><br> Selected checkbox should be checked.<br> " +
                        "Number of post should be the same based on selected post.<br><br>",

            // 1.5
            "<b>Steps to Replicate:</b><br>" +
                        "1. On My Posts Page, click the Three Dots on the right side.<br>" +
                        "2. Click Mark as Returned options.<br>" +
                        "3. Click Select First 20 checkbox.<br><br>" +
                        "<b>Expected Result:</b><br> Selected checkbox should be checked.<br> " +
                        "Number of post should be the same based on selected post.<br><br>",

            // 1.6
            "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click the Three Dots on the right side.<br>" +
                         "2. Click Mark as Returned options.<br>" +
                         "3. Select 1 post in the dashboard and click the checkbox.<br>" +
                         "4. Click Mark as Returned button.<br>" +
                         "5. Click Confirm button.<br><br>" +
                         "<b>Expected Result:</b><br> Success notification should display.<br> " +
                         "Selected post should be remove from the dashboard.<br><br>",
            // 1.7
            "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click the Three Dots on the right side.<br>" +
                         "2. Click Mark as Returned options.<br>" +
                         "3. Select 2 or more post in the dashboard by clicking the checkbox.<br>" +
                         "4. Click Mark as Returned button.<br>" +
                         "5. Click Confirm button.<br><br>" +
                         "<b>Expected Result:</b><br> Success notification should display.<br> " +
                         "Selected post should be remove from the dashboard.<br><br>",

            // 1.8
            "<b>Steps to Replicate:</b><br>" +
                         "1. On My Posts Page, click the Three Dots on the right side.<br>" +
                         "2. Click Mark as Returned options.<br>" +
                         "3. Click Select First 20 checkbox.<br>" +
                         "4. Click Mark as Returned button.<br>" +
                         "5. Click Confirm button.<br><br>" +
                         "<b>Expected Result:</b><br> Success notification should display.<br> " +
                         "Selected post should be remove from the dashboard.<br><br>",

            // 1.9
            "<b>Steps to Replicate:</b><br>" +
                        "1. On My Posts Page, click the Three Dots on the right side.<br>" +
                        "2. Click Mark as Returned options.<br>" +
                        "3. Click Mark as Returned button.<br><br>" +
                        "<b>Expected Result:</b><br> Error notification should display.<br><br> ",
        };
   }
}

