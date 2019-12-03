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
    public partial class Form6 : Form
    {
        private int selectedRowIndex;
        private string client_id;
        private string client_name;
        private string client_age;
        private string client_rank;
        private string client_job;
        private string client_money;

        Form5 mainForm;

        private void Form6_Load(object sender, EventArgs e)
        {
            if (Owner != null)
            {
                mainForm = Owner as Form5;
            }

            tbID.Text = client_id;
            tbName.Text = client_name;
            tbAge.Text = client_age;
            tbRank.Text = client_rank;
            tbJob.Text = client_job;
            tbMoney.Text = client_money;
        }

        public Form6()
        {
            InitializeComponent();
        }

        public Form6(int selectedRowIndex, string v1, string v2, string v3, string v4, string v5, string v6)
        {
            InitializeComponent();
            this.selectedRowIndex = selectedRowIndex;
            this.client_id = v1;
            this.client_name = v2;
            this.client_age = v3;
            this.client_rank = v4;
            this.client_job = v5;
            this.client_money = v6;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (tbID.Text != "" && tbName.Text != "" && tbAge.Text != "" && tbRank.Text != "" && tbJob.Text != "" && tbMoney.Text != "")
            {
                string[] rowDatas = {
                tbID.Text,
                tbName.Text,
                tbAge.Text,
                tbRank.Text,
                tbJob.Text,
                tbMoney.Text
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
            tbMoney.Clear();
        }


    }
}
