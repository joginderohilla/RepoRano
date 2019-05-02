/*
 * Created by Ranorex
 * User: Jrohilla
 * Date: 4/22/2019
 * Time: 10:30 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Diagnostics;
using System.Xml;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Microsoft.VisualBasic;

namespace Demo
{
	/// <summary>
	/// Description of CommonFucntions.
	/// </summary>
	public static class CommonFucntions
	{
		static CommonFucntions()
		{
		}
		public static string Env = "";  
		public static void Kill_IE()
		{
			Process[] ps = Process.GetProcessesByName("IEXPLORE");

			foreach (Process p in ps)
			{
				p.Kill();
			}
		}
		
		
		public static void ValidateXMLNode(string xmlpath, string tagname,string tagvalue)
		{

			XmlDocument doc = new XmlDocument();
			//doc.Load(@"D:\\Meridian Link\\Testdata\\Config.xml");
			doc.Load(xmlpath);

			XmlNode node = doc.DocumentElement.SelectSingleNode("//"+tagname);

			string nodeContent = node.InnerText;

			if (nodeContent.Equals(tagvalue))
			{
				Report.Log(ReportLevel.Success, "Info", tagvalue+" matched under tagname name "+tagname+" in xml file at path "+xmlpath, new RecordItemIndex(1));
			}
			else
			{
				Report.Log(ReportLevel.Failure, "Info", tagvalue+" did not match under tagname name "+tagname+" in xml file at path "+xmlpath, new RecordItemIndex(1));
			}

		}
		
		public static void SelectEnvironment()
		{
			
			Env = Interaction.InputBox("Input Box", "Enter Environment", "Default", -1, -1);
			
		}
		
		
		
	}
}
