namespace WindowsFormsProject
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMoney = new System.Windows.Forms.TextBox();
            this.tbJob = new System.Windows.Forms.TextBox();
            this.tbRank = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.onTable = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FormAdapter = new System.Windows.Forms.Button();
            this.cleaner = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.testcode = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbMoney);
            this.groupBox1.Controls.Add(this.tbJob);
            this.groupBox1.Controls.Add(this.tbRank);
            this.groupBox1.Controls.Add(this.tbAge);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.tbID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "검색 조건";
            // 
            // tbMoney
            // 
            this.tbMoney.Location = new System.Drawing.Point(442, 64);
            this.tbMoney.Name = "tbMoney";
            this.tbMoney.Size = new System.Drawing.Size(100, 21);
            this.tbMoney.TabIndex = 11;
            // 
            // tbJob
            // 
            this.tbJob.Location = new System.Drawing.Point(265, 64);
            this.tbJob.Name = "tbJob";
            this.tbJob.Size = new System.Drawing.Size(100, 21);
            this.tbJob.TabIndex = 10;
            // 
            // tbRank
            // 
            this.tbRank.Location = new System.Drawing.Point(86, 67);
            this.tbRank.Name = "tbRank";
            this.tbRank.Size = new System.Drawing.Size(100, 21);
            this.tbRank.TabIndex = 9;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(442, 26);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(100, 21);
            this.tbAge.TabIndex = 8;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(265, 26);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 21);
            this.tbName.TabIndex = 7;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(86, 26);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 21);
            this.tbID.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "등급";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "직업";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "적립금";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "고객이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "나이";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "고객아이디";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.onTable);
            this.groupBox2.Location = new System.Drawing.Point(588, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "테이블";
            // 
            // onTable
            // 
            this.onTable.AutoSize = true;
            this.onTable.Font = new System.Drawing.Font("배달의민족 주아", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.onTable.Location = new System.Drawing.Point(49, 29);
            this.onTable.Name = "onTable";
            this.onTable.Size = new System.Drawing.Size(110, 38);
            this.onTable.TabIndex = 0;
            this.onTable.Text = "label7";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FormAdapter);
            this.groupBox3.Controls.Add(this.cleaner);
            this.groupBox3.Controls.Add(this.btn_insert);
            this.groupBox3.Controls.Add(this.btn_select);
            this.groupBox3.Location = new System.Drawing.Point(588, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 320);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "작동";
            // 
            // FormAdapter
            // 
            this.FormAdapter.Location = new System.Drawing.Point(6, 249);
            this.FormAdapter.Name = "FormAdapter";
            this.FormAdapter.Size = new System.Drawing.Size(188, 54);
            this.FormAdapter.TabIndex = 3;
            this.FormAdapter.Text = "NEXT TABLE";
            this.FormAdapter.UseVisualStyleBackColor = true;
            this.FormAdapter.Click += new System.EventHandler(this.FormAdapter_Click);
            // 
            // cleaner
            // 
            this.cleaner.Location = new System.Drawing.Point(6, 176);
            this.cleaner.Name = "cleaner";
            this.cleaner.Size = new System.Drawing.Size(188, 54);
            this.cleaner.TabIndex = 2;
            this.cleaner.Text = "textbox cleaner";
            this.cleaner.UseVisualStyleBackColor = true;
            this.cleaner.Click += new System.EventHandler(this.cleaner_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(6, 99);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(188, 54);
            this.btn_insert.TabIndex = 1;
            this.btn_insert.Text = "INSERT";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(6, 29);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(188, 54);
            this.btn_select.TabIndex = 0;
            this.btn_select.Text = "SELECT";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(569, 319);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // testcode
            // 
            this.testcode.AutoSize = true;
            this.testcode.Location = new System.Drawing.Point(59, 336);
            this.testcode.Name = "testcode";
            this.testcode.Size = new System.Drawing.Size(38, 12);
            this.testcode.TabIndex = 4;
            this.testcode.Text = "label7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.testcode);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMoney;
        private System.Windows.Forms.TextBox tbJob;
        private System.Windows.Forms.TextBox tbRank;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button cleaner;
        private System.Windows.Forms.Label testcode;
        private System.Windows.Forms.Label onTable;
        private System.Windows.Forms.Button FormAdapter;
    }
}

