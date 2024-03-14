
namespace automation_dph.src.Tests.AddNewPostsSuites
{
	[TestClass]
	[TestCategory("AUTO FILL DETAILS TEST SUTIES")]
	public class Suites_AutoFillDetailsTests : BasePageTest
	{
		[TestMethod]
		[TestCategory("4.17 ONDEMAND AUTOFILL PICKUP DETAILS")]
		public async Task Test_001AddNewProfileDetails()
		{
			await MyPostsPages.AddNewPosts_Button.ClickAsync();
			await AddNewPostsPages.SelectDeliveryType("Ondemand");
			await AddNewPostsPages.AutoFillPickupDetails_Button.ClickAsync();
			await AddNewPostsPages.AddNewProfile_Link.ClickAsync();
			await PickupDetailsManualFill();
		}

        private async Task PickupDetailsManualFill()
        {
			await AddNewPostsPages.InputCustomerDetails("customerName", "mobileNumber", "email");
			await AddNewPostsPages.InputLocationDetails("METRO MANILA", "METRO MANILA", "MALABON CITY", "LONGOS", "1234");
			await AddNewPostsPages.InputPostDetails("remarks",1);

        }
    }
}

