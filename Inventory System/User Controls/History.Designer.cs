namespace Inventory_System
{
    partial class History
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
            dgvInventory = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            SuspendLayout();
            // 
            // dgvInventory
            // 
            dgvInventory.BackgroundColor = Color.FromArgb(34, 34, 34);
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.GridColor = Color.FromArgb(51, 51, 51);
            dgvInventory.Location = new Point(69, 114);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.Size = new Size(654, 395);
            dgvInventory.TabIndex = 3;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 34);
            Controls.Add(dgvInventory);
            MaximumSize = new Size(1048, 628);
            MinimumSize = new Size(847, 628);
            Name = "History";
            Size = new Size(1048, 628);
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvInventory;
    }
}
