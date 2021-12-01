using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class SampleWebServices : System.Web.Services.WebService
{
	public SampleWebServices()
	{
		//Uncomment the following line if using designed components 
		//InitializeComponent(); 
	}
	[WebMethod]
	public string Hello(string UserName)
	{
		string RetVal = "";
		try
		{
			if (string.IsNullOrEmpty(UserName))
			{
				RetVal = "Empty UserName";
			}
			else
			{
				RetVal = "Hello " + UserName;
			}
		}
		catch (Exception ex)
		{
			RetVal = ex.Message;
		}
		return RetVal;
	}

}
