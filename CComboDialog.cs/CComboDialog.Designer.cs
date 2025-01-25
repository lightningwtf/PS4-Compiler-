namespace PS4_Compiler_GUI_with_VS_EXC
{
    partial class CComboDialog
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
            this.cComboBox1 = new System.Windows.Forms.ComboBox();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cComboBox1
            // 
            this.cComboBox1.FormattingEnabled = true;
            this.cComboBox1.Location = new System.Drawing.Point(12, 31);
            this.cComboBox1.Name = "cComboBox1";
            this.cComboBox1.Size = new System.Drawing.Size(269, 21);
            this.cComboBox1.TabIndex = 0;
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(287, 29);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(140, 23);
            this.AcceptButton.TabIndex = 1;
            this.AcceptButton.Text = "Accept";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // innerform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 98);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.cComboBox1);
            this.Name = "innerform";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cComboBox1;
        private System.Windows.Forms.Button AcceptButton;
    }
}

