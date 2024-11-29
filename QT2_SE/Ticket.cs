using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QT2_SE
{
    public partial class Ticket : Form
    {
        private string connString = System.Configuration.ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        public Ticket()
        {
            InitializeComponent();
            LoadDestinations();
            LoadTransportModes();
            LoadPaymentMethods();
            LoadPreviousTickets();
           
        }
        private void LoadDestinations()
        {
            cmb_Destination.Items.AddRange(new string[] { "Downtown", "Airport", "City Center", "Museum" });
        }
        private void LoadTransportModes()
        {
            cmb_Transport.Items.AddRange(new string[] { "Bus: 5$ ", "MRT: 3$ ", "Train: 10$ " });
        }
        private void LoadPaymentMethods()
        {
            cmb_Payment.Items.AddRange(new string[] { "Credit Card", "QR Code" });
        }

        private void LoadPreviousTickets()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"SELECT T.TicketID, T.UserID, U.FullName, U.Email, U.Phone, 
                                T.Destination, T.TransportationMode, T.PaymentStatus, U.PaymentMethod, T.IssuedAt
                         FROM Tickets T
                         JOIN Users U ON T.UserID = U.UserID";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewTickets.DataSource = dt;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Ticket_Bus_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTicketInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_proceed_Click(object sender, EventArgs e)
        {
            // Step 1: Retrieve selected values from the ComboBoxes
            string destination = cmb_Destination.SelectedItem?.ToString();
            string transportMode = cmb_Transport.SelectedItem?.ToString();
            string paymentMethod = cmb_Payment.SelectedItem?.ToString();

            // Check if all selections are made
            if (string.IsNullOrEmpty(destination) || string.IsNullOrEmpty(transportMode) || string.IsNullOrEmpty(paymentMethod))
            {
                MessageBox.Show("Please select all options before proceeding.");
                return;
            }

            // Step 2: Open the UserInfoForm to collect user details
            UserInfoForm userInfoForm = new UserInfoForm();
            if (userInfoForm.ShowDialog() == DialogResult.OK)
            {
                string fullName = userInfoForm.FullName;
                string email = userInfoForm.Email;
                string phone = userInfoForm.Phone;

                bool paymentSuccessful = false;

                // Step 3: Determine payment flow based on the selected payment method
                if (paymentMethod == "QR Code")
                {
                    // Open the QR code form for payment
                    QRcode qrCodeForm = new QRcode();
                    qrCodeForm.ShowDialog();

                    // Assume payment was successful after QR code scanning
                    paymentSuccessful = true;
                    MessageBox.Show("Payment completed via QR code!");
                }
                else if (paymentMethod == "Credit Card")
                {
                    // Open the Credit Card payment form
                    Creditcard creditCardForm = new Creditcard();
                    creditCardForm.ShowDialog();

                    // Check if payment was successful
                    paymentSuccessful = creditCardForm.PaymentSuccessful;
                    if (paymentSuccessful)
                    {
                        MessageBox.Show("Payment completed via Credit Card!");
                    }
                    else
                    {
                        MessageBox.Show("Payment via Credit Card was not completed.");
                        return; // Exit if payment was not successful
                    }
                }

                // Step 4: Insert the user and ticket information into the database if payment was successful
                if (paymentSuccessful)
                {
                    int userId;
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        conn.Open();
                        string insertUserQuery = "INSERT INTO Users (FullName, Email, Phone, PaymentMethod) " +
                                                 "VALUES (@FullName, @Email, @Phone, @PaymentMethod); SELECT SCOPE_IDENTITY();";

                        using (SqlCommand cmd = new SqlCommand(insertUserQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@FullName", fullName);
                            cmd.Parameters.AddWithValue("@Email", email);
                            cmd.Parameters.AddWithValue("@Phone", phone);
                            cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                            userId = Convert.ToInt32(cmd.ExecuteScalar());
                        }
                    }

                    // Step 5: Insert the ticket into the database
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        conn.Open();
                        string insertTicketQuery = "INSERT INTO Tickets (UserID, Destination, TransportationMode, PaymentStatus) " +
                                                   "VALUES (@UserID, @Destination, @TransportMode, @PaymentStatus)";

                        using (SqlCommand cmd = new SqlCommand(insertTicketQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@UserID", userId);
                            cmd.Parameters.AddWithValue("@Destination", destination);
                            cmd.Parameters.AddWithValue("@TransportMode", transportMode);
                            cmd.Parameters.AddWithValue("@PaymentStatus", paymentMethod == "QR Code" ? "Pending" : "Paid");
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Ticket created successfully!");
                    LoadPreviousTickets();
                }
            }
        }






        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
