﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        string password = "admin";
        string username = "admin";
        Form1 form1= new Form1();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text  == username)
            {
                if (textBox2.Text == password)
                    form1.Show();

            }    
            else
            {
                MessageBox.Show("wrong username or password");
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure Ebadat?", "Closeing window", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
                this.Dispose();
            if (dialog == DialogResult.No)
                e.Cancel = true;

        }
    }
}
