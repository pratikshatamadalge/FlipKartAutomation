using FlipcartAutomation.Base;
using NUnit.Framework;
using FlipcartAutomation.Pages;

namespace FlipcartAutomation
{
    public class Tests:BaseClass
    {

        [Test, Order(0)]
        public void LoginTest()
        {
            Login login = new Login(driver);
            login.LoginPage();
        }

        [Test,Order(1)]
        public void SearchProductTest()
        {
            SearchProduct search = new SearchProduct(driver);
            search.SearchProductPage();
        }

        [Test,Order(2)]
        public void AddToCartTest()
        {
            AddToCart cart = new AddToCart(driver);
            cart.AddToCartPage();
        }

        [Test,Order(3)]
        public void PlaceOrderTest()
        {
            PlaceOrder order = new PlaceOrder(driver);
            order.PlaceOrderPage();
        }

        [Test,Order(4)]
        public void AddressTest()
        {
            Address address = new Address(driver);
            address.AddressPage();
        }

        [Test, Order(5)]
        public void LogoutTest()
        {
            Logout logout = new Logout(driver);
            logout.LogoutPage();
        }
    }
}