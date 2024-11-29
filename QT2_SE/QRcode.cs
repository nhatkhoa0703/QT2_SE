using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT2_SE
{
    public partial class QRcode : Form
    {
        public QRcode()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void QRcode_Load(object sender, EventArgs e)
        {
            // Load the QR code image
            try
            {
                // Adjust the path to your QR code image file
                string qrCodePath = "C:\\General\\SE\\img\\qrcard.jpg";

                // Check if the file exists
                if (System.IO.File.Exists(qrCodePath))
                {
                    // Load the image and set it to fit the PictureBox
                    Image qrImage = Image.FromFile(qrCodePath);
                    pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox2.Image = qrImage;
                }
                else
                {
                    MessageBox.Show("QR code image not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading QR code: " + ex.Message);
            }
        }

        private void btn_PaymentComplete_Click(object sender, EventArgs e)
        {
            // Confirm payment and close the form
            MessageBox.Show("Payment completed successfully!");
            this.Close();
        }
    }
}
