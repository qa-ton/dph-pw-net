
namespace automation_dph.src.Pages
{
    public class LoginPages : BasePageDriver
    {
        public LoginPages(IPage page, PageTest pageTest) : base(page, pageTest)
        {

        }

        // TEXT FIELDS
        private ILocator TxtEmailUser => Page.Locator("#dph-login-email");
        private ILocator TxtPasswordUser => Page.Locator("#dph-login-pass");
        private ILocator TxtEmailReset => Page.Locator("//div[@class='login-container']//input");

        // CHECKBOXES
        private ILocator ChkRememberUsername => Page.Locator(".checkmark");

        // HYPERLINKS
        private ILocator LnkForgotPassword => Page.Locator(".forgot-password");
        private ILocator LnkLogin => Page.Locator(".forgot-password.tw-text-base");

        // BUTTONS
        private ILocator BtnLoginUser => Page.Locator("#dph-login-submit-btn");
        private ILocator BtnResetPassword => Page.Locator("text='Reset Password'");


        public ILocator LoginTextEmailUsername { get { return TxtEmailUser; } }
        public ILocator LoginTextPasswordUsername { get { return TxtPasswordUser; } }
        public ILocator LoginButton { get { return BtnLoginUser; } }
        public ILocator RememberUsername_Checkbox { get { return ChkRememberUsername; } }
        public ILocator ForgotPassword_Hyperlink { get { return LnkForgotPassword; } }
        public ILocator EmailReset_Textfield { get { return TxtEmailReset; } }
        public ILocator ResetPassword_Button { get { return BtnResetPassword; } }
        public ILocator Login_Hyperlink { get { return LnkLogin; } }

        private ILocator NotificationCard => Page.Locator(".Toastify__toast-body");
        public ILocator SuccessNotification { get { return NotificationCard; } }

        private ILocator ErrorNotificationCard => Page.Locator(".Toastify__toast.Toastify__toast--error");
        public ILocator ErrorNotification { get { return ErrorNotificationCard; } }

        public string GetSuccessMessageNotification { get { return NotificationCard.First.InnerTextAsync().GetAwaiter().GetResult(); } }
        public string GetErrorMessageNotification { get { return NotificationCard.First.InnerTextAsync().GetAwaiter().GetResult(); } }
        public string? GetValueOfEmailText { get { return TxtEmailUser.InputValueAsync().GetAwaiter().GetResult(); } }

        public async Task LoginToWebApplication(string username, string password)
        {
            _logger.Trace("Attempting to perform a login.");
            await TxtEmailUser.FillAsync(username);
            await TxtPasswordUser.FillAsync(password);
            await BtnLoginUser.ClickAsync();
            // Info logging level.
            // To signify manual functional test that performing in test
            // Should be used for manual functional test steps
            _logger.Info("Logged into web application.");
        }

        public async Task GoToForgotPassword()
        {
            await ForgotPassword_Hyperlink.ClickAsync();
            _logger.Info("Forgot Password hyperlink is clicked.");
        }
    }
}