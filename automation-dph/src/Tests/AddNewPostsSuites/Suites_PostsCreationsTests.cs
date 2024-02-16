
using System.Net;
using System.Net.Mail;

namespace automation_dph.src.Tests.AddNewPostsSuites
{
	[TestClass]
    [TestCategory("POST CREATIONS TEST SUITES")]
    public class Suites_PostsCreationsTests : BasePageTest
	{
        // include cod amount in test scenarios

        [TestMethod]
        [TestCategory("TS-4.1 ONDEMAND LALAMOVE POSTS CREATION")]
        public async Task Test001_OndemandPostsCreations()
        {
            await PostCreation(EnumsPostCreation.LalamoveCreation(), "PostsCreation - Screenshot");
        }

        [TestMethod]
        [TestCategory("TS-4.1 ONDEMAND LALAMOVE POSTS CREATION")]
        public async Task Test002_OndemandPostsCreationsCebuAreas()
        {
            await PostCreation(EnumsPostCreation.LalamoveCreationCebuAreas(), "PostsCreation - Screenshot");
        }

        [TestMethod]
        [TestCategory("TS-4.1 ONDEMAND LALAMOVE POSTS CREATION")]
        public async Task Test003_OndemandPostsCreationsPampangaAreas()
        {
            await PostCreation(EnumsPostCreation.LalamoveCreationPampangaAreas(), "PostsCreation - Screenshot");
        }

        [TestMethod]
        [TestCategory("TS-4.1 ONDEMAND LALAMOVE POSTS CREATION")]
        public async Task Test004_OndemandPostsCreationsNotSupported()
        {
            await PostCreation(EnumsPostCreation.LalamoveCreationNotSupported(), "PostsCreation - Screenshot");
        }

        [TestMethod]
        [TestCategory("TS-4.1 ONDEMAND LALAMOVE POSTS CREATION")]
        public async Task Test005_OndemandPostsCreationsNotSupportedCebuareas()
        {
            await PostCreation(EnumsPostCreation.LalamoveCreationNotSupportedCebuAreas(), "PostsCreation - Screenshot");
        }

        [TestMethod]
        [TestCategory("TS-4.5 SCHEDULED POSTS CREATION")]
        public async Task Test006_ScheduledPostsCreations()
        {
            await PostScheduledCreation(EnumsPostCreation.ScheduledCreation(), "PostsCreation - Screenshot");
        }

        [TestMethod]
        [Ignore]
        [TestCategory("TS-4.5 SCHEDULED POSTS CREATION")]
        public async Task Test007_ScheduledNonServiceable()
        {
            // This is based on provider setup
            await PostScheduledCreation(EnumsPostCreation.ScheduledNonServiceable(), "PostsCreation - Screenshot");
        }

        private async Task PostScheduledCreation(IEnumerable<object[]> postCreations, string screenShotFolderName)
        {
            GetDataTestConfiguration.GetJsonValueString();
            foreach (var getData in postCreations)
            {
                var parameters = new PostsDataConfiguration
                {
                    DeliveryType = (string)getData[0],
                    //VehicleType = (string)getData[1],
                    Sendername = (string)getData[1],
                    PickupMobileNumber = (string)getData[2],
                    PickupEmailAddress = (string)getData[3],
                    PickupAddress = (string)getData[4],
                    PickupProvince = (string)getData[5],
                    PickupCity = (string)getData[6],
                    PickupBarangay = (string)getData[7],
                    PickupPostalCode = (string)getData[8],
                    RecipientName = (string)getData[9],
                    DeliveryMobileNumber = (string)getData[10],
                    DeliveryEmailAddress = (string)getData[11],
                    DeliveryAddress = (string)getData[12],
                    DeliveryProvince = (string)getData[13],
                    DeliveryCity = (string)getData[14],
                    DeliveryBarangay = (string)getData[15],
                    DeliveryPostalCode = (string)getData[16],
                    Courier = (string)getData[17],
                    TestScenariosDescription = (string)getData[18],
                    ScreenShotFileName = (string)getData[19],
                };
                string TestType = (string)getData[20];

                if(TestType == "NonServiceable")
                {
                    await MyPostsPages.AddNewPosts_Button.ClickAsync();
                    await AddNewPostsPages.SelectDeliveryType(parameters.DeliveryType);
                    await AddNewPostsPages.PickupInputFillType(parameters.Sendername, parameters.PickupMobileNumber, parameters.PickupEmailAddress, parameters.PickupAddress,
                          parameters.PickupProvince, parameters.PickupCity, parameters.PickupBarangay, parameters.PickupPostalCode);
                    await AddNewPostsPages.DeliveryInputFillType(parameters.RecipientName, parameters.DeliveryMobileNumber, parameters.DeliveryEmailAddress, parameters.DeliveryAddress,
                          parameters.DeliveryProvince, parameters.DeliveryCity, parameters.DeliveryBarangay, parameters.DeliveryPostalCode);
                    await Page.GotoAsync("https://staging.deliveries.ph/");
                }
                else if(TestType == "Serviceable")
                {
                    await MyPostsPages.AddNewPosts_Button.ClickAsync();
                    await AddNewPostsPages.ManualFillPostsCreation(parameters);
                    await AddNewPostsPages.Save_Button.ClickAsync();
                    await ManualPostsCreationAssertions.ShouldSuccessNotificationAppear(
                                 parameters.TestScenariosDescription, screenShotFolderName, parameters.ScreenShotFileName);
                }
            }
        }

        private async Task PostCreation(IEnumerable<object[]> postCreations, string screenShotFolderName)
        {
            GetDataTestConfiguration.GetJsonValueString();
            foreach (var getData in postCreations)
            {
                var parameters = new PostsDataConfiguration
                {
                    DeliveryType = (string)getData[0],
                    VehicleType = (string)getData[1],
                    Sendername = (string)getData[2],
                    PickupMobileNumber = (string)getData[3],
                    PickupEmailAddress = (string)getData[4],
                    PickupAddress = (string)getData[5],
                    PickupProvince = (string)getData[6],
                    PickupCity = (string)getData[7],
                    PickupBarangay = (string)getData[8],
                    PickupPostalCode = (string)getData[9],
                    RecipientName = (string)getData[10],
                    DeliveryMobileNumber = (string)getData[11],
                    DeliveryEmailAddress = (string)getData[12],
                    DeliveryAddress = (string)getData[13],
                    DeliveryProvince = (string)getData[14],
                    DeliveryCity = (string)getData[15],
                    DeliveryBarangay = (string)getData[16],
                    DeliveryPostalCode = (string)getData[17],
                    Courier = (string)getData[18],
                    TestScenariosDescription = (string)getData[19],
                    ScreenShotFileName = (string)getData[20],
                };
                string TestType = (string)getData[21];
                if (TestType == "VehicleNotSupported")
                {
                    // Test Steps
                    await MyPostsPages.AddNewPosts_Button.ClickAsync();
                    await AddNewPostsPages.SelectDeliveryType(parameters.DeliveryType);
                    await AddNewPostsPages.PickupInputFillType(parameters.Sendername, parameters.PickupMobileNumber, parameters.PickupEmailAddress, parameters.PickupAddress,
                          parameters.PickupProvince, parameters.PickupCity, parameters.PickupBarangay, parameters.PickupPostalCode);
                    await AddNewPostsPages.DeliveryInputFillType(parameters.RecipientName, parameters.DeliveryMobileNumber, parameters.DeliveryEmailAddress, parameters.DeliveryAddress,
                          parameters.DeliveryProvince, parameters.DeliveryCity, parameters.DeliveryBarangay, parameters.DeliveryPostalCode);
                    await AddNewPostsPages.SelectVehicleType(parameters.VehicleType);
                    EnvironmentVariableManager.SetValue(AddNewPostsPages.VehicleTypeSelectCourier_Label, AddNewPostsPages.GetValueOfVehicleTypeInCourierPage);
                    await Page.WaitForLoadStateAsync();
                    ILocator selectCourier = Page.Locator($"//div[contains(text(),'{parameters.Courier}')]");
                    await selectCourier.First.HoverAsync();
                    await ManualPostsCreationAssertions.ShouldInformationMessageDisplay(
                                 parameters.TestScenariosDescription, screenShotFolderName, parameters.ScreenShotFileName);
                    await Page.GotoAsync("https://staging.deliveries.ph/");
                }
                else if (TestType == "VehicleSupported")
                {
                    // Test Steps
                    await MyPostsPages.AddNewPosts_Button.ClickAsync();
                    await AddNewPostsPages.ManualFillPostsCreation(parameters);
                    await AddNewPostsPages.Save_Button.ClickAsync();
                    await ManualPostsCreationAssertions.ShouldSuccessNotificationAppear(
                                 parameters.TestScenariosDescription, screenShotFolderName, parameters.ScreenShotFileName);
                }
            }
        }
    }
}

 