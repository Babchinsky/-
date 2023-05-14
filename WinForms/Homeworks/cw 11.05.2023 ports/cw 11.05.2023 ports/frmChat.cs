using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace cw_11._05._2023_ports
{
    public partial class frmChat : Form
    {
        //переменные, необходимые для настройки
        //подключения:
        //удаленный хост и порты - удаленный и локальный
        static int RemotePort;
        static int LocalPort;
        static IPAddress RemoteIPAddr;


        public frmChat (IPAddress remoteIPAddr, int localPort, int remotePort)
        {
            InitializeComponent();
            
             RemoteIPAddr = remoteIPAddr;
             LocalPort = localPort;
             RemotePort = remotePort;

            txtHistory.Text += Convert.ToString(RemoteIPAddr) + " " + Convert.ToString(LocalPort) + " " + Convert.ToString(RemotePort);
        }

        void ThreadFuncReceive()
        {
            try
            {
                while (true)
                {
                    //connection to the local host
                    UdpClient uClient = new UdpClient(LocalPort);
                    IPEndPoint ipEnd = null;
                    //receiving datagramm
                    byte[] responce = uClient.Receive(ref ipEnd);
                    //conversion to a string
                    string strResult = Encoding.Unicode.GetString(responce);
                    //txtHistory.ForeColor = Color.Green;
                    //output to the screen
                    //Console.WriteLine(strResult);
                    txtHistory.Text = strResult;
                    //txtHistory.ForeColor = Color.Red;
                    uClient.Close();
                }
            }
            catch (SocketException sockEx)
            {
                MessageBox.Show(String.Format("Socket exception: " + sockEx.Message));
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Exception : " + ex.Message));
            }
        }

        static void SendData(string datagramm)
        {
            UdpClient uClient = new UdpClient();
            //connecting to a remote host
            IPEndPoint ipEnd = new IPEndPoint(RemoteIPAddr, RemotePort);
            try
            {
                byte[] bytes = Encoding.Unicode.GetBytes(datagramm);
                uClient.Send(bytes, bytes.Length, ipEnd);
            }
            catch (SocketException sockEx)
            {
                MessageBox.Show(String.Format("Socket exception: " + sockEx.Message));
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Exception : " + ex.Message));
            }
            finally
            {
                //close the UdpClient class instance
                uClient.Close();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                //отдельный поток для чтения в методе
                //ThreadFuncReceive
                //этот метод вызывает метод Receive()
                //класса UdpClient,
                //который блокирует текущий поток, поэтому
                //необходим отдельный поток
                Thread thread = new Thread(
                       new ThreadStart(ThreadFuncReceive)
                );
                //create a background thread
                thread.IsBackground = true;
                //start the thread
                thread.Start();
                //txtNewMessage.ForeColor = Color.Red;
                while (true)
                {
                    SendData(txtNewMessage.Text);
                }
            }
            catch (FormatException formExc)
            {
                MessageBox.Show(String.Format("Conversion impossible :" + formExc));
            }
            catch (Exception exc)
            {
                MessageBox.Show(String.Format("Exception : " + exc.Message));
            }
        }
    }
}
