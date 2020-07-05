using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Xml;
using System.Net.NetworkInformation;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Linq;

namespace EnergyMonitor
{
	public partial class MainForm : Form
	{
		//private static readonly IPAddress GroupAddress = IPAddress.Parse("239.12.255.254");
		//private const int GroupPort = 9522;
		IPAddress GroupAddress=IPAddress.Parse(ReadXML("GroupAddress"));
		int GroupPort=Int32.Parse(ReadXML("GroupPort"));
		
		Thread Listener;
		bool StopThread=false;
		bool logging=false;
		TextWriter csv;
		String Networkcard = null;
				
		//const String ChartName="Power";
		String[] ChartNamen = {"Wirkleistung"}; //,"Scheinleistung","Blindleistung"};
		DateTime xaxismin = DateTime.Now;
		DateTime xaxismax = DateTime.Now;
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		void StartListener() {
			txtStatus.Text="Start...";
			UdpClient listener = new UdpClient(GroupPort);
			listener.Client.ReceiveTimeout=5000;
			TimeSpan ts;
			
			txtStatus.Text="Gefundene Netzwerkkarten (falls mehr als eine, in settings.xml konfigurieren!):";
			
			NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
			int i=0;
			String adapters="";
			foreach (NetworkInterface adapter in nics)
			{
					IPInterfaceProperties ip_properties = adapter.GetIPProperties();
  					if (adapter.GetIPProperties().MulticastAddresses.Count==0)
    					continue; // most of VPN adapters will be skipped
 					if (!adapter.SupportsMulticast)
    					continue; // multicast is meaningless for this type of connection
  					if (OperationalStatus.Up != adapter.OperationalStatus)
    					continue; // this adapter is off or not connected
  					IPv4InterfaceProperties p = adapter.GetIPProperties().GetIPv4Properties();
  					if (null == p)
    					continue; // IPv4 is not configured on this adapter
  					if((Networkcard!="") && (!adapter.Name.Equals(Networkcard))) continue;
  					i++;
  					adapters+=Environment.NewLine+adapter.Name;
 					txtStatus.Text+=Environment.NewLine+adapter.Name;
  					listener.Client.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.MulticastInterface, (int)IPAddress.HostToNetworkOrder(p.Index));
  			}
			
			if(i>1) {
				MessageBox.Show(i.ToString()+ " Netzwerkkarten gefunden:"+adapters+Environment.NewLine+"Bitte den Richtigen Adapter in settings.xml konfigurieren!");
				Application.Exit();
			}
			
			IPEndPoint groupEP = new IPEndPoint(GroupAddress, GroupPort);

			try {
				listener.JoinMulticastGroup(GroupAddress);
				txtStatus.Text+=Environment.NewLine+"Waiting for Broadcast...";

                byte[] readobis = listener.Receive(ref groupEP);
                byte[] obis = new byte[4];

                byte[] WirkleistungBezugObis            = new byte[] { 0, 1, 4, 0 };
                byte[] WirkleistungLieferungObis        = new byte[] { 0, 2, 4, 0 };
                byte[] WirkleistungBezugCounterObis     = new byte[] { 0, 1, 8, 0 };
                byte[] WirkleistungLieferungCounterObis = new byte[] { 0, 2, 8, 0 };
                byte[] BlindleistungBezugObis           = new byte[] { 0, 3, 4, 0 };
                byte[] BlindleistungLieferungObis       = new byte[] { 0, 4, 4, 0 };
                byte[] ScheinleistungBezugObis          = new byte[] { 0, 9, 4, 0 };
                byte[] ScheinleistungLieferungObis      = new byte[] { 0,10, 4, 0 };
                byte[] LeistungfaktorObis               = new byte[] { 0,13, 4, 0 };
                byte[] NetzfrequenzObis                 = new byte[] { 0,14, 4, 0 };


                byte[] P1_WirkleistungBezugObis         = new byte[] { 0,21, 4, 0 };
                byte[] P1_WirkleistungLieferungObis     = new byte[] { 0,22, 4, 0 };
                byte[] P1_StromObis                     = new byte[] { 0,31, 4, 0 };
                byte[] P1_SpannungObis                  = new byte[] { 0,32, 4, 0 };

                byte[] P2_WirkleistungBezugObis         = new byte[] { 0,41, 4, 0 };
                byte[] P2_WirkleistungLieferungObis     = new byte[] { 0,42, 4, 0 };
                byte[] P2_StromObis                     = new byte[] { 0,51, 4, 0 };
                byte[] P2_SpannungObis                  = new byte[] { 0,52, 4, 0 };

                byte[] P3_WirkleistungBezugObis         = new byte[] { 0,61, 4, 0 };
                byte[] P3_WirkleistungLieferungObis     = new byte[] { 0,62, 4, 0 };
                byte[] P3_StromObis                     = new byte[] { 0,71, 4, 0 };
                byte[] P3_SpannungObis                  = new byte[] { 0,72, 4, 0 };

                int WirkleistungBezugIndex = 0;
                int WirkleistungLieferungIndex = 0;
                int WirkleistungBezugCounterIndex = 0;
                int WirkleistungLieferungCounterIndex = 0;
                int BlindleistungBezugIndex = 0;
                int BlindleistungLieferungIndex = 0;
                int ScheinleistungBezugIndex = 0;
                int ScheinleistungLieferungIndex = 0;
                int LeistungfaktorIndex = 0;
                int NetzfrequenzIndex = 0;

                int P1_WirkleistungBezugIndex = 0;
                int P1_WirkleistungLieferungIndex = 0;
                int P1_StromIndex = 0;
                int P1_SpannungIndex = 0;

                int P2_WirkleistungBezugIndex = 0;
                int P2_WirkleistungLieferungIndex = 0;
                int P2_StromIndex = 0;
                int P2_SpannungIndex = 0;

                int P3_WirkleistungBezugIndex = 0;
                int P3_WirkleistungLieferungIndex = 0;
                int P3_StromIndex = 0;
                int P3_SpannungIndex = 0;

                for (int s = 28; s < readobis.Length-4; s+=4)
                {
                    Array.Copy(readobis, s, obis, 0, 3);
                    if (obis.SequenceEqual(WirkleistungBezugObis)) { WirkleistungBezugIndex = s + 4; }
                    if (obis.SequenceEqual(WirkleistungLieferungObis)) { WirkleistungLieferungIndex = s + 4; }
                    if (obis.SequenceEqual(WirkleistungBezugCounterObis)) { WirkleistungBezugCounterIndex = s + 4; }
                    if (obis.SequenceEqual(WirkleistungLieferungCounterObis)) { WirkleistungLieferungCounterIndex = s + 4; }
                    if (obis.SequenceEqual(BlindleistungBezugObis)) { BlindleistungBezugIndex = s + 4; }
                    if (obis.SequenceEqual(BlindleistungLieferungObis)) { BlindleistungLieferungIndex = s + 4; }
                    if (obis.SequenceEqual(ScheinleistungBezugObis)) { ScheinleistungBezugIndex = s + 4; }
                    if (obis.SequenceEqual(ScheinleistungLieferungObis)) { ScheinleistungLieferungIndex = s + 4; }
                    if (obis.SequenceEqual(LeistungfaktorObis)) { LeistungfaktorIndex = s + 4; }
                    if (obis.SequenceEqual(NetzfrequenzObis)) { NetzfrequenzIndex = s + 4; }

                    if (obis.SequenceEqual(P1_WirkleistungBezugObis)) { P1_WirkleistungBezugIndex = s + 4; }
                    if (obis.SequenceEqual(P1_WirkleistungLieferungObis)) { P1_WirkleistungLieferungIndex = s + 4; }
                    if (obis.SequenceEqual(P1_StromObis)) { P1_StromIndex = s + 4; }
                    if (obis.SequenceEqual(P1_SpannungObis)) { P1_SpannungIndex = s + 4; }

                    if (obis.SequenceEqual(P2_WirkleistungBezugObis)) { P2_WirkleistungBezugIndex = s + 4; }
                    if (obis.SequenceEqual(P2_WirkleistungLieferungObis)) { P2_WirkleistungLieferungIndex = s + 4; }
                    if (obis.SequenceEqual(P2_StromObis)) { P2_StromIndex = s + 4; }
                    if (obis.SequenceEqual(P2_SpannungObis)) { P2_SpannungIndex = s + 4; }

                    if (obis.SequenceEqual(P3_WirkleistungBezugObis)) { P3_WirkleistungBezugIndex = s + 4; }
                    if (obis.SequenceEqual(P3_WirkleistungLieferungObis)) { P3_WirkleistungLieferungIndex = s + 4; }
                    if (obis.SequenceEqual(P3_StromObis)) { P3_StromIndex = s + 4; }
                    if (obis.SequenceEqual(P3_SpannungObis)) { P3_SpannungIndex = s + 4; }
                }

                while (!StopThread) {
					
					byte[] read = listener.Receive(ref groupEP);

                    txtStatus.Text=String.Format("Received broadcast from {0}",groupEP.ToString());
                    //txtStatus.Text = String.Format("{0}", String.Join(" ",read));
                    uint SerialNumber=ConvertRead(read,20,4);
					double WirkleistungBezugCounter     = Convert.ToDouble(ConvertRead64(read, WirkleistungBezugCounterIndex,     8) / 3600000.0); // Zähler Bezug
					double WirkleistungLieferungCounter = Convert.ToDouble(ConvertRead64(read, WirkleistungLieferungCounterIndex, 8) / 3600000.0); // Zähler Lieferung
                    float LeistungsfaktorWert           = Convert.ToSingle(ConvertRead  (read, LeistungfaktorIndex,               4) / 1000.0); // Leistungsfaktor
                    float NetzfrequenzWert              = Convert.ToSingle(ConvertRead  (read, NetzfrequenzIndex,                 4) / 1000.0); // Netzfrequenz

                    txtStatus.Text += Environment.NewLine + String.Format("Bezug    : {0:0,0.000} kWh",WirkleistungBezugCounter);
					txtStatus.Text += Environment.NewLine + String.Format("Lieferung: {0:0,0.000} kWh",WirkleistungLieferungCounter);
                    txtStatus.Text += Environment.NewLine + String.Format("Leistungsfaktor: {0:0.000} cos(\u03C6)", LeistungsfaktorWert);
                    txtStatus.Text += Environment.NewLine + String.Format("Netzfrequenz   : {0:0,0.000} Hz", NetzfrequenzWert);

                    float WirkleistungBezugWert        = Convert.ToSingle(ConvertRead(read, WirkleistungBezugIndex,        4)/10.0);   // Wirkleistung Bezug
					float WirkleistungLieferungWert    = Convert.ToSingle(ConvertRead(read, WirkleistungLieferungIndex,    4)/10.0);   // Wirkleistung Lieferung
                    float BlindleistungBezugWert       = Convert.ToSingle(ConvertRead(read, BlindleistungBezugIndex,       4)/10.0);   // Blindleistung Bezug
                    float BlindleistungLieferungWert   = Convert.ToSingle(ConvertRead(read, BlindleistungLieferungIndex,   4)/10.0);   // Blindleistung Lieferung
                    float ScheinleistungBezugWert      = Convert.ToSingle(ConvertRead(read, ScheinleistungBezugIndex,      4)/10.0);   // Scheinleistung Bezug
					float ScheinleistungLieferungWert  = Convert.ToSingle(ConvertRead(read, ScheinleistungLieferungIndex,  4)/10.0);   // Scheinleistung Lieferung
					
					float P1_WirkleistungBezugWert     = Convert.ToSingle(ConvertRead(read, P1_WirkleistungBezugIndex,     4)/10.0);   // Wirkleistung Bezug P1
					float P1_WirkleistungLieferungWert = Convert.ToSingle(ConvertRead(read, P1_WirkleistungLieferungIndex, 4)/10.0);   // Wirkleistung Lieferung P1
					float P1_StromWert                 = Convert.ToSingle(ConvertRead(read, P1_StromIndex,                 4)/1000.0); // Strom P1
					float P1_SpannungWert              = Convert.ToSingle(ConvertRead(read, P1_SpannungIndex,              4)/1000.0); // Spannung P1
					
					float P2_WirkleistungBezugWert     = Convert.ToSingle(ConvertRead(read, P2_WirkleistungBezugIndex,     4)/10.0);   // Wirkleistung Bezug P2
					float P2_WirkleistungLieferungWert = Convert.ToSingle(ConvertRead(read, P2_WirkleistungLieferungIndex, 4)/10.0);   // Wirkleistung Lieferung P2
					float P2_StromWert                 = Convert.ToSingle(ConvertRead(read, P2_StromIndex,                 4)/1000.0); // Strom P2
					float P2_SpannungWert              = Convert.ToSingle(ConvertRead(read, P2_SpannungIndex,              4)/1000.0); // Spannung P2
					
					float P3_WirkleistungBezugWert     = Convert.ToSingle(ConvertRead(read, P3_WirkleistungBezugIndex,     4)/10.0);   // Wirkleistung Bezug P3
					float P3_WirkleistungLieferungWert = Convert.ToSingle(ConvertRead(read, P3_WirkleistungLieferungIndex, 4)/10.0);   // Wirkleistung Lieferung P3
					float P3_StromWert                 = Convert.ToSingle(ConvertRead(read, P3_StromIndex,                 4)/1000.0); // Strom P3
					float P3_SpannungWert              = Convert.ToSingle(ConvertRead(read, P3_SpannungIndex,              4)/1000.0); // Spannung P3
					
					grpSumme.Text=String.Format("Summe Serial Number: {0}",SerialNumber);
					
					txtBezugWirkleistung.Text       = String.Format("{0:0}",WirkleistungBezugWert);
					txtLieferungWirkleistung.Text   = String.Format("{0:0}",WirkleistungLieferungWert);
					txtBezugScheinleistung.Text     = String.Format("{0:0}",ScheinleistungBezugWert);
					txtLieferungScheinleistung.Text = String.Format("{0:0}",ScheinleistungLieferungWert);
					txtBezugBlindleistung.Text      = String.Format("{0:0}",BlindleistungBezugWert);
					txtLieferungBlindleistung.Text  = String.Format("{0:0}",BlindleistungLieferungWert);
					
					txtBezugPhase1.Text             = String.Format("{0:0}",P1_WirkleistungBezugWert);
					txtLieferungPhase1.Text         = String.Format("{0:0}",P1_WirkleistungLieferungWert);
					txtStromPhase1.Text             = String.Format("{0:0.000}",P1_StromWert);
					txtSpannungPhase1.Text          = String.Format("{0:0.0}",P1_SpannungWert);
					
					txtBezugPhase2.Text             = String.Format("{0:0}",P2_WirkleistungBezugWert);
					txtLieferungPhase2.Text         = String.Format("{0:0}",P2_WirkleistungLieferungWert);
					txtStromPhase2.Text             = String.Format("{0:0.000}",P2_StromWert);
					txtSpannungPhase2.Text          = String.Format("{0:0.0}",P2_SpannungWert);

					txtBezugPhase3.Text             = String.Format("{0:0}",P3_WirkleistungBezugWert);
					txtLieferungPhase3.Text         = String.Format("{0:0}",P3_WirkleistungLieferungWert);
					txtStromPhase3.Text             = String.Format("{0:0.000}",P3_StromWert);
					txtSpannungPhase3.Text          = String.Format("{0:0.0}",P3_SpannungWert);

                    //if(gaugeLieferung.MaxValue<WirkleistungLieferungWert) gaugeLieferung.MaxValue=WirkleistungLieferungWert;
                    //if(gaugeBezug.MaxValue<WirkleistungBezugWert) gaugeBezug.MaxValue=WirkleistungBezugWert;
                    //gaugeLieferung.ScaleLinesMajorStepValue=gaugeLieferung.MaxValue/10;
                    //gaugeBezug.ScaleLinesMajorStepValue=gaugeBezug.MaxValue/10;
                    //gaugeLieferung.Value=WirkleistungLieferungWert;
                    //gaugeBezug.Value=WirkleistungBezugWert;

                    const int r = 500;
                    if ((-WirkleistungLieferungWert < GaugeSumme.MinValue) || (WirkleistungLieferungWert > GaugeSumme.MaxValue))
                    {
                        GaugeSumme.MinValue = -runden(WirkleistungLieferungWert,r);
                        GaugeSumme.MaxValue = runden(WirkleistungLieferungWert,r);
                    }
                    if ((-WirkleistungBezugWert < GaugeSumme.MinValue) || (WirkleistungBezugWert > GaugeSumme.MaxValue))
                    {
                        GaugeSumme.MinValue = -runden(WirkleistungBezugWert,r);
                        GaugeSumme.MaxValue = runden(WirkleistungBezugWert,r);
                    }

                    if (WirkleistungLieferungWert > 0) GaugeSumme.Value = -WirkleistungLieferungWert;
                    if (WirkleistungBezugWert > 0) GaugeSumme.Value = WirkleistungBezugWert;

                    GaugeSumme.ScaleLinesMajorStepValue = (-GaugeSumme.MinValue + GaugeSumme.MaxValue) / 10;

                    DateTime timeNow = DateTime.Now;
					
					chart.Series[ChartNamen[0]].Points.AddXY(timeNow,WirkleistungBezugWert-WirkleistungLieferungWert);
					//chart.Series[ChartNamen[1]].Points.AddXY(timeNow,ScheinleistungBezugWert-ScheinleistungLieferungWert);
					//chart.Series[ChartNamen[2]].Points.AddXY(timeNow,BlindleistungBezugWert-BlindleistungLieferungWert);
					chart.ChartAreas[0].AxisX.Maximum=DateTime.Now.ToOADate();
										
					if(comboBox.SelectedIndex==0) chart.ChartAreas[0].AxisX.Minimum=xaxismin.ToOADate();
					else if(TimeSpan.TryParse(comboBox.SelectedItem.ToString(),out ts))
						chart.ChartAreas[0].AxisX.Minimum=(DateTime.FromOADate(chart.ChartAreas[0].AxisX.Maximum)-ts).ToOADate();
					
					WriteLogFile(timeNow,WirkleistungBezugWert,ScheinleistungBezugWert,BlindleistungBezugWert,WirkleistungLieferungWert,ScheinleistungLieferungWert,BlindleistungLieferungWert);
				}
			listener.Close();
			}
			catch (Exception e) {
				txtStatus.Text="Error: "+e.ToString();
			}
		}
		
        int runden(float a,int r)
        {
            return (((int)a / r) + 1) * r;
        }

		void MainFormLoad(object sender, EventArgs e)
		{
			foreach(String ChartName in ChartNamen) {
				chart.Series.Add(ChartName);
				chart.Series[ChartName].ChartType = SeriesChartType.Line;
			
				chart.Series[ChartName].BorderWidth = 2;
				chart.Series[ChartName].ChartArea = "Area";
				chart.Series[ChartName].XValueType = ChartValueType.DateTime;
			}
			chart.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm";
			chart.ChartAreas[0].AxisX.Minimum=xaxismin.ToOADate();
			chart.ChartAreas[0].AxisX.Maximum=DateTime.Now.ToOADate();

			Control.CheckForIllegalCrossThreadCalls = false;
			Listener = new Thread(new ThreadStart(StartListener));
			Listener.Start();
			
			comboBox.SelectedIndex=0;
			
			if((String)ReadXML("Logging")=="on") logging=true;
			Networkcard=ReadXML("Network");
			
			WriteLogFile(DateTime.Now,-1,0,0,0,0,0);

            //Format Gauge
            int gx = GaugeSumme.Size.Width;
            int gy = GaugeSumme.Size.Height;
            int gm = (gx < gy ? gx : gy);

            GaugeSumme.BaseArcRadius =  (int)(gm / 2.4);
            GaugeSumme.ScaleLinesInterInnerRadius = (int)(gm / 2.6);
            GaugeSumme.ScaleLinesInterOuterRadius = (int)(gm / 2.2);
            GaugeSumme.ScaleLinesMajorInnerRadius = GaugeSumme.ScaleLinesInterInnerRadius;
            GaugeSumme.ScaleLinesMajorOuterRadius = (int)(gm / 2.4);
            GaugeSumme.ScaleLinesMinorInnerRadius = GaugeSumme.ScaleLinesInterInnerRadius;
            GaugeSumme.ScaleLinesMinorOuterRadius = GaugeSumme.ScaleLinesMajorOuterRadius;
            GaugeSumme.NeedleRadius = GaugeSumme.ScaleLinesMajorOuterRadius;
            GaugeSumme.ScaleNumbersRadius = (int)(gm / 2.1);

            AGaugeLabel L = new AGaugeLabel();
            AGaugeLabel B = new AGaugeLabel();
            L.Color = B.Color = System.Drawing.SystemColors.WindowText;
            L.Font = B.Font = new System.Drawing.Font("Verdana", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            L.Name = "LabelLieferung";
            B.Name = "LabelBezug";
            L.Position = new System.Drawing.Point(10, gy-30);
            B.Position = new System.Drawing.Point(gx - 80, gy-30);
            L.Text = "Lieferung W";
            B.Text = "Bezug W";

            GaugeSumme.GaugeLabels.Add(L);
            GaugeSumme.GaugeLabels.Add(B);
        }

        uint ConvertRead(byte[] source,int start,int length) {
			byte[] tmp = new byte[length];
			Buffer.BlockCopy(source,start,tmp,0,length);
			String s=BitConverter.ToString(tmp).Replace("-","");
			uint n=Convert.ToUInt32(s,16);
			return n;
		}
		
		ulong ConvertRead64(byte[] source,int start,int length) {
			byte[] tmp = new byte[length];
			Buffer.BlockCopy(source,start,tmp,0,length);
			String s=BitConverter.ToString(tmp).Replace("-","");
			ulong n=Convert.ToUInt64(s,16);
			return n;
		}
		
		void BtnEndeClick(object sender, EventArgs e)
		{
			StopThread=true;
			Listener.Join();
			csv.Close();
			Application.Exit();
		}
		
		static String ReadXML(String s) {
			XmlDocument doc = new XmlDocument();
			doc.Load("settings.xml");
			
			XmlNode Read = doc.DocumentElement.SelectSingleNode("/configuration/"+s);
			return Read.InnerText;
		}
		
		void WriteLogFile(DateTime now,float a,float b,float c,float d, float e,float f)
		{
			if(logging) {
				String Filename=DateTime.Now.ToShortDateString()+".csv";
				bool FileExists=File.Exists(Filename);
				csv = new StreamWriter(Filename,true);
				if(!FileExists) csv.WriteLine("Datum/Uhrzeit;WirkleisungBezug;ScheinleistungBezug;BlindleistungBezug;WirkleisungLieferung;ScheinleistungLieferung;BlindleistungLieferung");
				if(a>=0) csv.WriteLine(now.ToString()+";"+a+";"+b+";"+c+";"+d+";"+e+";"+f);
				csv.Close();
			}
		}
    }
}
