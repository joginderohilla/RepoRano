/*
 * Created by Ranorex
 * User: jrohilla
 * Date: 5/1/2019
 * Time: 3:32 AM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace Demo
{
	/// <summary>
	/// Description of Page_Xpath.
	/// </summary>
	public static class Page_Xpath
	{
		static Page_Xpath()
		{
		}
		
		static public RxPath Ext=".//input[#'sa_WorkPhoneExtension']";
		static public Ranorex.InputTag ExtOut=null;  
		static public RxPath PurposeType=".//select[#'RequestType_RequestType']";
		static public Ranorex.SelectTag PurposeTypeOut=null;  
		
		static public string WebDocument ="/dom[@domain='beta.loanspq.com']";
	    


	}
}
