using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaiKiemTra01.DAL;

namespace BaiKiemTra01
{
    public partial class Form1 : Form
    {
        string pathDataNhom;
        string pathDataChitiet;
        private List<ChiTietdb> chitietdanhba;
        private List<Nhomdb> nhomdanhba;
        public Form1()
        {
            InitializeComponent();
            pathDataNhom = Application.StartupPath + @"\Data\NhomDanhBa.data";
            pathDataChitiet = Application.StartupPath + @"\Data\ChiTietDanhBa.data";
            dg1.AutoGenerateColumns = false;

            nhomdanhba = Nhomdb.GetListFromFile(pathDataNhom);
            bds1.DataSource = nhomdanhba;
            dg1.DataSource = bds1;
        }

        private void dg1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var nhomdanhba = (Nhomdb)bds1.Current;
            chitietdanhba = ChiTietdb.getListFromFile(pathDataChitiet, nhomdanhba.maNhom);
            dg2.AutoGenerateColumns = false;
            bds2.DataSource = chitietdanhba;
            dg2.DataSource = bds2;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            var nhom = (Nhomdb)bds1.Current;
            bds1.Remove(nhom);
            bds2.Clear();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            var ll = (ChiTietdb)bds2.Current;
            bds2.Remove(ll);
        }
    }
}
