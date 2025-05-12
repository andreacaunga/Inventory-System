using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System.User_Controls
{
    public partial class Inventory : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-JM0T2KKH\\SQLEXPRESS;Initial Catalog=dboInventory;User ID=sa;Password=123;Trust Server Certificate=True");
        SqlCommand cmd;
        public Inventory()
        {
            InitializeComponent();
            pnlItem.Visible = false;
            LoadInventoryData();
            UIDesign.DGVTheme(dgvInventory);
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void LoadInventoryData()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                string query = "SELECT * FROM tblItems";
                cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                dgvInventory.Rows.Clear();

                while (reader.Read())
                {
                    int rowIndex = dgvInventory.Rows.Add();
                    dgvInventory.Rows[rowIndex].Cells["itemID"].Value = reader["itemID"].ToString();
                    dgvInventory.Rows[rowIndex].Cells["itemName"].Value = reader["itemName"].ToString();
                    dgvInventory.Rows[rowIndex].Cells["itemType"].Value = reader["itemType"].ToString();
                    dgvInventory.Rows[rowIndex].Cells["quantity"].Value = reader["quantity"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            pnlItem.Visible = true;
            pnlButtons.Visible = false;
            lblHeader.Text = "ADD ITEM";

            txtItemName.Clear();
            cmbxItemType.Text = "Select type";
            txtQuantity.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlItem.Visible = false;
            pnlButtons.Visible = true;
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            pnlItem.Visible = true;
            pnlButtons.Visible = false;
            lblHeader.Text = "EDIT ITEM";

            DataGridViewRow row = dgvInventory.CurrentRow;

            txtItemName.Text = row.Cells["itemName"].Value.ToString();
            cmbxItemType.Text = row.Cells["itemType"].Value.ToString();
            txtQuantity.Text = row.Cells["quantity"].Value.ToString();
        }

        private int getItemID()
        {
            if (dgvInventory.CurrentRow != null)
            {
                return Convert.ToInt32(dgvInventory.CurrentRow.Cells["itemID"].Value);
            }
            return -1;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            conn.Open();

            if (lblHeader.Text == "ADD ITEM")
            {
                cmd = new SqlCommand("INSERT INTO tblItems (itemName, itemType, quantity) VALUES (@name, @type, @qty)", conn);
            }
            else if (lblHeader.Text == "EDIT ITEM")
            {
                int itemID = getItemID();

                if (itemID <= 0)
                {
                    MessageBox.Show("No row selected to edit.");
                    conn.Close();
                    return;
                }
                cmd = new SqlCommand("UPDATE tblItems SET itemName = @name, itemType = @type, quantity = @qty WHERE itemID = @id", conn);
                cmd.Parameters.AddWithValue("@id", itemID);
            }
            else
            {
                conn.Close();
                return;
            }

            cmd.Parameters.AddWithValue("@name", txtItemName.Text);
            cmd.Parameters.AddWithValue("@type", cmbxItemType.Text);
            cmd.Parameters.AddWithValue("@qty", txtQuantity.Text);

            cmd.ExecuteNonQuery();
            LoadInventoryData();

            if (lblHeader.Text == "ADD ITEM")
            {
                MessageBox.Show("Item added successfully.");
            }
            else if (lblHeader.Text == "EDIT ITEM")
            {
                MessageBox.Show("Changes saved successfully.");
            }
            conn.Close();

            txtItemName.Clear();
            cmbxItemType.Text = "Select type";
            txtQuantity.Clear();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            int itemID = getItemID();

            if (itemID <= 0)
            {
                MessageBox.Show("No row selected to delete.");
                conn.Close();
                return;
            }

            try
            {
                conn.Open();
                cmd = new SqlCommand("DELETE FROM tblItems WHERE itemID = @id", conn);
                cmd.Parameters.AddWithValue("@id", itemID);

                cmd.ExecuteNonQuery();
                conn.Close();

                LoadInventoryData();
                MessageBox.Show("Item deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}
