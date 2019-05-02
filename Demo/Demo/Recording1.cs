﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

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
using Ranorex.Core.Repository;

namespace Demo
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("ba0ef323-42d7-473c-8399-6e4d0629dc4a", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the DemoRepository repository.
        /// </summary>
        public static DemoRepository repo = DemoRepository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
            NewVariable = "";
            NewVariable1 = "";
            NewVariable2 = "";
            NewVariable3 = "";
            NewVariable4 = "";
            NewVariable5 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
        {
            get { return instance; }
        }

#region Variables

        string _NewVariable1;

        /// <summary>
        /// Gets or sets the value of variable NewVariable1.
        /// </summary>
        [TestVariable("284542df-6e90-404a-b445-c962a7d1a815")]
        public string NewVariable1
        {
            get { return _NewVariable1; }
            set { _NewVariable1 = value; }
        }

        string _NewVariable2;

        /// <summary>
        /// Gets or sets the value of variable NewVariable2.
        /// </summary>
        [TestVariable("48bda6d4-bbe4-46bd-a5ce-1b29c151496d")]
        public string NewVariable2
        {
            get { return _NewVariable2; }
            set { _NewVariable2 = value; }
        }

        string _NewVariable3;

        /// <summary>
        /// Gets or sets the value of variable NewVariable3.
        /// </summary>
        [TestVariable("ee506569-6822-4242-b88b-aae9785c2af9")]
        public string NewVariable3
        {
            get { return _NewVariable3; }
            set { _NewVariable3 = value; }
        }

        string _NewVariable4;

        /// <summary>
        /// Gets or sets the value of variable NewVariable4.
        /// </summary>
        [TestVariable("d533f968-674d-49b9-b62d-80bf224908c5")]
        public string NewVariable4
        {
            get { return _NewVariable4; }
            set { _NewVariable4 = value; }
        }

        string _NewVariable5;

        /// <summary>
        /// Gets or sets the value of variable NewVariable5.
        /// </summary>
        [TestVariable("f2abad01-9951-4c02-8164-2af64c7ebb5e")]
        public string NewVariable5
        {
            get { return _NewVariable5; }
            set { _NewVariable5 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable NewVariable.
        /// </summary>
        [TestVariable("4db58673-ee31-4ffa-8eb0-196b8fe70983")]
        public string NewVariable
        {
            get { return repo.NewVariable; }
            set { repo.NewVariable = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click at {X=0,Y=0}.", new RecordItemIndex(0));
            Mouse.MoveTo(0, 0);
            Mouse.Click(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}