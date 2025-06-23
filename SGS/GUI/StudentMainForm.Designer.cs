namespace SGS.GUI
{
    partial class StudentMainForm
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
            this.btn_transcript = new System.Windows.Forms.Button();
            this.btn_courses = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_transcript
            // 
            this.btn_transcript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(116)))), ((int)(((byte)(0)))));
            this.btn_transcript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_transcript.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transcript.ForeColor = System.Drawing.Color.White;
            this.btn_transcript.Location = new System.Drawing.Point(166, 186);
            this.btn_transcript.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_transcript.Name = "btn_transcript";
            this.btn_transcript.Size = new System.Drawing.Size(300, 111);
            this.btn_transcript.TabIndex = 6;
            this.btn_transcript.Text = "Transcript";
            this.btn_transcript.UseVisualStyleBackColor = false;
            this.btn_transcript.Click += new System.EventHandler(this.btn_transcript_Click);
            // 
            // btn_courses
            // 
            this.btn_courses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(116)))), ((int)(((byte)(0)))));
            this.btn_courses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_courses.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.btn_courses.ForeColor = System.Drawing.Color.White;
            this.btn_courses.Location = new System.Drawing.Point(166, 307);
            this.btn_courses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_courses.Name = "btn_courses";
            this.btn_courses.Size = new System.Drawing.Size(300, 111);
            this.btn_courses.TabIndex = 3;
            this.btn_courses.Text = "Courses";
            this.btn_courses.UseVisualStyleBackColor = false;
            this.btn_courses.Click += new System.EventHandler(this.btn_courses_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(116)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(-118, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(866, 71);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(116)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(116)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(-182, -4);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(900, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Admin Panel";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudentMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(641, 507);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_courses);
            this.Controls.Add(this.btn_transcript);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StudentMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentMainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentMainForm_Closed);
            this.Load += new System.EventHandler(this.StudentMainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_courses;
        private System.Windows.Forms.Button btn_transcript;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}