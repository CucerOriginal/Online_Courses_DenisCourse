namespace Online_Courses.Forms
{
    partial class GroupSelectForm
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
            this.GroupChangebutton = new System.Windows.Forms.Button();
            this.FIOlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GroupListdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupListdataGridView
            // 
            this.GroupListdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroupListdataGridView.Location = new System.Drawing.Point(262, 14);
            this.GroupListdataGridView.Name = "GroupListdataGridView";
            this.GroupListdataGridView.RowHeadersWidth = 51;
            this.GroupListdataGridView.RowTemplate.Height = 29;
            this.GroupListdataGridView.Size = new System.Drawing.Size(178, 188);
            this.GroupListdataGridView.TabIndex = 0;
            this.GroupListdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GroupListdataGridView_CellClick);
            // 
            // GroupChangebutton
            // 
            this.GroupChangebutton.Location = new System.Drawing.Point(452, 104);
            this.GroupChangebutton.Name = "GroupChangebutton";
            this.GroupChangebutton.Size = new System.Drawing.Size(94, 29);
            this.GroupChangebutton.TabIndex = 1;
            this.GroupChangebutton.Text = "Изменить";
            this.GroupChangebutton.UseVisualStyleBackColor = true;
            this.GroupChangebutton.Click += new System.EventHandler(this.GroupChangebutton_Click);
            // 
            // FIOlabel
            // 
            this.FIOlabel.AutoSize = true;
            this.FIOlabel.Location = new System.Drawing.Point(26, 104);
            this.FIOlabel.Name = "FIOlabel";
            this.FIOlabel.Size = new System.Drawing.Size(50, 20);
            this.FIOlabel.TabIndex = 2;
            this.FIOlabel.Text = "label1";
            // 
            // GroupSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 214);
            this.Controls.Add(this.FIOlabel);
            this.Controls.Add(this.GroupChangebutton);
            this.Controls.Add(this.GroupListdataGridView);
            this.Name = "GroupSelectForm";
            this.Text = "GroupSelectForm";
            this.Load += new System.EventHandler(this.GroupSelectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupListdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView GroupListdataGridView;
        private Button GroupChangebutton;
        private Label FIOlabel;
    }
}