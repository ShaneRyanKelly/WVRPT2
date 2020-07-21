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
using System.Runtime.Remoting.Channels;

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

        private void retrieveData(string idNumber)
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
                    from dbo.Buoy_" + idNumber;
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dAdapter.Fill(ds);
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.AutoResizeColumns();
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

        private void capeCodMAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            retrieveData("44018");
        }

        private void diamondShoalsNCToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            retrieveData("41025");
        }

        private void capeMayNJToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            retrieveData("44009");
        }

        private void breezyPointNYToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            retrieveData("44065");
        }

        private void montaukPointNYToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            retrieveData("44017");
        }

        private void stAugustineFLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            retrieveData("41117");
        }

        private void morroBayCAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            retrieveData("46028");
        }

        private void pointArenaCAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            retrieveData("46014");
        }

        private void newportORToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            retrieveData("46050");
        }

        private void sanNicolasIslandCAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            retrieveData("46219");
        }
    }
}
