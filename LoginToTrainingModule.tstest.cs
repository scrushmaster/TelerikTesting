using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;

namespace Commons
{

    public class LoginToTrainingModule : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]

        private Pages _pages;

        /// <summary>
        /// Gets the Pages object that has references
        /// to all the elements, frames or regions
        /// in this project.
        /// </summary>
        public Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        #endregion
        
        // Add your test methods here...
    
        [CodedStep(@"Verify element 'LoginSpan' 'is' visible.")]
        public void LoginToTrainingModule_CodedStep()
        {
            // Verify element 'LoginSpan' 'is' visible.
            Pages.ConvergenceServer.LoginSpan.Wait.ForExists(30000);
            Assert.AreEqual(true, Pages.ConvergenceServer.LoginSpan.IsVisible());
            
        }
    
        [CodedStep(@"Execute test 'VerifyLoginLandingPage'")]
        public void LoginToTrainingModule_CodedStep1()
        {
            // Execute test 'VerifyLoginLandingPage'
            this.ExecuteTest("VerifyLoginLandingPage.tstest");
            
        }
    
        [CodedStep(@"Execute test 'VerifyLoginLandingPage'")]
        public void LoginToTrainingModule_CodedStep2()
        {
            // Execute test 'VerifyLoginLandingPage'
            this.ExecuteTest("VerifyLoginLandingPage.tstest");
            
        }
    
        [CodedStep(@"Verify element 'NameDiv' 'is' visible.")]
        public void VerifyLoginLandingPage_CodedStep()
        {
                        // Verify element 'NameDiv' 'is' visible.
                        Pages.ConvergenceTrainingServer0.NameDiv.Wait.ForExists(30000);
                        Assert.AreEqual(true, Pages.ConvergenceTrainingServer0.NameDiv.IsVisible());
                        
        }
    
        [CodedStep(@"Verify element 'CompletionDiv' 'is' visible.")]
        public void VerifyLoginLandingPage_CodedStep1()
        {
                        // Verify element 'CompletionDiv' 'is' visible.
                        Pages.ConvergenceTrainingServer0.CompletionDiv.Wait.ForExists(30000);
                        Assert.AreEqual(true, Pages.ConvergenceTrainingServer0.CompletionDiv.IsVisible());
                        
        }
    
        [CodedStep(@"Verify element 'DurationDiv' 'is' visible.")]
        public void VerifyLoginLandingPage_CodedStep2()
        {
                        // Verify element 'DurationDiv' 'is' visible.
                        Pages.ConvergenceTrainingServer0.DurationDiv.Wait.ForExists(30000);
                        Assert.AreEqual(true, Pages.ConvergenceTrainingServer0.DurationDiv.IsVisible());
                        
        }
    
        [CodedStep(@"Verify element 'TimeSpentDiv' 'is' visible.")]
        public void VerifyLoginLandingPage_CodedStep3()
        {
                        // Verify element 'TimeSpentDiv' 'is' visible.
                        Pages.ConvergenceTrainingServer0.TimeSpentDiv.Wait.ForExists(30000);
                        Assert.AreEqual(true, Pages.ConvergenceTrainingServer0.TimeSpentDiv.IsVisible());
                        
        }
    
        [CodedStep(@"Verify element 'DueDiv' 'is' visible.")]
        public void VerifyLoginLandingPage_CodedStep4()
        {
                        // Verify element 'DueDiv' 'is' visible.
                        Pages.ConvergenceTrainingServer0.DueDiv.Wait.ForExists(30000);
                        Assert.AreEqual(true, Pages.ConvergenceTrainingServer0.DueDiv.IsVisible());
                        
        }
    
        [CodedStep(@"Verify element 'MyTrainingDiv' 'is' visible.")]
        public void VerifyLoginLandingPage_CodedStep5()
        {
                        // Verify element 'MyTrainingDiv' 'is' visible.
                        Pages.ConvergenceTrainingServer0.MyTrainingDiv.Wait.ForExists(30000);
                        Assert.AreEqual(true, Pages.ConvergenceTrainingServer0.MyTrainingDiv.IsVisible());
                        
        }
    
        [CodedStep(@"Verify element 'ListViewDiv' 'is' visible.")]
        public void VerifyLoginLandingPage_CodedStep6()
        {
                        // Verify element 'ListViewDiv' 'is' visible.
                        Pages.ConvergenceTrainingServer0.ListViewDiv.Wait.ForExists(30000);
                        Assert.AreEqual(true, Pages.ConvergenceTrainingServer0.ListViewDiv.IsVisible());
                        
        }
    
        [CodedStep(@"Verify element 'SmallIconsDiv' 'is' visible.")]
        public void VerifyLoginLandingPage_CodedStep7()
        {
                        // Verify element 'SmallIconsDiv' 'is' visible.
                        Pages.ConvergenceTrainingServer0.SmallIconsDiv.Wait.ForExists(30000);
                        Assert.AreEqual(true, Pages.ConvergenceTrainingServer0.SmallIconsDiv.IsVisible());
                        
        }
    
        [CodedStep(@"Verify element 'LargeIconsDiv' 'is' visible.")]
        public void VerifyLoginLandingPage_CodedStep8()
        {
                        // Verify element 'LargeIconsDiv' 'is' visible.
                        Pages.ConvergenceTrainingServer0.LargeIconsDiv.Wait.ForExists(30000);
                        Assert.AreEqual(true, Pages.ConvergenceTrainingServer0.LargeIconsDiv.IsVisible());
                        
        }
    
        [CodedStep(@"Verify input 'Text' value 'Exact' ''.")]
        public void VerifyLoginLandingPage_CodedStep9()
        {
                        // Verify input 'Text' value 'Exact' ''.
                        Assert.IsTrue(ArtOfTest.Common.CompareUtils.StringCompare(Pages.ConvergenceTrainingServer0.Text.Value, "", ArtOfTest.Common.StringCompareType.Exact));
                        
        }
    
        [CodedStep(@"Verify element 'HelpDiv' 'is' visible.")]
        public void VerifyLoginLandingPage_CodedStep10()
        {
                        // Verify element 'HelpDiv' 'is' visible.
                        Pages.ConvergenceTrainingServer0.HelpDiv.Wait.ForExists(30000);
                        Assert.AreEqual(true, Pages.ConvergenceTrainingServer0.HelpDiv.IsVisible());
                        
        }
    
        [CodedStep(@"Verify element 'CphContentBtnLogoutLink' 'is' visible.")]
        public void VerifyLoginLandingPage_CodedStep11()
        {
                        // Verify element 'CphContentBtnLogoutLink' 'is' visible.
                        Pages.ConvergenceTrainingServer0.CphContentBtnLogoutLink.Wait.ForExists(30000);
                        Assert.AreEqual(true, Pages.ConvergenceTrainingServer0.CphContentBtnLogoutLink.IsVisible());
                        
        }
    
        [CodedStep(@"HandleAlreadyLoggedInPopup")]
        public void HandleAlreadyLoggedInPopup_CodedStep()
        {
            //Handles the already logged in popup.
            try
            {
                Pages.ConvergenceTrainingServer0.NameDiv.IsVisible();
            }
            catch
            {
                Pages.ConvergenceServer.btn_LoginConflictOK.Click();
            }
        }            
    }
}
