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
    public partial class DatePicker : Form
    {
        public DatePicker()
        {
            InitializeComponent();
        }

        public DateTime date = new DateTime();  

        private void DatePicker_Load(object sender, EventArgs e)
        {
            monthCalendar1.SetDate(date);
        }

       

        private void monthCalendar1_DateSelected_1(object sender, DateRangeEventArgs e)
        {
            date = monthCalendar1.SelectionRange.Start;
            Close();
        }
    }
}
