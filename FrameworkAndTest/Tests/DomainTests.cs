using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework;

namespace Tests
{
    [TestClass]
    public class DomainTests
    {
        [TestInitialize]
        public void initialize()
        {
            Main.CreateDriver();
        }

        [TestMethod]
        public void verifyTabMenusNavigation()
        {
            HomePage.goToHome();
            Assert.IsTrue(HomePage.isAtPropertyOrHomePage(), "The operation failed to navigate to the home page");
            
            HomePage.GoToTab("News");
            Assert.IsTrue(NewsPage.isAtNewsPage(), "The operation failed to navigate to the news page");

            HomePage.GoToTab("Property");
            Assert.IsTrue(HomePage.isAtPropertyOrHomePage(), "The operation failed to navigate to the property page");

            HomePage.GoToTab("Business for Sale");
            Assert.IsTrue(BusinessForSalePage.isAtBusinessForSalePage(), "The operation failed to navigate to the business for sale page");

            HomePage.GoToTab("Agents");
            Assert.IsTrue(AgentsPage.isAtAgentsPage(), "The operation failed to navigate to the agents page");

            HomePage.GoToTab("Franchise");
            Assert.IsTrue(FranchisePage.isAtFranchiseSalePage(), "The operation failed to navigate to the franchise page");

            HomePage.GoToTab("Sign Up");
            Assert.IsTrue(SignUpPage.isAtSignUpPage(), "The operation failed to navigate to the signup page");
            Main.navigateBack();

            HomePage.GoToTab("Login");
            Assert.IsTrue(LoginPage.isAtLoginPage(), "The operation failed to navigate to the login page");
            Main.navigateBack();

            HomePage.GoToTab("Commercial Real Estate");
            Assert.IsTrue(HomePage.isAtPropertyOrHomePage(), "The operation failed to navigate to the home page");
           

        }

        [TestCleanup]
        public void cleanup()
        {
            Main.cleanup();
        }
    }
}
