namespace automation_dph.src.Utils
{
    public class BasePageDriver
    {
        protected IPage Page;
        protected PageTest PageTest;

        public BasePageDriver(IPage page, PageTest pageTest)
        {
            Page = page;
            PageTest = pageTest;
        }
    }
}