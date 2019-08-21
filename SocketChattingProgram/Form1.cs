using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SocketChattingProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Serverbtn_Click(object sender, EventArgs e)
        {
            ServerDevice sd = new ServerDevice();
            sd.Show();
        }

        private void Clientbtn_Click(object sender, EventArgs e)
        {
            ClientDevice cd = new ClientDevice();
            cd.Show();
        }
    }
}
