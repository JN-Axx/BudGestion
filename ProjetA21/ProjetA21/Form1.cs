using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ProjetA21
{
    public partial class frmBdgMois : Form
    {
        public frmBdgMois()
        {
            InitializeComponent();
        }

     

        private void frmBdgMois_Load_1(object sender, EventArgs e)
        {
            DateTime date1 = new DateTime(2010, 3, 14, 2, 30, 0, DateTimeKind.Local);
            Console.WriteLine("Invalid time: {0}",
                              TimeZoneInfo.Local.IsInvalidTime(date1));
            DateTime utcDate1 = date1.ToUniversalTime();
            DateTime date2 = utcDate1.ToLocalTime();

            MessageBox.Show(date2.ToString());

        }
    }
}
