
namespace automation_dph.src.Tests.AddNewPostsSuites
{
    [TestClass]
    [TestCategory("PICkUP DETAILS PAGE TEST SUITES")]
    public class Suites_PickupDetailsTests : BasePageTest
    {
        [TestMethod]
        [TestCategory("TS-4.7 ONDEMAND PICKUP DETAILS")]
        [TestCategory("TS-4.9 ONDEMAND DELIVERY DETAILS")]
        public async Task Test001_InputValidValue()
        {
            await CreationDetails(EnumsPostFieldDetails.ValidDataValueForOndemandPickupDetails(), "PickupDetails - Screenshot");
            await CreationDetails(EnumsPostFieldDetails.ValidDataValueForOndemandDeliveryDetails(), "DeliveryDetails - Screenshot");
        }

        [TestMethod]
        [TestCategory("TS-4.7 ONDEMAND PICKUP DETAILS")]
        [TestCategory("TS-4.9 ONDEMAND DELIVERY DETAILS")]
        public async Task Test002_ClearFunctionality()
        {
            await CreationDetails(EnumsPostFieldDetails.ClearFunctionalityDataForOndemandPickupDetails(), "PickupDetails - Screenshot");
            await CreationDetails(EnumsPostFieldDetails.ClearFunctionalityDataForOndemandDeliveryDetails(), "DeliveryDetails - Screenshot");
        }

        [TestMethod]
        [TestCategory("TS-4.7 ONDEMAND PICKUP DETAILS")]
        [TestCategory("TS-4.9 ONDEMAND DELIVERY DETAILS")]
        public async Task Test003_PreviousStepFunctionality()
        {
            await CreationDetails(EnumsPostFieldDetails.PreviousStepFunctionalityDataForOndemandPickupDetails(), "PickupDetails - Screenshot");
            await CreationDetails(EnumsPostFieldDetails.PreviousStepFunctionalityDataForOndemandDeliveryDetails(), "DeliveryDetails - Screenshot");
        }

        [TestMethod]
        [TestCategory("TS-4.7 ONDEMAND PICKUP DETAILS")]
        [TestCategory("TS-4.9 ONDEMAND DELIVERY DETAILS")]
        public async Task Test004_PickupDetailsHyperlink()
        {
            await CreationDetails(EnumsPostFieldDetails.HyperlinkFunctionalityDataForOndemandPickupDetails(), "PickupDetails - Screenshot");
            await CreationDetails(EnumsPostFieldDetails.HyperlinkFunctionalityDataForOndemandDeliveryDetails(), "DeliveryDetails - Screenshot");
        }

        [TestMethod]
        [TestCategory("TS-4.7 ONDEMAND PICKUP DETAILS")]
        [TestCategory("TS-4.9 ONDEMAND DELIVERY DETAILS")]
        public async Task Test005_InputInvalidValue()
        {
            await CreationDetails(EnumsPostFieldDetails.InvalidDataValueForOndemandPickupDetails(), "PickupDetails - Screenshot");
            await CreationDetails(EnumsPostFieldDetails.InvalidDataValueForOndemandDeliveryDetails(), "DeliveryDetails - Screenshot");
        }

        [TestMethod]
        [TestCategory("TS-4.7 ONDEMAND PICKUP DETAILS")]
        [TestCategory("TS-4.9 ONDEMAND DELIVERY DETAILS")]
        public async Task Test006_InputBlankValue()
        {
            await CreationDetails(EnumsPostFieldDetails.BlankDataValueForOndemandPickupDetails(), "PickupDetails - Screenshot");
            await CreationDetails(EnumsPostFieldDetails.BlankDataValueForOndemandDeliveryDetails(), "DeliveryDetails - Screenshot");
        }

        [TestMethod]
        [TestCategory("TS-4.7 ONDEMAND PICKUP DETAILS")]
        [TestCategory("TS-4.9 ONDEMAND DELIVERY DETAILS")]
        public async Task Test007_InputMaxLengthValue()
        {
            await CreationDetails(EnumsPostFieldDetails.MaxLengthDataValueForOndemandPickupDetails(), "PickupDetails - Screenshot");
            await CreationDetails(EnumsPostFieldDetails.MaxLengthDataValueForOndemandDeliveryDetails(), "DeliveryDetails - Screenshot");
        }

        [TestMethod]
        [TestCategory("TS-4.8 SCHEDULED PICKUP DETAILS")]
        [TestCategory("TS-4.10 SCHEDULED DELIVERY DETAILS")]
        public async Task Test008_InputValidValue()
        {
            await CreationDetails(EnumsPostFieldDetails.ValidDataValueForScheduledPickupDetails(), "PickupDetails - Screenshot");
            await CreationDetails(EnumsPostFieldDetails.ValidDataValueForScheduledDeliveryDetails(), "DeliveryDetails - Screenshot");
        }

        [TestMethod]
        [TestCategory("TS-4.8 SCHEDULED PICKUP DETAILS")]
        [TestCategory("TS-4.10 SCHEDULED DELIVERY DETAILS")]
        public async Task Test009_ClearFunctionality()
        {
            await CreationDetails(EnumsPostFieldDetails.ClearFunctionalityDataForScheduledPickupDetails(), "PickupDetails - Screenshot");
            await CreationDetails(EnumsPostFieldDetails.ClearFunctionalityDataForScheduledDeliveryDetails(), "DeliveryDetails - Screenshot");
        }

        [TestMethod]
        [TestCategory("TS-4.8 SCHEDULED PICKUP DETAILS")]
        [TestCategory("TS-4.10 SCHEDULED DELIVERY DETAILS")]
        public async Task Test010_PreviousStepFunctionality()
        {
            await CreationDetails(EnumsPostFieldDetails.PreviousStepFunctionalityDataForScheduledPickupDetails(), "PickupDetails - Screenshot");
            await CreationDetails(EnumsPostFieldDetails.PreviousStepFunctionalityDataForScheduledDeliveryDetails(), "DeliveryDetails - Screenshot");
        }

        [TestMethod]
        [TestCategory("TS-4.8 SCHEDULED PICKUP DETAILS")]
        [TestCategory("TS-4.10 SCHEDULED DELIVERY DETAILS")]
        public async Task Test011_PickupDetailsHyperlink()
        {
            await CreationDetails(EnumsPostFieldDetails.HyperlinkFunctionalityDataForScheduledPickupDetails(), "PickupDetails - Screenshot");
            await CreationDetails(EnumsPostFieldDetails.HyperlinkFunctionalityDataForScheduledDeliveryDetails(), "DeliveryDetails - Screenshot");
        }

        [TestMethod]
        [TestCategory("TS-4.8 SCHEDULED PICKUP DETAILS")]
        [TestCategory("TS-4.10 SCHEDULED DELIVERY DETAILS")]
        public async Task Test012_InputInvalidValue()
        {
            await CreationDetails(EnumsPostFieldDetails.InvalidDataValueForScheduledPickupDetails(), "PickupDetails - Screenshot");
            await CreationDetails(EnumsPostFieldDetails.InvalidDataValueForScheduledDeliveryDetails(), "DeliveryDetails - Screenshot");
        }

        [TestMethod]
        [TestCategory("TS-4.8 SCHEDULED PICKUP DETAILS")]
        [TestCategory("TS-4.10 SCHEDULED DELIVERY DETAILS")]
        public async Task Test013_InputBlankValue()
        {
            await CreationDetails(EnumsPostFieldDetails.BlankDataValueForScheduledPickupDetails(), "PickupDetails - Screenshot");
            await CreationDetails(EnumsPostFieldDetails.BlankDataValueForScheduledDeliveryDetails(), "DeliveryDetails - Screenshot");
        }

        [TestMethod]
        [TestCategory("TS-4.8 SCHEDULED PICKUP DETAILS")]
        [TestCategory("TS-4.10 SCHEDULED DELIVERY DETAILS")]
        public async Task Test014_InputMaxLengthValue()
        {
            await CreationDetails(EnumsPostFieldDetails.MaxLengthDataValueForScheduledPickupDetails(), "PickupDetails - Screenshot");
            await CreationDetails(EnumsPostFieldDetails.MaxLengthDataValueForScheduledDeliveryDetails(), "DeliveryDetails - Screenshot");
        }



        private async Task CreationDetails(IEnumerable<object[]> fieldDetails, string screenShotFolderName)
        {
            foreach(var getData in fieldDetails)
            {
                string deliveryType = (string)getData[0];
                string testScenariosDescription = (string)getData[1];
                string screenShotFileName = (string)getData[2];
                ILocator labelLocator = (ILocator)getData[3];

                if (testScenariosDescription.Contains("Validate Valid"))
                {
                    await MyPostsPages.AddNewPosts_Button.ClickAsync();
                    await AddNewPostsPages.SelectDeliveryType(deliveryType);
                    await AddNewPostsPages.PickupDetailsAutoFill("refNo");

                    if (screenShotFileName.Contains("PickupDetails"))
                    {
                        await AddNewPostsAssertions.ShouldProceedToNextPage(labelLocator,
                            testScenariosDescription, screenShotFolderName, screenShotFileName);
                    }
                    else if (screenShotFileName.Contains("DeliveryDetails"))
                    {
                        await AddNewPostsPages.DeliveryDetailsAutoFill();
                        await AddNewPostsAssertions.ShouldProceedToNextPage(labelLocator,
                            testScenariosDescription, screenShotFolderName, screenShotFileName);
                    }
                }

                else if (testScenariosDescription.Contains("Validate Clear"))
                {
                    ILocator dropdownLocator = (ILocator)getData[3];
                    ILocator buttonLocator = (ILocator)getData[4];
                    await MyPostsPages.AddNewPosts_Button.ClickAsync();
                    await AddNewPostsPages.SelectDeliveryType(deliveryType);
                    await AddNewPostsPages.ReferenceNumber_Textbox.FillAsync("refNo");
                    await AddNewPostsPages.UseLastProfilePickup_Button.ClickAsync();

                    if (screenShotFileName.Contains("PickupDetails"))
                    {
                        await buttonLocator.ClickAsync();
                        await AddNewPostsAssertions.ShouldClearValue(dropdownLocator,
                                testScenariosDescription, screenShotFolderName, screenShotFileName);
                    }
                    else if (screenShotFileName.Contains("DeliveryDetails"))
                    {
                        await AddNewPostsPages.NextStepPickupDelivery_Button.ClickAsync();
                        await AddNewPostsPages.UseLastProfileDelivery_Button.ClickAsync();
                        await buttonLocator.ClickAsync();
                        await AddNewPostsAssertions.ShouldClearValue(dropdownLocator,
                                testScenariosDescription, screenShotFolderName, screenShotFileName);
                    }
                }

                else if (testScenariosDescription.Contains("Previous"))
                {
                    await MyPostsPages.AddNewPosts_Button.ClickAsync();
                    await AddNewPostsPages.SelectDeliveryType(deliveryType);
                    await AddNewPostsPages.ReferenceNumber_Textbox.FillAsync("refNo");
                    await AddNewPostsPages.UseLastProfilePickup_Button.ClickAsync();

                    if (screenShotFileName.Contains("PickupDetails"))
                    {
                        await AddNewPostsPages.PreviousStepPickupDetails_Button.First.ClickAsync();
                        await AddNewPostsAssertions.ShouldDisplayPreviousPage(labelLocator,
                                testScenariosDescription, screenShotFolderName, screenShotFileName);
                    }
                    else if (screenShotFileName.Contains("DeliveryDetails"))
                    {
                        await AddNewPostsPages.NextStepPickupDelivery_Button.ClickAsync();
                        await AddNewPostsPages.PreviousStepPickupDetails_Button.First.ClickAsync();
                        await AddNewPostsAssertions.ShouldDisplayPreviousPage(labelLocator,
                                testScenariosDescription, screenShotFolderName, screenShotFileName);
                    }
                }

                else if (testScenariosDescription.Contains("Details hyperlink"))
                {
                    ILocator LinkLocator = (ILocator)getData[4];
                    await MyPostsPages.AddNewPosts_Button.ClickAsync();
                    await AddNewPostsPages.SelectDeliveryType(deliveryType);
                    await AddNewPostsPages.PickupDetailsAutoFill("refNo");

                    if (screenShotFileName.Contains("PickupDetails"))
                    {
                        await LinkLocator.ClickAsync();
                        await AddNewPostsAssertions.ShouldDisplayPreviousPage(labelLocator,
                                testScenariosDescription, screenShotFolderName, screenShotFileName);
                    }
                    else if (screenShotFileName.Contains("DeliveryDetails"))
                    {
                        await AddNewPostsPages.DeliveryDetailsAutoFill();
                        await LinkLocator.ClickAsync();
                        await AddNewPostsAssertions.ShouldDisplayPreviousPage(labelLocator,
                                testScenariosDescription, screenShotFolderName, screenShotFileName);
                    }
                }

                else if (testScenariosDescription.Contains("Invalid value"))
                {
                    ILocator textboxLocator = (ILocator)getData[3];
                    string inputValue = (string)getData[4];
                    ILocator courierLabelLocator = (ILocator)getData[5];

                    if (screenShotFileName.Contains("PickupDetails"))
                    {
                        if (testScenariosDescription.Contains("4.7.29") || testScenariosDescription.Contains("4.8.29"))
                        {
                            await TestStepMethod(deliveryType, inputValue, textboxLocator);
                            await AddNewPostsAssertions.ShouldDisplayErrorNotification(
                                testScenariosDescription, screenShotFolderName, screenShotFileName);
                        }
                        else
                        {
                            await TestStepMethod(deliveryType, inputValue, textboxLocator);
                            await AddNewPostsAssertions.ShouldProceedToNextPage(courierLabelLocator,
                                testScenariosDescription, screenShotFolderName, screenShotFileName);
                        }
                    }
                    else if (screenShotFileName.Contains("DeliveryDetails"))
                    {
                        if (testScenariosDescription.Contains("4.9.30") || testScenariosDescription.Contains("4.9.31") || testScenariosDescription.Contains("4.9.32") ||
                             testScenariosDescription.Contains("4.9.43") || testScenariosDescription.Contains("4.9.44") || screenShotFileName.Contains("4.10.30") ||
                             screenShotFileName.Contains("4.10.31") || screenShotFileName.Contains("4.10.32") || screenShotFileName.Contains("4.10.43") ||
                             screenShotFileName.Contains("4.10.44"))
                        {
                            await MyPostsPages.AddNewPosts_Button.ClickAsync();
                            await AddNewPostsPages.SelectDeliveryType(deliveryType);
                            await AddNewPostsPages.PickupDetailsAutoFill("refno");
                            await AddNewPostsPages.UseLastProfileDelivery_Button.ClickAsync();
                            await AddNewPostsPages.InputPricingDetails("1", "0", "0", "2", "3", "4", "1", "2");
                            await textboxLocator.FillAsync(inputValue);
                            await AddNewPostsPages.NextStepPickupDelivery_Button.ClickAsync();
                            await AddNewPostsAssertions.ShouldProceedToNextPage(courierLabelLocator,
                                testScenariosDescription, screenShotFolderName, screenShotFileName);
                        }
                        else
                        {
                            await MyPostsPages.AddNewPosts_Button.ClickAsync();
                            await AddNewPostsPages.SelectDeliveryType(deliveryType);
                            await AddNewPostsPages.PickupDetailsAutoFill("refno");
                            await AddNewPostsPages.UseLastProfileDelivery_Button.ClickAsync();
                            await AddNewPostsPages.InputPricingDetails("1", "0", "0", "2", "3", "4", "1", "2");
                            await textboxLocator.ClearAsync();
                            await textboxLocator.FillAsync(inputValue);
                            await AddNewPostsPages.NextStepPickupDelivery_Button.ClickAsync();
                            await AddNewPostsAssertions.ShouldDisplayErrorNotification(
                                testScenariosDescription, screenShotFolderName, screenShotFileName);

                        }
                    }
                }

                else if(testScenariosDescription.Contains("Blank value"))
                {
                    ILocator textboxLocator = (ILocator)getData[3];
                    string inputValue = (string)getData[4];
                    ILocator courierLabelLocator = (ILocator)getData[5];

                    if(screenShotFileName.Contains("PickupDetails"))
                    {
                        if(testScenariosDescription.Contains("4.7.34") || testScenariosDescription.Contains("4.7.40") ||
                            testScenariosDescription.Contains("4.8.34") || testScenariosDescription.Contains("4.8.40"))
                        {
                            await MyPostsPages.AddNewPosts_Button.ClickAsync();
                            await AddNewPostsPages.SelectDeliveryType(deliveryType);
                            await AddNewPostsPages.ReferenceNumber_Textbox.FillAsync("refNo");
                            await AddNewPostsPages.UseLastProfilePickup_Button.ClickAsync();
                            await textboxLocator.FillAsync(inputValue);
                            await AddNewPostsPages.NextStepPickupDelivery_Button.ClickAsync();
                            //await TestStepMethod(deliveryType, inputValue, textboxLocator);
                            await AddNewPostsAssertions.ShouldProceedToNextPage(courierLabelLocator,
                                    testScenariosDescription, screenShotFolderName, screenShotFileName);
                        }
                        else if(testScenariosDescription.Contains("4.7.36") || testScenariosDescription.Contains("4.7.37") || testScenariosDescription.Contains("4.7.38") ||
                            testScenariosDescription.Contains("4.8.36") || testScenariosDescription.Contains("4.8.37") || testScenariosDescription.Contains("4.8.38"))
                        {
                            await MyPostsPages.AddNewPosts_Button.ClickAsync();
                            await AddNewPostsPages.SelectDeliveryType(deliveryType);
                            await AddNewPostsPages.ReferenceNumber_Textbox.FillAsync("refNo");
                            await AddNewPostsPages.UseLastProfilePickup_Button.ClickAsync();
                            await textboxLocator.ClickAsync();
                            await Page.Keyboard.PressAsync("Delete");
                            await AddNewPostsPages.NextStepPickupDelivery_Button.ClickAsync();
                            await AddNewPostsAssertions.ShouldDisplayErrorNotification(
                                testScenariosDescription, screenShotFolderName, screenShotFileName);
                        }
                        else
                        {
                            await TestStepMethod(deliveryType, inputValue, textboxLocator);
                            await AddNewPostsAssertions.ShouldDisplayErrorNotification(
                                testScenariosDescription, screenShotFolderName, screenShotFileName);
                        }
                    }
                    else if(screenShotFileName.Contains("DeliveryDetails"))
                    {
                        if (testScenariosDescription.Contains("4.9.47") || testScenariosDescription.Contains("4.9.61") || testScenariosDescription.Contains("4.9.62") ||
                            testScenariosDescription.Contains("4.10.47") || testScenariosDescription.Contains("4.10.61") || testScenariosDescription.Contains("4.10.62"))
                        {
                            await MyPostsPages.AddNewPosts_Button.ClickAsync();
                            await AddNewPostsPages.SelectDeliveryType(deliveryType);
                            await AddNewPostsPages.PickupDetailsAutoFill("refno");
                            await AddNewPostsPages.UseLastProfileDelivery_Button.ClickAsync();
                            await AddNewPostsPages.InputPricingDetails("1", "0", "0", "2", "3", "4", "1", "2");
                            await textboxLocator.ClearAsync();
                            await textboxLocator.FillAsync(inputValue);
                            await AddNewPostsPages.NextStepPickupDelivery_Button.ClickAsync();
                            //await TestStepMethod(deliveryType, inputValue, textboxLocator);
                            await AddNewPostsAssertions.ShouldProceedToNextPage(courierLabelLocator,
                                    testScenariosDescription, screenShotFolderName, screenShotFileName);
                        }
                        else if (testScenariosDescription.Contains("4.9.49") || testScenariosDescription.Contains("4.9.50") || testScenariosDescription.Contains("4.9.51") ||
                            testScenariosDescription.Contains("4.10.49") || testScenariosDescription.Contains("4.10.50") || testScenariosDescription.Contains("4.10.51"))
                        {
                            await MyPostsPages.AddNewPosts_Button.ClickAsync();
                            await AddNewPostsPages.SelectDeliveryType(deliveryType);
                            await AddNewPostsPages.ReferenceNumber_Textbox.FillAsync("refNo");
                            await AddNewPostsPages.UseLastProfilePickup_Button.ClickAsync();
                            await AddNewPostsPages.NextStepPickupDelivery_Button.ClickAsync();
                            await AddNewPostsPages.UseLastProfileDelivery_Button.ClickAsync();
                            await AddNewPostsPages.InputPricingDetails("1", "0", "0", "2", "3", "4", "1", "2");
                            await textboxLocator.ClickAsync();
                            await Page.Keyboard.PressAsync("Delete");
                            await AddNewPostsPages.NextStepPickupDelivery_Button.ClickAsync();
                            await AddNewPostsAssertions.ShouldDisplayErrorNotification(
                                testScenariosDescription, screenShotFolderName, screenShotFileName);
                        }
                        else
                        {
                            await MyPostsPages.AddNewPosts_Button.ClickAsync();
                            await AddNewPostsPages.SelectDeliveryType(deliveryType);
                            await AddNewPostsPages.PickupDetailsAutoFill("refno");
                            await AddNewPostsPages.UseLastProfileDelivery_Button.ClickAsync();
                            await AddNewPostsPages.InputPricingDetails("1", "0", "0", "2", "3", "4", "1", "2");
                            await textboxLocator.ClearAsync();
                            await textboxLocator.FillAsync(inputValue);
                            await AddNewPostsPages.NextStepPickupDelivery_Button.ClickAsync();
                            await AddNewPostsAssertions.ShouldDisplayErrorNotification(
                                testScenariosDescription, screenShotFolderName, screenShotFileName);
                        }
                    }
                }

                else if(testScenariosDescription.Contains("Max Length"))
                {
                    ILocator textboxLocator = (ILocator)getData[3];
                    string inputValue = (string)getData[4];

                    if (screenShotFileName.Contains("PickupDetails"))
                    {
                        await MyPostsPages.AddNewPosts_Button.ClickAsync();
                        await AddNewPostsPages.SelectDeliveryType(deliveryType);
                        await textboxLocator.FillAsync(inputValue);
                        if (testScenariosDescription.Contains("4.7.47") || testScenariosDescription.Contains("4.8.47"))
                        {
                            await AddNewPostsAssertions.ShouldNotExceededForTextArea(textboxLocator,
                                testScenariosDescription, screenShotFolderName, screenShotFileName);
                        }
                        else
                        {
                            await AddNewPostsAssertions.ShouldValueNotExceeded(textboxLocator,
                                testScenariosDescription, screenShotFolderName, screenShotFileName);
                        }
                    }
                    else if(screenShotFileName.Contains("DeliveryDetails"))
                    {
                        await MyPostsPages.AddNewPosts_Button.ClickAsync();
                        await AddNewPostsPages.SelectDeliveryType(deliveryType);
                        await AddNewPostsPages.PickupDetailsAutoFill("refno");
                        await AddNewPostsPages.UseLastProfileDelivery_Button.ClickAsync();
                        await textboxLocator.ClickAsync();
                        await textboxLocator.FillAsync(inputValue);
                        if(testScenariosDescription.Contains("4.9.76") || testScenariosDescription.Contains("4.9.77") ||
                             testScenariosDescription.Contains("4.10.76") || testScenariosDescription.Contains("4.10.77"))
                        {
                            await AddNewPostsAssertions.ShouldNotExceededForTextArea(textboxLocator,
                                testScenariosDescription, screenShotFolderName, screenShotFileName);
                        }
                        else
                        {
                            await AddNewPostsAssertions.ShouldValueNotExceeded(textboxLocator,
                                testScenariosDescription, screenShotFolderName, screenShotFileName);
                        }

                    }
                }

                await Page.GotoAsync("https://staging.deliveries.ph/");
            }
        }

        //[TestMethod]
        //[TestCategory("TS-4.7-8 ONDEMAND/SCHEDULED PICKUP DETAILS")]
        //public async Task Test001_InputValidValue()
        //{
        //    await PostCreationDetails(EnumsPostFieldDetails.ValidValuePickupDetails(), "PickupDetails - Screenshot");
        //    await PostCreationDetails(EnumsPostFieldDetails.ScheduledValidValuePickupDetails(), "PickupDetails - Screenshot");
        //}

        //[TestMethod]
        //[TestCategory("TS-4.7-8 ONDEMAND/SCHEDULED PICKUP DETAILS")]
        //public async Task Test002_ClearFunctionality()
        //{
        //    await PostCreationDetails(EnumsPostFieldDetails.ClearDropdownPickupDetails(), "PickupDetails - Screenshot");
        //    await PostCreationDetails(EnumsPostFieldDetails.ScheduledClearDropdownPickupDetails(), "PickupDetails - Screenshot");
        //}
        
        //[TestMethod]
        //[TestCategory("TS-4.7-8 ONDEMAND/SCHEDULED PICKUP DETAILS")]
        //public async Task Test003_PreviousStepFunctionality()
        //{
        //    await PostCreationDetails(EnumsPostFieldDetails.PreviousStepPickupFunctionality(), "PickupDetails - Screenshot");
        //}

        //[TestMethod]
        //[TestCategory("TS-4.7-8 ONDEMAND/SCHEDULED PICKUP DETAILS")]
        //public async Task Test004_PickupDetailsHyperlink()
        //{
        //    await PostCreationDetails(EnumsPostFieldDetails.PickupDetailsHyperlink(), "PickupDetails - Screenshot");
        //}

        //[TestMethod]
        //[TestCategory("TS-4.7-8 ONDEMAND/SCHEDULED PICKUP DETAILS")]
        //public async Task Test005_InputInvalidValue()
        //{
        //    await PostCreationDetails(EnumsPostFieldDetails.InvalidValuePickupDetails(), "PickupDetails - Screenshot");
        //    await PostCreationDetails(EnumsPostFieldDetails.ScheduledInvalidValuePickupDetails(), "PickupDetails - Screenshot");
        //}

        //[TestMethod]
        //[TestCategory("TS-4.7-8 ONDEMAND/SCHEDULED PICKUP DETAILS")]
        //public async Task Test006_InputBlankValue()
        //{
        //    await PostCreationDetails(EnumsPostFieldDetails.BlankValuePickupDetails(), "PickupDetails - Screenshot");
        //    await PostCreationDetails(EnumsPostFieldDetails.ScheduledBlankValuePickupDetails(), "PickupDetails - Screenshot");
        //}

        //[TestMethod]
        //[TestCategory("TS-4.7-8 ONDEMAND/SCHEDULED PICKUP DETAILS")]
        //public async Task Test007_InputMaxLengthValue()
        //{
        //    await PostCreationDetails(EnumsPostFieldDetails.MaxLengthValuePickupDetails(), "PickupDetails - Screenshot");
        //    await PostCreationDetails(EnumsPostFieldDetails.ScheduledMaxLengthValuePickupDetails(), "PickupDetails - Screenshot");
        //}

        // DELIVERY DETAILS
        //[TestMethod]
        //[TestCategory("TS-4.9-10 ONDEMAND/SCHEDULED DELIVERY DETAILS")]
        //public async Task Test008_InputValidValue()
        //{
        //    await PostCreationDetails(EnumsPostFieldDetails.ValidValueDeliveryDetails(), "DeliveryDetails - Screenshot");
        //    //await PostCreationDetails(EnumsPostFieldDetails.ScheduledValidValueDeliveryDetails(), "DeliveryDetails - Screenshot");
        //}

        //[TestMethod]
        //[TestCategory("TS-4.9-10 ONDEMAND/SCHEDULED DELIVERY DETAILS")]
        //public async Task Test009_ClearFunctionality()
        //{
        //    await PostCreationDetails(EnumsPostFieldDetails.ClearDropdownDeliveryDetails(), "DeliveryDetails - Screenshot");
        //    //await PostCreationDetails(EnumsPostFieldDetails.ScheduledClearDropdownPickupDetails(), "DeliveryDetails - Screenshot");
        //}

        //[TestMethod]
        //[TestCategory("TS-4.9-10 ONDEMAND/SCHEDULED DELIVERY DETAILS")]
        //public async Task Test010_PreviousStepFunctionality()
        //{
        //    await PostCreationDetails(EnumsPostFieldDetails.PreviousStepDeliveryFunctionality(), "DeliveryDetails - Screenshot");
        //}

        //[TestMethod]
        //[TestCategory("TS-4.9-10 ONDEMAND/SCHEDULED DELIVERY DETAILS")]
        //public async Task Test011_DeliveryDetailsHyperlink()
        //{
        //    await PostCreationDetails(EnumsPostFieldDetails.DeliveryDetailsHyperlink(), "DeliveryDetails - Screenshot");
        //}

        //private async Task PostCreationDetails(IEnumerable<object[]> fieldDetails, string screenShotFolderName)
        //{
        //    foreach (var getData in fieldDetails)
        //    {
        //        string deliveryType = (string)getData[0];
        //        string TestScenariosDescription = (string)getData[1];
        //        string ScreenShotFileName = (string)getData[2];
        //        string testCaseType = (string)getData[3];
        //        ILocator labelLocator = (ILocator)getData[4];

        //        //_ = (validDetails.DeliveryType == "Valid") ? await TestStepMethod() : Task.CompletedTask;


        //        if (TestScenariosDescription.Contains("Valid value"))
        //        {
        //            if(ScreenShotFileName.Contains("Pickup"))
        //            {
        //                await MyPostsPages.AddNewPosts_Button.ClickAsync();
        //                await AddNewPostsPages.SelectDeliveryType(deliveryType);
        //                await AddNewPostsPages.PickupDetailsAutoFill("refNo");
        //                await AddNewPostsAssertions.ShouldProceedToNextPage(labelLocator,
        //                    TestScenariosDescription, screenShotFolderName, ScreenShotFileName);
        //            }
        //            else if(ScreenShotFileName.Contains("Delivery"))
        //            {
        //                await MyPostsPages.AddNewPosts_Button.ClickAsync();
        //                await AddNewPostsPages.SelectDeliveryType(deliveryType);
        //                await AddNewPostsPages.PickupDetailsAutoFill("refNo");
        //                await AddNewPostsPages.DeliveryDetailsAutoFill();
        //                await AddNewPostsAssertions.ShouldProceedToNextPage(labelLocator,
        //                    TestScenariosDescription, screenShotFolderName, ScreenShotFileName);
        //            }
        //            //await Page.GotoAsync("https://staging.deliveries.ph/");
        //        }
        //        if (testCaseType == "hyperlink")
        //        {
        //            ILocator LinkLocator = (ILocator)getData[4];
        //            await MyPostsPages.AddNewPosts_Button.ClickAsync();
        //            await AddNewPostsPages.SelectDeliveryType(deliveryType);
        //            await AddNewPostsPages.PickupDetailsAutoFill("refNo");

        //            if (ScreenShotFileName.Contains("Pickup"))
        //            {
        //                await LinkLocator.ClickAsync();
        //                await AddNewPostsAssertions.ShouldDisplayPreviousPage(labelLocator,
        //                        TestScenariosDescription, screenShotFolderName, ScreenShotFileName);
        //            }
        //            else if (ScreenShotFileName.Contains("Delivery"))
        //            {
        //                await AddNewPostsPages.DeliveryDetailsAutoFill();
        //                await LinkLocator.ClickAsync();
        //                await AddNewPostsAssertions.ShouldDisplayPreviousPage(labelLocator,
        //                        TestScenariosDescription, screenShotFolderName, ScreenShotFileName);
        //            }
        //        }
        //        if (testCaseType == "Clear")
        //        {
        //            ILocator dropdownLocator = (ILocator)getData[4];
        //            ILocator buttonLocator = (ILocator)getData[5];
        //            await MyPostsPages.AddNewPosts_Button.ClickAsync();
        //            await AddNewPostsPages.SelectDeliveryType(deliveryType);
        //            await AddNewPostsPages.ReferenceNumber_Textbox.FillAsync("refNo");
        //            await AddNewPostsPages.UseLastProfilePickup_Button.ClickAsync();

        //            if (ScreenShotFileName.Contains("Pickup"))
        //            {
        //                await buttonLocator.ClickAsync();
        //                await AddNewPostsAssertions.ShouldClearValue(dropdownLocator,
        //                        TestScenariosDescription, screenShotFolderName, ScreenShotFileName);
        //            }
        //            else if (ScreenShotFileName.Contains("Delivery"))
        //            {
        //                await AddNewPostsPages.NextStepPickupDelivery_Button.ClickAsync();
        //                await AddNewPostsPages.UseLastProfileDelivery_Button.ClickAsync();
        //                await buttonLocator.ClickAsync();
        //                await AddNewPostsAssertions.ShouldClearValue(dropdownLocator,
        //                        TestScenariosDescription, screenShotFolderName, ScreenShotFileName);
        //            }

        //        }

        //        else if (testCaseType == "Previous")
        //        {
        //            //ILocator labelLocator = (ILocator)getData[4];
        //            await MyPostsPages.AddNewPosts_Button.ClickAsync();
        //            await AddNewPostsPages.SelectDeliveryType(deliveryType);
        //            await AddNewPostsPages.ReferenceNumber_Textbox.FillAsync("refNo");
        //            await AddNewPostsPages.UseLastProfilePickup_Button.ClickAsync();

        //            if (ScreenShotFileName.Contains("Pickup"))
        //            {
        //                await AddNewPostsPages.PreviousStepPickupDetails_Button.First.ClickAsync();
        //                await AddNewPostsAssertions.ShouldDisplayPreviousPage(labelLocator,
        //                        TestScenariosDescription, screenShotFolderName, ScreenShotFileName);
        //            }
        //            else if (ScreenShotFileName.Contains("Delivery"))
        //            {
        //                await AddNewPostsPages.NextStepPickupDelivery_Button.ClickAsync();
        //                await AddNewPostsPages.PreviousStepPickupDetails_Button.First.ClickAsync();
        //                await AddNewPostsAssertions.ShouldDisplayPreviousPage(labelLocator,
        //                        TestScenariosDescription, screenShotFolderName, ScreenShotFileName);
        //            }
        //        }

        //        else if (testCaseType == "Invalid")
        //        {
        //            ILocator textboxLocator = (ILocator)getData[4];
        //            string inputValue = (string)getData[5];
        //            ILocator courierLabelLocator = (ILocator)getData[6];
        //            if (ScreenShotFileName.Contains("Pickup"))
        //            {
        //                if (TestScenariosDescription.Contains("4.7.29") || TestScenariosDescription.Contains("4.8.29"))
        //                {
        //                    await TestStepMethod(deliveryType, inputValue, textboxLocator);
        //                    await AddNewPostsAssertions.ShouldDisplayErrorNotification(
        //                        TestScenariosDescription, screenShotFolderName, ScreenShotFileName);
        //                }
        //                else
        //                {
        //                    await TestStepMethod(deliveryType, inputValue, textboxLocator);
        //                    await AddNewPostsAssertions.ShouldProceedToNextPage(courierLabelLocator,
        //                        TestScenariosDescription, screenShotFolderName, ScreenShotFileName);
        //                }
        //            }
        //            else if (ScreenShotFileName.Contains("Delivery"))
        //            {
        //                if (TestScenariosDescription.Contains("4.7.29") || TestScenariosDescription.Contains("4.8.29"))
        //                {
        //                    await TestStepMethod(deliveryType, inputValue, textboxLocator);
        //                    await AddNewPostsPages.DeliveryDetailsAutoFill();
        //                    await AddNewPostsAssertions.ShouldDisplayErrorNotification(
        //                        TestScenariosDescription, screenShotFolderName, ScreenShotFileName);
        //                }
        //                else
        //                {
        //                    await TestStepMethod(deliveryType, inputValue, textboxLocator);
        //                    await AddNewPostsPages.DeliveryDetailsAutoFill();
        //                    await AddNewPostsAssertions.ShouldProceedToNextPage(courierLabelLocator,
        //                        TestScenariosDescription, screenShotFolderName, ScreenShotFileName);
        //                }
        //            }
                    
        //        }

        //        else if (testCaseType == "Blank")
        //        {
        //            ILocator textboxLocator = (ILocator)getData[4];
        //            string inputValue = (string)getData[5];
        //            ILocator courierLabelLocator = (ILocator)getData[6];
        //            if (TestScenariosDescription.Contains("4.7.34") || TestScenariosDescription.Contains("4.7.40") ||
        //                TestScenariosDescription.Contains("4.8.34") || TestScenariosDescription.Contains("4.8.40"))
        //            {
        //                await TestStepMethod(deliveryType, inputValue, textboxLocator);
        //                await AddNewPostsPages.ReferenceNumber_Textbox.FillAsync("test");
        //                await AddNewPostsPages.NextStepPickupDelivery_Button.ClickAsync();
        //                await AddNewPostsAssertions.ShouldProceedToNextPage(courierLabelLocator,
        //                        TestScenariosDescription, screenShotFolderName, ScreenShotFileName);
        //            }
        //            else
        //            {
        //                await TestStepMethod(deliveryType, inputValue, textboxLocator);
        //                await AddNewPostsAssertions.ShouldDisplayErrorNotification(
        //                    TestScenariosDescription, screenShotFolderName, ScreenShotFileName);
        //            }

        //        }

        //        else if (testCaseType == "Max Length")
        //        {
        //            ILocator textboxLocator = (ILocator)getData[4];
        //            string inputValue = (string)getData[5];
        //            await MyPostsPages.AddNewPosts_Button.ClickAsync();
        //            await AddNewPostsPages.SelectDeliveryType(deliveryType);
        //            await textboxLocator.FillAsync(inputValue);
        //            await AddNewPostsAssertions.ShouldValueNotExceeded( textboxLocator,
        //                TestScenariosDescription, screenShotFolderName, ScreenShotFileName);
        //        }
        //        await Page.GotoAsync("https://staging.deliveries.ph/");
        //    }
        //}

        private async Task TestStepMethod(string deliveryType, string fieldValue, ILocator fieldLocator)
        {
            await MyPostsPages.AddNewPosts_Button.ClickAsync();
            await AddNewPostsPages.SelectDeliveryType(deliveryType);
            await Page.WaitForTimeoutAsync(8000); // wait for the auto display of error message to close (or report to dev)
            await AddNewPostsPages.UseLastProfilePickup_Button.ClickAsync();
            await AddNewPostsPages.ReferenceNumber_Textbox.FillAsync(fieldValue);
            await fieldLocator.ClearAsync();
            await fieldLocator.FillAsync(fieldValue);
            await AddNewPostsPages.NextStepPickupDelivery_Button.ClickAsync();
        }


    }
}

