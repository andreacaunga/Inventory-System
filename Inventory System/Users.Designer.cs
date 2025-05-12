namespace Inventory_System
{
    partial class Users
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvUsers = new DataGridView();
            itemName = new DataGridViewTextBoxColumn();
            itemType = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            itemID = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToResizeColumns = false;
            dgvUsers.AllowUserToResizeRows = false;
            dgvUsers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = Color.FromArgb(34, 34, 34);
            dgvUsers.BorderStyle = BorderStyle.None;
            dgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(34, 34, 34);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { itemName, itemType, quantity, itemID });
            dgvUsers.GridColor = Color.FromArgb(34, 34, 34);
            dgvUsers.Location = new Point(82, 109);
            dgvUsers.Name = "dgvUsers";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(34, 34, 34);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(654, 395);
            dgvUsers.TabIndex = 3;
            // 
            // itemName
            // 
            itemName.HeaderText = "Item Name";
            itemName.Name = "itemName";
            itemName.ReadOnly = true;
            itemName.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // itemType
            // 
            itemType.HeaderText = "Item Type";
            itemType.Name = "itemType";
            itemType.ReadOnly = true;
            itemType.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // quantity
            // 
            quantity.HeaderText = "Quantity";
            quantity.Name = "quantity";
            quantity.ReadOnly = true;
            quantity.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // itemID
            // 
            itemID.HeaderText = "Item ID";
            itemID.Name = "itemID";
            itemID.Visible = false;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 34);
            Controls.Add(dgvUsers);
            Name = "Users";
            Size = new Size(1048, 628);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUsers;
        private DataGridViewTextBoxColumn itemName;
        private DataGridViewTextBoxColumn itemType;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn itemID;
    }
}
