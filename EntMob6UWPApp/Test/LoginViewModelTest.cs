using EntMob6UWP.Domain;
using EntMob6UWPApp.Services;
using EntMob6UWPApp.ViewModels;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public class LoginViewModelTest
    {
        Mocks.MockFrameNavigation mockFrameNavigation;
        LoginViewModel loginViewModel;
        [TestInitialize]
        public void setUp()
        {
            mockFrameNavigation = new Mocks.MockFrameNavigation();
            loginViewModel = new LoginViewModel(mockFrameNavigation,
                 new StubIAccountDataService().GetAccount(
                (username, password) =>
                {
                    if (username.Equals("boyen"))
                    {
                        return new Account
                        {
                            Username = username,
                            Password = password,
                            Enabled = true
                        };
                    }
                    else
                    {
                        return null;
                    }

                }

                ));
        }
        [TestMethod]
        public void TestNavigationIfCorrectUser()
        {
            loginViewModel.Username = "boyen";
            loginViewModel.LoginCommand.Execute("NoMessage");
            Assert.AreEqual(mockFrameNavigation.NavigationRequests.Count, 1);
        }
        [TestMethod]
        public void TestNavigationIfIncorrectUser()
        {
            loginViewModel.Username = "boyena";
            loginViewModel.LoginCommand.Execute("NoMessage");
            Assert.AreEqual(mockFrameNavigation.NavigationRequests.Count,0);
        }

    }
}
