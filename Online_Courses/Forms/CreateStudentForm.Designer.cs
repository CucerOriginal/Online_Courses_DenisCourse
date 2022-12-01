namespace Online_Courses.Forms
{
    partial class CreateStudentForm
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
            this.SecondNametextBox = new System.Windows.Forms.TextBox();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.MiddleNametextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumertextBox = new System.Windows.Forms.TextBox();
            this.BorthdaydateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddrestextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SecondNametextBox
            // 
            this.SecondNametextBox.Location = new System.Drawing.Point(67, 139);
            this.SecondNametextBox.Name = "SecondNametextBox";
            this.SecondNametextBox.Size = new System.Drawing.Size(125, 27);
            this.SecondNametextBox.TabIndex = 0;
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(67, 223);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(125, 27);
            this.NametextBox.TabIndex = 1;
            // 
            // MiddleNametextBox
            // 
            this.MiddleNametextBox.Location = new System.Drawing.Point(67, 307);
            this.MiddleNametextBox.Name = "MiddleNametextBox";
            this.MiddleNametextBox.Size = new System.Drawing.Size(125, 27);
            this.MiddleNametextBox.TabIndex = 2;
            // 
            // PhoneNumertextBox
            // 
            this.PhoneNumertextBox.Location = new System.Drawing.Point(264, 223);
            this.PhoneNumertextBox.Name = "PhoneNumertextBox";
            this.PhoneNumertextBox.Size = new System.Drawing.Size(125, 27);
            this.PhoneNumertextBox.TabIndex = 4;
            // 
            // BorthdaydateTimePicker
            // 
            this.BorthdaydateTimePicker.Location = new System.Drawing.Point(264, 139);
            this.BorthdaydateTimePicker.Name = "BorthdaydateTimePicker";
            this.BorthdaydateTimePicker.Size = new System.Drawing.Size(250, 27);
            this.BorthdaydateTimePicker.TabIndex = 5;
            // 
            // AddrestextBox
            // 
            this.AddrestextBox.Location = new System.Drawing.Point(264, 307);
            this.AddrestextBox.Name = "AddrestextBox";
            this.AddrestextBox.Size = new System.Drawing.Size(125, 27);
            this.AddrestextBox.TabIndex = 6;
            // 
            // CreateStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddrestextBox);
            this.Controls.Add(this.BorthdaydateTimePicker);
            this.Controls.Add(this.PhoneNumertextBox);
            this.Controls.Add(this.MiddleNametextBox);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.SecondNametextBox);
            this.Name = "CreateStudentForm";
            this.Text = "CreateStudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox SecondNametextBox;
        private TextBox NametextBox;
        private TextBox MiddleNametextBox;
        private TextBox PhoneNumertextBox;
        private DateTimePicker BorthdaydateTimePicker;
        private TextBox AddrestextBox;
    }
}