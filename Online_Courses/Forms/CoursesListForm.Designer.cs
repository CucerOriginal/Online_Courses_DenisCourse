﻿namespace Online_Courses.Forms
{
    partial class CoursesListForm
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
            this.AddStudentbutton = new System.Windows.Forms.Button();
            this.Raspisaniebutton = new System.Windows.Forms.Button();
            this.StudentListbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CousreListdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CousreListdataGridView
            // 
            this.CousreListdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CousreListdataGridView.Location = new System.Drawing.Point(34, 46);
            this.CousreListdataGridView.Name = "CousreListdataGridView";
            this.CousreListdataGridView.RowHeadersWidth = 51;
            this.CousreListdataGridView.RowTemplate.Height = 29;
            this.CousreListdataGridView.Size = new System.Drawing.Size(479, 286);
            this.CousreListdataGridView.TabIndex = 0;
            // 
            // AddStudentbutton
            // 
            this.AddStudentbutton.Location = new System.Drawing.Point(536, 90);
            this.AddStudentbutton.Name = "AddStudentbutton";
            this.AddStudentbutton.Size = new System.Drawing.Size(172, 29);
            this.AddStudentbutton.TabIndex = 1;
            this.AddStudentbutton.Text = "Добавить учащегося";
            this.AddStudentbutton.UseVisualStyleBackColor = true;
            // 
            // Raspisaniebutton
            // 
            this.Raspisaniebutton.Location = new System.Drawing.Point(536, 174);
            this.Raspisaniebutton.Name = "Raspisaniebutton";
            this.Raspisaniebutton.Size = new System.Drawing.Size(172, 29);
            this.Raspisaniebutton.TabIndex = 2;
            this.Raspisaniebutton.Text = "Показать расписание";
            this.Raspisaniebutton.UseVisualStyleBackColor = true;
            // 
            // StudentListbutton
            // 
            this.StudentListbutton.Location = new System.Drawing.Point(536, 270);
            this.StudentListbutton.Name = "StudentListbutton";
            this.StudentListbutton.Size = new System.Drawing.Size(172, 29);
            this.StudentListbutton.TabIndex = 3;
            this.StudentListbutton.Text = "Список учащихся";
            this.StudentListbutton.UseVisualStyleBackColor = true;
            // 
            // CoursesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 379);
            this.Controls.Add(this.StudentListbutton);
            this.Controls.Add(this.Raspisaniebutton);
            this.Controls.Add(this.AddStudentbutton);
            this.Controls.Add(this.CousreListdataGridView);
            this.Name = "CoursesListForm";
            this.Text = "CoursesListForm";
            ((System.ComponentModel.ISupportInitialize)(this.CousreListdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView CousreListdataGridView;
        private Button AddStudentbutton;
        private Button Raspisaniebutton;
        private Button StudentListbutton;
    }
}