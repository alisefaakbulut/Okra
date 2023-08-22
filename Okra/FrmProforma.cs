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
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Xml.Linq;
using DevExpress.XtraEditors.Filtering.Templates;

namespace Okra
{
    public partial class FrmProforma : Form
    {
        public FrmProforma()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }
        void Clear()
        {
            txtId.Value = 0;
            txtAmount.Value = 0;
            cmbCategories.Clear();
            cmbProducts.Clear();
            cmbProductColors.Clear();
            cmbFeet.Clear();
            cmbFootColors.Clear();
            cmbFabrics.Clear();
            cmbFabricColors.Clear();
            txtCompanyName.Clear();
            txtDiscount.Value = 0;
            txtPrice.Clear();
        }
        Context context = new Context();
        void List()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From Proformas", context.Connection());
            sqlDataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }
        void GetCategoriesList()
        {
            SqlCommand sqlCommand = new SqlCommand("Select Name From Categories", context.Connection());
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                cmbCategories.Properties.Items.Add(dataReader[0]);
            }
            context.Connection().Close();
        }
        void GetProductsList()
        {
            SqlCommand sqlCommand = new SqlCommand("Select Name From Products", context.Connection());
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                cmbProducts.Properties.Items.Add(dataReader[0]);
            }
            context.Connection().Close();
        }
        void GetProductColorsList()
        {
            SqlCommand sqlCommand = new SqlCommand("Select Name From ProductColors", context.Connection());
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                cmbProductColors.Properties.Items.Add(dataReader[0]);
            }
            context.Connection().Close();
        }
        void GetFeetList()
        {
            SqlCommand sqlCommand = new SqlCommand("Select Name From Feet", context.Connection());
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                cmbFeet.Properties.Items.Add(dataReader[0]);
            }
            context.Connection().Close();
        }
        void GetFootColorsList()
        {
            SqlCommand sqlCommand = new SqlCommand("Select Name From FootColors", context.Connection());
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                cmbFootColors.Properties.Items.Add(dataReader[0]);
            }
            context.Connection().Close();
        }
        void GetFabricsList()
        {
            SqlCommand sqlCommand = new SqlCommand("Select Name From Fabrics", context.Connection());
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                cmbFabrics.Properties.Items.Add(dataReader[0]);
            }
            context.Connection().Close();
        }
        void GetFabricColorsList()
        {
            SqlCommand sqlCommand = new SqlCommand("Select Name From FabricColors", context.Connection());
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                cmbFabricColors.Properties.Items.Add(dataReader[0]);
            }
            context.Connection().Close();
        }

        private void FrmProforma_Load(object sender, EventArgs e)
        {
            List();
            GetCategoriesList();
            GetProductsList();
            GetProductColorsList();
            GetFeetList();
            GetFootColorsList();
            GetFabricsList();
            GetFabricColorsList();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Insert into Proformas(Amount, Category, Product, ProductColor, Foot, FootColor, Fabric, FabricColor, " +
                "CompanyName, ReceiptNo, Discount, Piece, Price, TotalPrice, Date) " +
                "values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, @p13, @p14, @p15)",
                context.Connection());
            sqlCommand.Parameters.AddWithValue("@p1", int.Parse(txtAmount.Text));
            sqlCommand.Parameters.AddWithValue("@p2", cmbCategories.Text);
            sqlCommand.Parameters.AddWithValue("@p3", cmbProducts.Text);
            sqlCommand.Parameters.AddWithValue("@p4", cmbProductColors.Text);
            sqlCommand.Parameters.AddWithValue("@p5", cmbFeet.Text);
            sqlCommand.Parameters.AddWithValue("@p6", cmbFootColors.Text);
            sqlCommand.Parameters.AddWithValue("@p7", cmbFabrics.Text);
            sqlCommand.Parameters.AddWithValue("@p8", cmbFabricColors.Text);
            sqlCommand.Parameters.AddWithValue("@p9", txtCompanyName.Text);
            sqlCommand.Parameters.AddWithValue("@p10", "MB2023"); //-Recipt No hesaplattır
            sqlCommand.Parameters.AddWithValue("@p11", int.Parse(txtDiscount.Text));
            sqlCommand.Parameters.AddWithValue("@p12", 10); //-Parça Sayısı hesaplanacak
            sqlCommand.Parameters.AddWithValue("@p13", decimal.Parse(txtPrice.Text));
            sqlCommand.Parameters.AddWithValue("@p14", 100000); //-Total PRice hesaplanacak
            sqlCommand.Parameters.AddWithValue("@p15", DateTime.Now);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Ürün Sisteme Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();
            Clear();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Delete From Proformas where Id=@p1", context.Connection());
            sqlCommand.Parameters.AddWithValue("@p1", int.Parse(txtId.Text));
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Proforma Sistemden Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();
            Clear();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Update Proformas set Amount = @p1, Category = @p2, Product = @p3, ProductColor = @p4, Foot = @p5, FootColor = @p6, Fabric = @p7," +
                " FabricColor = @p8, CompanyName = @p9, ReceiptNo = @p10, Discount = @p11, Piece = @p12, Price = @p13, TotalPrice = @p14, Date = @p15 where Id=@p16", context.Connection());
            sqlCommand.Parameters.AddWithValue("@p1", int.Parse(txtAmount.Text));
            sqlCommand.Parameters.AddWithValue("@p2", cmbCategories.Text);
            sqlCommand.Parameters.AddWithValue("@p3", cmbProducts.Text);
            sqlCommand.Parameters.AddWithValue("@p4", cmbProductColors.Text);
            sqlCommand.Parameters.AddWithValue("@p5", cmbFeet.Text);
            sqlCommand.Parameters.AddWithValue("@p6", cmbFootColors.Text);
            sqlCommand.Parameters.AddWithValue("@p7", cmbFabrics.Text);
            sqlCommand.Parameters.AddWithValue("@p8", cmbFabricColors.Text);
            sqlCommand.Parameters.AddWithValue("@p9", txtCompanyName.Text);
            sqlCommand.Parameters.AddWithValue("@p10", "MB2023"); //-Recipt No hesaplattır
            sqlCommand.Parameters.AddWithValue("@p11", int.Parse(txtDiscount.Text));
            sqlCommand.Parameters.AddWithValue("@p12", 10); //-Parça Sayısı hesaplanacak
            sqlCommand.Parameters.AddWithValue("@p13", decimal.Parse(txtPrice.Text));
            sqlCommand.Parameters.AddWithValue("@p14", 100000); //-Total PRice hesaplanacak
            sqlCommand.Parameters.AddWithValue("@p15", DateTime.Now);
            sqlCommand.Parameters.AddWithValue("@p16", txtId.Value);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Ürün Sistemde Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();
            Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtId.Value = decimal.Parse(dataRow["Id"].ToString());
            txtAmount.Value = decimal.Parse(dataRow["Amount"].ToString());
            cmbCategories.Text = dataRow["Category"].ToString();
            cmbProducts.Text = dataRow["Product"].ToString();
            cmbProductColors.Text = dataRow["ProductColor"].ToString();
            cmbFeet.Text = dataRow["Foot"].ToString();
            cmbFootColors.Text = dataRow["FootColor"].ToString();
            cmbFabrics.Text = dataRow["Fabric"].ToString(); ;
            cmbFabricColors.Text = dataRow["FabricColor"].ToString();
            txtCompanyName.Text = dataRow["CompanyName"].ToString();
            txtDiscount.Value = int.Parse(dataRow["Discount"].ToString());
            txtPrice.Text = dataRow["Price"].ToString();
        }
    }
}
