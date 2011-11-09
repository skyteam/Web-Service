using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Diagnostics;
using Service;
namespace FormHost
{
    public partial class FormHost : Form
    {
        ServiceHost Host;
        public FormHost()
        {
            InitializeComponent();
            ShowNOKInfo();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!cbBSHTTP.Checked && !cbMEX.Checked && !cbTCPNET.Checked && !cbWSHTTP.Checked)
            {
                MessageBox.Show("Please chose at least one type of binding");
                return;
            }
            try
            {
                string BaseAddress = txtBaseAddress.Text.Trim();

                Type ContractType = typeof(IBService);
                Type InstanceType = typeof(BService);

                Host = new ServiceHost(InstanceType);

                ServiceMetadataBehavior Behavior = new ServiceMetadataBehavior();
                Behavior.HttpGetEnabled = true;
                Behavior.HttpGetUrl = new Uri(BaseAddress);
                Host.Description.Behaviors.Add(Behavior);

                string Address = "";
                if (cbMEX.Checked)
                {
                    Address = BaseAddress + "/MEX";
                    Host.AddServiceEndpoint(typeof(IMetadataExchange), new BasicHttpBinding(), Address);
                    txtStatus.AppendText("MEX enpoint created\n\n");
                }
                if (cbBSHTTP.Checked)
                {
                    Address = BaseAddress + "/BSHTTP";
                    Host.AddServiceEndpoint(ContractType, new BasicHttpBinding(), Address);
                    txtStatus.AppendText("Basic HTTP enpoint created\n\n");
                }
                if (cbWSHTTP.Checked)
                {
                    Address = BaseAddress + "/WSHTTP";
                    Host.AddServiceEndpoint(ContractType, new WSHttpBinding(), Address);
                    txtStatus.AppendText("WS HTTP enpoint created\n\n");
                }
                if(cbTCPNET.Checked)
                {
                    Address = "net.tcp://localhost:9000/TCPNET";
                    Host.AddServiceEndpoint(ContractType, new NetTcpBinding(), Address);
                    txtStatus.AppendText("TCPNET enpoint created\nThe address is\n" + Address + "\n\n");
                }

                Host.Open();
                txtStatus.AppendText("Service is hosted\n");
                ShowOKInfo();
            }
            catch
            {
                MessageBox.Show("Not Successed");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Host.Close();
            ShowNOKInfo();
            Host = null;
            txtStatus.AppendText("Service is destroyed\n");
        }
        private void ShowNOKInfo()
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            lbStatus.Text = "SERVICE IS NOT HOSTED";
            lbStatus.ForeColor = Color.Red;
        }
        private void ShowOKInfo()
        {
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            lbStatus.Text = "SERVICE IS HOSTED";
            lbStatus.ForeColor = Color.Green;
        }
    }
}
