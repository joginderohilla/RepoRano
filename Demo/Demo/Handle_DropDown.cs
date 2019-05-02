/*
 * Created by Ranorex
 * User: jrohilla
 * Date: 5/1/2019
 * Time: 3:48 AM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Runtime;

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
    /// Description of Handle_DropDown.
    /// </summary>
    [TestModule("15C6734C-775C-4138-969D-1825EFF228D9", ModuleType.UserCode, 1)]
    public class Handle_DropDown : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Handle_DropDown()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            
            var repo = DemoRepository.Instance;
        	var loansPQXpressAccountsLogin = repo.LoansPQXpressAccountsLogin.Self;      	
          	
        	loansPQXpressAccountsLogin.TryFindSingle(Page_Xpath.PurposeType,5000,out Page_Xpath.PurposeTypeOut);
        	Report.Info ("Get No. of List Item",Page_Xpath.PurposeTypeOut.Element.Children.Count.ToString());
      	               	
     		//IList<Ranorex.OptionTag > optionList =Host.Local.Find<Ranorex.OptionTag>("./dom[@domain='beta.loanspq.com']//select[#'RequestType_RequestType']/Option",500);
     		
     		Report.Info("Info",loansPQXpressAccountsLogin.Find<Ranorex.OptionTag>(".//select[#'RequestType_RequestType']/Option").Count.ToString());
     		
     		IList<Ranorex.OptionTag > optionList= loansPQXpressAccountsLogin.Find<Ranorex.OptionTag>(".//select[#'RequestType_RequestType']/Option");
     		
     		foreach (Ranorex.OptionTag ot in optionList) 
     		{
     			Report.Info("Info",ot.Element.GetAttributeValue("tagvalue").ToString());
     		}
     		
        	Page_Xpath.PurposeTypeOut.Element.SetAttributeValue("tagvalue","Other");
        	Delay.Duration(2000);
        	
            
        }
    }
}
