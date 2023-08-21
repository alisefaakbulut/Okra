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

namespace Okra
{
    public partial class FrmFabric : Form
    {
        public FrmFabric()
        {
            InitializeComponent();
        }
        Context context = new Context();
        void List()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From Fabrics", context.Connection());
            sqlDataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }
        private void FrmFabric_Load(object sender, EventArgs e)
        {
            List();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Insert into Fabrics(Name,Code) values (@p1, @p2)", context.Connection());
            sqlCommand.Parameters.AddWithValue("@p1", txtName.Text);
            sqlCommand.Parameters.AddWithValue("@p2", txtCode.Text);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Kumaş Sisteme Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();
            txtName.Text = "";
            txtCode.Text = "";
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Update Fabrics set Name=@p1, Code=@p2 where Id=@p3", context.Connection());
            sqlCommand.Parameters.AddWithValue("@p1", txtName.Text);
            sqlCommand.Parameters.AddWithValue("@p2", txtCode.Text);
            sqlCommand.Parameters.AddWithValue("@p3", txtId.Value);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Kumaş Sistemde Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();
            txtName.Text = "";
            txtCode.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Value = 0;
            txtName.Text = "";
            txtCode.Text = "";
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Delete From Fabrics where Id=@p1", context.Connection());
            sqlCommand.Parameters.AddWithValue("@p1", int.Parse(txtId.Text));
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Kumaş Sistemden Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();
            txtId.Value = 0;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtId.Value = decimal.Parse(dataRow["Id"].ToString());
            txtName.Text = dataRow["Name"].ToString();
            txtCode.Text = dataRow["code"].ToString();
        }
    }
}
