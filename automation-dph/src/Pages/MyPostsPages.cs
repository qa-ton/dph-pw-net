namespace automation_dph.src.Pages
{
    public class MyPostsPages : BasePageDriver
    {
        public MyPostsPages(IPage page, PageTest pageTest) : base(page, pageTest)
        {

        }

        // LABELS
        private ILocator LblMyPostsTitlePage => Page.Locator(".page-title");
        private ILocator LblDashLatestStore => Page.Locator(".border-dotted-bottom.pad-left-10");
        private ILocator LblDashStatus => Page.Locator(".customer .tooltip__text");
        private ILocator LblDashCouriername => Page.Locator(".courierName");
        private ILocator LblDashCompletionDate => Page.Locator(".job-items-container .list-item-container:nth-of-type(1) .position-relative");
        private ILocator LblDashTrackingNumber => Page.Locator(".content__field:nth-of-type(21) [class='col-8']");
        private ILocator LblNumberOfRecords => Page.Locator(".tw-bg-dark-4.tw-px-4.tw-py-2.tw-text-\\[11px\\]");
        private ILocator LblNumberOfSelectedCheckbox => Page.Locator("label#action-all");
        private ILocator LblPaginationPostsNumberDisplay => Page.Locator(".tw-font-semibold.tw-text-dark-2.tw-text-xs");
        private ILocator LblAddNewPostsTitlePage => Page.Locator(".content-header > .title");
        private ILocator LblReference => Page.Locator(".item.ref-no");
        private ILocator LblCustomerName => Page.Locator(".customer.item");
        private ILocator LblPreferredPartner => Page.Locator(".item.partner");
        private ILocator LblTime => Page.Locator(".item.time");
        private ILocator LblPickupCity => Page.Locator(".item.pickup-city");
        private ILocator LblDeliveryCity => Page.Locator(".delivery-city.item");
        private ILocator LblTags => Page.Locator(".item.tags-space");
        private ILocator LblCompletion => Page.Locator(".completion-date.item");

        // TEXT FIELDS
        private ILocator TxtSearch => Page.Locator("input[type='search']");
        private ILocator TxtFromDateTimePicker => Page.Locator("input[name='daterangepicker_start']");
        private ILocator TxtToDateTimePicker => Page.Locator("input[name='daterangepicker_end']");

        // DROPDOWN FIELDS
        private ILocator DdlSearchPost => Page.Locator(".search-input.widget-dropdown-search .css-16pqwjk-indicatorContainer.select-dropdown__dropdown-indicator.select-dropdown__indicator");
        private ILocator DdlHubs => Page.Locator("div:nth-of-type(2) .form-control-input-select:nth-of-type(2)");
        private ILocator DdlStatus => Page.Locator(".dropdown-label");
        private ILocator DdlPreferredPartner => Page.Locator(".css-1pcexqc-container.input-state--valid.react-select-container.select-preferred-partner > .css-bg1rzq-control.select-dropdown__control");
        private ILocator DdlDate => Page.Locator(".float-right.tw-ml-\\[10px\\] > span:nth-of-type(1)");

        // CHECKBOXES
        private ILocator ChkDashSinglePost => Page.Locator(".list-item-container [type]");
        private ILocator ChkDashSelecAllPost => Page.Locator(".select-all-column [type]");

        // BUTTONS
        private ILocator BtnLogout => Page.Locator("//button[contains(text(),'Logout')]");
        private ILocator BtnDashLatesPost => Page.Locator(".list-item");
        private ILocator BtnApplyDate => Page.Locator(".applyBtn.btn.btn-sm.btn-success");
        private ILocator BtnMultipleMarkAsReturned => Page.Locator(".markAsReturned-container .btn__multiple-select");
        private ILocator BtnConfirm => Page.Locator(".modal-footer.modal__footer > button:nth-of-type(1)");
        private ILocator BtnDashPrintWaybill => Page.Locator("text='Print Waybill'");
        private ILocator BtnMultiplePrintDefaultWaybill => Page.Locator(".btn.btn__multiple-select.print-action");
        private ILocator MultiplePrintProviderWaybillButton => Page.Locator(".btn.btn__multiple-select.print-action");
        private ILocator BtnNextPageIcon => Page.Locator(".tw-flex.tw-gap-3.tw-items-center > button:nth-of-type(2)");
        private ILocator BtnPreviousPageIcon => Page.Locator("button:nth-of-type(1) > .fa-chevron-left.fas");
        private ILocator BtnAddNewPosts => Page.Locator(".btn.btn-newPost");

        // ITEM AND OPTION BUTTONS
        private ILocator BtnUserProfileIcon => Page.Locator(".fa.fa-user.glow-blue");
        private ILocator BtnMyPostsEllipsis => Page.Locator(".dropdown-toggle");
        private ILocator OptBtnMultipleMarkAsReturned => Page.Locator("li:nth-of-type(1) > a[role='menuitem']");
        private ILocator OptBtnMultiplePrintDefaultWaybill => Page.Locator("li:nth-of-type(2) > a[role='menuitem'] > span");
        private ILocator OptBtnProviderWaybillDash => Page.Locator("text='Provider Waybill'");
        private ILocator OptBtnMultiplePrintProvidertWaybill => Page.Locator("li:nth-of-type(3) > a[role='menuitem'] > span");

        // CONTAINERS
        private ILocator DashLstContainer => Page.Locator(".items-wrapper > .no-data-display");
        private ILocator StatusLstContainer => Page.Locator(".dropdown-list");

        // CANVAS
        private ILocator GeneratedWaybillCanvas => Page.Locator(".react-pdf__Page__canvas");

        // LINKS
        private ILocator LnkWaybillNextPagination => Page.Locator(".modal__footer .fa-chevron-right");
        private ILocator LnkWaybillPreviousPagination => Page.Locator(".modal__footer [aria-label='Go to previous page']");
        private ILocator LnkCancelledReturnedRejectedTab => Page.Locator("div:nth-of-type(2) > .item__name");
        private ILocator LnkAllTab => Page.Locator("div:nth-of-type(1) > .item__name");

        // LISTS
        private ILocator LstSearchPostDropdown => Page.Locator("//div[@class='css-tegnl5 select-dropdown__menu-list']");
        private ILocator LstHubsDropdown => Page.Locator("//*[@id=\"app\"]/div/div/div[3]/div/div[1]/div[2]/div[2]/div[2]/div[2]/div/div[2]/div");
        private ILocator LstStatusDropdown => Page.Locator(".dropdown-list");
        private ILocator LstPreferredPartnerDropdown => Page.Locator("//div[@class='css-tegnl5 select-dropdown__menu-list']");
        private ILocator LstDateDropdown => Page.Locator("body > .daterangepicker.dropdown-menu.ltr");
        private ILocator LstMyPostsEllipsisButton => Page.Locator("ul[role='menu']");

        // DASHBOARDS
        private ILocator DashMyPosts => Page.Locator(".items-wrapper");



        public ILocator MyPostsTitlePage_Label { get { return LblMyPostsTitlePage; } }
        public ILocator UserProfileIcon_Button { get { return BtnUserProfileIcon; } }
        public ILocator Logout_Button { get { return BtnLogout; } }
        public ILocator Search_Textfield { get { return TxtSearch; } }
        public ILocator DashboardLatesPost_Button { get { return BtnDashLatesPost; } }
        public ILocator SearchPost_Dropdown { get { return DdlSearchPost; } }
        public ILocator DashboardPostList_Container { get { return DashLstContainer; } }
        public ILocator Hubs_Dropdown { get { return DdlHubs; } }
        public ILocator DashboardLatestStore_Label { get { return LblDashLatestStore; } }
        public ILocator Status_Dropdown { get { return DdlStatus; } }
        public ILocator StatusIcon_Dashboard { get { return LblDashStatus; } }
        public ILocator PreferredPartner_Dropdown { get { return DdlPreferredPartner; } }
        public ILocator Couriername_Label { get { return LblDashCouriername; } }
        public ILocator Date_Dropdown { get { return DdlDate; } }
        public ILocator CompletionDate_Label { get { return LblDashCompletionDate; } }
        public ILocator FromDateTimePicker_Textfield { get { return TxtFromDateTimePicker; } }
        public ILocator ToDateTimePicker_Textfield { get { return TxtToDateTimePicker; } }
        public ILocator ApplyDate_Button { get { return BtnApplyDate; } }
        public ILocator DashboardTrackingNumber_Label { get { return LblDashTrackingNumber; } }
        public ILocator NumberOfRecords_Label { get { return LblNumberOfRecords; } }
        public ILocator MyPostsEllipsis_Button { get { return BtnMyPostsEllipsis; } }
        public ILocator OptMarkAsReturned_Button { get { return OptBtnMultipleMarkAsReturned; } }
        public ILocator DashSinglePost_Checkbox { get { return ChkDashSinglePost; } }
        public ILocator NumberOfSelectedCheckbox_Label { get { return LblNumberOfSelectedCheckbox; } }
        public ILocator DashSelecAllPost_Checkbox { get { return ChkDashSelecAllPost; } }
        public ILocator MultipleMarkAsReturned_Button { get { return BtnMultipleMarkAsReturned; } }
        public ILocator Confirm_Button { get { return BtnConfirm; } }
        public ILocator DashPrintWaybill_Button { get { return BtnDashPrintWaybill; } }
        public ILocator OptMultiplePrintDefaultWaybill_Button { get { return OptBtnMultiplePrintDefaultWaybill; } }
        public ILocator DropdownStatusList_Container { get { return StatusLstContainer; } }
        public ILocator MultiplePrintDefaultWaybill_Button { get { return BtnMultiplePrintDefaultWaybill; } }
        public ILocator OptProviderWaybillDash_Button { get { return OptBtnProviderWaybillDash; } }
        public ILocator MultiplePrintProviderWaybill { get { return MultiplePrintProviderWaybillButton; } }
        public ILocator OptMultiplePrintProvidertWaybill_Button { get { return OptBtnMultiplePrintProvidertWaybill; } }
        public ILocator GeneratedWaybill_Canvas { get { return GeneratedWaybillCanvas; } }
        public ILocator WaybillNextPagination_Link { get { return LnkWaybillNextPagination; } }
        public ILocator WaybillPreviousPagination_Link { get { return LnkWaybillPreviousPagination; } }
        public ILocator PaginationPostsNumberDisplay_Label { get { return LblPaginationPostsNumberDisplay; } }
        public ILocator NextPageIcon_Button { get { return BtnNextPageIcon; } }
        public ILocator PreviousPageIcon_Button { get { return BtnPreviousPageIcon; } }
        public ILocator CancelledReturnedRejectedTab_Link { get { return LnkCancelledReturnedRejectedTab; } }
        public ILocator AddNewPosts_Button { get { return BtnAddNewPosts; } }
        public ILocator AddNewPostsTitlePage_Label { get { return LblAddNewPostsTitlePage; } }
        public ILocator SearchPostDropdown_List { get { return LstSearchPostDropdown; } }
        public ILocator HubsDropdown_List { get { return LstHubsDropdown; } }
        public ILocator StatusDropdown_List { get { return LstStatusDropdown; } }
        public ILocator PreferredPartnerDropdown_List { get { return LstPreferredPartnerDropdown; } }
        public ILocator DateDropdown_List { get { return LstDateDropdown; } }
        public ILocator AllTab_Link { get { return LnkAllTab; } }
        public ILocator Reference_Label { get { return LblReference; } }
        public ILocator CustomerName_Label { get { return LblCustomerName; } }
        public ILocator PreferredPartner_Label { get { return LblPreferredPartner; } }
        public ILocator Time_Label { get { return LblTime; } }
        public ILocator PickupCity_Label { get { return LblPickupCity; } }
        public ILocator DeliveryCity_Label { get { return LblDeliveryCity; } }
        public ILocator Tags_Label { get { return LblTags; } }
        public ILocator Completion_Label { get { return LblCompletion; } }
        public ILocator MyPostsEllipsisButton_List { get { return LstMyPostsEllipsisButton; } }
        public ILocator MyPosts_Dashboard { get { return DashMyPosts; } }


        public string GetValueOfDashboardListLabel { get { return DashLstContainer.InnerTextAsync().GetAwaiter().GetResult(); } }
        public string GetValueOfAllhubs { get { return DdlHubs.InnerTextAsync().GetAwaiter().GetResult(); } }
        public string GetValueOfStoreInDashboard { get { return LblDashLatestStore.InnerTextAsync().GetAwaiter().GetResult(); } }
        public string GetValueOfStatusInDashboard { get { return LblDashStatus.First.InnerTextAsync().GetAwaiter().GetResult(); } }
        public string GetValueOfSearchPostDropdownfield { get { return DdlSearchPost.First.InnerTextAsync().GetAwaiter().GetResult(); } }
        //public string GetValueOfAllDataInDashboard { get { return LblDashboardStatus.InnerTextAsync().GetAwaiter().GetResult(); } }
        //public string GetValueOfAllStatusInDashboard { get { return AllStatusDataInDashboard.InnerTextAsync().GetAwaiter().GetResult(); } }
        public string GetValueOfLatestPartnerInDashboard { get { return LblDashCouriername.First.InnerTextAsync().GetAwaiter().GetResult(); } }
        public string GetValueOfCompletionDate { get { return LblDashCompletionDate.First.InnerTextAsync().GetAwaiter().GetResult(); } }
        public string GetValueOfDateDropdownfield { get { return DdlDate.InnerTextAsync().GetAwaiter().GetResult(); } }
        public string GetValueOfPreferredPartnerDropdownField { get { return DdlPreferredPartner.InnerTextAsync().GetAwaiter().GetResult(); } }
        public string GetValueOfTransactionRecord { get { return LblNumberOfRecords.InnerTextAsync().GetAwaiter().GetResult(); } }
        public string GetValueOfStatusDropdownfield { get { return DdlStatus.InnerTextAsync().GetAwaiter().GetResult(); } }
        public string GetValueOfSelectedCheckboxLabel { get { return LblNumberOfSelectedCheckbox.InnerTextAsync().GetAwaiter().GetResult(); } }
        public string GetValueOfAllStatusList { get { return StatusLstContainer.InnerTextAsync().GetAwaiter().GetResult(); } }
        public string GetValueOfHubsDropdownfield { get { return Hubs_Dropdown.InnerTextAsync().GetAwaiter().GetResult(); } }
        public string GetValueOfNumberOfPostsDisplay { get { return LblPaginationPostsNumberDisplay.First.InnerTextAsync().GetAwaiter().GetResult(); } }

        public async Task LogoutToWebApplication()
        {
            await BtnUserProfileIcon.ClickAsync();
            await BtnLogout.ClickAsync();
            _logger.Info("Logged out into application.");
        }
    }
}