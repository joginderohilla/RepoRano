/*
 * Created by Ranorex
 * User: Jrohilla
 * Date: 4/16/2019
 * Time: 11:52 PM
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
	/// Description of VlidateApplicationLaunched.
	/// </summary>
	[TestModule("821DE1C6-A25F-4137-B03E-6C3708EA912F", ModuleType.UserCode, 1)]
	public class NavigateToVehicleApp : ITestModule
	{
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public NavigateToVehicleApp()
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
			
			var label_NewApp = repo.LoansPQXpressAccountsLogin.AspnetForm.Label_NewAppInfo;
				
			
			WebFunctions.ValidateWebElementExistanceByFrequency(label_NewApp,10,2000);	
			WebFunctions.ValidateWebElementExistance(label_NewApp);   
			Delay.Duration(1000);
			
			var label_NewApp1 = repo.LoansPQXpressAccountsLogin.AspnetForm.Label_NewApp;
			WebFunctions.MoveToWebElement(label_NewApp1);
			
			
			var listItem_Vehicle = repo.LoansPQXpressAccountsLogin.AspnetForm.ListItem_Vehicle;
			WebFunctions.ClickWebElement(listItem_Vehicle);
			
			WebFunctions.WaitforDocumentload(loansPQXpressAccountsLogin,Page_Xpath.WebDocument,15000);
			var img_VehicleApp = repo.LoansPQXpressAccountsLogin.VehicleForm.Img_VehicleAppInfo;			
			WebFunctions.ValidateWebElementExistanceByFrequency(img_VehicleApp,10,2000);
			
			
		}
	}
}
