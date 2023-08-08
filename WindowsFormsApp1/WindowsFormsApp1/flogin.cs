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
using System.Data.Linq;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class flogin : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public flogin()
        {
            InitializeComponent();
        }
       
        private void btnlg_Click(object sender, EventArgs e)
        {

            string loCompare = txttk.Text;
            string loComparep= txtmk.Text;
            var users = db.sp_checkLogin(loCompare,loComparep).FirstOrDefault(x => x.username == loCompare && x.password == loComparep);
            if (users == null )
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
            else
            {
                if (users.role == "1")
                {
                    MessageBox.Show("Login success! Giang viên", "Thông báo");
                    fdiem f = new fdiem();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                if (users.role == "2")
                {
                    MessageBox.Show("Login success! Cán Bộ");
                    fquanly f = new fquanly();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
            }
        


        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn thoát hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb==DialogResult.OK)
            {
                Application.Exit();
            }
        }

    }
}
