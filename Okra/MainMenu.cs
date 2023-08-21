using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okra
{
    public partial class MainMenu : Form
    {
        FrmProduct frmProduct;
        FrmProductColor frmProductColor;
        FrmFoot frmFoot;
        FrmFootColor frmFootColor;
        FrmFabric frmFabric;
        FrmFabricColor frmFabricColor;
        FrmCategory frmCategory;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmProductColor == null)
            {
                frmProductColor = new FrmProductColor();
                frmProductColor.MdiParent = this;
                frmProductColor.Show();
            }

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
        
        private void btnProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmProduct == null)
            {
                frmProduct = new FrmProduct();
                frmProduct.MdiParent = this;
                frmProduct.Show();
            }
            
        }

        private void btnFoot_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmFoot == null)
            {
                frmFoot = new FrmFoot();
                frmFoot.MdiParent = this;
                frmFoot.Show();
            }

        }

        private void btnFootColor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmFootColor == null)
            {
                frmFootColor = new FrmFootColor();
                frmFootColor.MdiParent = this;
                frmFootColor.Show();
            }
        }

        private void btnFabric_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmFabric == null)
            {
                frmFabric = new FrmFabric();
                frmFabric.MdiParent = this;
                frmFabric.Show();
            }
        }

        private void btnFabricColor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmFabricColor == null)
            {
                frmFabricColor = new FrmFabricColor();
                frmFabricColor.MdiParent = this;
                frmFabricColor.Show();
            }
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmCategory == null)
            {
                frmCategory = new FrmCategory();
                frmCategory.MdiParent = this;
                frmCategory.Show();
            }
        }
    }
}
