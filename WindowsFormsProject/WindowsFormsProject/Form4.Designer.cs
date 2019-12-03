namespace WindowsFormsProject
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbJob = new System.Windows.Forms.TextBox();
            this.tbRank = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.cleaner = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbJob);
            this.groupBox1.Controls.Add(this.tbRank);
            this.groupBox1.Controls.Add(this.tbAge);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.tbID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "갱신 조건";
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
            this.label6.Text = "단가";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "제조업체";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "제품명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "재고량";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "제품번호";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(57, 143);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(131, 58);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(214, 143);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(128, 58);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // cleaner
            // 
            this.cleaner.Location = new System.Drawing.Point(419, 145);
            this.cleaner.Name = "cleaner";
            this.cleaner.Size = new System.Drawing.Size(114, 54);
            this.cleaner.TabIndex = 4;
            this.cleaner.Text = "CLEAR";
            this.cleaner.UseVisualStyleBackColor = true;
            this.cleaner.Click += new System.EventHandler(this.cleaner_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 271);
            this.Controls.Add(this.cleaner);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form4";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbJob;
        private System.Windows.Forms.TextBox tbRank;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button cleaner;
    }
}