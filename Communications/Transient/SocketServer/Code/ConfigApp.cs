using System;
using System.Text;
using System.Configuration;
public class ConfigApp
{
	public static int ServerPort = (ConfigurationManager.AppSettings["ServerPort"] == null) ? 10000 : Int32.Parse(ConfigurationManager.AppSettings["ServerPort"].ToString().Trim());
}
