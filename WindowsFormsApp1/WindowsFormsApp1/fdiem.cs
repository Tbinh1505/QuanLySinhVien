using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class fdiem : Form
    {
        //quản lý điểm login cho giảng viên
        SqlConnection conn;
        SqlCommand sqlCommand;
        DataTable dt = new DataTable();
        public fdiem()
        {
            InitializeComponent();
        }


        // kết nối csdl
        public void connect()
        {
            try
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-0FRAEUGA\SQLEXPRESS;Initial Catalog=FPL_DaoTao2;Integrated Security=True");
                conn.Open();
            }
            catch (Exception)
            {

                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //lấy dữ liệu ở bảng csdl để đổ vào dta
        public void getData()
        {
            string sqlSelect = "select st.MASV,st.HOTEN,gd.TiengAnh,gd.TinHoc,gd.GDTC,SUM(gd.Tienganh+gd.TinHoc+gd.GDTC)/3 as [Điểm TB] from Students st inner join Grade gd on st.MASV=gd.MASV group by st.MASV,st.HOTEN,gd.TiengAnh,gd.TinHoc,gd.GDTC ";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            dta.DataSource = dt;
            //pos = 0;

            //displaytext(pos);
        }


        // làm mới lại dữ liệu ở bảng thêm điểm
        public void reset()
        {
            txtMasv.Text = "";
            txtHoTen.Text = "";
            txtDiemTiengAnh.Text = "";
            txtDiemTinHoc.Text = "";
            txtDiemTC.Text = "";
            txtDiemTB.Text = "";

        }
        private void fdiem_Load(object sender, EventArgs e)
        {
            
            connect();
            getData();//kết nối vào bảng 

        }


        //nhập điểm cho sinh viên đã có trong bảng students bên csdl
        private void btnNew_Click(object sender, EventArgs e)
        {
            int anh = Convert.ToInt32(txtDiemTiengAnh.Text);
            int tin = Convert.ToInt32(txtDiemTinHoc.Text);
            int tc = Convert.ToInt32(txtDiemTC.Text);
  
            if (anh >= 0 && anh <= 10 || tin >= 0 && tin <= 10 || tc >= 0 && tc <= 10)
            {
                string sqlThem = "insert into Grade (MASV,Tienganh,Tinhoc,GDTC) values ('" + txtMasv.Text + "','" + txtDiemTiengAnh.Text + "','" + txtDiemTinHoc.Text + "','" + txtDiemTC.Text + "')";
                double diemTB = (anh + tin + tc) / 3;
                //diemTB = Convert.ToDouble(txtDiemTB.Text);
                SqlCommand cmd = new SqlCommand(sqlThem, conn);
                cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Điểm không được > 10", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            MessageBox.Show("Nhập điểm thành công!");
            getData();
            reset();
          

        }

        //tìm điểm của sinh viên
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select STUDENTS.MASV,STUDENTS.Hoten,Grade.Tienganh,Grade.Tinhoc,Grade.GDTC from STUDENTS inner join Grade on STUDENTS.MASV = Grade.MASV where STUDENTS.MASV = '" + txtMsvSearch.Text + "' ";



            //"select Grade.Tienganh,Tinhoc,GDTC,students.MASV,students.Hoten from Grade inner join STUDENTS on Grade.MASV = STUDENTS.MASV where STUDENTS.MASV = '" + txtMsvSearch.Text + "' ";


            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            dta.DataSource = dt;
            //reset();
        }


        // xóa sinh viên theo mã sinh viên khi ấn vào dữ liệu trong dta
        private void btnDelete_Click(object sender, EventArgs e)
        {
             sqlCommand = conn.CreateCommand();
            string sqlThem = "DELETE from Grade where MASV = '"+txtMasv.Text+"'";
            SqlCommand cmd = new SqlCommand(sqlThem, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa điểm của sinh viên thành công!");
            getData();
            reset();
        }


        //hiện thông tin của sinh viên trên bảng khi ấn vào dta
        private void dta_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dta.CurrentRow.Index;
            txtMasv.Text = dta.Rows[i].Cells["MASV"].Value.ToString();
            txtHoTen.Text = dta.Rows[i].Cells["HOTEN"].Value.ToString();
            txtDiemTiengAnh.Text = dta.Rows[i].Cells["TiengAnh"].Value.ToString();
            txtDiemTinHoc.Text = dta.Rows[i].Cells["TinHoc"].Value.ToString();
            txtDiemTC.Text = dta.Rows[i].Cells["GDTC"].Value.ToString();
            txtDiemTB.Text = dta.Rows[i].Cells[6].Value.ToString();

        }


        //update điểm sinh viên
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int anh = Convert.ToInt32(txtDiemTiengAnh.Text);
            int tin = Convert.ToInt32(txtDiemTinHoc.Text);
            int tc = Convert.ToInt32(txtDiemTC.Text);
            sqlCommand = conn.CreateCommand();
            if (anh >= 0 && anh <= 10 || tin >= 0 && tin <= 10 || tc >= 0 && tc <= 10)
            {
                double diemTB = (anh + tin + tc) / 3;
                diemTB = Convert.ToDouble(txtDiemTB.Text);
                sqlCommand.CommandText = "UPDATE Grade set Tienganh='" + txtDiemTiengAnh.Text + "',Tinhoc='" + txtDiemTinHoc.Text + "',GDTC='" + txtDiemTC.Text + "' WHERE MASV = '" + txtMasv.Text + "'";
                sqlCommand.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Điểm không được > 10,Kiểm Tra lại!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            MessageBox.Show("Sửa điểm của sinh viên thành công!");
            getData();
        }

        private void fdiem_MouseClick(object sender, MouseEventArgs e)
        {
            reset();
        }
    }
}
