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
using System.IO;
using System.Security.Cryptography;

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
     void connecting(string log, string pass)
        {
            labelError.Text = "";
            string path = "info.ini";
                th = new Thread(delegate ()
                {
                    IPEndPoint ipEndPoint = new IPEndPoint(ip, port);
                    send = new Socket(ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                    try
                    {
                        // Соединяем сокет с удаленной точкой
                        send.Connect(ipEndPoint);
                        string message = "10" + log + "@" + pass;
                        byte[] msg = Encoding.UTF8.GetBytes(message);
                        // Отправляем данные через сокет
                        send.Send(msg);

                        // Получаем ответ от сервера
                        byte[] bytes = new byte[20];
                        send.Receive(bytes);
                        msgserv = Encoding.UTF8.GetString(bytes);

                        switch (msgserv.Substring(0, 2))
                        {
                            case "11":                              
                                this.Invoke((MethodInvoker)delegate ()
                                {
                                    game.Enabled = true;
                                    registration.Visible = false;
                                    go.Text = "Выйти";
                                    login.Visible = false;
                                    password.Visible = false;
                                    checkBoxlogin.Visible = false;
                                    label1.Visible = false;
                                    label2.Visible = false;
                                    ConnectUser.Text = "Добро пожаловать :" + log;
                                    ConnectUser.Visible = true;
                                });
                                break;
                            case "10":
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
                            this.Invoke((MethodInvoker)delegate ()
                            {
                                game.Enabled = false;
                                registration.Visible = true;
                                go.Text = "Войти";
                                login.Visible = true;
                                password.Visible = true;
                                checkBoxlogin.Visible = true;
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
        /////////////////

string GetHashString(string s)
{
            //переводим строку в байт-массим  
            byte[] bytes = Encoding.Unicode.GetBytes(s);
            //создаем объект для получения средст шифрования  
            MD5CryptoServiceProvider CSP = new MD5CryptoServiceProvider();
            //вычисляем хеш-представление в байтах  
            byte[] byteHash = CSP.ComputeHash(bytes);
            string hash = string.Empty;
            //формируем одну цельную строку из массива  
            foreach (byte b in byteHash)
                hash += string.Format("{0:x2}", b);
 return hash;
 }
        //connect to server
        private void go_Click(object sender, EventArgs e)
        {
            labelError.Text = "";
            string path = "info.ini";
            if (go.Text == "Войти")
            {
                if (checkBoxlogin.Checked)
                {
                    FileStream file = new FileStream(path, FileMode.Truncate);
                    StreamWriter fileinfo = new StreamWriter(file, Encoding.GetEncoding(1251));               
                    fileinfo.WriteLine(login.Text);
                    fileinfo.WriteLine(GetHashString(password.Text));
                    fileinfo.WriteLine("0101");
                    fileinfo.Close();
                }
                th = new Thread(delegate ()
                {
                    IPEndPoint ipEndPoint = new IPEndPoint(ip, port);
                    send = new Socket(ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                    try
                    {
                    // Соединяем сокет с удаленной точкой
                    send.Connect(ipEndPoint);
                    string message = "10" + login.Text + "@" + password.Text;
                    byte[] msg = Encoding.UTF8.GetBytes(message);
                    // Отправляем данные через сокет
                    send.Send(msg);

                    // Получаем ответ от сервера
                    byte[] bytes = new byte[20];
                    send.Receive(bytes);
                    msgserv = Encoding.UTF8.GetString(bytes);

                        switch (msgserv.Substring(0, 2))
                        {
                            case "11":
                                MessageBox.Show(msgserv);
                                this.Invoke((MethodInvoker)delegate ()
                                {
                                    game.Enabled = true;
                                    registration.Visible = false;
                                    go.Text = "Выйти";
                                    login.Visible = false;
                                    password.Visible = false;
                                    checkBoxlogin.Visible = false;
                                    label1.Visible = false;
                                    label2.Visible = false;
                                    ConnectUser.Text = "Добро пожаловать :" + login.Text;
                                    ConnectUser.Visible = true;
                                });
                                break;
                            case "10":
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
                        MessageBox.Show(ex.ToString());
                        if (Application.OpenForms["Launcher"] != null)// form is runing
                        {
                            this.Invoke((MethodInvoker)delegate ()
                            {
                                game.Enabled = false;
                                registration.Visible = true;
                                go.Text = "Войти";
                                login.Visible = true;
                                password.Visible = true;
                                checkBoxlogin.Visible = true;
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
                checkBoxlogin.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                ConnectUser.Visible = false;
                FileStream file = new FileStream(path, FileMode.Truncate);
                StreamWriter fileinfo = new StreamWriter(file, Encoding.GetEncoding(1251));
                fileinfo.Close();
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
            System.Diagnostics.Process.Start("game.exe",msgserv.Substring(3));
            if (th != null) th.Abort();
            Application.Exit();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            if (th != null) th.Abort();
            Application.Exit();
        }

        private void Launcher_Load(object sender, EventArgs e)
        {
            string[] Mass = File.ReadAllLines("info.ini", Encoding.GetEncoding(1251));
            if (Mass[2] == "0101")
            {      
              checkBoxlogin.Checked = true;
              connecting(Mass[0],Mass[1]);
            }
           // login.Text = Mass[0];
           // password.Text = Mass[1];
        }
    }
}
