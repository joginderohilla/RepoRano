/*
 * Created by Ranorex
 * User: Jrohilla
 * Date: 4/22/2019
 * Time: 10:56 PM
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

    [TestModule("692478BD-976E-4A67-A58C-8C43A63DE296", ModuleType.UserCode, 1)]
    public class Cleanup_Script : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Cleanup_Script()
        {        	        

        }
        
     
        
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0; 
            
          
            CommonFucntions.Kill_IE();           
            Report.Log(ReportLevel.Info, "Info", "Closed All IE Instances", new RecordItemIndex(1));
         
        }
    }
}
