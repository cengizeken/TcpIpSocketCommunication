﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcpIpSocketCommunication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Client.SendString("Test data from client");
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Connector tpp = new Connector();
            tpp.TryToConnect();
        }

        
    }
}
