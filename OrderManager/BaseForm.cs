using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManager
{

    
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            //something
            InitializeComponent();
        }
        private bool isShowMenu;
        private void BaseForm_Load(object sender, EventArgs e)
        {
            pnlBase.Controls.Clear();
            addNewPanel(new ContentPanel.Product());
        }


        private void addNewPanel(UserControl newPanel)
        {
            newPanel.Dock = DockStyle.Fill;
            pnlBase.Controls.Add(newPanel); 
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlBase.Controls.Clear();
        }

        private void btnProdcut_Click(object sender, EventArgs e)
        {
            pnlBase.Controls.Clear();
            addNewPanel(new ContentPanel.Product());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            pnlBase.Controls.Clear();
            addNewPanel(new ContentPanel.Customer());
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            pnlBase.Controls.Clear();
            addNewPanel(new ContentPanel.Order());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(fPnlMenu.Width > 0)
            {
                isShowMenu = false;
                timer.Start();
            }
            else
            {
                fPnlMenu.Show();
                isShowMenu = true;
                timer.Start();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(isShowMenu)
            {
                if (fPnlMenu.Width >= fPnlMenu.MaximumSize.Width)
                    timer.Stop();
                fPnlMenu.Width += 50;
            }
            else
            {
                if(fPnlMenu.Width <= 0)
                {
                    timer.Stop();
                }
                fPnlMenu.Width -= 50;
            }
        }
    }
}
