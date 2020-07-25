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

        private void retrieveData(string idNumber, bool isWave)
        {
            try
            {
                String query;
                if (isWave)
                {
                    query = @"Select  DateIndex,
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
                }
                else
                {
                    query = @"Select  DateIndex,
                    WDIR,
                    WSPD,
                    GST,
                    WVHT,
                    DPD,
                    APD,
                    MWD,
                    PRES,
                    ATMP,
                    WTMP,
                    DEWP,
                    VIS,
                    PTDY,
                    TIDE
                    from dbo.Met_" + idNumber;
                }
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


        private void capeCodMAToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            retrieveData("44018", true);
        }

        private void diamondShoalsNCToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            retrieveData("41025", true);
        }

        private void capeMayNJToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            retrieveData("44009", true);
        }

        private void breezyPointNYToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            retrieveData("44065", true);
        }

        private void montaukPointNYToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            retrieveData("44017", true);
        }

        private void stAugustineFLToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            retrieveData("41117", true);
        }

        private void morroBayCAToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            retrieveData("46028", true);
        }

        private void pointArenaCAToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            retrieveData("46014", true);
        }

        private void sanNicolasIslandCAToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            retrieveData("46219", true);
        }

        private void newportORToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            retrieveData("46050", true);
        }

        private void capeCodMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            retrieveData("44018", false);
        }

        private void diamondShoalsNCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            retrieveData("41025", false);
        }

        private void capeMayNJToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            retrieveData("44009", false);
        }

        private void breezyPointNYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            retrieveData("44065", false);
        }

        private void montaukPointNYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            retrieveData("44017", false);
        }

        private void stAugustineFLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            retrieveData("41117", false);
        }

        private void morroBayCAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            retrieveData("46028", false);
        }

        private void pointArenaCAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            retrieveData("46014", false);
        }

        private void sanNicolasIslandCAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            retrieveData("46219", false);
        }

        private void newportORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            retrieveData("46050", false);
        }
    }
}
