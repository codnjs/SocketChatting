using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SocketChattingProgram
{
    public partial class ClientDevice : Form
    {
        TcpListener Server;
        TcpClient Client;
        StreamReader Reader;
        StreamWriter Writer;
        NetworkStream stream;
        Thread ReceiveThread;
        bool Connected;

        private delegate void AddTextDelegate(string strText);

        public ClientDevice()
        {
            InitializeComponent();
        }

        private void ClientDevice_Load(object sender, EventArgs e)
        {
            String IP = "10.96.124.194"; // 접속 할 서버 아이피를 입력
            int port = 8080; // 포트
            Client = new TcpClient();
            Client.Connect(IP, port);
            stream = Client.GetStream();
            Connected = true;
            CliChatting.AppendText("Connected to Server!" + "\r\n");
            Reader = new StreamReader(stream);
            Writer = new StreamWriter(stream);
            ReceiveThread = new Thread(new ThreadStart(Receive));
            ReceiveThread.Start();
        }

        private void ClientDevice_FormClosing(object sender, FormClosingEventArgs e)
        {
            Connected = false;
            if (Reader != null) Reader.Close();
            if (Writer != null) Writer.Close();
            if (Server != null) Server.Stop();
            if (Client != null) Client.Close();
            if (ReceiveThread != null) ReceiveThread.Abort();
        }

        private void CliSend_Click(object sender, EventArgs e)
        {
            CliChatting.AppendText("Me : " + CliMessage.Text + "\r\n");
            Writer.WriteLine(CliMessage.Text); // 보내버리기
            Writer.Flush();
            CliMessage.Clear();
        }

        private void Receive() // 서버로 부터 값 받아오기
        {
            AddTextDelegate AddText = new AddTextDelegate(CliChatting.AppendText);
            while (Connected)
            {
                Thread.Sleep(1);
                if (stream.CanRead)
                {
                    string tempStr = Reader.ReadLine();
                    if (tempStr.Length > 0)
                    {
                        Invoke(AddText, "You : " + tempStr + "\r\n");
                    }
                }
            }
        }        
    }
}
