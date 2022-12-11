﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;

namespace TeknikServis.Formlar
{
    public partial class FrmQRCode : Form
    {
        public FrmQRCode()
        {
            InitializeComponent();
        }

        private void FrmQRCode_Load(object sender, EventArgs e)
        {
        }

        private void BtnQROlustur_Click(object sender, EventArgs e)
        {
            QRCodeEncoder enc = new QRCodeEncoder();
            pictureEdit1.Image = enc.Encode(TxtSeriNo.Text);
        }
    }
}
