using QuanLySieuThi.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThi.Forms
{
    public partial class Form_Home : Form
    {
        int w;
        bool check;
        public Form_Home()
        {
            InitializeComponent();
            timerTime.Start();
            w = panelLeft.Width;
            check = false;

            //Hiện trang chủ
            UC_TrangChu uctc = new UC_TrangChu();
            addControlsToPanel(uctc);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (check)
            {
                panelLeft.Width = panelLeft.Width + 50;
                if (panelLeft.Width >= w)
                {
                    timer1.Stop();
                    check = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 50;
                if(panelLeft.Width <= 65)
                {
                    timer1.Stop();
                    check = true;
                    this.Refresh();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void movesidePannel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void addControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            movesidePannel(btnTrangChu);
            UC_TrangChu uctc = new UC_TrangChu(); 
            addControlsToPanel(uctc);
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            movesidePannel(btnBanHang);
            UC_BanHang ucbh = new UC_BanHang();
            addControlsToPanel(ucbh);
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            movesidePannel(btnNhapHang);
            UC_ChiTietMuaHang ctmh = new UC_ChiTietMuaHang();
            addControlsToPanel(ctmh);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            movesidePannel(btnKhachHang);
        }

        private void btnNguoiDung_Click(object sender, EventArgs e)
        {
            movesidePannel(btnNguoiDung);
            Uc_NguoiDung nd = new Uc_NguoiDung();
            addControlsToPanel(nd);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            movesidePannel(btnThongKe);
            UC_ThongKe tk = new UC_ThongKe();
            addControlsToPanel(tk);
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            movesidePannel(btnCaiDat);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblTime.Text = dt.ToString("HH:MM:ss");
        }
    }
}
