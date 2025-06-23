namespace SGS.GUI
{
    partial class TeacherAssesmentDetailForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RollNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObtainedMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_save = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(116)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RollNumber,
            this.StdName,
            this.TotalMarks,
            this.ObtainedMarks});
            this.dataGridView1.Location = new System.Drawing.Point(4, 26);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(970, 407);
            this.dataGridView1.TabIndex = 0;
            // 
            // RollNumber
            // 
            this.RollNumber.DataPropertyName = "Studentid";
            this.RollNumber.HeaderText = "RollNumber";
            this.RollNumber.MinimumWidth = 8;
            this.RollNumber.Name = "RollNumber";
            this.RollNumber.ReadOnly = true;
            // 
            // StdName
            // 
            this.StdName.DataPropertyName = "Studentname";
            this.StdName.HeaderText = "StdName";
            this.StdName.MinimumWidth = 8;
            this.StdName.Name = "StdName";
            this.StdName.ReadOnly = true;
            // 
            // TotalMarks
            // 
            this.TotalMarks.DataPropertyName = "Totalmarks";
            this.TotalMarks.HeaderText = "TotalMarks";
            this.TotalMarks.MinimumWidth = 8;
            this.TotalMarks.Name = "TotalMarks";
            this.TotalMarks.ReadOnly = true;
            // 
            // ObtainedMarks
            // 
            this.ObtainedMarks.DataPropertyName = "Obtainedmarks";
            this.ObtainedMarks.HeaderText = "ObtainedMarks";
            this.ObtainedMarks.MinimumWidth = 8;
            this.ObtainedMarks.Name = "ObtainedMarks";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(116)))), ((int)(((byte)(0)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(679, 443);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(285, 63);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(116)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(116)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(-5, -6);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1057, 27);
            this.label4.TabIndex = 14;
            this.label4.Text = "label4";
            // 
            // TeacherAssesmentDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(977, 520);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TeacherAssesmentDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherAssesmentDetailForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeacherAssmentDetailForm_Closed);
            this.Load += new System.EventHandler(this.TeacherAssesmentDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RollNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn StdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalMarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObtainedMarks;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label4;
    }
}