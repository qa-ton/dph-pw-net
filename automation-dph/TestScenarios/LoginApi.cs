namespace automation_dph.TestScenarios
{
    public class LoginApi : BasePageDriver
    {
        public LoginApi(IPage page, PageTest pageTest) : base(page, pageTest)
        {

        }

        public static string[] TestScenarios = new string[]
        {
            "1.1 Validate Valid Username and Valid Password",
            "1.2 Validate Valid Username and Invalid Password",
            "1.3 Validate Invalid Username and valid Password",
            "1.4 Validate Invalid Username and invalid Password",
            "1.5 Validate Blank value in Email field.",
            "1.6 Validate Blank value in Password field.",
            "1.7 Validate Max length value in Email field.",
            "1.8 Validate Max length value in Password field.",
        };

        public static string[] StepsToReplicate = new string[]
        {
            // 1.1
            "<b>Steps to Replicate:</b><br>" +
                        "1. Fill-up a Valid username in email field.<br>" +
                        "2. Fill-up a Valid password in password field.<br>" +
                        "3. Click Send button.<br><br>" +
                        "<b>Expected Result:</b><br> User should be login without any errors.<br> " +
                        "Response should be true.<br><br>",
            // 1.2
            "<b>Steps to Replicate:</b><br>" +
                        "1. Fill-up a Valid username in email field.<br>" +
                        "2. Fill-up a Invalid password in password field.<br>" +
                        "3. Click Send button.<br><br>" +
                        "<b>Expected Result:</b><br> User should not login.<br> " +
                        "Response should be INVALID_PASSWORD.<br><br>",
            // 1.3
            "<b>Steps to Replicate:</b><br>" +
                        "1. Fill-up a Invalid username in email field.<br>" +
                        "2. Fill-up a Valid password in password field.<br>" +
                        "3. Click Send button.<br><br>" +
                        "<b>Expected Result:</b><br> User should not login.<br> " +
                        "Response should be EMAIL_NOT_FOUND.<br><br>",
            // 1.4
           "<b>Steps to Replicate:</b><br>" +
                        "1. Fill-up a Invalid username in email field.<br>" +
                        "2. Fill-up a Invalid password in password field.<br>" +
                        "3. Click Send button.<br><br>" +
                        "<b>Expected Result:</b><br> User should not login.<br> " +
                        "Response should be EMAIL_NOT_FOUND.<br><br>",
            // 1.5
            "<b>Steps to Replicate:</b><br>" +
                        "1. Fill-up a blank value in email field.<br>" +
                        "2. Fill-up a valid value in password field.<br>" +
                        "3. Click Send button.<br><br>" +
                        "<b>Expected Result:</b><br> User should not login.<br> " +
                        "Response should be Validation Error.<br><br>",
            // 1.6
            "<b>Steps to Replicate:</b><br>" +
                        "1. Fill-up a valid value in email field.<br>" +
                        "2. Fill-up a blank value in password field.<br>" +
                        "3. Click Send button.<br><br>" +
                        "<b>Expected Result:</b><br> User should not login.<br> " +
                        "Response should be Validation Error.<br><br>",
            // 1.7
            "<b>Steps to Replicate:</b><br>" +
                        "1. Fill-up a max length value in email field.<br>" +
                        "2. Fill-up a valid value in password field.<br>" +
                        "3. Click Send button.<br><br>" +
                        "<b>Expected Result:</b><br> User should not login.<br> " +
                        "Response should be Validation Error.<br><br>",
            // 1.8
            "<b>Steps to Replicate:</b><br>" +
                        "1. Fill-up a valid value in email field.<br>" +
                        "2. Fill-up a max length value in password field.<br>" +
                        "3. Click Send button.<br><br>" +
                        "<b>Expected Result:</b><br> User should not login.<br> " +
                        "Response should be Validation Error.<br><br>",
        };
    }
}