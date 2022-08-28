using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoprite
{
    public partial class BrandModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();

        public BrandModule()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Inserting brand name into table
            try
            {
                if 
                    (MessageBox.Show("Are you sure you want to save this brand?", "",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tbBrand(brand)VALUES(@brand)", cn);
                    cm.Parameters.AddWithValue("@brand", txtBrand.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been succesfully saved.", "Record");
                    Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose(); 

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            txtBrand.Clear();
        }
    }
}
