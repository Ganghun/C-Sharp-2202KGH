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
    public partial class Form3 : Form
    {
    public Form3()
    {
        InitializeComponent();
    }

    MySqlConnection conn;
    MySqlDataAdapter dataAdapter;
    DataSet dataSet;
    int selectedRowIndex;

    private void Form3_Load(object sender, EventArgs e)
    {
        string connStr = "server=localhost;port=3306;database=wfdb;uid=root;pwd=korr3698";
        conn = new MySqlConnection(connStr);
        dataAdapter = new MySqlDataAdapter("SELECT * FROM 제품", conn);
        dataSet = new DataSet();

        onTable.Text = "제품";
        dataAdapter.Fill(dataSet, "제품");
        dataGridView1.DataSource = dataSet.Tables["제품"];
    }

    internal void UpdateRow(string[] rowDatas)
    {
        string sql = "UPDATE 제품 SET 제품번호=@제품번호, 제품명=@제품명, 재고량=@재고량, 단가=@단가, 제조업체=@제조업체 WHERE 제품번호=@제품번호";
        dataAdapter.UpdateCommand = new MySqlCommand(sql, conn);
        dataAdapter.UpdateCommand.Parameters.AddWithValue("@제품번호", rowDatas[0]);
        dataAdapter.UpdateCommand.Parameters.AddWithValue("@제품명", rowDatas[1]);
        dataAdapter.UpdateCommand.Parameters.AddWithValue("@재고량", rowDatas[2]);
        dataAdapter.UpdateCommand.Parameters.AddWithValue("@단가", rowDatas[3]);
        dataAdapter.UpdateCommand.Parameters.AddWithValue("@제조업체", rowDatas[4]);
        try
        {
            conn.Open();
            dataAdapter.UpdateCommand.ExecuteNonQuery();

            dataSet.Clear();  // 이전 데이터 지우기
            dataAdapter.Fill(dataSet, "제품");
            dataGridView1.DataSource = dataSet.Tables["제품"];
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
        string sql = "DELETE FROM 제품 WHERE 제품번호=@제품번호";
        dataAdapter.DeleteCommand = new MySqlCommand(sql, conn);
        dataAdapter.DeleteCommand.Parameters.AddWithValue("@제품번호", client_id);

        try
        {
            conn.Open();
            dataAdapter.DeleteCommand.ExecuteNonQuery();

            dataSet.Clear();
            dataAdapter.Fill(dataSet, "제품");
            dataGridView1.DataSource = dataSet.Tables["제품"];
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
        string sql = "SELECT * FROM 제품 WHERE ";

        #region 검색 조건 설정
        string[] conditions = new string[5];
        conditions[0] = (tbID.Text != "") ? "제품번호 = @제품번호" : null;
        conditions[1] = (tbName.Text != "") ? "제품명 = @제품명" : null;
        conditions[2] = (tbAge.Text != "") ? "재고량= @재고량" : null;
        conditions[3] = (tbRank.Text != "") ? "단가 = @단가" : null;
        conditions[4] = (tbJob.Text != "") ? "제조업체 = @제조업체" : null;

        if (tbID.Text != "" || tbAge.Text != "" || tbName.Text != "" || tbRank.Text != "" || tbJob.Text != "")
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
            sql = "SELECT * FROM 제품";
        }
        #endregion

        dataAdapter.SelectCommand = new MySqlCommand(sql, conn);
        dataAdapter.SelectCommand.Parameters.AddWithValue("@제품번호", tbID.Text);
        dataAdapter.SelectCommand.Parameters.AddWithValue("@제품명", tbName.Text);
        dataAdapter.SelectCommand.Parameters.AddWithValue("@재고량", tbAge.Text);
        dataAdapter.SelectCommand.Parameters.AddWithValue("@단가", tbRank.Text);
        dataAdapter.SelectCommand.Parameters.AddWithValue("@제조업체", tbJob.Text);

        try
        {
            conn.Open();
            dataSet.Clear();
            if (dataAdapter.Fill(dataSet, "제품") > 0)
                dataGridView1.DataSource = dataSet.Tables["제품"];
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
        string sql = "INSERT INTO 고객(제품번호, 제품명, 재고량, 단가, 제조업체)" +
            " VALUES(";

        string[] conditions = new string[5];
        conditions[0] = (tbID.Text != "") ? "@제품번호" : null;
        conditions[1] = (tbName.Text != "") ? "@제품명" : null;
        conditions[2] = (tbAge.Text != "") ? "@재고량" : null;
        conditions[3] = (tbRank.Text != "") ? "@단가" : null;
        conditions[4] = (tbJob.Text != "") ? "@제조업체" : null;

        if (tbID.Text != "" && tbAge.Text != "" && tbName.Text != "" && tbRank.Text != "" && tbJob.Text != "")
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


        testcode.Text = sql;

        dataAdapter.InsertCommand = new MySqlCommand(sql, conn);
        dataAdapter.InsertCommand.Parameters.AddWithValue("@제품번호", tbID.Text);
        dataAdapter.InsertCommand.Parameters.AddWithValue("@제품명", tbName.Text);
        dataAdapter.InsertCommand.Parameters.AddWithValue("@재고량", tbAge.Text);
        dataAdapter.InsertCommand.Parameters.AddWithValue("@단가", tbRank.Text);
        dataAdapter.InsertCommand.Parameters.AddWithValue("@제조업체", tbJob.Text);

        try
        {
            conn.Open();
            dataAdapter.InsertCommand.ExecuteNonQuery();

            dataSet.Clear();                                        // 이전 데이터 지우기
            dataAdapter.Fill(dataSet, "제품");                      // DB -> DataSet
            dataGridView1.DataSource = dataSet.Tables["제품"];      // dataGridView에 테이블 표시                                     // 텍스트 박스 내용 지우기
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
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        selectedRowIndex = e.RowIndex;
        DataGridViewRow row = dataGridView1.Rows[selectedRowIndex];

        // 새로운 폼에 선택된 row의 정보를 담아서 생성
        Form4 Dig = new Form4(
            selectedRowIndex,
            row.Cells[0].Value.ToString(),
            row.Cells[1].Value.ToString(),
            row.Cells[2].Value.ToString(),
            row.Cells[3].Value.ToString(),
            row.Cells[4].Value.ToString()
            );

        Dig.Owner = this;               // 새로운 폼의 부모가 Form1 인스턴스임을 지정
        Dig.ShowDialog();               // 폼 띄우기(Modal)
        Dig.Dispose();
    }

        private void FormAdapter_Click(object sender, EventArgs e)
        {
            Form5 Dig = new Form5();

            Dig.Owner = this;               // 새로운 폼의 부모가 Form1 인스턴스임을 지정
            Dig.ShowDialog();               // 폼 띄우기(Modal)
            Dig.Dispose();
        }
    }
}
