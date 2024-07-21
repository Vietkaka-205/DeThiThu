using DeThiThu_C_2.Models;
using System.Data;
using System.Web;

namespace DeThiThu_C_2
{
    public partial class Form1 : Form
    {
        private DeThiThu_C2Context dbcontext = new DeThiThu_C2Context();
        private DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            string thongDiep = txtThongDiep.Text;
            MessageBox.Show(thongDiep);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                cbbLuaChon.Items.Add(i);

            }
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "C:\\Users\\kim dong kiem\\Desktop\\data.txt";
                StreamReader sr = new StreamReader(path);
                string noiDung = sr.ReadToEnd();
                txtcau2.Text = noiDung;
                sr.Close();
                MessageBox.Show("Thanh cong");

            }
            catch (Exception)
            {
                MessageBox.Show("That Bai");

            }

        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "C:\\Users\\kim dong kiem\\Desktop\\data.txt";
                StreamWriter sw = new StreamWriter(path);
                sw.WriteLine(txtcau2.Text);
                sw.Close();
                MessageBox.Show("Thanh Cong");
            }
            catch (Exception)
            {
                MessageBox.Show("That Bai");
            }

        }

        private void btnLoad1_Click(object sender, EventArgs e)
        {
            var sinhVien = dbcontext.Sinhviens.ToList();
            foreach (var sv in sinhVien)
            {               
                DataRow dr = dt.NewRow();               
                dr["Ten"] = sv.Ten;
                dr["Nganh"] = sv.Nganh;
                dr["GioiTinh"] = sv.Gioitinh;
                dt.Rows.Add(dr);
            }
            dgvCau3.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Ten", typeof(string));
            dt.Columns.Add("Nganh", typeof(string));
            dt.Columns.Add("GioiTinh", typeof(bool));
        }

        private void dgvCau3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dongHienTai = dgvCau3.Rows[e.RowIndex];
            var ten = dongHienTai.Cells[0].Value;
            var nganh = dongHienTai.Cells[1].Value;
            var gioiTinh = (bool)dongHienTai.Cells[2].Value;

            txtTen.Text = ten.ToString();
            txtNganh.Text = nganh.ToString();
            if (gioiTinh == true)
            {
                rdoNam.Checked = true;
            }
            else
            {
                rdoNu.Checked = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //txtTen.Text = "";
            //txtNganh.Text = "";
            //rdoNam.Checked = true;

            DialogResult result = MessageBox.Show("Ban co chac chan chon khong?","Xac nhan",MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                txtTen.Text = "";
                txtNganh.Text = "";
                rdoNam.Checked = true;
            }
        }
    }
}
