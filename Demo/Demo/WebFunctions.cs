
using System;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace Demo
{
	/// <summary>
	/// Description of WebFucntions.
	/// </summary>
	public static class WebFunctions
		
	{
		
		static bool ElementFound;
	
		static WebFunctions()
		{
			
		}
		
		public static void LaunchBrowser(string url, string browser)
		{
			Report.Log(ReportLevel.Info, "Website", "Opening web site "+url+" with browser 'IE' in normal mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser(url, browser, "", false, true, false, false, false, true);
            Delay.Milliseconds(0);
		}
		
		public static void CloseBrowser(Ranorex.WebDocument BrowserRepo)
		{
			
      		Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'LoansPQXpressAccountsLogin'.", new RecordItemIndex(0));
      		
      		
            Host.Current.CloseApplication(BrowserRepo, new Duration(0));
            Delay.Milliseconds(0);
		}
		
		public static void ValidateWebElementExistance(Ranorex.Core.Repository.RepoItemInfo WebElementName)
		{
			Report.Log(ReportLevel.Info, "Web Element", "Validating Element "+WebElementName+" Existance with in browser 'IE' in normal mode.", new RecordItemIndex(0));
			
					
			if (WebElementName.Exists(2000) )
            {
            	
            	Report.Log(ReportLevel.Success,"Element Existance:",  "Element "+WebElementName+" found Sucessfully on Web Page" , new RecordItemIndex(1) );
            }
            else
            {
            	
            	Report.Log(ReportLevel.Failure,"Element Existance:",  "Element "+WebElementName+" Coudnlt be found on Web Page", new RecordItemIndex(1)  );
            	
            }
			
            Delay.Milliseconds(0);
		}
		
		public static void ValidateWebElementNotExistance(Ranorex.Core.Repository.RepoItemInfo WebElementName)
		{
			Report.Log(ReportLevel.Info, "Web Element", "Validating Element "+WebElementName+" Existance with in browser 'IE' in normal mode.", new RecordItemIndex(0));
			
					
			if (!WebElementName.Exists(2000) )
            {
            	
            	Report.Log(ReportLevel.Success,"Element Existance:",  "Element "+WebElementName+" Does'nt exist on Web Page" , new RecordItemIndex(1) );
            }
            else
            {
            	
            	Report.Log(ReportLevel.Failure,"Element Existance:",  "Element "+WebElementName+" found on Web Page", new RecordItemIndex(1)  );
            	
            }
			
            Delay.Milliseconds(0);
		}
		
				
		public static void ClickWebElement( Ranorex.WebElement Web_Element)
			
		{
						
			Web_Element.Click();
			Report.Log(ReportLevel.Info,"Click",  "Clicked on Element "+Web_Element,new RecordItemIndex(1));
			
		}
		
		public static void ClickWebButton( Ranorex.Button Web_Element)
			
		{
						
			Web_Element.Click();
			Report.Log(ReportLevel.Info,"Click",  "Clicked on Web Button "+Web_Element,new RecordItemIndex(1));
			
		}
		
		public static void ClickWebComboBox( Ranorex.ComboBox Web_Element)
			
		{
						
			Web_Element.Click();
			Report.Log(ReportLevel.Info,"Click",  "Clicked on Web ComboBox "+Web_Element,new RecordItemIndex(1));
			
		}
		
		
		public static void SetDataWebEdit( Ranorex.WebElement Web_Element,string DataValue)
		{
						
			Web_Element.PressKeys(DataValue);
			Report.Log(ReportLevel.Info,"Set Data",  "Data:"+DataValue+" is set to given Editbox"+Web_Element,new RecordItemIndex(1));
		}
		
		public static void SetDataWebCombobox( Ranorex.ComboBox Web_Element,string DataValue)
		{
						
			Web_Element.PressKeys(DataValue);
			Report.Log(ReportLevel.Info,"Set Data",  "Data:"+DataValue+" is set to given Editbox"+Web_Element,new RecordItemIndex(1));
		}
		
		public static void MoveToWebElement( Ranorex.WebElement Web_Element)
		{
						
			Web_Element.MoveTo(2000);
			Report.Log(ReportLevel.Info,"Move to Element",  "Mouse cursor is moved to Given Elment"+Web_Element,new RecordItemIndex(1));
		}
		
		
		public static void SelectWebListItem( Ranorex.WebElement Web_Element, string PropertyName, string PropertyValue)
		{
						
			Web_Element.Element.SetAttributeValue(PropertyName,PropertyValue);
			Report.Log(ReportLevel.Info, "Select Item", "Selected "+PropertyValue+" in List for WebElement"+Web_Element, new RecordItemIndex(1));
            Delay.Milliseconds(0);
		}
		
		
		public static void SetWebAttributeValue( Ranorex.WebElement Web_Element,string PropertyName, string PropertyValue)
		{
						
			Web_Element.Element.SetAttributeValue(PropertyName,PropertyValue);
			Report.Log(ReportLevel.Info,"Set Attribute Value",  "Property Value: "+PropertyValue+" is set to Propetry: "+PropertyName+" for WebElment "+Web_Element ,new RecordItemIndex(1));
		}
		
		public static void SetWebComboBoxAttributeValue( Ranorex.ComboBox Web_Element,string PropertyName, string PropertyValue)
		{
						
			Web_Element.Element.SetAttributeValue(PropertyName,PropertyValue);
			Report.Log(ReportLevel.Info,"Set Attribute Value",  "Property Value: "+PropertyValue+" is set to Propetry: "+PropertyName+" for WebComboBox "+Web_Element ,new RecordItemIndex(1));
		}
		
		
		public static string GetWebAttributeValueText( Ranorex.WebElement Web_Element,string PropertyName)
		{
						
			string varPropertyValue=Web_Element.Element.GetAttributeValueText(PropertyName);
			Report.Log(ReportLevel.Info,"Get Attribute Value",  "Property Value: "+varPropertyValue+" is fecthed for Propetry: "+PropertyName+" for WebElment "+Web_Element ,new RecordItemIndex(1));
			
			return varPropertyValue;
		}
		
		public static string GetWebText( Ranorex.Text Web_Element,string PropertyName)
		{
						
			string varPropertyValue=Web_Element.Element.GetAttributeValueText(PropertyName);
			Report.Log(ReportLevel.Info,"Get Attribute Value",  "Property Value: "+varPropertyValue+" is fecthed for Propetry: "+PropertyName+" for WebElment "+Web_Element ,new RecordItemIndex(1));
			
			return varPropertyValue;
		}
		
	   public static void ValidateWebElementExistanceByFrequency(Ranorex.Core.Repository.RepoItemInfo WebElementName,int Frequency,int Interval)
		{
			Report.Log(ReportLevel.Info, "Web Element", "Validating Element "+WebElementName+" Existance with in browser 'IE' in normal mode.", new RecordItemIndex(0));
			
			for (int i = 0; i < Frequency; i++)
			{
								
				if (WebElementName.Exists(1000) )
				{
					
					Report.Log(ReportLevel.Success,"Element Existance:",  "Element "+WebElementName+" found Sucessfully on Web Page" , new RecordItemIndex(1));
					ElementFound=true;
				    break;
					
				}			
				
				Delay.Milliseconds(Interval);
				
			}
			
			if (ElementFound==false)
			{
				Report.Log(ReportLevel.Failure,"Element Existance:",  "Element "+WebElementName+" Coudnlt be found on Web Page", new RecordItemIndex(1));
			}	
		
			
			
		}
	   
	   public static void WaitforFormload( Ranorex.Form Appath,string DocumentPath, int timeout)
	   {
	   	
	    Ranorex.WebDocument doc= Appath.FindSingle<Ranorex.WebDocument>(DocumentPath); 
	    
	    Report.Log(ReportLevel.Info,"Waiting for Form to Load.", "Web Form "+Appath+" is loading", new RecordItemIndex(1));
        doc.WaitForDocumentLoaded(timeout);  

	   	
	   }
	   
	     public static void WaitforDocumentload( Ranorex.WebDocument Appath,string DocumentPath, int timeout)
	   {
	   	
	    Ranorex.WebDocument doc= Appath.FindSingle<Ranorex.WebDocument>(DocumentPath);      
		Report.Log(ReportLevel.Info,"Waiting for Page to Load.", "WebPage "+Appath+" is loading", new RecordItemIndex(1));    
        doc.WaitForDocumentLoaded(timeout);  

	   	
	   }
	
	
	}
}
