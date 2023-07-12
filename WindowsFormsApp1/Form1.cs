using CipherBase.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private ICypher cipherHelper = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cipherHelper = new Cesar();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.label1.Text = "Шифр Віженера";
            cipherHelper = new Vigenere();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.label1.Text = "Шифр Полібія";
            this.Key.Visible = false;
            this.KeyBox.Visible = false;
            this.Result.Location = new Point(22, 227);
            this.ResultBox.Location = new Point(160, 224);
            cipherHelper = new Polibii();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.label1.Text = "Шифр Цезаря";
            cipherHelper = new Cesar();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ResultBox.Text = this.cipherHelper.encode(this.textBox1.Text.ToLower(), this.KeyBox.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
                this.ResultBox.Text = this.cipherHelper.decode(this.textBox1.Text.ToLower(), this.KeyBox.Text);
        }
    }
}
