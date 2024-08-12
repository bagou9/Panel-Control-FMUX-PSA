using System;
using System.Reflection;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.IO.Ports;
using System.Collections;
using System.Net;
using System.Text;


namespace FMUX_arduino_CAN_Serial
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		SerialPort _serialPort;
		string COM_port = "";
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			foreach (string com in System.IO.Ports.SerialPort.GetPortNames())
			{
				comboBoxCom.Items.Add(com);
			}
			comboBoxCom.SelectedIndex = comboBoxCom.Items.Count - 1;
			
			if (comboBoxCom.Items.Count == 0)
			{
				MessageBox.Show(this, "Error: No COM port detected, please ensure the Arduino is plugged in",  "Error");
				buttonSerial.Enabled = false;
			}
		}
		void ButtonSerialClick(object sender, EventArgs e)
		{
			COM_port = comboBoxCom.SelectedItem.ToString();
			
			if (buttonSerial.Text == "Arduino Connect")
			{
				_serialPort = new SerialPort(COM_port, 115200, Parity.None, 8, StopBits.One);
				_serialPort.Handshake = Handshake.None;
				_serialPort.ReadTimeout = 5000;
				_serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialReceive); 
				
				try {
					_serialPort.Open();
					if ( _serialPort.IsOpen)
					{
						buttonSerial.Text = "Arduino Disconnect";
					}
					else
						MessageBox.Show(this, "Error: COM Port could not be opened",  "Error",  MessageBoxButtons.OK);
					
				} catch(Exception err) {
					MessageBox.Show(this, "Error: COM port " + err.Message, "Error",  MessageBoxButtons.OK);
				}
			}
			else
			{
				if (_serialPort != null)
				{
					if (_serialPort.IsOpen)
					{
						_serialPort.Close();
						buttonSerial.Text = "Arduino Connect";
					}
				}
			}
		}
		
		void SerialSend(string cmd) 
		{
			try {
				_serialPort.WriteLine(cmd);
			} catch (InvalidOperationException exception) {
				MessageBox.Show(this, "Error: Serial port is not accessible",  "Error");
				Application.Exit();
			}
		}
		
		void SerialReceive(object sender, SerialDataReceivedEventArgs e)
		{
			string text = _serialPort.ReadLine();
		}
		void ButtonEjectClick(object sender, EventArgs e)
		{
			string val = ((Button)sender).Tag.ToString();
			SerialSend(val);
		}
		void VolmoinsClick(object sender, EventArgs e)
		{
			SerialSend("v-");
		}
		void VolplusClick(object sender, EventArgs e)
		{
			SerialSend("v+");
		}
	}
}
