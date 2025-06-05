using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tela_de_login_joão_02
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void botton1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "joão victor") && (textBox2.Text == "1234"))
            {
                MessageBox.Show("Bem vindo ao sistema ");

            }
            else
            {
                MessageBox.Show("Login ou senha inválidos!");
            }

        }
    }
}
