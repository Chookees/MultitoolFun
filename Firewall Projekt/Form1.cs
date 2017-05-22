#region Using's
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.Diagnostics;
using System.Net.Sockets;
using System.IO;
using System.Data.OleDb;
#endregion

namespace Firewall_Projekt
{
    public partial class Form1 : Form
    {
        Process winpcap;
        Process Wireshark;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Environment.Is64BitOperatingSystem)
            {

            }

            else
            {
                MessageBox.Show("Sie haben kein 64Bit Betriebssystem. Bitte Downloaden Sie Wireshark 32Bit um die Internet Kommunikation anzeigen lassen zu können.\nDer Download Link wurde in ihren Zwischenspeicher kopiert.", "Achtung");
                System.Windows.Forms.Clipboard.SetDataObject("https://www.wireshark.org/#download", true);
            }
        }

        private void interneUndExterneIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxStream.Items.Add("Lade IP-Adresse... " + Convert.ToString(DateTime.Now.ToLongTimeString()));
            string sHostName = Dns.GetHostName();
            var vHost = Dns.GetHostEntry(Dns.GetHostName());
            listBoxStream.Items.Add("Gebe IP-Adresse(n) aus. " + Convert.ToString(DateTime.Now.ToLongTimeString()));

            foreach (var ip in vHost.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    listBoxStream.Items.Add("IP Adresse: " + ip + "     Host Name/PC Name: " + sHostName);
                }
            }

            listBoxStream.Items.Add("Suche Öffentliche IP. Bitte warten... " + Convert.ToString(DateTime.Now.ToLongTimeString()));
            Thread.Sleep(500);
            GetMyInternetIpAddress();
        }

        private void zeigeInternetKommunikationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxStream.Items.Add("Starte Winpcap.exe... " + Convert.ToString(DateTime.Now.ToLongTimeString()));
            Directory.SetCurrentDirectory(@"..\");
            String sDir = Directory.GetCurrentDirectory();
            winpcap = Process.Start("debug\\WinPcap.exe");

            try
            {
                do
                {
                    Thread.Sleep(3000);
                    listBoxStream.Items.Add("Warte auf Beenden von WinPcap.exe... " + Convert.ToString(DateTime.Now.ToLongTimeString()));
                } while (!winpcap.HasExited);

                listBoxStream.Items.Add("WinPcap.exe wurde beendet, starte Wireshark.exe " + Convert.ToString(DateTime.Now.ToLongTimeString()));
                Wireshark = Process.Start("Wireshark\\Wireshark.exe");

                do
                {

                } while (!Wireshark.HasExited);

                listBoxStream.Items.Add("Wireshark.exe wurde beendet." + Convert.ToString(DateTime.Now.ToLongTimeString()));
                listBoxStream.Items.Add("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listBoxStream.Items.Add("Fehler aufgetreten. Wurde nicht ordnungsgemäß beendet. " + Convert.ToString(DateTime.Now.ToLongTimeString()));
                listBoxStream.Items.Add("");
            }
        }

        private void pingPongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process Pong;
            listBoxStream.Items.Add("Starte PingPong by Artur... " + Convert.ToString(DateTime.Now.ToLongTimeString()));
            Pong = Process.Start("PingPongbyArtur.exe");

            do
            {

            } while (!Pong.HasExited);

            listBoxStream.Items.Add("PingPong by Artur wurde beendet." + Convert.ToString(DateTime.Now.ToLongTimeString()));
        }

        private void tABSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Directory.SetCurrentDirectory(@"..\");
            Process TABS;
            listBoxStream.Items.Add("Starte T.A.B.S ... " + Convert.ToString(DateTime.Now.ToLongTimeString()));
            TABS = Process.Start("TotallyAccurateBattleSimulator.exe");

            do
            {

            } while (!TABS.HasExited);

            listBoxStream.Items.Add("T.A.B.S wurde beendet." + Convert.ToString(DateTime.Now.ToLongTimeString()));
            listBoxStream.Items.Add("");
        }

        private void schnellesBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process AutoUSB;
            listBoxStream.Items.Add("Starte Schnell USB Backup ... " + Convert.ToString(DateTime.Now.ToLongTimeString()));
            AutoUSB = Process.Start("AutoBackup.exe");

            do
            {

            } while (!AutoUSB.HasExited);

            listBoxStream.Items.Add("Schnell USB Backup wurde beendet." + Convert.ToString(DateTime.Now.ToLongTimeString()));
            listBoxStream.Items.Add("");
        }

        private void detailBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {     
            Process USB;
            listBoxStream.Items.Add("Starte Backup Programm Made by Artur und Marvin... " + Convert.ToString(DateTime.Now.ToLongTimeString()));
            USB = Process.Start("USB.exe");

            do
            {

            } while (!USB.HasExited);

            listBoxStream.Items.Add("Backup Programm Made by Artur und Marvin wurde beendet." + Convert.ToString(DateTime.Now.ToLongTimeString()));
            listBoxStream.Items.Add("");
        }

        private void cS16ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process CS;
            listBoxStream.Items.Add("Starte Counter Strike 1.6 ... " + Convert.ToString(DateTime.Now.ToLongTimeString()));
            CS = Process.Start("CounterStrike.exe");

            do
            {

            } while (!CS.HasExited);

            listBoxStream.Items.Add("Counter Strike 1.6 wurde beendet." + Convert.ToString(DateTime.Now.ToLongTimeString()));
            listBoxStream.Items.Add("");
        }

        #region IP Adresse ausserhalb bekommen
        public IPAddress GetMyInternetIpAddress()
        {
            WebRequest hwr = HttpWebRequest.Create(new Uri("http://checkip.dyndns.org"));
            WebResponse wr;
            Stream stream;
            StreamReader streamReader;
            string htmlResult;
            string[] htmlSplit;
            string IP;

            try
            {
                wr = hwr.GetResponse();
                stream = wr.GetResponseStream();
                streamReader = new StreamReader(stream, Encoding.UTF8);
                htmlResult = streamReader.ReadToEnd();
                htmlSplit = htmlResult.Split(new string[] { ":", "<" }, StringSplitOptions.RemoveEmptyEntries);
                IP = htmlSplit[6].Trim();
                stream.Close();
                wr.Close();
                listBoxStream.Items.Add("IP gefunden... " + Convert.ToString(DateTime.Now.ToLongTimeString()));
                listBoxStream.Items.Add("Öffentliche IP: " + IP);
                listBoxStream.Items.Add("");
                return IPAddress.Parse(IP);
            }
            catch (Exception ex)
            {
                if (MessageBox.Show(ex.Message, "Fehler!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation) == DialogResult.Retry)
                {
                    listBoxStream.Items.Clear();
                    listBoxStream.Items.Add("Versuche erneute Verbindung..." + Convert.ToString(DateTime.Now.ToLongTimeString()));
                    GetMyInternetIpAddress();
                }
                else
                {
                    listBoxStream.Items.Add("Fehler aufgetreten..." + Convert.ToString(DateTime.Now.ToLongTimeString()));
                    listBoxStream.Items.Add("Operation abgebrochen..." + Convert.ToString(DateTime.Now.ToLongTimeString()));
                    listBoxStream.Items.Add("");
                }
                return IPAddress.Parse(IP = "111.111.111.111");
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            listBoxStream.Items.Clear();
        }
        #endregion

    }
}
