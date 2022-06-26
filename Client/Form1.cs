using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SimpleTcpClient Client;

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Focus();
            Client = new SimpleTcpClient();
            Client.StringEncoder = Encoding.UTF8;
            Client.DataReceived += Client_DataReceived;
        }
       
        //For receiving data from client
        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            status_txt.Invoke((MethodInvoker)delegate()
            {
                status_txt.Text += e.MessageString;
            });
        }
       
        //event used to connect with server
        private void connection_btn_Click(object sender, EventArgs e)
        {
            try
            {
                connection_btn.Enabled = false;
                Client.Connect(host_txt.Text, Convert.ToInt32(port_txt.Text));
            }
            catch
            {
                MessageBox.Show("Connection error !!!");
                connection_btn.Enabled = true;                
            }

        }
 
        
        //Send and received reply from server in 5 seconds
        private void send_btn_Click(object sender, EventArgs e)
        {
            Client.WriteLineAndGetReply(message_txt.Text, TimeSpan.FromSeconds(3));
            
        }

        //application exit
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

