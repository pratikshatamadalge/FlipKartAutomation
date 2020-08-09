namespace FlipcartAutomation.Pages
{
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;

    class AddToCart
    {
        public IWebDriver driver;

        public AddToCart(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//body/div[@id='container']/div/div/div/div/div/div/ul/li/button[1]")]
        IWebElement addToCart;

        public void AddToCartPage()
        {
            addToCart.Click();
        }

        public string validatePage()
        {
            return addToCart.Text;
        }
    }
}
