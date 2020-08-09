// <copyright file="FlipcartTest.cs" company="Bridgelabz">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FlipcartAutomation
{
    using FlipcartAutomation.Base;
    using FlipcartAutomation.Pages;
    using NUnit.Framework;

    public class Tests:BaseClass
    {
        [Test, Order(0)]
        public void LoginTest()
        {
            Login login = new Login(driver);
            login.LoginPage();
            string actualResult = login.validatePage();
            Assert.AreEqual("My Account", actualResult);
        }

        [Test,Order(1)]
        public void SearchProductTest()
        {
            SearchProduct search = new SearchProduct(driver);
            search.SearchProductPage();
            string actualResult = search.validatePage();
            Assert.AreEqual("Sort By",actualResult);
        }

        [Test,Order(2)]
        public void AddToCartTest()
        {
            AddToCart cart = new AddToCart(driver);
            cart.AddToCartPage();
            string actualResult = cart.validatePage();
            Assert.AreEqual("GO TO CART", actualResult);
        }

        [Test,Order(3)]
        public void PlaceOrderTest()
        {
            PlaceOrder order = new PlaceOrder(driver);
            order.PlaceOrderPage();
            string actualResult = order.validatePage();
            Assert.AreEqual("ORDER SUMMARY", actualResult);
        }

        [Test,Order(4)]
        public void AddressTest()
        {
            Address address = new Address(driver);
            string actualResult = address.validatePage();
            address.AddressPage();
            Assert.AreEqual("ORDER SUMMARY", actualResult);
        }

        [Test, Order(5)]
        public void LogoutTest()
        {
            Logout logout = new Logout(driver);
            logout.LogoutPage();
        }
    }
}