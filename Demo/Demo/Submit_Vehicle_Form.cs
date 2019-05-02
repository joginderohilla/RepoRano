/*
 * Created by Ranorex
 * User: Jrohilla
 * Date: 4/23/2019
 * Time: 1:24 AM
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
	/// Description of SubmitVehicleForm.
	/// </summary>
	[TestModule("47743B60-FAC2-46D0-B206-82CDDC187099", ModuleType.UserCode, 1)]
	public class Submit_Vehicle_Form : ITestModule
	{
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public Submit_Vehicle_Form()
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
			WebFunctions.WaitforDocumentload(loansPQXpressAccountsLogin,Page_Xpath.WebDocument,15000);
			
	
			
			var select_OfficialFamilyUse = repo.LoansPQXpressAccountsLogin.Select_OfficialFamilyUse;		
			WebFunctions.SelectWebListItem(select_OfficialFamilyUse,"tagvalue","EMPLOYEE");			
			WebFunctions.WaitforDocumentload(loansPQXpressAccountsLogin,Page_Xpath.WebDocument,15000);
			
			
			var dropDown_PurposeTypeInfo = repo.LoansPQXpressAccountsLogin.VehicleForm.DropDown_PurposeTypeInfo;
			WebFunctions.ValidateWebElementExistanceByFrequency(dropDown_PurposeTypeInfo,10,2000);
			
			var dropDown_PurposeType = repo.LoansPQXpressAccountsLogin.VehicleForm.DropDown_PurposeType;
			WebFunctions.SelectWebListItem(dropDown_PurposeType,"tagvalue","Other");			
			WebFunctions.WaitforDocumentload(loansPQXpressAccountsLogin,Page_Xpath.WebDocument,15000);
			
			var editbox_SSN1 = repo.LoansPQXpressAccountsLogin.VehicleForm.Editbox_SSNInfo;
			WebFunctions.ValidateWebElementExistanceByFrequency(editbox_SSN1,10,2000);
			Delay.Duration(2000);
			
			var editbox_SSN = repo.LoansPQXpressAccountsLogin.VehicleForm.Editbox_SSN;
			WebFunctions.SetWebAttributeValue(editbox_SSN,"value","");
			WebFunctions.SetDataWebEdit(editbox_SSN,"000000001");
			
			WebFunctions.SetDataWebEdit(editbox_SSN,"{TAB}");
			WebFunctions.WaitforDocumentload(loansPQXpressAccountsLogin,Page_Xpath.WebDocument,15000);
			
			var label_WouldYouLikeToImportMemberData = repo.MessageFromWebpage.Label_WouldYouLikeToImportMemberDataInfo;
			if (repo.MessageFromWebpage.Label_WouldYouLikeToImportMemberDataInfo.Exists(10000))
			{
				var button_OK = repo.MessageFromWebpage.Button_OK;
				WebFunctions.ClickWebButton(button_OK);
				
			}
			WebFunctions.WaitforDocumentload(loansPQXpressAccountsLogin,Page_Xpath.WebDocument,15000);
			
			
			var editbox_AmountRequested = repo.LoansPQXpressAccountsLogin.VehicleForm.Editbox_AmountRequested;
			WebFunctions.SetWebAttributeValue(editbox_AmountRequested,"value","");
			WebFunctions.SetDataWebEdit(editbox_AmountRequested,"10");
			Delay.Duration(3000);
			
			
			
			
			var checkBox_HearAboutOrganisation = repo.LoansPQXpressAccountsLogin.VehicleForm.CheckBox_HearAboutOrganisation;
			
			string varPropertyValue=WebFunctions.GetWebAttributeValueText(checkBox_HearAboutOrganisation,"checked");
			
			if (varPropertyValue=="False")
				
			{
				WebFunctions.ClickWebElement(checkBox_HearAboutOrganisation);
				
			}
			
			WebFunctions.WaitforDocumentload(loansPQXpressAccountsLogin,Page_Xpath.WebDocument,15000);
			var dropDown_AutomaticPaymentsInfo = repo.LoansPQXpressAccountsLogin.VehicleForm.DropDown_AutomaticPaymentsInfo;
			
			WebFunctions.ValidateWebElementExistance(dropDown_AutomaticPaymentsInfo);
			var dropDown_AutomaticPayments = repo.LoansPQXpressAccountsLogin.VehicleForm.DropDown_AutomaticPayments;
			WebFunctions.SelectWebListItem(dropDown_AutomaticPayments,"tagvalue","No");

			var dropDown_DirectDposit = repo.LoansPQXpressAccountsLogin.VehicleForm.DropDown_DirectDposit;
			WebFunctions.SelectWebListItem(dropDown_DirectDposit,"tagvalue","No");
			
			WebFunctions.WaitforDocumentload(loansPQXpressAccountsLogin,Page_Xpath.WebDocument,15000);
			var editbox_LoanTerm = repo.LoansPQXpressAccountsLogin.VehicleForm.Editbox_LoanTerm;
			WebFunctions.SetDataWebEdit(editbox_LoanTerm,"1");

			
			Delay.Duration(2000);
			var button_PullCreitAndSave = repo.LoansPQXpressAccountsLogin.VehicleForm.Button_PullCreitAndSave;
			WebFunctions.ClickWebElement(button_PullCreitAndSave);
						
			
			var label_RefferedProducts = repo.LoansPQXpressAccountsLogin.VehicleForm.Label_RefferedProductsInfo;
			WebFunctions.ValidateWebElementExistanceByFrequency(label_RefferedProducts,10,5000);
			
			
			
		}
	}
}
