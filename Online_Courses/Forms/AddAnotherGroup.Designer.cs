namespace Online_Courses.Forms
{
    partial class AddAnotherGroup
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
            this.CousreListdataGridView = new System.Windows.Forms.DataGridView();
            this.AddCoursbutton = new System.Windows.Forms.Button();
            this.FIOStudentlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CousreListdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CousreListdataGridView
            // 
            this.CousreListdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CousreListdataGridView.Location = new System.Drawing.Point(311, 60);
            this.CousreListdataGridView.Name = "CousreListdataGridView";
            this.CousreListdataGridView.RowHeadersWidth = 51;
            this.CousreListdataGridView.RowTemplate.Height = 29;
            this.CousreListdataGridView.Size = new System.Drawing.Size(300, 188);
            this.CousreListdataGridView.TabIndex = 0;
            this.CousreListdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CousreListdataGridView_CellClick);
            // 
            // AddCoursbutton
            // 
            this.AddCoursbutton.Location = new System.Drawing.Point(911, 126);
            this.AddCoursbutton.Name = "AddCoursbutton";
            this.AddCoursbutton.Size = new System.Drawing.Size(135, 29);
            this.AddCoursbutton.TabIndex = 1;
            this.AddCoursbutton.Text = "Добавить курс";
            this.AddCoursbutton.UseVisualStyleBackColor = true;
            this.AddCoursbutton.Click += new System.EventHandler(this.AddCoursbutton_Click);
            // 
            // FIOStudentlabel
            // 
            this.FIOStudentlabel.AutoSize = true;
            this.FIOStudentlabel.Location = new System.Drawing.Point(21, 143);
            this.FIOStudentlabel.Name = "FIOStudentlabel";
            this.FIOStudentlabel.Size = new System.Drawing.Size(50, 20);
            this.FIOStudentlabel.TabIndex = 2;
            this.FIOStudentlabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ученик";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(630, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(266, 188);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // AddAnotherGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 290);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FIOStudentlabel);
            this.Controls.Add(this.AddCoursbutton);
            this.Controls.Add(this.CousreListdataGridView);
            this.Name = "AddAnotherGroup";
            this.Text = "AddAnotherGroup";
            this.Load += new System.EventHandler(this.AddAnotherGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CousreListdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView CousreListdataGridView;
        private Button AddCoursbutton;
        private Label FIOStudentlabel;
        private Label label1;
        private DataGridView dataGridView1;
    }
}