namespace automation_dph.TestScenarios
{
    public class Login : BasePageDriver
    {
        public Login(IPage page, PageTest pageTest) : base(page, pageTest)
        {

        }

        public const string ScreenShotFolderName = "Login - Screenshot";

        public string[] TestScenarios = new string[]
        {
            "1.1 Validate Valid Username and Valid Password",
            "1.2 Validate Valid Username and Invalid Password",
            "1.3 Validate Invalid Username and valid Password",
            "1.4 Validate Invalid Username and invalid Password",
            "1.5 Validate Checked/Unchecked Remember username",
            "1.6 Validate Forgot Password? Hyperlink",
            "1.7 Validate Valid email for Reset Password",
            "1.8 Validate Blank value in Email field",
            "1.9 Validate Blank value in Password field",
            "1.12 Validate Blank value in Reset page Email field",
            "5.10 Validate Applying date again (Yesterday)",
        };

        public string[] StepsToReplicate = new string[]
        {
            // 1.1
            "<b>Steps to Replicate:</b><br>" +
                        "1. Enter Valid username in email textfield.<br>" +
                        "2. Enter Valid password in password textfield.<br>" +
                        "3. Click login button.<br><br>" +
                        "<b>Expected Result:</b><br> User should be login without any errors.<br> " +
                        "Succes notification should display.<br><br>",
            // 1.2
            "<b>Steps to Replicate:</b><br>" +
                        "1. Enter Valid username in email textfield.<br>" +
                        "2. Enter Invalid password in password textfield.<br>" +
                        "3. Click login button.<br><br>" +
                        "<b>Expected Result:</b><br> User should not be login.<br> " +
                        "Error notification should display.<br><br>",
            // 1.3
            "<b>Steps to Replicate:</b><br>" +
                         "1. Enter Invalid username in email textfield.<br>" +
                         "2. Enter Valid password in password textfield.<br>" +
                         "3. Click login button.<br><br>" +
                         "<b>Expected Result:</b><br> User should not be login.<br> " +
                         "Error notification should display.<br><br>",
            // 1.4
            "<b>Steps to Replicate:</b><br>" +
                         "1. Enter Invalid username in email textfield.<br>" +
                         "2. Enter Invalid password in password textfield.<br>" +
                         "3. Click login button.<br><br>" +
                         "<b>Expected Result:</b><br> User should not be login.<br> " +
                         "Error notification should display.<br><br>",
            // 1.5
            "<b>Steps to Replicate:</b><br>" +
                         "1. Enter Valid username in email textfield.<br>" +
                         "2. Enter Valid password in password textfield.<br>" +
                         "3. Click Remember username checkbox.<br>" +
                         "4. Click login button.<br>" +
                         "5. Click profile icon, then click logout button.<br>" +
                         "6. Verify value username in email textfield.<br><br>" +
                         "<b>Expected Result:</b><br> Value should display based on the input.<br><br>",
            // 1.6
            "<b>Steps to Replicate:</b><br>" +
                         "1. Click Forgot Password? hyper link.<br>" +
                         "2. Enter value in email textfield.<br><br>" +
                         "<b>Expected Result:</b><br> Inputted value should display.<br><br>",
            // 1.7
            "<b>Steps to Replicate:</b><br>" +
                         "1. Click Forgot Password? hyper link.<br>" +
                         "2. Enter value in email textfield.<br>" +
                         "3. Click Reset Password button.<br><br>" +
                         "<b>Expected Result:</b><br> Succcess notification should display.<br>" +
                         "Reset password link should send based on email inputted.<br><br>",
            // 1.8
            "<b>Steps to Replicate:</b><br>" +
                         "1. Enter Blank value in email textfield.<br>" +
                         "2. Enter Valid password in password textfield.<br>" +
                         "3. Click login button.<br><br>" +
                         "<b>Expected Result:</b><br> User should not be login.<br>" +
                         "Error notification should display.<br><br>",
            // 1.9
            "<b>Steps to Replicate:</b><br>" +
                         "1. Enter Valid value in email textfield.<br>" +
                         "2. Enter Blank password in password textfield.<br>" +
                         "3. Click login button.<br><br>" +
                         "<b>Expected Result:</b><br> User should not be login.<br>" +
                         "Error notification should display.<br><br>",
            // 1.12
            "<b>Steps to Replicate:</b><br>" +
                         "1. Click Forgot Password? hyper link.<br>" +
                         "2. Enter Blank value in email textfield.<br>" +
                         "3. Click Reset Password button.<br><br>" +
                         "<b>Expected Result:</b><br> Error notification should display.<br>" +
                         "Reset password link should not sent.<br><br>",
        };
    }
}