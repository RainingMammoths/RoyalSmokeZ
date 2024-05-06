using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using System.Net;

namespace RoyalSmokeZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            isDone = false;
        }

        private bool isDone;

        string n;
        byte[] b1;
        OpenFileDialog op;
        List<User> users = new List<User>();

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = users;
            //dataGridView1.Columns.Add("")
            int startin = 60 - DateTime.Now.Second;
            var t = new System.Threading.Timer(
                o => Console.WriteLine("Hello"),
                 null, startin * 1000, 60000);
        }

        private void CheckWithHost()
        {
            TcpClient client = new TcpClient("SwtRascal", 5055);
            StreamWriter sw = new StreamWriter(client.GetStream());
            sw.WriteLine(n);
            sw.Flush();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                //string t = textBox1.Text;
                //t = op.FileName;
                //FileInfo fi = new FileInfo(textBox1.Text = op.FileName);
                //n = fi.Name + "." + fi.Length;
                TcpClient client = new TcpClient("SwtRascal", 5055);
                StreamWriter sw = new StreamWriter(client.GetStream());
                sw.WriteLine(n);
                sw.Flush();
                //label1.Text = "File Transferred....";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //TcpClient client = new TcpClient("SwtRascal", 5050);
            //Stream s = client.GetStream();
            //b1 = File.ReadAllBytes(op.FileName);
            //s.Write(b1, 0, b1.Length);
            //client.Close();
            //label1.Text = "File Transferred....";

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
