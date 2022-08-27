using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoprite
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            customizeDesign();
        }
        #region panelSlide
        public void customizeDesign()
        {
            panelSubProduct.Visible = false;
            panelSubRecord.Visible = false;
            panelSubStock.Visible = false;
            PanelSubSetting.Visible = false;

        }

        private void hideSubmenu()
        {
            if (panelSubProduct.Visible == true)
                panelSubProduct.Visible = false;
            if (panelSubRecord.Visible == true)
                panelSubRecord.Visible = false;
            if (PanelSubSetting.Visible == true)
                PanelSubSetting.Visible = false;
            if (panelSubStock.Visible == true)
                panelSubStock.Visible = false;
        }

        private void showSubmenu (Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }
        #endregion panelSlide
        private void button8_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void lblRole_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRecord_Click(object sender, EventArgs e)
        {

        }

        private void btnDasboard_Click(object sender, EventArgs e)
        {

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubProduct);
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnInStock_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubStock);
        }

        private void btnStockEntry_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnStockAdjustment_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnSaleHistory_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnSaleRecord_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            showSubmenu(PanelSubSetting);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }
    }
}