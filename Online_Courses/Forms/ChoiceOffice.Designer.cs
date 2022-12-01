namespace Online_Courses.Forms
{
    partial class ChoiceOffice
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
            this.Mainbutton = new System.Windows.Forms.Button();
            this.FilialOnebutton = new System.Windows.Forms.Button();
            this.FilialTwobutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Mainbutton
            // 
            this.Mainbutton.Location = new System.Drawing.Point(109, 106);
            this.Mainbutton.Name = "Mainbutton";
            this.Mainbutton.Size = new System.Drawing.Size(220, 45);
            this.Mainbutton.TabIndex = 0;
            this.Mainbutton.Text = "Главный офис";
            this.Mainbutton.UseVisualStyleBackColor = true;
            // 
            // FilialOnebutton
            // 
            this.FilialOnebutton.Location = new System.Drawing.Point(109, 169);
            this.FilialOnebutton.Name = "FilialOnebutton";
            this.FilialOnebutton.Size = new System.Drawing.Size(220, 45);
            this.FilialOnebutton.TabIndex = 1;
            this.FilialOnebutton.Text = "Филиал первый";
            this.FilialOnebutton.UseVisualStyleBackColor = true;
            // 
            // FilialTwobutton
            // 
            this.FilialTwobutton.Location = new System.Drawing.Point(109, 231);
            this.FilialTwobutton.Name = "FilialTwobutton";
            this.FilialTwobutton.Size = new System.Drawing.Size(220, 45);
            this.FilialTwobutton.TabIndex = 2;
            this.FilialTwobutton.Text = "Филиал второй";
            this.FilialTwobutton.UseVisualStyleBackColor = true;
            // 
            // ChoiceOffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 352);
            this.Controls.Add(this.FilialTwobutton);
            this.Controls.Add(this.FilialOnebutton);
            this.Controls.Add(this.Mainbutton);
            this.Name = "ChoiceOffice";
            this.Text = "ChoiceOffice";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Mainbutton;
        private Button FilialOnebutton;
        private Button FilialTwobutton;
    }
}