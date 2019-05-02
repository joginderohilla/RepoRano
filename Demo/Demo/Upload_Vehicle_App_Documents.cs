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
    /// Description of UploadFile.
    /// </summary>
    [TestModule("38C79D77-7D57-4930-A442-98259D27EF68", ModuleType.UserCode, 1)]
    public class Upload_Vehicle_App_Documents : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Upload_Vehicle_App_Documents()
        {
            // Do not delete - a parameterless constructor is required!
        }
	
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            Delay.Duration(2000);
            var repo = DemoRepository.Instance;
           var loansPQXpressAccountsLogin = repo.LoansPQXpressAccountsLogin.Self;
            
            var button_LettersAndDocs = repo.LoansPQXpressAccountsLogin.Button_LettersAndDocs;
            WebFunctions.ClickWebElement(button_LettersAndDocs);        
         	WebFunctions.WaitforDocumentload(loansPQXpressAccountsLogin,Page_Xpath.WebDocument,15000);
          
            Delay.Duration(2000);
            if (repo.LoansPQXpressAccountsLogin.Button_RquestDocSupportInfo.Exists(10000))
            {
            	var button_RquestDocSupport1 = repo.LoansPQXpressAccountsLogin.Button_RquestDocSupport;
            	WebFunctions.ClickWebElement(button_RquestDocSupport1);
            	
            }
            
           
            var documentSupportRequestInternetExpl = repo.DocumentSupportRequestInternetExpl.Self;

         	WebFunctions.WaitforFormload(documentSupportRequestInternetExpl,Page_Xpath.WebDocument,15000);
         	
            var select_RequestType = repo.LoansPQXpressAccountsLogin.Select_RequestType;          
            WebFunctions.SetDataWebEdit(select_RequestType,"Add New Document");
            Delay.Duration(2000);


            //Browse File to Upload
            
            var editbox_Browse = repo.LoansPQXpressAccountsLogin.Editbox_Browse;
            WebFunctions.ClickWebElement(editbox_Browse);
            
            var editbox_FileName = repo.Window_ChooseFileToUpload.Editbox_FileName;
            editbox_FileName.Focus();
            Delay.Duration(2000);
            WebFunctions.SetDataWebCombobox(editbox_FileName,"C:\\Users\\jrohilla\\Downloads\\File1.pdf");
            
            Delay.Duration(2000);
            var window_ChooseFileToUpload = repo.Window_ChooseFileToUpload;
            window_ChooseFileToUpload.Self.Focus();

            Delay.Duration(2000);
            
            var button_Open = repo.Window_ChooseFileToUpload.Button_Open;
            button_Open.Click();
            
            var editbox_Description = repo.LoansPQXpressAccountsLogin.VehicleForm.Editbox_Description;
            
            WebFunctions.SetDataWebEdit(editbox_Description,"Uploading Document");
            
            Delay.Duration(2000);
            var editbox_DocumentName = repo.LoansPQXpressAccountsLogin.Editbox_DocumentName;
            WebFunctions.SetDataWebEdit(editbox_DocumentName,"New Document");
            
            
            var checkbox_VehicleLoan = repo.LoansPQXpressAccountsLogin.VehicleForm.Checkbox_VehicleLoan;
            WebFunctions.ClickWebElement(checkbox_VehicleLoan);
            
            var button_SubmitRequest = repo.LoansPQXpressAccountsLogin.Button_SubmitRequest;
            WebFunctions.ClickWebElement(button_SubmitRequest);
            
            //Get pop up Text
            var label_RequestSubmittedSuccessfully = repo.MessageFromWebpage.Label_RequestSubmittedSuccessfully;
            string  PopupText=WebFunctions.GetWebText(label_RequestSubmittedSuccessfully,"Text");
            Report.Log(ReportLevel.Info,"PopUpText",  PopupText  );
            
            
            //Validate Pop Text
            if (PopupText=="Your request has been successfully submitted.")
            {
            	var button_OK = repo.MessageFromWebpage.Button_OK;
            	button_OK.Click();
            	Report.Log(ReportLevel.Success,"Status","Document Uploaded Successfully" , new RecordItemIndex(1));
            	
            }
            
            else
            {
            	
            	Report.Log(ReportLevel.Failure,"Status","Unable to upload the document" , new RecordItemIndex(1));
            	
            }
//
        }
    }
}
