using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo_List
{
    public partial class UserControlDays : UserControl
    {
        Panel selectedPanel;

        public UserControlDays()
        {
            InitializeComponent();
            selectedPanel = null;
        }

        public void Days(int numDay)
        {
            lDays.Text = numDay + "";
        }

        // Клик на панель
        private void UserControlDays_Click(object sender, EventArgs e)
        {

            //frmMain parentForm = frmMain.Instance;

            
            //parentForm.ClearDays();
            //parentForm.DisplayDays();

            this.BackColor = Color.FromArgb(164, 164, 139);
            lDays.ForeColor = Color.FromArgb(173, 45, 89);
        }

        // Клик на текст
        private void lDays_Click(object sender, EventArgs e)
        {
            UserControlDays_Click((object)this, new EventArgs());
        }
    }
}
