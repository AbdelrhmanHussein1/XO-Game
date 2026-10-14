using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TecTacToc
{
    public partial class FormMain : Form
    {
        string player1Name;
        string player2Name;

        public FormMain()
        {
            InitializeComponent();
            // تم حذف قراءة الـ textBox من هنا لأن المستخدم لم يكتب شيئاً بعد
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gbText.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gbText.Enabled = false;
        }

        // دالة مساعدة لتحديث أسماء اللاعبين من التكست بوكس
        private void UpdatePlayerNames()
        {
            player1Name = string.IsNullOrWhiteSpace(textBox1.Text) ? "Player1" : textBox1.Text;
            player2Name = string.IsNullOrWhiteSpace(textBox2.Text) ? "Player2" : textBox2.Text;
        }

        private void PlayWithFrind_Click(object sender, EventArgs e)
        {
            // تحديث الأسماء عند الضغط على الزر
            UpdatePlayerNames();

            Form1 XOGame = new Form1(player1Name, player2Name, false, useDefaultNames);
            XOGame.PlayWithComputer = false;
            XOGame.ShowDialog();
        }

        public void PlayWithComyter_Click(object sender, EventArgs e)
        {
            PlayWithComyter.Visible = false;
            button1.Visible = false;

            btnEasy.Visible = true;
            btnMedium.Visible = true;
            btnHard.Visible = true;

            btnReturn.Visible = true;
        }

        public bool useDefaultNames = true;
        public string lb1 { get; set; }
        public string lb2 { get; set; }

        private void button3_Click(object sender, EventArgs e)
        {
            // تصحيح إسناد الأسماء
            lb1 = textBox1.Text;
            lb2 = textBox2.Text; // تصحيح الخطأ هنا (كانت lb1 مكررة)

            UpdatePlayerNames();
            useDefaultNames = false;
            MessageBox.Show("Name saved successfully");
        }

        public bool HardMode = true;

        private void btnEasy_Click(object sender, EventArgs e)
        {
            UpdatePlayerNames();

            Form1 XOGame = new Form1(player1Name, "Computer", true, useDefaultNames, Form1.enLevel.Easy);
            XOGame.ShowDialog();
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            UpdatePlayerNames();

            Form1 XOGame = new Form1(player1Name, "Computer", true, useDefaultNames, Form1.enLevel.Medium);
            XOGame.ShowDialog();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            UpdatePlayerNames();

            Form1 XOGame = new Form1(player1Name, "Computer", true, useDefaultNames, Form1.enLevel.Hard);
            XOGame.ShowDialog();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            PlayWithComyter.Visible = true;
            button1.Visible = true;

            btnEasy.Visible = false;
            btnMedium.Visible = false;
            btnHard.Visible = false;

            btnReturn.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            button2.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}