using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WVRPT2
{
    public partial class Form1 : Form
    {
        private SqlConnection con;
        public Form1()
        {
            InitializeComponent();
            con = ConnectDB();
        }

        private void rockawayNYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                String query = @"Select  DateIndex,
                    WVHT,
                    SwH,
                    SwP,
                    SwD,
                    WWH,
                    WWP,
                    WWD,
                    STEEPNESS,
                    APD,
                    MWD
                    from dbo.Buoy_44065";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dAdapter.Fill(ds);
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
                MessageBox.Show("connection successful");
                con.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }

        }

        private SqlConnection ConnectDB()
        {
            String connectString = "Server=LAPTOP-DTUMN89D;Database=buoys;Trusted_Connection=True;";
            SqlConnection con = new SqlConnection(connectString);
            return con;
        }
    }
}
