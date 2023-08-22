﻿using System;
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
    public partial class Main : Form
    {
        FrmProduct frmProduct;
        FrmProductColor frmProductColor;
        FrmFoot frmFoot;
        FrmFootColor frmFootColor;
        FrmFabric frmFabric;
        FrmFabricColor frmFabricColor;
        FrmCategory frmCategory;
        FrmProforma frmProforma;
        public Main()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmProduct == null)
            {
                frmProduct = new FrmProduct();
                frmProduct.MdiParent = this;
                frmProduct.Show();
            }
        }
    }
}
