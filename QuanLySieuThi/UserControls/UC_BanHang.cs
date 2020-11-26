using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySieuThi.Forms;

namespace QuanLySieuThi.UserControls
{
    public partial class UC_BanHang : UserControl
    {
        public UC_BanHang()
        {
            InitializeComponent();
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            using (Form_HoanThanhOrder hto = new Form_HoanThanhOrder())
            {
                hto.ShowDialog();
            }
        }
    }
}
