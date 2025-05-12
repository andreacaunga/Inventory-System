namespace Inventory_System
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            pnlSidebar = new Panel();
            btnUsers = new Button();
            label3 = new Label();
            btnInventory = new Button();
            btnDashboard = new Button();
            btnLogout = new Button();
            btnHistory = new Button();
            sidebarTransition = new System.Windows.Forms.Timer(components);
            pnlContainer = new Panel();
            panel1 = new Panel();
            btnExit = new Label();
            label1 = new Label();
            lblHeader = new Label();
            pnlSidebar.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(17, 17, 17);
            pnlSidebar.Controls.Add(btnUsers);
            pnlSidebar.Controls.Add(label3);
            pnlSidebar.Controls.Add(btnInventory);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(btnHistory);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.MaximumSize = new Size(265, 680);
            pnlSidebar.MinimumSize = new Size(64, 680);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(265, 680);
            pnlSidebar.TabIndex = 1;
            pnlSidebar.MouseEnter += pnlSidebar_MouseEnter;
            pnlSidebar.MouseLeave += pnlSidebar_MouseLeave;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.FromArgb(17, 17, 17);
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatAppearance.MouseDownBackColor = Color.FromArgb(51, 51, 51);
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUsers.ForeColor = Color.FromArgb(255, 36, 0);
            btnUsers.Image = (Image)resources.GetObject("btnUsers.Image");
            btnUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsers.Location = new Point(-3, 317);
            btnUsers.Name = "btnUsers";
            btnUsers.Padding = new Padding(10, 0, 0, 0);
            btnUsers.Size = new Size(265, 52);
            btnUsers.TabIndex = 8;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(12, 11);
            label3.Name = "label3";
            label3.Padding = new Padding(15, 8, 10, 5);
            label3.Size = new Size(35, 28);
            label3.TabIndex = 7;
            label3.Text = " ";
            // 
            // btnInventory
            // 
            btnInventory.BackColor = Color.FromArgb(17, 17, 17);
            btnInventory.FlatAppearance.BorderSize = 0;
            btnInventory.FlatAppearance.MouseDownBackColor = Color.FromArgb(51, 51, 51);
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInventory.ForeColor = Color.FromArgb(255, 36, 0);
            btnInventory.Image = (Image)resources.GetObject("btnInventory.Image");
            btnInventory.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventory.Location = new Point(-3, 201);
            btnInventory.Name = "btnInventory";
            btnInventory.Padding = new Padding(10, 0, 0, 0);
            btnInventory.Size = new Size(265, 52);
            btnInventory.TabIndex = 4;
            btnInventory.Text = "Inventory";
            btnInventory.UseVisualStyleBackColor = false;
            btnInventory.Click += btnInventory_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(17, 17, 17);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(51, 51, 51);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.FromArgb(255, 36, 0);
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(-3, 143);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(10, 0, 0, 0);
            btnDashboard.Size = new Size(265, 52);
            btnDashboard.TabIndex = 3;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(17, 17, 17);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(51, 51, 51);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.FromArgb(255, 36, 0);
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(-3, 622);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(10, 0, 0, 0);
            btnLogout.Size = new Size(265, 52);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.FromArgb(17, 17, 17);
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatAppearance.MouseDownBackColor = Color.FromArgb(51, 51, 51);
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHistory.ForeColor = Color.FromArgb(255, 36, 0);
            btnHistory.Image = (Image)resources.GetObject("btnHistory.Image");
            btnHistory.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistory.Location = new Point(-3, 259);
            btnHistory.Name = "btnHistory";
            btnHistory.Padding = new Padding(10, 0, 0, 0);
            btnHistory.Size = new Size(265, 52);
            btnHistory.TabIndex = 5;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += btnHistory_Click;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // pnlContainer
            // 
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(265, 52);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(847, 628);
            pnlContainer.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(17, 17, 17);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblHeader);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(265, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(30, 15, 15, 0);
            panel1.Size = new Size(847, 52);
            panel1.TabIndex = 5;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.AutoSize = true;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(805, 11);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(10, 5, 10, 5);
            btnExit.Size = new Size(30, 25);
            btnExit.TabIndex = 8;
            btnExit.Text = " ";
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(1441, 30);
            label1.Name = "label1";
            label1.Padding = new Padding(10, 5, 10, 5);
            label1.Size = new Size(20, 25);
            label1.TabIndex = 4;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.FromArgb(255, 36, 0);
            lblHeader.Location = new Point(33, 15);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(103, 21);
            lblHeader.TabIndex = 2;
            lblHeader.Text = "DASHBOARD";
            lblHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 34);
            ClientSize = new Size(1112, 680);
            Controls.Add(pnlContainer);
            Controls.Add(panel1);
            Controls.Add(pnlSidebar);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlSidebar;
        private System.Windows.Forms.Timer sidebarTransition;
        private Button btnDashboard;
        private Button btnInventory;
        private Button btnHistory;
        private Button btnLogout;
        private Panel pnlContainer;
        private Label label3;
        private Panel panel1;
        private Label label1;
        private Label lblHeader;
        private Label btnExit;
        public Button btnUsers;
    }
}
