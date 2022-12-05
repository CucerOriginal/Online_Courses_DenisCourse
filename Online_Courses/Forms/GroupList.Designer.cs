namespace Online_Courses.Forms
{
    partial class GroupList
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
            this.GroupListdataGridView = new System.Windows.Forms.DataGridView();
            this.StudentListdataGridView = new System.Windows.Forms.DataGridView();
            this.ChangeGroupbutton = new System.Windows.Forms.Button();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.Refreshbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GroupListdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentListdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupListdataGridView
            // 
            this.GroupListdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroupListdataGridView.Location = new System.Drawing.Point(48, 109);
            this.GroupListdataGridView.Name = "GroupListdataGridView";
            this.GroupListdataGridView.RowHeadersWidth = 51;
            this.GroupListdataGridView.RowTemplate.Height = 29;
            this.GroupListdataGridView.Size = new System.Drawing.Size(188, 278);
            this.GroupListdataGridView.TabIndex = 0;
            this.GroupListdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GroupListdataGridView_CellContentClick);
            // 
            // StudentListdataGridView
            // 
            this.StudentListdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentListdataGridView.Location = new System.Drawing.Point(293, 109);
            this.StudentListdataGridView.Name = "StudentListdataGridView";
            this.StudentListdataGridView.RowHeadersWidth = 51;
            this.StudentListdataGridView.RowTemplate.Height = 29;
            this.StudentListdataGridView.Size = new System.Drawing.Size(670, 278);
            this.StudentListdataGridView.TabIndex = 1;
            this.StudentListdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentListdataGridView_CellClick);
            // 
            // ChangeGroupbutton
            // 
            this.ChangeGroupbutton.Location = new System.Drawing.Point(784, 425);
            this.ChangeGroupbutton.Name = "ChangeGroupbutton";
            this.ChangeGroupbutton.Size = new System.Drawing.Size(179, 29);
            this.ChangeGroupbutton.TabIndex = 2;
            this.ChangeGroupbutton.Text = "Изменить Группу";
            this.ChangeGroupbutton.UseVisualStyleBackColor = true;
            this.ChangeGroupbutton.Click += new System.EventHandler(this.ChangeGroupbutton_Click);
            // 
            // Searchbutton
            // 
            this.Searchbutton.Location = new System.Drawing.Point(704, 43);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(94, 29);
            this.Searchbutton.TabIndex = 3;
            this.Searchbutton.Text = "Найти";
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Группы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Учащиеся";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Поиск";
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.Location = new System.Drawing.Point(327, 45);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(348, 27);
            this.SearchtextBox.TabIndex = 7;
            // 
            // Refreshbutton
            // 
            this.Refreshbutton.Location = new System.Drawing.Point(869, 74);
            this.Refreshbutton.Name = "Refreshbutton";
            this.Refreshbutton.Size = new System.Drawing.Size(94, 29);
            this.Refreshbutton.TabIndex = 8;
            this.Refreshbutton.Text = "Обновить";
            this.Refreshbutton.UseVisualStyleBackColor = true;
            this.Refreshbutton.Click += new System.EventHandler(this.Refreshbutton_Click);
            // 
            // GroupList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 484);
            this.Controls.Add(this.Refreshbutton);
            this.Controls.Add(this.SearchtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.ChangeGroupbutton);
            this.Controls.Add(this.StudentListdataGridView);
            this.Controls.Add(this.GroupListdataGridView);
            this.Name = "GroupList";
            this.Text = "GroupList";
            this.Load += new System.EventHandler(this.GroupList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupListdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentListdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView GroupListdataGridView;
        private DataGridView StudentListdataGridView;
        private Button ChangeGroupbutton;
        private Button Searchbutton;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox SearchtextBox;
        private Button Refreshbutton;
    }
}