using MySql.Data.MySqlClient;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        MySqlConnection conn;
        MySqlDataAdapter dataAdapter;
        DataSet dataSet;
        int selectedRowIndex;

        private void Form5_Load(object sender, EventArgs e)
        {
            string connStr = "server=localhost;port=3306;database=wfdb;uid=root;pwd=korr3698";
            conn = new MySqlConnection(connStr);
            dataAdapter = new MySqlDataAdapter("SELECT * FROM 주문", conn);
            dataSet = new DataSet();

            onTable.Text = "주문";
            dataAdapter.Fill(dataSet, "주문");
            dataGridView1.DataSource = dataSet.Tables["주문"];
        }

        internal void UpdateRow(string[] rowDatas)
        {
            string sql = "UPDATE 주문 SET 주문번호=@주문번호, 주문고객=@주문고객, 주문제품=@주문제품, 수량=@수량, 배송지=@배송지, 주문일자=@주문일자";
            dataAdapter.UpdateCommand = new MySqlCommand(sql, conn);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@주문번호", rowDatas[0]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@주문고객", rowDatas[1]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@주문제품", rowDatas[2]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@수량", rowDatas[3]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@배송지", rowDatas[4]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@주문일자", rowDatas[5]);

            try
            {
                conn.Open();
                dataAdapter.UpdateCommand.ExecuteNonQuery();

                dataSet.Clear();  // 이전 데이터 지우기
                dataAdapter.Fill(dataSet, "주문");
                dataGridView1.DataSource = dataSet.Tables["주문"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        internal void DeleteRow(string client_id)
        {
            string sql = "DELETE FROM 주문 WHERE 주문번호=@주문번호";
            dataAdapter.DeleteCommand = new MySqlCommand(sql, conn);
            dataAdapter.DeleteCommand.Parameters.AddWithValue("@주문번호", client_id);

            try
            {
                conn.Open();
                dataAdapter.DeleteCommand.ExecuteNonQuery();

                dataSet.Clear();
                dataAdapter.Fill(dataSet, "주문");
                dataGridView1.DataSource = dataSet.Tables["주문"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM 주문 WHERE ";

            #region 검색 조건 설정
            string[] conditions = new string[6];
            conditions[0] = (tbID.Text != "") ? "주문번호 = @주문번호" : null;
            conditions[1] = (tbName.Text != "") ? "주문고객 = @주문고객" : null;
            conditions[2] = (tbAge.Text != "") ? "주문제품= @주문제품" : null;
            conditions[3] = (tbRank.Text != "") ? "수량 = @수량" : null;
            conditions[4] = (tbJob.Text != "") ? "배송지 = @배송지" : null;
            conditions[5] = (tbMoney.Text != "") ? "주문일자 = @주문일자" : null;

            if (tbID.Text != "" || tbAge.Text != "" || tbName.Text != "" || tbRank.Text != "" || tbJob.Text != "" || tbMoney.Text != "")
            {
                bool isFirst = true;
                for (int i = 0; i < conditions.Length; i++)
                {
                    if (conditions[i] != null)
                    {
                        if (isFirst)
                        {
                            sql += conditions[i];
                        }
                        else
                        {
                            sql += " and " + conditions[i];
                        }
                    }
                }
            }
            else
            {
                sql = "SELECT * FROM 주문";
            }
            #endregion

            dataAdapter.SelectCommand = new MySqlCommand(sql, conn);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@주문번호", tbID.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@주문고객", tbName.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@주문제품", tbAge.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@수량", tbRank.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@배송지", tbJob.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@주문일자", tbMoney.Text);

            try
            {
                conn.Open();
                dataSet.Clear();
                if (dataAdapter.Fill(dataSet, "주문") > 0)
                    dataGridView1.DataSource = dataSet.Tables["주문"];
                else
                    MessageBox.Show("찾는 데이터가 없습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO 주문(주문번호, 주문고객, 주문제품, 수량, 배송지, 주문일자)" +
                " VALUES(";

            string[] conditions = new string[6];
            conditions[0] = (tbID.Text != "") ? "@주문번호" : null;
            conditions[1] = (tbName.Text != "") ? "@주문고객" : null;
            conditions[2] = (tbAge.Text != "") ? "@주문제품" : null;
            conditions[3] = (tbRank.Text != "") ? "@수량" : null;
            conditions[4] = (tbJob.Text != "") ? "@배송지" : null;
            conditions[5] = (tbMoney.Text != "") ? "@주문일자" : null;

            if (tbID.Text != "" && tbAge.Text != "" && tbName.Text != "" && tbRank.Text != "" && tbJob.Text != "" && tbMoney.Text != "")
            {
                bool isFirst = true;
                for (int i = 0; i < conditions.Length; i++)
                {
                    if (conditions[i] != null)
                    {
                        if (isFirst)
                        {
                            sql += conditions[i];
                            isFirst = false;
                        }
                        else if (i == conditions.Length - 1)
                        {
                            sql += "," + conditions[i] + ")";
                        }
                        else
                        {
                            sql += ", " + conditions[i];
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("모든 정보를 입력하세요");
            }


 

            dataAdapter.InsertCommand = new MySqlCommand(sql, conn);
            dataAdapter.InsertCommand.Parameters.AddWithValue("@주문번호", tbID.Text);
            dataAdapter.InsertCommand.Parameters.AddWithValue("@주문고객", tbName.Text);
            dataAdapter.InsertCommand.Parameters.AddWithValue("@주문제품", tbAge.Text);
            dataAdapter.InsertCommand.Parameters.AddWithValue("@수량", tbRank.Text);
            dataAdapter.InsertCommand.Parameters.AddWithValue("@배송지", tbJob.Text);
            dataAdapter.InsertCommand.Parameters.AddWithValue("@주문일자", tbMoney.Text);

            try
            {
                conn.Open();
                dataAdapter.InsertCommand.ExecuteNonQuery();

                dataSet.Clear();                                        // 이전 데이터 지우기
                dataAdapter.Fill(dataSet, "주문");                      // DB -> DataSet
                dataGridView1.DataSource = dataSet.Tables["주문"];      // dataGridView에 테이블 표시                                     // 텍스트 박스 내용 지우기
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }


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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRowIndex];

            // 새로운 폼에 선택된 row의 정보를 담아서 생성
            Form6 Dig = new Form6(
                selectedRowIndex,
                row.Cells[0].Value.ToString(),
                row.Cells[1].Value.ToString(),
                row.Cells[2].Value.ToString(),
                row.Cells[3].Value.ToString(),
                row.Cells[4].Value.ToString(),
                row.Cells[5].Value.ToString()
                );

            Dig.Owner = this;               // 새로운 폼의 부모가 Form1 인스턴스임을 지정
            Dig.ShowDialog();               // 폼 띄우기(Modal)
            Dig.Dispose();
        }



    }
}
