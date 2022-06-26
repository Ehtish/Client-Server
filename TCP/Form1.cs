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

namespace TCP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SimpleTcpServer server;
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Focus();
            server = new SimpleTcpServer();
            server.Delimiter = 0x13; //Enter
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
        }
        
        //for receiving data from client side
        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            status_txt.Invoke((MethodInvoker)delegate()
            {
                status_txt.Text += textBox1.Text;
                if (textBox1.Text !="")
                {
                    //e.ReplyLine(string.Format("\nYou said {0}\n", e.MessageString));
                    e.ReplyLine(string.Format("\nYou said {0}\n", e.MessageString));
                }
                
            });
        }

        //it is used to start a server
        private void start_btn_Click(object sender, EventArgs e)
        {
            status_txt.Text += "Server Starting....\n";
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(host_txt.Text);
            server.Start(ip, Convert.ToInt32(port_txt.Text));
        }

        //it is used to stop a server
        private void stop_btn_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
            {
                server.Stop();
                status_txt.Clear();
            }
        }
       
        //Closed the application
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
