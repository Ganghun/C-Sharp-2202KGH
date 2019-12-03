using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProject
{
    public partial class Form4 : Form
    {
        private int selectedRowIndex;
        private string client_id;
        private string client_name;
        private string client_age;
        private string client_rank;
        private string client_job;

        Form3 mainForm;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (Owner != null)
            {
                mainForm = Owner as Form3;
            }

            tbID.Text = client_id;
            tbName.Text = client_name;
            tbAge.Text = client_age;
            tbRank.Text = client_rank;
            tbJob.Text = client_job;
        }

        public Form4(int selectedRowIndex, string v1, string v2, string v3, string v4, string v5)
        {
            InitializeComponent();
            this.selectedRowIndex = selectedRowIndex;
            this.client_id = v1;
            this.client_name = v2;
            this.client_age = v3;
            this.client_rank = v4;
            this.client_job = v5;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (tbID.Text != "" && tbName.Text != "" && tbAge.Text != "" && tbRank.Text != "" && tbJob.Text != "")
            {
                string[] rowDatas = {
                tbID.Text,
                tbName.Text,
                tbAge.Text,
                tbRank.Text,
                tbJob.Text,
                };

                mainForm.UpdateRow(rowDatas);
                this.Close();
            }
            else
            {
                MessageBox.Show("모든 정보를 입력하세요.");
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            mainForm.DeleteRow(client_id);
            this.Close();
        }

        private void cleaner_Click(object sender, EventArgs e)
        {
            tbID.Clear();
            tbName.Clear();
            tbAge.Clear();
            tbRank.Clear();
            tbJob.Clear();
        }


    }
}
