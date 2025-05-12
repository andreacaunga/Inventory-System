using Inventory_System.User_Controls;

namespace Inventory_System
{
    public partial class frmMain : Form
    {
        Dashboard dashboard = new Dashboard();
        Inventory inventory = new Inventory();
        History history = new History();
        frmLogin frmlogin = new frmLogin();

        public frmMain()
        {
            InitializeComponent();
            pnlSidebar.Size = pnlSidebar.MinimumSize;

            dashboard.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(dashboard);
        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                pnlSidebar.Width -= 10; // speed
                if (pnlSidebar.Width == 64)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                pnlSidebar.Width += 10; // speed
                if (pnlSidebar.Width == 265)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void pnlSidebar_MouseEnter(object sender, EventArgs e)
        {
            sidebarExpand = false;
            sidebarTransition.Start();

            //if (inventory.pnlItem.Visible)
            //{
            //    inventory.pnlItem.Visible = false;
            //}
        }

        private void pnlSidebar_MouseLeave(object sender, EventArgs e)
        {
            if (!pnlSidebar.ClientRectangle.Contains(pnlSidebar.PointToClient(Cursor.Position)))
            {
                sidebarExpand = true;
                sidebarTransition.Start();

                //if (!inventory.pnlItem.Visible)
                //{
                //    inventory.pnlItem.Visible = true;
                //}
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //Dashboard dashboard = new Dashboard();
            dashboard.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(dashboard);
            dashboard.BringToFront();

            lblHeader.Text = "DASHBOARD";
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            //Inventory inventory = new Inventory();
            inventory.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(inventory);
            inventory.BringToFront();

            lblHeader.Text = "INVENTORY";
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            //History history = new History();
            history.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(history);
            history.BringToFront();

            lblHeader.Text = "HISTORY";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmlogin.Show();
            this.Close();
        }
    }
}
