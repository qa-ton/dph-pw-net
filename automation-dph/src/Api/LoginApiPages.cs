using Microsoft.Playwright;

namespace automation_dph.src.Api
{
    public class LoginApiPages : BasePageDriver
    {
        public LoginApiPages(IPage page, PageTest pageTest) : base(page, pageTest)
        {

        }

        private IAPIRequestContext requestContext = null!;
        private IAPIResponse response = null!;

        public async Task LoginToAPI(string emailAPI, string passwordAPI, string environment)
        {
            var playwright = await Playwright.CreateAsync();
            requestContext = await playwright.APIRequest.NewContextAsync(new APIRequestNewContextOptions()
            {
                BaseURL = $"{environment}",
                IgnoreHTTPSErrors = true
            });

            response = await requestContext.PostAsync(url: "/login", new APIRequestContextOptions()
            {
                // this is a anonymous type
                // get api field
                DataObject = new
                {
                    email = emailAPI,
                    password = passwordAPI
                }
            });

            // Assert for response result
            var jsonString = await response.JsonAsync();
            var jsonResultString = await response.TextAsync();

            LoginResponseField.Success = jsonString?.GetProperty("success").GetBoolean();
            //PostField.ApiKey = jsonString?.GetProperty("results").GetProperty("apiKey").GetString()!;
            //PostField.ClientId = jsonString?.GetProperty("results").GetProperty("clientId").GetString();
            //PostField.SessionToken = jsonString?.GetProperty("results").GetProperty("sessionToken").GetString();
            LoginResponseField.ResponseResults = jsonResultString;
        }
    }
}