
using System.Net;
using System.Net.Mail;
using Microsoft.Playwright;

namespace automation_dph.src.Pages
{
	public class AddNewPostsPages : BasePageDriver
	{
		public AddNewPostsPages(IPage page, PageTest pageTest) : base(page, pageTest)
		{
            GetDataTestConfiguration = new(Page, PageTest);
        }

        public GetDataTestConfiguration GetDataTestConfiguration { get; private set; } = null!;

        public async Task SelectDeliveryType(string deliveryType)
        {
            await Page.WaitForLoadStateAsync();
            switch (deliveryType)
            {
                case "Ondemand":
                    await OnDemandDelivery_Checkbox.ClickAsync();
                    await NextStepSchedulePost_Button.First.ClickAsync();
                    break;
                case "Scheduled":
                    await ScheduledDelivery_Checkbox.ClickAsync();
                    await NextStepSchedulePost_Button.First.ClickAsync();
                    break;
                default:
                    throw new InvalidOperationException($"Invalid {deliveryType} delivery type.");
            }
        }

        public async Task PickupInputFillType(string customerName, string mobileNumber, string emailAddress, string address
            , string province, string city, string barangay, string postalCode)
        {
            GetDataTestConfiguration.GetJsonValueString();
            DateTime dateTime = DateTime.Now;
            string randomReferenceNumber = dateTime.ToString("mm:ss:fff");
            await Page.WaitForTimeoutAsync(5000); // wait for dropdown values to load
            await ReferenceNumber_Textbox.FillAsync($"automation-{randomReferenceNumber}");
            await InputCustomerDetails(customerName, mobileNumber, emailAddress);
            await InputLocationDetails(address, province, city, barangay, postalCode);
            await InputPostDetails("For test automation purposes only.", 1);
            await NextStepPickupDelivery_Button.First.ClickAsync();
        }

        public async Task DeliveryInputFillType(string customerName, string mobileNumber, string emailAddress, string address
            , string province, string city, string barangay, string postalCode)
        {
            await InputCustomerDetails(customerName, mobileNumber, emailAddress);
            await InputLocationDetails(address, province, city, barangay, postalCode);
            await InputPricingDetails("2", "0", "0", "2", "3", "1", "4", "5");
            await InputPostDetails("For test automation purposes only.", 1);
            await ItemDescription_Textbox.FillAsync("Item automation.");
            await NextStepPickupDelivery_Button.First.ClickAsync();
        }

        private async Task InputPostDetails(string remarks, int tags)
        {
            await Page.WaitForLoadStateAsync();
            await Remarks_Textbox.First.FillAsync(remarks);
            await NumberOfInputTags(tags);
        }

        public async Task InputPricingDetails(string quantity, string codAmount, string declaredValue, string length, string width, string height, string depth, string weight)
        {
            await Page.WaitForLoadStateAsync();
            await Quantity_Textbox.First.FillAsync(quantity);
            await CodAmount_Textbox.First.FillAsync(codAmount);
            await DeclaredValue_Textbox.First.FillAsync(declaredValue);
            await Length_Textbox.First.FillAsync(length);
            await Width_Textbox.First.FillAsync(width);
            await Height_Textbox.First.FillAsync(height);
            await Depth_Textbox.First.FillAsync(depth);
            await Weight_Textbox.First.FillAsync(weight);
        }

        private async Task InputLocationDetails(string fullAddress, string province, string city, string barangay, string postalCode)
        {
            await Page.WaitForLoadStateAsync();
            await Address_Textbox.First.FillAsync(fullAddress);
            await Pin_Button.ClickAsync();
            await Page.WaitForTimeoutAsync(2000);
            await SavePin_Button.ClickAsync();
            await InputProvinceDetails(province);
            await InputCityDetails(city);
            await InputBarangayDetails(barangay);
            await PostalCode_Textbox.First.FillAsync(postalCode);
        }

        private async Task InputCustomerDetails(string customerName, string mobileNumber, string emailAddress)
        {
            await Page.WaitForLoadStateAsync();
            await SenderName_Textbox.First.FillAsync(customerName);
            await MobileNumber_Textbox.First.FillAsync(mobileNumber);
            await EmailAddress_Textbox.First.FillAsync(emailAddress);
        }

        private async Task InputProvinceDetails(string province)
        {
            await Page.WaitForLoadStateAsync();
            await Province_Dropdown.ClickAsync();
            ILocator provinceDropdown = Page.Locator($"text='{province}'");
            await provinceDropdown.First.ClickAsync();
        }

        private async Task InputCityDetails(string city)
        {
            await Page.WaitForLoadStateAsync();
            await City_Dropdown.First.ClickAsync();
            ILocator cityDropdown = Page.Locator($"text='{city}'");
            await cityDropdown.First.ClickAsync();
        }

        private async Task InputBarangayDetails(string barangay)
        {
            await Page.WaitForLoadStateAsync();
            await Barangay_Dropdown.First.ClickAsync();
            ILocator barangayDropdown = Page.Locator($"text='{barangay}'");
            await barangayDropdown.First.ClickAsync();
        }

        private async Task NumberOfInputTags(int countTags)
        {
            await Tags_Dropdown.ClickAsync();
            for (int i = 0; i < countTags; i++ )
            {
                await Page.Keyboard.PressAsync("ArrowDown");
            }
            await Page.Keyboard.PressAsync("Enter");
        }

        public async Task SelectCourier(string courierType)
        {
            await Page.WaitForLoadStateAsync();
            await Page.WaitForTimeoutAsync(8000); // wait for list of courier to load
            ILocator selectCourier = Page.Locator($"//div[contains(text(),'{courierType}')]");
            await selectCourier.First.ClickAsync();
            await Page.WaitForTimeoutAsync(3000); // wait for courier to select
            switch (courierType)
            {
                case MyPostsElementNameList.PreferredPartner.PRIME_MOVERS:
                    await SmallPackageSizePrime_Checkbox.First.ClickAsync();
                    break;
                case MyPostsElementNameList.PreferredPartner.LIBCAP:
                    await SmallPackageSizeLibcap_Checkbox.First.ClickAsync();
                    break;
                case MyPostsElementNameList.PreferredPartner.XDE:
                    await SmallPackageSizeXde_Checkbox.First.ClickAsync();
                    break;
                case MyPostsElementNameList.PreferredPartner.ENTREGO_GLOBE:
                    await SmallPackageSizeEntregoGlobe_Checkbox.First.ClickAsync();
                    break;
                case MyPostsElementNameList.PreferredPartner.NONPAREIL:
                    await SmallPackageSizeNonpareil_Checkbox.First.ClickAsync();
                    break;
                case MyPostsElementNameList.PreferredPartner.NINJAVAN:
                    await MediumPackageSizeNinjavan_Checkbox.First.ClickAsync();
                    break;
                case MyPostsElementNameList.PreferredPartner.QUADX_ZONE:
                    await LargePackageSizeQuadx_Checkbox.First.ClickAsync();
                    break;
                default:
                    break;
            }
            await NextStepSelectCourier_Button.ClickAsync();
        }

        public async Task FillOutMetafields(string courier)
        {
            switch (courier)
            {
                case "Lalamove":
                    await NextStepSelectCourier_Button.ClickAsync();
                    break;
                case "Grab":
                    await NextStepSelectCourier_Button.ClickAsync();
                    break;
                case MyPostsElementNameList.PreferredPartner.PRIME_MOVERS:
                    await CostCenterPrime_Textbox.First.FillAsync("test");
                    await NextStepSelectCourier_Button.ClickAsync();
                    break;
                case MyPostsElementNameList.PreferredPartner.LIBCAP:
                    await DeliveryPostalCodeLibcap_Textbox.First.FillAsync("test1");
                    await DeliveryTransportModeLibcap_Textbox.First.FillAsync("test2");
                    await DeliveryTypeLibcap_Textbox.First.FillAsync("test3");
                    await NextStepSelectCourier_Button.ClickAsync();
                    break;
                case MyPostsElementNameList.PreferredPartner.XDE:
                    await DeliveryTypeXde_Textbox.First.FillAsync("test1");
                    await WidthXde_Textbox.First.FillAsync("3");
                    await WeightXde_Textbox.First.FillAsync("4");
                    await LengthXde_Textbox.First.FillAsync("5");
                    await HeightXde_Textbox.First.FillAsync("3");
                    await BusinessUnitCodeXde_Textbox.First.FillAsync("test2");
                    await NextStepSelectCourier_Button.ClickAsync();
                    break;
                case MyPostsElementNameList.PreferredPartner.ENTREGO_GLOBE:
                    await PickupPostalCodeEntregoGlobe_Textbox.First.FillAsync("1234");
                    await DeliveryPostalCodeEntregoGlobe_Textbox.First.FillAsync("2345");
                    await BusinessUnitCodeEntregoGlobe_Textbox.First.FillAsync("test3");
                    await NextStepSelectCourier_Button.ClickAsync();
                    break;
                case MyPostsElementNameList.PreferredPartner.NONPAREIL:
                    await ModeOfShipmentNonpareil_Textbox.First.FillAsync("1234");
                    await CostCenterNonpareil_Textbox.First.FillAsync("2345");
                    await RequestedByNonpareil_Textbox.First.FillAsync("test3");
                    await NextStepSelectCourier_Button.ClickAsync();
                    break;
                case MyPostsElementNameList.PreferredPartner.NINJAVAN:
                    await SelectValueOfNinjavanMetafields("9:00am - 12:00pm", "12:00pm - 3:00pm");
                    await NextStepSelectCourier_Button.ClickAsync();
                    break;
                default:
                    throw new InvalidOperationException($"Invalid {courier} courier type.");
            }
        }

        public async Task SelectValueOfNinjavanMetafields(string pickupTimeSlot, string deliveryTimeSlot)
        {
            await Page.WaitForLoadStateAsync();
            await PickupTimeSlotNinjavan_Dropdown.SelectOptionAsync(new[] { pickupTimeSlot });
            await DeliveryTimeSlotNinjavan_Dropdown.SelectOptionAsync(new[] { deliveryTimeSlot });
        }

        public async Task SelectVehicleType(string vehicleType)
        {
            await Page.WaitForLoadStateAsync();
            await VehicleType_Dropdown.ClickAsync();
            ILocator selectVehicle = Page.Locator($"text='{vehicleType}'");
            await selectVehicle.First.ClickAsync();
        }

        public async Task ManualFillPostsCreation(PostsDataConfiguration data)
        {
            GetDataTestConfiguration.GetJsonValueString();
            await SelectDeliveryType(data.DeliveryType);
            await PickupInputFillType(data.Sendername, data.PickupMobileNumber, data.PickupEmailAddress, data.PickupAddress,
                                      data.PickupProvince, data.PickupCity, data.PickupBarangay, data.PickupPostalCode);
            await DeliveryInputFillType(data.RecipientName, data.DeliveryMobileNumber, data.DeliveryEmailAddress, data.DeliveryAddress,
                                      data.DeliveryProvince, data.DeliveryCity, data.DeliveryBarangay, data.DeliveryPostalCode);

            if(data.DeliveryType == "Ondemand")
            {
                await SelectVehicleType(data.VehicleType);
                EnvironmentVariableManager.SetValue(VehicleTypeSelectCourier_Label, GetValueOfVehicleTypeInCourierPage);
                await SelectCourier(data.Courier);
                await FillOutMetafields(data.Courier);
            }
            else if(data.DeliveryType == "Scheduled")
            {
                await SelectCourier(data.Courier);
                await FillOutMetafields(data.Courier);
            }
            await Page.WaitForTimeoutAsync(2000); // wait for element to get the value
            EnvironmentVariableManager.SetValue(CourierNameSummary_Label, GetValueOfCourierNameInSummaryPage);
            EnvironmentVariableManager.SetValue(ProvincePickupSummary_Label, GetValueOfProvinceInSummaryPage);
        }

        public async Task PickupDetailsAutoFill(string referenceNumber)
        {
            DateTime dateTime = DateTime.Now;
            string randomReferenceNumber = dateTime.ToString("mm:ss:fff");
            await Page.WaitForTimeoutAsync(5000); // wait for dropdown values to load
            await ReferenceNumber_Textbox.FillAsync($"{referenceNumber}-{randomReferenceNumber}");
            await UseLastProfilePickup_Button.ClickAsync();
            await NextStepPickupDelivery_Button.ClickAsync();
        }

        public async Task DeliveryDetailsAutoFill()
        {
            await UseLastProfileDelivery_Button.ClickAsync();
            await InputPricingDetails("1","0","0","1","2","3","4","5");
            await NextStepPickupDelivery_Button.ClickAsync();
        }

        // CHECKBOXES
        private ILocator ChkOnDemandDelivery => Page.Locator(".onDemand-button");
        private ILocator ChkScheduledDelivery => Page.Locator(".scheduled-button");
        private ILocator ChkSmallPackageSizePrime => Page.Locator("div:nth-of-type(1) > .rates_info > div:nth-of-type(1)");
        private ILocator ChkSmallPackageSizeLibcap => Page.Locator("div:nth-of-type(2) > .rates_info > div:nth-of-type(1)");
        private ILocator ChkSmallPackageSizeXde => Page.Locator("div:nth-of-type(4) > .rates_info > div:nth-of-type(1)");
        private ILocator ChkSmallPackageSizeEntregoGlobe => Page.Locator("div:nth-of-type(11) > .rates_info > div:nth-of-type(1)");
        private ILocator ChkSmallPackageSizeNonpareil => Page.Locator("div:nth-of-type(13) > .rates_info > div:nth-of-type(1)");
        private ILocator ChkMediumPackageSizeNinjavan => Page.Locator(".rates_info > div:nth-of-type(2) .circle");
        private ILocator ChkLargePackageSizeQuadx => Page.Locator("div:nth-of-type(21) > .rates_info > div:nth-of-type(3)");

        // BUTTONS
        private ILocator BtnNextStepSchedulePost => Page.Locator(".wizard__navigation [type]");
        private ILocator BtnNextStepPickupDeliveryDetails => Page.Locator(".btn.btn-icon-right.tw-bg-dark-3.tw-duration-200.tw-ease-in-out");
        private ILocator BtnNextStepSelectCourier => Page.Locator(".wizard__navigation > button:nth-of-type(2)");
        private ILocator BtnUseLastProfilePickup => Page.Locator(".btn.btn-icon-left.tw-bg-blue-4");
        private ILocator BtnUseLastProfileDelivery => Page.Locator(".btn.btn-icon-left.tw-bg-blue-4");
        private ILocator BtnAutoFillPickupDetails => Page.Locator("[class='btn tw-bg-dark-3']");
        private ILocator BtnSave => Page.Locator(".btn.tw-bg-blue-3.tw-duration-300.tw-ease-in-out.tw-transition-all");
        private ILocator BtnPin => Page.Locator(".address .btn-icon-left");
        private ILocator BtnSavePin => Page.Locator(".btn.btn--blue.btn-sm");
        private ILocator ProvinceCloseBtn => Page.Locator("[class='column-2']:nth-of-type(3) .form-control-input-select:nth-of-type(1) [class='css-16pqwjk-indicatorContainer creatable-select__indicator creatable-select__clear-indicator'] [class]");
        private ILocator CityCloseBtn => Page.Locator(".form-control-input-select:nth-of-type(2) [class='css-16pqwjk-indicatorContainer creatable-select__indicator creatable-select__clear-indicator'] [class]");
        private ILocator BarangayCloseBtn => Page.Locator("[class='column-2']:nth-of-type(4) [class='css-16pqwjk-indicatorContainer creatable-select__indicator creatable-select__clear-indicator'] [class]");
        private ILocator BtnPreviousStepPickupDetails => Page.Locator(".wizard__navigation [type='button']:nth-of-type(1)");

        //HYPERLINKS
        private ILocator LnkScheduledPost => Page.Locator("#horizontal-list li:nth-of-type(1) span");
        private ILocator LnkPickupDetails => Page.Locator("#horizontal-list li:nth-of-type(2) span");
        private ILocator LnkDeliveryDetails => Page.Locator("#horizontal-list li:nth-of-type(3) span");

        //LABELS
        private ILocator LblCourierNameSummary => Page.Locator(".courier__name");
        private ILocator LblVehicleTypeSelectCourier => Page.Locator(".css-1hwfws3.select-dropdown__value-container.select-dropdown__value-container--has-value");
        private ILocator LblProvincePickupSummary => Page.Locator(".pickupDetails .location__content .data:nth-of-type(8)");
        private ILocator LblScheduledPostPage => Page.Locator(".schedule-post .title");
        private ILocator LblDeliveryDetailsPage => Page.Locator(".delivery-details .title");
        private ILocator LblSelectCourierPage => Page.Locator(".title.tw-pt-2");
        private ILocator LblPickupDetailsPage => Page.Locator(".content-body .title");

        //TEXTBOXES
        private ILocator TxtReferenceNumber => Page.Locator("input[name='refNo']");
        private ILocator TxtSenderName => Page.Locator("input[name='customerName']");
        private ILocator TxtMobileNumber => Page.Locator("input[name='contactNumber']");
        private ILocator TxtEmailAddress => Page.Locator("input[name='emailAddress']");
        private ILocator TxtAddress => Page.Locator("input[name='address']");
        private ILocator TxtPostalCode => Page.Locator("input[name='postalCode']");
        private ILocator TxtRemarks => Page.Locator("textarea[name='remarks']");
        private ILocator TxtQuantity => Page.Locator("input[name='quantity']");
        private ILocator TxtCodAmount => Page.Locator("input[name='codAmount']");
        private ILocator TxtDeclaredValue => Page.Locator("input[name='itemPrice']");
        private ILocator TxtLength => Page.Locator("input[name='length']");
        private ILocator TxtWidth => Page.Locator("input[name='width']");
        private ILocator TxtHeight => Page.Locator("input[name='height']");
        private ILocator TxtDepth => Page.Locator("input[name='depth']");
        private ILocator TxtWeight => Page.Locator("input[name='weight']");
        private ILocator TxtItemDescription => Page.Locator("textarea[name='details']");
        private ILocator TxtCostCenterPrime => Page.Locator("input[name='cost_center']");
        private ILocator TxtDeliveryPostalCodeLibcap => Page.Locator("input[name='deliveryZipCode']");
        private ILocator TxtDeliveryTransportModeLibcap => Page.Locator("input[name='deliveryTransportMode']");
        private ILocator TxtDeliveryTypeLibcap => Page.Locator("input[name='deliveryType']");
        private ILocator TxtDeliveryTypeXde => Page.Locator("input[name='deliveryType']");
        private ILocator TxtWidthXde => Page.Locator("input[name='width']");
        private ILocator TxtWeightXde=> Page.Locator("input[name='weight']");
        private ILocator TxtLengthXde => Page.Locator("input[name='length']");
        private ILocator TxtHeightXde => Page.Locator("input[name='height']");
        private ILocator TxtBusinessUnitCodeXde => Page.Locator("input[name='businessUnitCode']");
        private ILocator TxtPickupPostalCodeEntregoGlobe => Page.Locator("input[name='pickup_postal']");
        private ILocator TxtDeliveryPostalCodeEntregoGlobe => Page.Locator("input[name='delivery_postal']");
        private ILocator TxtBusinessUnitCodeEntregoGlobe => Page.Locator("input[name='businessUnitCode']");
        private ILocator TxtModeOfShipmentNonpareil=> Page.Locator("input[name='modeOfShipment']");
        private ILocator TxtCostCenterNonpareil => Page.Locator("input[name='costCenter']");
        private ILocator TxtRequestedByNonpareil => Page.Locator("input[name='requestedBy']");


        //DROPDOWNS
        private ILocator DdlProvince => Page.Locator("(//div[@class='css-1pcexqc-container react-select-container'])[1]");
        private ILocator DdlCity => Page.Locator("(//div[@class='css-1pcexqc-container react-select-container'])[2]");
        private ILocator DdlBarangay => Page.Locator("(//div[@class='css-1pcexqc-container react-select-container'])[3]");
        private ILocator DdlTags => Page.Locator(".creatable-tags__control.css-bg1rzq-control");
        private ILocator DdlVehicleType => Page.Locator(".css-1hwfws3.select-dropdown__value-container.select-dropdown__value-container--has-value");
        private ILocator DdlPickupTimeSlotNinjavan => Page.Locator("select[name='pickupTimeSlot']");
        private ILocator DdlDeliveryTimeSlotNinjavan => Page.Locator("select[name='deliveryTimeSlot']");

        // Hover Message label
        private ILocator LblHoverCourierMessage => Page.Locator("//*[@id=\"app\"]/div/div/div[3]/div/div[2]/div[2]/div[1]/div[2]/div/div[5]/div[1]/span");

        //DIVs
        private ILocator LstOndemandCourierRow => Page.Locator(".row");

        // Notification
        private ILocator ToastErrorNotification => Page.Locator(".Toastify__toast-container.Toastify__toast-container--top-right");


        public ILocator OnDemandDelivery_Checkbox { get { return ChkOnDemandDelivery; } }
        public ILocator ScheduledDelivery_Checkbox { get { return ChkScheduledDelivery; } }
        public ILocator NextStepSchedulePost_Button { get { return BtnNextStepSchedulePost; } }
        public ILocator ReferenceNumber_Textbox { get { return TxtReferenceNumber; } }
        public ILocator SenderName_Textbox { get { return TxtSenderName; } }
        public ILocator MobileNumber_Textbox { get { return TxtMobileNumber; } }
        public ILocator EmailAddress_Textbox { get { return TxtEmailAddress; } }
        public ILocator Address_Textbox { get { return TxtAddress; } }
        public ILocator Province_Dropdown { get { return DdlProvince; } }
        public ILocator City_Dropdown { get { return DdlCity; } }
        public ILocator Barangay_Dropdown { get { return DdlBarangay; } }
        public ILocator PostalCode_Textbox { get { return TxtPostalCode; } }
        public ILocator Remarks_Textbox { get { return TxtRemarks; } }
        public ILocator Tags_Dropdown { get { return DdlTags; } }
        public ILocator AutoFillPickupDetails_Button { get { return BtnAutoFillPickupDetails; } }
        public ILocator UseLastProfilePickup_Button { get { return BtnUseLastProfilePickup; } }
        public ILocator UseLastProfileDelivery_Button { get { return BtnUseLastProfileDelivery; } }
        public ILocator NextStepPickupDelivery_Button { get { return BtnNextStepPickupDeliveryDetails; } }
        public ILocator Quantity_Textbox { get { return TxtQuantity; } }
        public ILocator CodAmount_Textbox { get { return TxtCodAmount; } }
        public ILocator DeclaredValue_Textbox { get { return TxtDeclaredValue; } }
        public ILocator Length_Textbox { get { return TxtLength; } }
        public ILocator Width_Textbox { get { return TxtWidth; } }
        public ILocator Height_Textbox { get { return TxtHeight; } }
        public ILocator Depth_Textbox { get { return TxtDepth; } }
        public ILocator Weight_Textbox { get { return TxtWeight; } }
        public ILocator ItemDescription_Textbox { get { return TxtItemDescription; } }
        public ILocator VehicleType_Dropdown { get { return DdlVehicleType; } }
        public ILocator NextStepSelectCourier_Button { get { return BtnNextStepSelectCourier; } }
        public ILocator Save_Button { get { return BtnSave; } }
        public ILocator CourierNameSummary_Label { get { return LblCourierNameSummary; } }
        public ILocator VehicleTypeSelectCourier_Label { get { return LblVehicleTypeSelectCourier; } }
        public ILocator Pin_Button { get { return BtnPin; } }
        public ILocator SavePin_Button { get { return BtnSavePin; } }
        public ILocator ProvincePickupSummary_Label { get { return LblProvincePickupSummary; } }
        public ILocator HoverCourierMessage_Label { get { return LblHoverCourierMessage; } }
        public ILocator SmallPackageSizePrime_Checkbox { get { return ChkSmallPackageSizePrime; } }
        public ILocator CostCenterPrime_Textbox { get { return TxtCostCenterPrime; } }
        public ILocator SmallPackageSizeLibcap_Checkbox { get { return ChkSmallPackageSizeLibcap; } }
        public ILocator SmallPackageSizeXde_Checkbox { get { return ChkSmallPackageSizeXde; } }
        public ILocator SmallPackageSizeEntregoGlobe_Checkbox { get { return ChkSmallPackageSizeEntregoGlobe; } }
        public ILocator SmallPackageSizeNonpareil_Checkbox { get { return ChkSmallPackageSizeNonpareil; } }
        public ILocator MediumPackageSizeNinjavan_Checkbox { get { return ChkMediumPackageSizeNinjavan; } }
        public ILocator LargePackageSizeQuadx_Checkbox { get { return ChkLargePackageSizeQuadx; } }
        public ILocator DeliveryPostalCodeLibcap_Textbox { get { return TxtDeliveryPostalCodeLibcap; } }
        public ILocator DeliveryTransportModeLibcap_Textbox { get { return TxtDeliveryTransportModeLibcap; } }
        public ILocator DeliveryTypeLibcap_Textbox { get { return TxtDeliveryTypeLibcap; } }
        public ILocator DeliveryTypeXde_Textbox { get { return TxtDeliveryTypeXde; } }
        public ILocator WidthXde_Textbox { get { return TxtWidthXde; } }
        public ILocator WeightXde_Textbox { get { return TxtWeightXde; } }
        public ILocator LengthXde_Textbox { get { return TxtLengthXde; } }
        public ILocator HeightXde_Textbox { get { return TxtHeightXde; } }
        public ILocator BusinessUnitCodeXde_Textbox { get { return TxtBusinessUnitCodeXde; } }
        public ILocator PickupPostalCodeEntregoGlobe_Textbox { get { return TxtPickupPostalCodeEntregoGlobe; } }
        public ILocator DeliveryPostalCodeEntregoGlobe_Textbox { get { return TxtDeliveryPostalCodeEntregoGlobe; } }
        public ILocator BusinessUnitCodeEntregoGlobe_Textbox { get { return TxtBusinessUnitCodeEntregoGlobe; } }
        public ILocator ModeOfShipmentNonpareil_Textbox { get { return TxtModeOfShipmentNonpareil; } }
        public ILocator CostCenterNonpareil_Textbox { get { return TxtCostCenterNonpareil; } }
        public ILocator RequestedByNonpareil_Textbox { get { return TxtRequestedByNonpareil; } }
        public ILocator PickupTimeSlotNinjavan_Dropdown { get { return DdlPickupTimeSlotNinjavan; } }
        public ILocator DeliveryTimeSlotNinjavan_Dropdown { get { return DdlDeliveryTimeSlotNinjavan; } }
        public ILocator OndemandCourierRow_List { get { return LstOndemandCourierRow; } }
        public ILocator ErrorNotification_Toastify { get { return ToastErrorNotification; } }
        public ILocator ScheduledPostPage_Label { get { return LblScheduledPostPage; } }
        public ILocator ScheduledPost_Link { get { return LnkScheduledPost; } }
        public ILocator DeliveryDetailsPage_Label { get { return LblDeliveryDetailsPage; } }
        public ILocator ProvinceClose_Button { get { return ProvinceCloseBtn; } }
        public ILocator CityClose_Button { get { return CityCloseBtn; } }
        public ILocator BarangayClose_Button { get { return BarangayCloseBtn; } }
        public ILocator PreviousStepPickupDetails_Button { get { return BtnPreviousStepPickupDetails; } }
        public ILocator PickupDetails_Link { get { return LnkPickupDetails; } }
        public ILocator SelectCourierPage_Label { get { return LblSelectCourierPage; } }
        public ILocator PickupDetailsPage_Label { get { return LblPickupDetailsPage; } }
        public ILocator DeliveryDetails_Link { get { return LnkDeliveryDetails; } }


        // Get value
        public string GetValueOfCourierNameInSummaryPage { get { return LblCourierNameSummary.InnerTextAsync().GetAwaiter().GetResult(); } }
        public string GetValueOfVehicleTypeInCourierPage { get { return LblVehicleTypeSelectCourier.InnerTextAsync().GetAwaiter().GetResult(); } }
        public string GetValueOfProvinceInSummaryPage { get { return LblProvincePickupSummary.First.InnerTextAsync().GetAwaiter().GetResult(); } }
        public string GetValueOfHoverMessageInCourierPage { get { return LblHoverCourierMessage.First.InnerTextAsync().GetAwaiter().GetResult(); } }
        public string GetValueOfCourierListInCourierPage { get { return LstOndemandCourierRow.First.InnerTextAsync().GetAwaiter().GetResult(); } }
        public string GetValueOfErrorNotification { get { return ToastErrorNotification.First.InnerTextAsync().GetAwaiter().GetResult(); } }
        public string GetValueOfScheduledPostPageLabel { get { return LblScheduledPostPage.First.InnerTextAsync().GetAwaiter().GetResult(); } }
        public string GetValueOfDeliveryDetailsPageLabel { get { return LblDeliveryDetailsPage.First.InnerTextAsync().GetAwaiter().GetResult(); } }
        public string GetValueOfSelectCourierPageLabel { get { return LblSelectCourierPage.First.InnerTextAsync().GetAwaiter().GetResult(); } }
        public string GetValueOfPickupDetailsPageLabel { get { return LblPickupDetailsPage.First.InnerTextAsync().GetAwaiter().GetResult(); } }

    }
}

