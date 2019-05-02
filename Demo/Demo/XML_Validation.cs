/*
 * Created by Ranorex
 * User: jrohilla
 * Date: 4/30/2019
 * Time: 10:51 PM
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
    /// Description of XMLValidation.
    /// </summary>
    [TestModule("086B5D1B-7BD6-47D5-8823-4E878F0099DA", ModuleType.UserCode, 1)]
    public class XML_Validation : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public XML_Validation()
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
            
             CommonFucntions.ValidateXMLNode("D:\\Meridian Link\\Testdata\\Config.xml","Version","9.1");
        }
    }
}
