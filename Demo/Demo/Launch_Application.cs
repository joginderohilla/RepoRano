/*
 * Created by Ranorex
 * User: Jrohilla
 * Date: 4/22/2019
 * Time: 11:33 PM
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
    /// Description of LaunchApplication.
    /// </summary>
    [TestModule("D0AF3DF0-BBFB-4B1D-B3A0-D7F9E99164B9", ModuleType.UserCode, 1)]
    public class Launch_Application : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Launch_Application()
        {

        }
                
       
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
   
             
             if (CommonFucntions.Env.ToUpper()=="QA")
             {
             
             	WebFunctions.LaunchBrowser("https://beta.loanspq.com","IE");
             	Report.Log(ReportLevel.Info, "Info", "Launched LPQ Application in IE Browser and QA Environment", new RecordItemIndex(1));
             	Delay.Milliseconds(2000);
             	
             }
             
                      
             
             else
             	
             {
             	             	
             	Report.Log(ReportLevel.Failure, "Info", "Invalid Environment Selection", new RecordItemIndex(1));
               	System.Environment.Exit(1);
             	             	
             }
             
             
          
             
        }
    }
}
