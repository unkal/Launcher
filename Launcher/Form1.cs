using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace Launcher
{
    public partial class Launcher : Form
    {
        static private Socket send;
        Thread th;
        private IPAddress ip = IPAddress.Parse("192.168.0.84");
        private int port = 1234;
        string msgserv;
        public Launcher()
        {
            InitializeComponent();          
        }
     
        //connect to server
        private void go_Click(object sender, EventArgs e)
        {
            labelError.Text = "";
            if (go.Text == "Войти")
            {
                th = new Thread(delegate ()
                {
                    IPEndPoint ipEndPoint = new IPEndPoint(ip, port);
                    send = new Socket(ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                    try
                    {
                    // Соединяем сокет с удаленной точкой
                    send.Connect(ipEndPoint);
                    string message = "1000" + login.Text + "@" + password.Text;
                    // message = "ХУЙПИЗДАДЖИГУРДА!!!!";
                    byte[] msg = Encoding.UTF8.GetBytes(message);
                    // Отправляем данные через сокет
                    send.Send(msg);

                    // Получаем ответ от сервера
                    byte[] bytes = new byte[20];
                    send.Receive(bytes);
                    msgserv = Encoding.UTF8.GetString(bytes);

                        switch (msgserv.Substring(0, 4))
                        {
                            case "1001":
                                MessageBox.Show(msgserv);
                                this.Invoke((MethodInvoker)delegate ()
                                {
                                    game.Enabled = true;
                                    registration.Visible = false;
                                    go.Text = "Выйти";
                                    login.Visible = false;
                                    password.Visible = false;
                                    label1.Visible = false;
                                    label2.Visible = false;
                                    ConnectUser.Text = "Добро пожаловать :" + login.Text;
                                    ConnectUser.Visible = true;
                                });
                                break;
                            case "1000":
                                this.Invoke((MethodInvoker)delegate ()
                                {
                                    labelError.Text = "Неверный логин или пароль";
                                });
                                break;
                        }
                    // Освобождаем сокет
                    send.Shutdown(SocketShutdown.Both);
                        send.Close();
                    }
                    catch (Exception ex)
                    {
                        if (Application.OpenForms["Launcher"] != null)// form is runing
                        {
                            MessageBox.Show(ex.ToString());
                            this.Invoke((MethodInvoker)delegate ()
                            {
                                game.Enabled = false;
                                registration.Visible = true;
                                go.Text = "Войти";
                                login.Visible = true;
                                password.Visible = true;
                                label1.Visible = true;
                                label2.Visible = true;
                                ConnectUser.Visible = false;
                            });
                        }
                        else
                        {
                            System.Diagnostics.Process.GetCurrentProcess().Kill();
                        }

                    }
                });
                th.Start();
            }
            else if (go.Text=="Выйти")
                {
                game.Enabled = false;
                registration.Visible = true;
                go.Text = "Войти";
                login.Visible = true;
                password.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                ConnectUser.Visible = false;
            }
        }
        //register web 
        private void registration_Click(object sender, EventArgs e)
        {           
            System.Diagnostics.Process.Start("http://google.com");

        }
        //off
        private void Launcher_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (th != null) th.Abort();
            Application.Exit();
        }
        // start game 
        private void game_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("game.exe",msgserv.Substring(5));
            if (th != null) th.Abort();
            Application.Exit();
        }
    }
}
