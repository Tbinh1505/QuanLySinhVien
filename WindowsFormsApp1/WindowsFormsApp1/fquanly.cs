using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class fquanly : Form
    {
        string gender; // giới tính
        SqlConnection conn;
        SqlCommand cmd;
        string text;

        public fquanly()
        {
            InitializeComponent();
        }


        //kết nối csdl
        public void connect()
        {
            try
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-0FRAEUGA\SQLEXPRESS;Initial Catalog=FPL_DaoTao2;Integrated Security=True");
                conn.Open();
            }
            catch (Exception)
            {

                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
                
        }

        //xóa toàn bộ thông tin của bảng
        public void reset()
        {
            txtMasv.Text = "";
            txtHoTen.Text = "";
            txtEmail.Text = "";
            txtSoDt.Text = "";
            txtDiaChi.Text = "";
            text = "";
            pictureBox1.ImageLocation = "";

        }


        public void getData()
        {
            string sqlSelect = "select * from STUDENTS";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            dataGridView1.DataSource = dt;
        }


        private void fquanly_Load(object sender, EventArgs e)
        {
            connect();
            getData();//kết nối vào bảng 
        }

        //thêm sinh viên vào csdl
        private void button1_Click(object sender, EventArgs e)
        {
            if (rdNam.Checked == true)
            {
                gender = "Nam";
            }
            else
            {
                gender = "Nữ";
            }
            string sqlThem = "insert into STUDENTS (MASV,HOTEN,EMAIL,SODT,GIOITINH,DIACHI,HINH) values ('"+txtMasv.Text+"',N'"+txtHoTen.Text+"','"+txtEmail.Text+"','"+txtSoDt.Text+"',N'"+gender+"',N'"+txtDiaChi.Text+"','"+text+"')";
            SqlCommand cmd = new SqlCommand(sqlThem, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Thêm Thành công sinh viên!");
            getData();
            reset();
        }

        //khi ấn vào datagridview thì sẽ hiện thông tin sinh viên trên bảng
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }



        //xóa sinh viên
        private void button3_Click(object sender, EventArgs e)
        {

          
            cmd = conn.CreateCommand();
            cmd.CommandText = " exec del_sv @masv = '" + txtMasv.Text+"'";
            MessageBox.Show("Xóa thành công sinh viên: '"+txtHoTen.Text+"'");
            cmd.ExecuteNonQuery();
            getData();
            reset();
        }

        //sửa sinh viên (update sinh viên)
        private void button4_Click(object sender, EventArgs e)
        {
           fdiem f = new fdiem();
           this.Hide();
           f.ShowDialog();
            this.Show();

        }

        private void fquanly_Click(object sender, EventArgs e)
        {
            reset();
        }


        private void pictureBox1_Click(object sender, EventArgs e) // hình ảnh
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "File anh|*.jpg; *.gif; *.png; |All File|*.*;";
            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                text = openFileDialog.FileName; // lay dung ten file anh khong lay duong dan
            }

            pictureBox1.ImageLocation = text;   
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rdNam.Checked == true)
            {
                gender = "Nam";
            }
            else
            {
                gender = "Nữ";
            }
            cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE STUDENTS set HOTEN =N'" + txtHoTen.Text + "',EMAIL='" + txtEmail.Text + "',SODT='" + txtSoDt.Text + "',GIOITINH=N'" + gender + "',DIACHI=N'" + txtDiaChi.Text + "',HINH='" + text+ "' WHERE MASV = '" + txtMasv.Text + "'";
            cmd.ExecuteNonQuery();
            getData();
            MessageBox.Show("Update sinh viên thành công!");

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtMasv.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtHoTen.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtSoDt.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "Nam")
            {
                rdNam.Checked = true;
            }
            else
            {
                rdNu.Checked = true;
            }
            txtDiaChi.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            pictureBox1.ImageLocation = text;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
