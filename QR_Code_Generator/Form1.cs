using System;
using QRCoder;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_Code_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("PLease Enter Text first", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                QRCodeGenerator qr = new QRCodeGenerator();
                QRCodeData data = qr.CreateQrCode(textBox1.Text, QRCodeGenerator.ECCLevel.Q);
                QRCode code = new QRCode(data);
                pictureBox1.Image = code.GetGraphic(5);

                MessageBox.Show("QR Code Generated SuccessFully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "JPG(*.JPG)|*.JPG";
            sf.ShowDialog();
            
        }
    }
}
