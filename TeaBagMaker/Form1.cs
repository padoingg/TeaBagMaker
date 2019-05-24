using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.VisualBasic;

namespace TeaBagMaker
{
    public partial class Form1 : Form
    {
        int Count = 0;
        string[] CList = new string[] { "홍차", "녹차", "루이보스차", "국화차" };
        int[] TList = new int[]{120,180,300,120};

        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < CList.Length; i++)
            {
                this.List.Items.Add(CList[i]);
            }
            if (List.Items.Count > 0)
            {
                this.List.SelectedIndex = 0;
            }
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
                this.Count = Convert.ToInt32(this.textBox1.Text);
                this.textBox1.ReadOnly = true;
                this.timer.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (Count < 1)
            {
                this.timer.Enabled = false;
                this.textBox1.ReadOnly = false;
                this.textBox1.Text = "";
                MessageBox.Show("티백을 건지세요!", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBox1.Focus();
            }
            else
            {
                this.Count--;
                this.textBox1.Text = Convert.ToString(this.Count+"초 남았습니다!");
            }
        }

    }
}