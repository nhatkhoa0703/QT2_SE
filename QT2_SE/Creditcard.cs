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
    public partial class Creditcard : Form
    {
        public bool PaymentSuccessful { get; private set; } = false;
        public Creditcard()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void Creditcard_Load(object sender, EventArgs e)
        {
            try
            {
                // Load images for the credit card logos
                string MoMoPath = @"C:\General\SE\img\momo.jpg";
                string VCBPath = @"C:\General\SE\img\vcb.jpg";
                string VIBPath = @"C:\General\SE\img\vib.jpg";

                // Load Visa image
                if (System.IO.File.Exists(MoMoPath))
                    pbMoMo.Image = Image.FromFile(MoMoPath);

                // Load MasterCard image
                if (System.IO.File.Exists(VCBPath))
                    pbVCB.Image = Image.FromFile(VCBPath);

                // Load Amex image
                if (System.IO.File.Exists(VIBPath))
                    pbVIB.Image = Image.FromFile(VIBPath);

                // Set the SizeMode for all PictureBoxes
                pbMoMo.SizeMode = PictureBoxSizeMode.Zoom;
                pbVCB.SizeMode = PictureBoxSizeMode.Zoom;
                pbVIB.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading card images: " + ex.Message);
            }
        }

       
        

        private void btnCompletePayment_Click(object sender, EventArgs e)
        {
            // Validate the form inputs
            if (string.IsNullOrWhiteSpace(txtCardholderName.Text) ||
                string.IsNullOrWhiteSpace(txtCardNumber.Text) ||
                string.IsNullOrWhiteSpace(txtCVV.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (txtCardNumber.Text.Length != 16 || !long.TryParse(txtCardNumber.Text, out _))
            {
                MessageBox.Show("Invalid card number. It should be 16 digits.");
                return;
            }

            if (txtCVV.Text.Length != 3 || !int.TryParse(txtCVV.Text, out _))
            {
                MessageBox.Show("Invalid CVV. It should be 3 digits.");
                return;
            }

            // Payment logic (simulate success for now)
            PaymentSuccessful = true;
            MessageBox.Show("Payment completed successfully!");

            // Close the form
            this.Close();
        }
    }
}
