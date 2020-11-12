﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frmQLSV : Form
    {
        public frmQLSV()
        {
            InitializeComponent();
        }

        private void frmQLSV_Load(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.MdiParent = this;
            about.Show();
        }

        private void toolStripButtonSinhVien_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "frmSinhVien")
                {
                    f.Activate();
                    return;
                }
            frmSinhVien sv = new frmSinhVien();
            sv.MdiParent = this;
            sv.Show();
        }

        private void toolStripButtonKhoa_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "frmKhoa")
                {
                    f.Activate();
                    return;
                }
            frmKhoa sv = new frmKhoa();
            sv.MdiParent = this;
            sv.Show();
        }

        private void toolStripButtonMonHoc_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "frmMonHoc")
                {
                    f.Activate();
                    return;
                }
            frmMonHoc sv = new frmMonHoc();
            sv.MdiParent = this;
            sv.Show();
        }
        private void toolStripButtonNhapDiem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "frmNhapDiem")
                {
                    f.Activate();
                    return;
                }
            frmNhapDiem sv = new frmNhapDiem();
            sv.MdiParent = this;
            sv.Show();
        }

        private void toolStripButtonXemDiem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "frmXemDiem")
                {
                    f.Activate();
                    return;
                }
            frmXemDiem sv = new frmXemDiem();
            sv.MdiParent = this;
            sv.Show();
        }

        private void toolStripButtonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButtonThongKeKhoa_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "frmThongKe")
                {
                    f.Activate();
                    return;
                }
            frmThongKe sv = new frmThongKe();
            sv.MdiParent = this;
            sv.Show();
        }
    }
}
