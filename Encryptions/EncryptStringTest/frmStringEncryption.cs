﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptStringTest
{
    public partial class frmStringEncryption : Form
    {
        public frmStringEncryption()
        {
            InitializeComponent();
        }

        private void butEncrypt_Click(object sender, EventArgs e)
        {
            textBoxEncrypted.Text = Encrypt.EncryptString(textBoxString.Text, textBoxPassword.Text);
                
          
        }

        private void butDecrypt_Click(object sender, EventArgs e)
        {

            textBoxEncrypted.Text = Encrypt.DecryptString(textBoxEncrypted.Text, textBoxPassword.Text);
              
               
        }
    }
}
