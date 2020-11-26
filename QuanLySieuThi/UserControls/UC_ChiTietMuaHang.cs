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
    public partial class UC_ChiTietMuaHang : UserControl
    {
        public UC_ChiTietMuaHang()
        {
            InitializeComponent();
        }

        private void btnThemMatHangMoi_Click(object sender, EventArgs e)
        {
            using(Form_ThemMoiSanPham tmsp = new Form_ThemMoiSanPham())
            {
                tmsp.ShowDialog();
            }
        }

        private void btnThemNSX_Click(object sender, EventArgs e)
        {
            using(Form_ThemNSX nsx = new Form_ThemNSX())
            {
                nsx.ShowDialog();
            }
        }
    }
}
