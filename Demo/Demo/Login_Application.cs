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
    /// Description of Login.
    /// </summary>
    [TestModule("F3BD88C0-5F3C-4FED-9A52-87EA7BECA965", ModuleType.UserCode, 1)]
    public class Login_Application : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Login_Application()
        {
            // Do not delete - a parameterless constructor is required!
        }
     
    
     
     string _Password = "";
     [TestVariable("c1d6a91a-b6c9-4037-8964-3a80f4618e84")]
     public string Password
     {
     	get { return _Password; }
     	set { _Password = value; }
     }
     
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
           
            
            var repo = DemoRepository.Instance;                   
          	var loansPQXpressAccountsLogin = repo.LoansPQXpressAccountsLogin.Self;        	
			WebFunctions.WaitforDocumentload(loansPQXpressAccountsLogin,Page_Xpath.WebDocument,15000);
			
			
            var editbox_Login = repo.LoansPQXpressAccountsLogin.Editbox_Login;
            WebFunctions.SetDataWebEdit(editbox_Login,"ALOKA_QA_BH");
            
            var button_Login = repo.LoansPQXpressAccountsLogin.Button_Login;
            WebFunctions.ClickWebElement(button_Login);
            
            WebFunctions.WaitforDocumentload(loansPQXpressAccountsLogin,Page_Xpath.WebDocument,15000);
            
            
//            var editbox_Question1 = repo.LoansPQXpressAccountsLogin.Editbox_Question1;
//            WebFunctions.SetDataWebEdit(editbox_Question1,"jhansi");
//            
//            var editbox_Question2 = repo.LoansPQXpressAccountsLogin.Editbox_Question2;
//            WebFunctions.SetDataWebEdit(editbox_Question2,"jhansi");
//            
//            var button_Continue = repo.LoansPQXpressAccountsLogin.Button_Continue;
//            WebFunctions.ClickWebElement(button_Continue);
//            
//            loansPQXpressAccountsLogin.Self.WaitForDocumentLoaded(15000);
            
            var editbox_Password = repo.LoansPQXpressAccountsLogin.AspnetForm.Editbox_Password;
            WebFunctions.SetDataWebEdit(editbox_Password,Password);
            
            var button_SignIn = repo.LoansPQXpressAccountsLogin.AspnetForm.Button_SignIn;          
            WebFunctions.ClickWebElement(button_SignIn);
            WebFunctions.WaitforDocumentload(loansPQXpressAccountsLogin,Page_Xpath.WebDocument,15000);
            
            var label_InvalidLogin = repo.LoansPQXpressAccountsLogin.AspnetForm.Label_InvalidLoginInfo;
            WebFunctions.ValidateWebElementNotExistance(label_InvalidLogin);
            
            var label_NewApp = repo.LoansPQXpressAccountsLogin.AspnetForm.Label_NewAppInfo;
            WebFunctions.ValidateWebElementExistanceByFrequency(label_NewApp,3,2000);
            
		 


            
        }
    }
}
