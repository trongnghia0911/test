using System;
using System.Text;
using System.Configuration;
public class ConfigApp
{
	public static int ServerPort = (ConfigurationManager.AppSettings["PortNumber"] == null) ? 20000 : Int32.Parse(ConfigurationManager.AppSettings["PortNumber"].ToString().Trim());
	public static string ServerIp = (ConfigurationManager.AppSettings["ServerIp"] == null) ? "localhost" : ConfigurationManager.AppSettings["ServerIp"].ToString().Trim();
}
