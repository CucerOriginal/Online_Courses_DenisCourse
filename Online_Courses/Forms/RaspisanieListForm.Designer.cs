namespace Online_Courses.Forms
{
    partial class RaspisanieListForm
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
            this.RaspisaniedataGridView = new System.Windows.Forms.DataGridView();
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.Refreshbutton = new System.Windows.Forms.Button();
            this.Searchbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RaspisaniedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RaspisaniedataGridView
            // 
            this.RaspisaniedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RaspisaniedataGridView.Location = new System.Drawing.Point(102, 128);
            this.RaspisaniedataGridView.Name = "RaspisaniedataGridView";
            this.RaspisaniedataGridView.RowHeadersWidth = 51;
            this.RaspisaniedataGridView.RowTemplate.Height = 29;
            this.RaspisaniedataGridView.Size = new System.Drawing.Size(584, 286);
            this.RaspisaniedataGridView.TabIndex = 0;
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.Location = new System.Drawing.Point(259, 86);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(246, 27);
            this.SearchtextBox.TabIndex = 1;
            // 
            // Refreshbutton
            // 
            this.Refreshbutton.Location = new System.Drawing.Point(102, 84);
            this.Refreshbutton.Name = "Refreshbutton";
            this.Refreshbutton.Size = new System.Drawing.Size(94, 29);
            this.Refreshbutton.TabIndex = 2;
            this.Refreshbutton.Text = "Обновить";
            this.Refreshbutton.UseVisualStyleBackColor = true;
            this.Refreshbutton.Click += new System.EventHandler(this.Refreshbutton_Click);
            // 
            // Searchbutton
            // 
            this.Searchbutton.Location = new System.Drawing.Point(592, 84);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(94, 29);
            this.Searchbutton.TabIndex = 3;
            this.Searchbutton.Text = "Поиск";
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // RaspisanieListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 485);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.Refreshbutton);
            this.Controls.Add(this.SearchtextBox);
            this.Controls.Add(this.RaspisaniedataGridView);
            this.Name = "RaspisanieListForm";
            this.Text = "RaspisanieListForm";
            this.Load += new System.EventHandler(this.RaspisanieListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RaspisaniedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView RaspisaniedataGridView;
        private TextBox SearchtextBox;
        private Button Refreshbutton;
        private Button Searchbutton;
    }
}