using System;
using System.Text;
using System.Configuration;
public class ConfigApp
{
	public static string URL = (ConfigurationManager.AppSettings["URL"] == null) ? "" : ConfigurationManager.AppSettings["URL"].ToString().Trim();
}
