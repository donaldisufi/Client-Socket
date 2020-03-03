using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace KlientiRii
{
    public partial class Form1 : Form
    {
	
		TcpListener Listener;
		TcpClient klienti;
		IPEndPoint ipe;
		NetworkStream ns;
		
		public Form1()
        {
            InitializeComponent();
		}

		private async void btnConect_Click(object sender, EventArgs e)
		{
		
		}
			
		private bool isANumber(string str)
		{
			try
			{
				int.Parse(str);
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
		
		private bool isIP(string IP)
		{
			try
			{
				IPAddress.Parse(IP);
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}


		private async void btnStart_Click(object sender, EventArgs e)
        {

			if (isANumber(txtPort.Text) && isIP(txtIP.Text))
			{
				if (txtMesazhi.Text.Length >= 1)
				{
					try
					{
						klienti = new TcpClient();
						ipe = new IPEndPoint(IPAddress.Parse(txtIP.Text), int.Parse(txtPort.Text));
						klienti.Connect(ipe);
						ns = klienti.GetStream();
						byte[] buffer;
						byte[] bufferPranues = new byte[1024];

						string mesazhi = txtMesazhi.Text;
						buffer = ASCIIEncoding.ASCII.GetBytes(mesazhi);

						ns.Write(buffer, 0, mesazhi.Length);
						txtMesazhetServeri.AppendText("Derguar serverit:" + mesazhi + "\r\n");
						Application.DoEvents();
						while (true)
						{

							int bajtaPranuar = await ns.ReadAsync(bufferPranues, 0, 1024);
							byte[] madhMes = new byte[4];
							byte[] mesazhiPr = new byte[bajtaPranuar - 4];
							Buffer.BlockCopy(bufferPranues, 0, madhMes, 0, 4);
							int msgSize = BitConverter.ToInt32(madhMes, 0);
							Buffer.BlockCopy(bufferPranues, 4, mesazhiPr, 0, msgSize);
							string msgText = ASCIIEncoding.ASCII.GetString(mesazhiPr);
							txtMesazhetServeri.AppendText("Serveri : " + msgText + "\n");
							Application.DoEvents();
						}

					}
					catch (Exception ex)
					{
						MessageBox.Show("Coudln't connect with server !!");
					}
				}else
				{
					MessageBox.Show("Ju lutem shkruani nje mesazh per te derguar!");
				}
			} else
			{
				MessageBox.Show("IP ose porti nuk eshte ne formatin e duhur!");
			}

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(klienti != null)
			{

			   OpenFileDialog obj = new OpenFileDialog();
				if(obj.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{
					try
					{
						klienti = new TcpClient();
						ipe = new IPEndPoint(IPAddress.Parse(txtIP.Text), int.Parse(txtPort.Text));
						klienti.Connect(ipe);
						ns = klienti.GetStream();

						var bytes = File.ReadAllBytes(obj.FileName);
						ns.Write(bytes, 0, bytes.Length);
						txtMesazhetServeri.AppendText("Fajlli ju dergua serverit:" + obj.FileName + "\r\n");

					}
					catch (Exception ex)
					{
					MessageBox.Show("Shkruani ip dhe portin e sakte te serverit .");
					}
				}
			}else
			{
				MessageBox.Show("Shkruani ip dhe portin e sakte te serverit .");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if(klienti != null)
			{
				klienti.Close();
				MessageBox.Show("Lidhja u ckyq");
			}else
			{
				MessageBox.Show("Nuk jeni i lidhur me asnje server");
			}
		}
	}
}
