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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection conn;
        MySqlDataAdapter dataAdapter;
        DataSet dataSet;
        int selectedRowIndex;

        private void Form1_Load(object sender, EventArgs e)
        {
            string connStr = "server=localhost;port=3306;database=wfdb;uid=root;pwd=korr3698";
            conn = new MySqlConnection(connStr);
            dataAdapter = new MySqlDataAdapter("SELECT * FROM 고객", conn);
            dataSet = new DataSet();

            onTable.Text = "고객";
            dataAdapter.Fill(dataSet, "고객");
            dataGridView1.DataSource = dataSet.Tables["고객"];
        }

        internal void UpdateRow(string[] rowDatas)
        {
            string sql = "UPDATE 고객 SET 고객아이디=@고객아이디, 고객이름=@고객이름, 나이=@나이, 등급=@등급, 직업=@직업, 적립금=@적립금 WHERE 고객아이디=@고객아이디";
            dataAdapter.UpdateCommand = new MySqlCommand(sql, conn);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@고객아이디", rowDatas[0]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@고객이름", rowDatas[1]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@나이", rowDatas[2]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@등급", rowDatas[3]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@직업", rowDatas[4]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@적립금", rowDatas[5]);

            try
            {
                conn.Open();
                dataAdapter.UpdateCommand.ExecuteNonQuery();

                dataSet.Clear();  // 이전 데이터 지우기
                dataAdapter.Fill(dataSet, "고객");
                dataGridView1.DataSource = dataSet.Tables["고객"];
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
            string sql = "DELETE FROM 고객 WHERE 고객아이디=@고객아이디";
            dataAdapter.DeleteCommand = new MySqlCommand(sql, conn);
            dataAdapter.DeleteCommand.Parameters.AddWithValue("@고객아이디", client_id);

            try
            {
                conn.Open();
                dataAdapter.DeleteCommand.ExecuteNonQuery();

                dataSet.Clear();
                dataAdapter.Fill(dataSet, "고객");
                dataGridView1.DataSource = dataSet.Tables["고객"];
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
            string sql = "SELECT * FROM 고객 WHERE ";

            #region 검색 조건 설정
            string[] conditions = new string[6];
            conditions[0] = (tbID.Text != "") ? "고객아이디 = @고객아이디" : null;
            conditions[1] = (tbName.Text != "") ? "고객이름 = @고객이름" : null;
            conditions[2] = (tbAge.Text != "") ? "나이= @나이" : null;
            conditions[3] = (tbRank.Text != "") ? "등급 = @등급" : null;
            conditions[4] = (tbJob.Text != "") ? "직업 = @직업" : null;
            conditions[5] = (tbMoney.Text != "") ? "적립금 = @적립금" : null;

            if(tbID.Text != "" || tbAge.Text != "" || tbName.Text != "" || tbRank.Text != "" || tbJob.Text != "" || tbMoney.Text != "")
            {
                bool isFirst = true;
                for (int i = 0; i < conditions.Length; i++)
                {
                    if(conditions[i] != null)
                    {
                        if(isFirst)
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
                sql = "SELECT * FROM 고객";
            }
            #endregion

            dataAdapter.SelectCommand = new MySqlCommand(sql, conn);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@고객아이디", tbID.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@고객이름", tbName.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@나이", tbAge.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@등급", tbRank.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@직업", tbJob.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@적립금", tbMoney.Text);

            try
            {
                conn.Open();
                dataSet.Clear();
                if (dataAdapter.Fill(dataSet, "고객") > 0)
                    dataGridView1.DataSource = dataSet.Tables["고객"];
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
            string sql = "INSERT INTO 고객(고객아이디, 고객이름, 나이, 등급, 직업, 적립금)" +
                " VALUES(";

            string[] conditions = new string[6];
            conditions[0] = (tbID.Text != "") ? "@고객아이디" : null;
            conditions[1] = (tbName.Text != "") ? "@고객이름" : null;
            conditions[2] = (tbAge.Text != "") ? "@나이" : null;
            conditions[3] = (tbRank.Text != "") ? "@등급" : null;
            conditions[4] = (tbJob.Text != "") ? "@직업" : null;
            conditions[5] = (tbMoney.Text != "") ? "@적립금" : null;

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
                        }else if(i == conditions.Length-1)
                        {
                            sql += "," + conditions[i]+")";
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


            testcode.Text = sql;

            dataAdapter.InsertCommand = new MySqlCommand(sql, conn);
            dataAdapter.InsertCommand.Parameters.AddWithValue("@고객아이디", tbID.Text);
            dataAdapter.InsertCommand.Parameters.AddWithValue("@고객이름", tbName.Text);
            dataAdapter.InsertCommand.Parameters.AddWithValue("@나이", tbAge.Text);
            dataAdapter.InsertCommand.Parameters.AddWithValue("@등급", tbRank.Text);
            dataAdapter.InsertCommand.Parameters.AddWithValue("@직업", tbJob.Text);
            dataAdapter.InsertCommand.Parameters.AddWithValue("@적립금", tbMoney.Text);

            try
            {
                conn.Open();
                dataAdapter.InsertCommand.ExecuteNonQuery();

                dataSet.Clear();                                        // 이전 데이터 지우기
                dataAdapter.Fill(dataSet, "고객");                      // DB -> DataSet
                dataGridView1.DataSource = dataSet.Tables["고객"];      // dataGridView에 테이블 표시                                     // 텍스트 박스 내용 지우기
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
            Form2 Dig = new Form2(
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

        private void FormAdapter_Click(object sender, EventArgs e)
        {
            Form3 Dig = new Form3();

            Dig.Owner = this;               // 새로운 폼의 부모가 Form1 인스턴스임을 지정
            Dig.ShowDialog();               // 폼 띄우기(Modal)
            Dig.Dispose();
        }
    }
}
