using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGaffney206Lab3
{
    public partial class frmDataMenu : Form
    {
        frmMain mainMenu;

        public frmDataMenu(frmMain mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
        }

        private void statesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.statesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.statesDataSet);

        }

        private void frmDataMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'statesDataSet.States' table. You can move, or remove it, as needed.
            this.statesTableAdapter.Fill(this.statesDataSet.States);

        }

        private void btnReturn_Click(object sender, EventArgs e) // Closes current form and shows the main menu
        {
            this.Close();
            mainMenu.Show();
        }
    }
}
