using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace Demo
{
    /// <summary>
    /// Description of ValidateApplicationLaunched.
    /// </summary>
    [TestModule("52BEE550-F508-49AA-B86D-A8C38F950095", ModuleType.UserCode, 1)]
    public class Validate_Application_Launched : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Validate_Application_Launched()
        {
            // Do not delete - a parameterless constructor is required!
        }

      
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            var repo = DemoRepository.Instance;
            var loansPQXpressAccountsLogin = repo.LoansPQXpressAccountsLogin.Self; 
            
            if (CommonFucntions.Env.ToUpper()=="QA")
            {
     
        	    
            	WebFunctions.WaitforDocumentload(loansPQXpressAccountsLogin,Page_Xpath.WebDocument,15000);
            	
				var img_HomepageLogo = repo.LoansPQXpressAccountsLogin.Img_HomepageLogoInfo;            	
            	WebFunctions.ValidateWebElementExistance(img_HomepageLogo);
            }

        
        			
            
        }
    }
}
