using System;
using System.Threading;
using System.Windows.Forms;


namespace BotForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            vLb3.Visible = true;
            Chat_Monitora vChat_Monitora = new Chat_Monitora();
            vChat_Monitora.Verify_Chat_Open(vTbCaptura1.Text, vTbResposta1.Text,
            vTbCaptura2.Text, vTbResposta2.Text, vTbCaptura3.Text, vTbResposta3.Text);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
