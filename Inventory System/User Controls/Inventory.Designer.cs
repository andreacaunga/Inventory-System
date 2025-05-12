namespace Inventory_System.User_Controls
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            txtSearch = new TextBox();
            dgvInventory = new DataGridView();
            itemName = new DataGridViewTextBoxColumn();
            itemType = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            itemID = new DataGridViewTextBoxColumn();
            btnAddItem = new Label();
            btnEditItem = new Label();
            btnDeleteItem = new Label();
            pnlItem = new Panel();
            btnBack = new Label();
            btnSave = new Button();
            txtQuantity = new TextBox();
            label3 = new Label();
            cmbxItemType = new ComboBox();
            label2 = new Label();
            txtItemName = new TextBox();
            label1 = new Label();
            lblHeader = new Label();
            pnlButtons = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            pnlItem.SuspendLayout();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(34, 34, 34);
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Cursor = Cursors.IBeam;
            txtSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.FromArgb(255, 36, 0);
            txtSearch.HideSelection = false;
            txtSearch.Location = new Point(69, 72);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(394, 20);
            txtSearch.TabIndex = 1;
            txtSearch.Text = "Search...";
            txtSearch.Click += txtSearch_Click;
            // 
            // dgvInventory
            // 
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AllowUserToResizeColumns = false;
            dgvInventory.AllowUserToResizeRows = false;
            dgvInventory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventory.BackgroundColor = Color.FromArgb(34, 34, 34);
            dgvInventory.BorderStyle = BorderStyle.None;
            dgvInventory.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvInventory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(34, 34, 34);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Columns.AddRange(new DataGridViewColumn[] { itemName, itemType, quantity, itemID });
            dgvInventory.GridColor = Color.FromArgb(34, 34, 34);
            dgvInventory.Location = new Point(69, 114);
            dgvInventory.Name = "dgvInventory";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(34, 34, 34);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.Size = new Size(654, 395);
            dgvInventory.TabIndex = 2;
            dgvInventory.CellContentClick += dgvInventory_CellContentClick;
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
            // btnAddItem
            // 
            btnAddItem.AutoSize = true;
            btnAddItem.Cursor = Cursors.Hand;
            btnAddItem.Font = new Font("Segoe UI", 12F);
            btnAddItem.ForeColor = Color.FromArgb(255, 36, 0);
            btnAddItem.Image = (Image)resources.GetObject("btnAddItem.Image");
            btnAddItem.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddItem.Location = new Point(19, 31);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Padding = new Padding(0, 5, 0, 5);
            btnAddItem.Size = new Size(121, 31);
            btnAddItem.TabIndex = 3;
            btnAddItem.Text = "            Add Item";
            btnAddItem.TextAlign = ContentAlignment.MiddleCenter;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnEditItem
            // 
            btnEditItem.AutoSize = true;
            btnEditItem.Cursor = Cursors.Hand;
            btnEditItem.Font = new Font("Segoe UI", 12F);
            btnEditItem.ForeColor = Color.FromArgb(255, 36, 0);
            btnEditItem.Image = (Image)resources.GetObject("btnEditItem.Image");
            btnEditItem.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditItem.Location = new Point(19, 90);
            btnEditItem.Name = "btnEditItem";
            btnEditItem.Padding = new Padding(0, 5, 0, 5);
            btnEditItem.Size = new Size(119, 31);
            btnEditItem.TabIndex = 4;
            btnEditItem.Text = "            Edit Item";
            btnEditItem.TextAlign = ContentAlignment.MiddleCenter;
            btnEditItem.Click += btnEditItem_Click;
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.AutoSize = true;
            btnDeleteItem.Cursor = Cursors.Hand;
            btnDeleteItem.Font = new Font("Segoe UI", 12F);
            btnDeleteItem.ForeColor = Color.FromArgb(255, 36, 0);
            btnDeleteItem.Image = (Image)resources.GetObject("btnDeleteItem.Image");
            btnDeleteItem.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteItem.Location = new Point(19, 148);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Padding = new Padding(0, 5, 0, 5);
            btnDeleteItem.Size = new Size(137, 31);
            btnDeleteItem.TabIndex = 5;
            btnDeleteItem.Text = "            Delete Item";
            btnDeleteItem.TextAlign = ContentAlignment.MiddleCenter;
            btnDeleteItem.Click += btnDeleteItem_Click;
            // 
            // pnlItem
            // 
            pnlItem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlItem.Controls.Add(btnBack);
            pnlItem.Controls.Add(btnSave);
            pnlItem.Controls.Add(txtQuantity);
            pnlItem.Controls.Add(label3);
            pnlItem.Controls.Add(cmbxItemType);
            pnlItem.Controls.Add(label2);
            pnlItem.Controls.Add(txtItemName);
            pnlItem.Controls.Add(label1);
            pnlItem.Controls.Add(lblHeader);
            pnlItem.Location = new Point(748, 114);
            pnlItem.Name = "pnlItem";
            pnlItem.Size = new Size(231, 325);
            pnlItem.TabIndex = 6;
            pnlItem.Visible = false;
            // 
            // btnBack
            // 
            btnBack.AutoSize = true;
            btnBack.Cursor = Cursors.Hand;
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(16, 15);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(10, 15);
            btnBack.TabIndex = 8;
            btnBack.Text = " ";
            btnBack.Click += btnBack_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(17, 17, 17);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(51, 51, 51);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(76, 269);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(78, 27);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = Color.FromArgb(34, 34, 34);
            txtQuantity.BorderStyle = BorderStyle.FixedSingle;
            txtQuantity.Font = new Font("Segoe UI", 9.75F);
            txtQuantity.ForeColor = Color.White;
            txtQuantity.Location = new Point(25, 221);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(72, 25);
            txtQuantity.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 197);
            label3.Name = "label3";
            label3.Size = new Size(56, 17);
            label3.TabIndex = 5;
            label3.Text = "Quantity";
            // 
            // cmbxItemType
            // 
            cmbxItemType.BackColor = Color.FromArgb(34, 34, 34);
            cmbxItemType.FlatStyle = FlatStyle.Flat;
            cmbxItemType.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbxItemType.ForeColor = Color.White;
            cmbxItemType.FormattingEnabled = true;
            cmbxItemType.Items.AddRange(new object[] { "Raw Meats", "Seafood", "Vegetables", "Fruits", "Dry Goods", "Canned Goods", "Frozen Items", "Drinks/Beverages", "Dairy Products", "Breads & Bakery", "Snacks", "Condiments & Sauces" });
            cmbxItemType.Location = new Point(25, 158);
            cmbxItemType.MaxDropDownItems = 5;
            cmbxItemType.Name = "cmbxItemType";
            cmbxItemType.Size = new Size(180, 25);
            cmbxItemType.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 133);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 3;
            label2.Text = "Item Type";
            // 
            // txtItemName
            // 
            txtItemName.BackColor = Color.FromArgb(34, 34, 34);
            txtItemName.BorderStyle = BorderStyle.FixedSingle;
            txtItemName.Font = new Font("Segoe UI", 9.75F);
            txtItemName.ForeColor = Color.White;
            txtItemName.Location = new Point(25, 90);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(180, 25);
            txtItemName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 66);
            label1.Name = "label1";
            label1.Size = new Size(72, 17);
            label1.TabIndex = 1;
            label1.Text = "Item Name";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.FromArgb(255, 36, 0);
            lblHeader.Location = new Point(76, 27);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(79, 20);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "ADD ITEM";
            // 
            // pnlButtons
            // 
            pnlButtons.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlButtons.Controls.Add(btnDeleteItem);
            pnlButtons.Controls.Add(btnAddItem);
            pnlButtons.Controls.Add(btnEditItem);
            pnlButtons.Location = new Point(748, 114);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(231, 325);
            pnlButtons.TabIndex = 7;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 34);
            Controls.Add(dgvInventory);
            Controls.Add(txtSearch);
            Controls.Add(pnlButtons);
            Controls.Add(pnlItem);
            ForeColor = Color.White;
            MaximumSize = new Size(1048, 628);
            MinimumSize = new Size(847, 628);
            Name = "Inventory";
            Size = new Size(1048, 628);
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            pnlItem.ResumeLayout(false);
            pnlItem.PerformLayout();
            pnlButtons.ResumeLayout(false);
            pnlButtons.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSearch;
        private DataGridView dgvInventory;
        private Label btnAddItem;
        private Label btnEditItem;
        private Label btnDeleteItem;
        public Panel pnlItem;
        private TextBox txtItemName;
        private Label label1;
        private Label lblHeader;
        private ComboBox cmbxItemType;
        private Label label2;
        private Button btnSave;
        private TextBox txtQuantity;
        private Label label3;
        private Label btnBack;
        public Panel pnlButtons;
        private DataGridViewTextBoxColumn itemName;
        private DataGridViewTextBoxColumn itemType;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn itemID;
    }
}
