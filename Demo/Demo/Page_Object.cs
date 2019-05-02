/*
 * Created by Ranorex
 * User: jrohilla
 * Date: 5/1/2019
 * Time: 2:50 AM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
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
    /// Description of Handle_Dropdown.
    /// </summary>
    [TestModule("C3C127B0-54B8-4FFE-98A4-85A0919454E1", ModuleType.UserCode, 1)]
    public class Page_Object : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Page_Object()
        {

        }


        void ITestModule.Run()
        {
        	Mouse.DefaultMoveTime = 300;
        	Keyboard.DefaultKeyPressTime = 100;
        	Delay.SpeedFactor = 1.0;
        	var repo = DemoRepository.Instance;
        	var loansPQXpressAccountsLogin = repo.LoansPQXpressAccountsLogin.Self;              	
          	WebFunctions.WaitforDocumentload(loansPQXpressAccountsLogin,Page_Xpath.WebDocument,15000);
			
        	loansPQXpressAccountsLogin.TryFindSingle(Page_Xpath.Ext,5000,out Page_Xpath.ExtOut);             	
        	Page_Xpath.ExtOut.Element.SetAttributeValue("value","001");
   
        	
        }
    }
}
