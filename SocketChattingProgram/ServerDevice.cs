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
    public partial class ServerDevice : Form
    {
        private int port = 8085;
        private TcpListener Server; // 소켓 서버
        private TcpClient Client; // 클라이언트
        private StreamReader Reader;
        private StreamWriter Writer;
        private NetworkStream stream; // 네트워크 스트림 연결
        private Thread ReceiveThread;
        private bool Connected;
        private delegate void AddTextDelegate(string strText); // 크로스 쓰레드 호출

        public ServerDevice()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        private void Label3_Click(object sender, EventArgs e)
        {

        }


        private void ServerDevice_Load(object sender, EventArgs e) // 서버창 열었을 때
        {
            Thread ListenThread = new Thread(new ThreadStart(Listen)); // 서버 시작
            ListenThread.Start();
        }

        private void SetEnter_Click(object sender, EventArgs e) // 서버 시작버튼
        {
            SerChatting.AppendText("Me : " + SerMessage.Text + "\r\n"); // 화면에 출력
            Writer.WriteLine(SerMessage.Text); // 보내버리기
            Writer.Flush();
            SerMessage.Clear();
        }

        private void ServerDevice_FormClosing(object sender, FormClosingEventArgs e) // 서버창 닫았을 때
        {
            Connected = false;
            if (Reader != null) Reader.Close();
            if (Writer != null) Writer.Close();
            if (Server != null) Server.Stop();
            if (Client != null) Client.Close();
            if (ReceiveThread != null) ReceiveThread.Abort(); // 사용한 객체를 모두 닫아준다

        }

        private void Listen() // 클라이언트와 연결하기
        {
            AddTextDelegate AddText = new AddTextDelegate(SerChatting.AppendText);
            IPAddress addr = new IPAddress(0); // 서버 ip
            Server = new TcpListener(addr, port);
            Server.Start(); // 서버 시작
            SerChatting.AppendText("서버 연결 성공!" + "\n" + addr);
            Client = Server.AcceptTcpClient(); // 클라이언트 연결 수락
            Connected = true;
            Invoke(AddText, "Connected to Client!" + "\r\n");
            stream = Client.GetStream(); // 클라이언트 스트림 값 받아오기
            Reader = new StreamReader(stream);
            Writer = new StreamWriter(stream);
            ReceiveThread = new Thread(new ThreadStart(Receive)); // 값을 받기 위한 쓰레드
            ReceiveThread.Start();

        }

        private void Receive() // 클라이언트에게 받기
        {
            AddTextDelegate AddText = new AddTextDelegate(SerChatting.AppendText);
            while (Connected)
            {
                Thread.Sleep(1);
                if (stream.CanRead) // 받아온 데이터가 있다면 출력
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
