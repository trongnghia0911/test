using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

using System.Diagnostics;
using System.Threading;
namespace Algorithmus
{

	//---------------------------------------------------------------------------
	public partial class FrmMain : Form
	{
		string FormatDateTime = "dd/MM/yyyy HH:mm:ss.fffffff";
		public FrmMain()
		{
			InitializeComponent();
		}
		//---------------------------------------------------------------------------
		private void ItmExit_Click(object sender, EventArgs e)
		{
			Close();
		}
		//---------------------------------------------------------------------------
		static uint SwapEndianness(ulong x)
		{
			return (uint)(((x & 0x000000ff) << 24) +
										 ((x & 0x0000ff00) << 8) +
										 ((x & 0x00ff0000) >> 8) +
										 ((x & 0xff000000) >> 24));
		}
		//---------------------------------------------------------------------------
		private DateTime DateTimeParser(byte[] ntpData, byte Position)
		{
			DateTime RetVal = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);//**UTC** time
			try
			{
				ulong intPart = BitConverter.ToUInt32(ntpData, Position);//Get the seconds part
				ulong fractPart = BitConverter.ToUInt32(ntpData, Position + 4);//Get the seconds fraction
				//Convert From big-endian to little-endian
				intPart = SwapEndianness(intPart);
				fractPart = SwapEndianness(fractPart);
				ulong milliseconds = (intPart * 1000) + ((fractPart * 1000) / 0x100000000L);
				RetVal = RetVal.AddMilliseconds((long)milliseconds);
			}
			catch (Exception ex)
			{
				TxtLogs.AppendText(Environment.NewLine + ex.Message);
			}
			return RetVal;
		}
		//---------------------------------------------------------------------------
		private void ItmCristian_Click(object sender, EventArgs e)
		{
			try
			{
				const string ntpServer = "time.windows.com";//default Windows time server
				IPAddress[] addresses = Dns.GetHostEntry(ntpServer).AddressList;
				//The UDP port number assigned to NTP is 123
				IPEndPoint ipEndPoint = new IPEndPoint(addresses[0], 123); //NTP uses UDP
				// NTP message size - 16 bytes of the digest (RFC 1305)
				byte[] ntpData = new byte[48];
				//Setting the Leap Indicator, Version Number and Mode values
				ntpData[0] = 0x1B; //LI = 0 (no warning), VN = 3 (IPv4 only), Mode = 3 (Client Mode)
				DateTime OriginateSendTimestamp = System.DateTime.Now; //T1                
				using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp))
				{
					socket.Connect(ipEndPoint);
					socket.ReceiveTimeout = 3000;//Stops code hang if NTP is blocked
					socket.Send(ntpData);
					socket.Receive(ntpData);
					socket.Close();
				}
				DateTime OriginateReceiveTimestamp = System.DateTime.Now; //T4
				byte Position = 32; //Received Time 
				DateTime ReceiveTimestamp = DateTimeParser(ntpData, Position).ToLocalTime(); //T2
				Position = 40;
				DateTime TransmitTimestamp = DateTimeParser(ntpData, Position).ToLocalTime(); //T3
				long Theta = (long)Math.Round(((ReceiveTimestamp.Ticks - OriginateSendTimestamp.Ticks) + (TransmitTimestamp.Ticks - OriginateReceiveTimestamp.Ticks)) / 2.0, 0);
				DateTime FinalDateTime = System.DateTime.Now.AddTicks(Theta);
				DateTimeUtils.SetDateTime(FinalDateTime.ToUniversalTime());
				FinalDateTime = System.DateTime.Now;
				TxtLogs.Clear();
				TxtLogs.AppendText("Originate Send Timestamp T1: " + OriginateSendTimestamp.ToString(FormatDateTime));
				TxtLogs.AppendText(Environment.NewLine);
				TxtLogs.AppendText("ReceiveTimestamp T2: " + ReceiveTimestamp.ToString(FormatDateTime));
				TxtLogs.AppendText(Environment.NewLine);
				TxtLogs.AppendText("Transmit Timestamp T3: " + TransmitTimestamp.ToString(FormatDateTime));
				TxtLogs.AppendText(Environment.NewLine);
				TxtLogs.AppendText("Originate Receive Time stamp T4: " + OriginateReceiveTimestamp.ToString(FormatDateTime));
				TxtLogs.AppendText(Environment.NewLine);
				TxtLogs.AppendText("Theta: " + Theta.ToString());
				TxtLogs.AppendText(Environment.NewLine);
				TxtLogs.AppendText("Final Time: " + FinalDateTime.ToString(FormatDateTime));
			}
			catch (Exception ex)
			{
				TxtLogs.AppendText(Environment.NewLine + ex.Message);
			}
		}
		//-----------------------------------------------------------
		private void ItmWebService_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(ConfigApp.URL))
				{
					TxtLogs.AppendText(Environment.NewLine + "Empty URL");
				}
				else
				{
					SampleWebServices m_SampleWebServices = new SampleWebServices(ConfigApp.URL);
					string RetVal=m_SampleWebServices.Hello("My Name");
					TxtLogs.AppendText(Environment.NewLine + RetVal);
				}
			}
			catch (Exception ex)
			{
				TxtLogs.AppendText(Environment.NewLine + ex.Message);
			}
		}
	}
}