namespace Online_Courses.Forms
{
    partial class StudentListForm
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
            this.StudentListdataGridView = new System.Windows.Forms.DataGridView();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.Refreshbutton = new System.Windows.Forms.Button();
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.ChangeDatabutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentListdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentListdataGridView
            // 
            this.StudentListdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentListdataGridView.Location = new System.Drawing.Point(68, 143);
            this.StudentListdataGridView.Name = "StudentListdataGridView";
            this.StudentListdataGridView.RowHeadersWidth = 51;
            this.StudentListdataGridView.RowTemplate.Height = 29;
            this.StudentListdataGridView.Size = new System.Drawing.Size(691, 275);
            this.StudentListdataGridView.TabIndex = 0;
            // 
            // Searchbutton
            // 
            this.Searchbutton.Location = new System.Drawing.Point(582, 73);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(94, 29);
            this.Searchbutton.TabIndex = 1;
            this.Searchbutton.Text = "Найти";
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // Refreshbutton
            // 
            this.Refreshbutton.Location = new System.Drawing.Point(65, 71);
            this.Refreshbutton.Name = "Refreshbutton";
            this.Refreshbutton.Size = new System.Drawing.Size(94, 29);
            this.Refreshbutton.TabIndex = 2;
            this.Refreshbutton.Text = "Обновить";
            this.Refreshbutton.UseVisualStyleBackColor = true;
            this.Refreshbutton.Click += new System.EventHandler(this.Refreshbutton_Click);
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.Location = new System.Drawing.Point(255, 71);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(310, 27);
            this.SearchtextBox.TabIndex = 3;
            // 
            // ChangeDatabutton
            // 
            this.ChangeDatabutton.Location = new System.Drawing.Point(68, 455);
            this.ChangeDatabutton.Name = "ChangeDatabutton";
            this.ChangeDatabutton.Size = new System.Drawing.Size(94, 29);
            this.ChangeDatabutton.TabIndex = 4;
            this.ChangeDatabutton.Text = "Изменить";
            this.ChangeDatabutton.UseVisualStyleBackColor = true;
            this.ChangeDatabutton.Click += new System.EventHandler(this.ChangeDatabutton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(560, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Показать всех учащихся ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 535);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ChangeDatabutton);
            this.Controls.Add(this.SearchtextBox);
            this.Controls.Add(this.Refreshbutton);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.StudentListdataGridView);
            this.Name = "StudentListForm";
            this.Text = "StudentListForm";
            this.Load += new System.EventHandler(this.StudentListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentListdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView StudentListdataGridView;
        private Button Searchbutton;
        private Button Refreshbutton;
        private TextBox SearchtextBox;
        private Button ChangeDatabutton;
        private Button button1;
    }
}