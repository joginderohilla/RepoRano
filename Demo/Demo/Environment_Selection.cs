/*
 * Created by Ranorex
 * User: jrohilla
 * Date: 5/1/2019
 * Time: 1:54 AM
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
    /// Description of Environment_Selection.
    /// </summary>
    [TestModule("81721F05-E3C5-4143-BC4D-5F7472B44044", ModuleType.UserCode, 1)]
    public class Environment_Selection : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Environment_Selection()
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
            
            CommonFucntions.SelectEnvironment(); 
        }
    }
}
