
using System.Globalization;

namespace automation_dph.src.Tests.AddNewPostsSuites
{
    [TestClass]
    [TestCategory("SELECT COURIER PAGE TEST SUITES")]
    public class Suites_SelectCourierTests : BasePageTest
	{
        [TestMethod]
        [TestCategory("TS-4.11 ONDEMAND COURIER")]
        public async Task Test001_CourierPickupDate()
        {
            await CreatePosts(EnumsSelectCourierPage.CourierPickupDate(), "SelectCourier - Screenshot");
        }

        [TestMethod]
        [TestCategory("TS-4.11 ONDEMAND COURIER")]
        public async Task Test002_CourierDeliveryTime()
        {
            await CreatePosts(EnumsSelectCourierPage.CourierDeliveryTime(), "SelectCourier - Screenshot");
        }

        private async Task CreatePosts(IEnumerable<object[]> dataDetails, string screenShotFolderName)
        {
            foreach (var getData in dataDetails)
            {
                string deliveryType = (string)getData[0];
                //string courierType = (string)getData[1];
                string testScenariosDescription = (string)getData[1];
                string screenShotFileName = (string)getData[2];
                int selectCourierCardNumberPosition = (int)getData[3];

                // Test steps
                await MyPostsPages.AddNewPosts_Button.ClickAsync();
                await AddNewPostsPages.SelectDeliveryType(deliveryType);

                // get value of pickup date and time and delivery date and time
                var elementPickupDateAndTime = await Page.QuerySelectorAsync(".form-control");
                string? getValueOfElement = await elementPickupDateAndTime.GetAttributeAsync("value");

                // extract the value of date and time
                DateTime extractDate = DateTime.Parse(getValueOfElement);
                DateTime extractTime = DateTime.Parse(getValueOfElement);

                // convert the date to (e.g. Mar 1, 2024)
                DateTime parsedDate = DateTime.ParseExact(extractDate.ToString("MM/dd/yyyy"), "MM/dd/yyyy", CultureInfo.InvariantCulture);
                string? convertedDate = parsedDate.ToString("MMM dd, yyyy", CultureInfo.InvariantCulture);
                string? convertedTime = extractTime.ToString("h:mm tt");

                await AddNewPostsPages.PickupDetailsAutoFill("refno");
                await AddNewPostsPages.DeliveryDetailsAutoFill();

                if (screenShotFileName.Contains("4.11.1"))
                {
                    await AddNewPostsAssertions.ShouldDisplayPickupDate(selectCourierCardNumberPosition, convertedDate,
                          testScenariosDescription, screenShotFolderName, screenShotFileName);
                }
                else if (screenShotFileName.Contains("4.11.2"))
                {
                    await AddNewPostsAssertions.ShouldDisplayPickupDate(selectCourierCardNumberPosition, convertedTime,
                          testScenariosDescription, screenShotFolderName, screenShotFileName);
                }


            }
        }
    }
}

