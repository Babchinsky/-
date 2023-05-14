using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace cw_11._05._2023_ports
{
    public partial class frmSettings : Form
    {
        static int RemotePort;          //переменные, необходимые для настройки
        static int LocalPort;           //подключения:
        static IPAddress RemoteIPAddr;  //удаленный хост и порты - удаленный и локальный


        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtIP.Text != "" && txtLocalPort.Text != "" && txtRemotePort.Text != "" )
            {
                RemoteIPAddr = IPAddress.Parse(txtIP.Text);
                LocalPort = Convert.ToInt32(txtLocalPort.Text);
                RemotePort = Convert.ToInt32(txtRemotePort.Text);

                new frmChat(RemoteIPAddr, LocalPort, RemotePort).Show();
                this.Hide();                
            }
            else
            {
                MessageBox.Show("The fields are empty", "Settings Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
