namespace WindowsForme_Zadatak
{
    partial class Form2
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
            this.drzavaCombo = new System.Windows.Forms.ComboBox();
            this.potvrdiButton = new System.Windows.Forms.Button();
            this.mjestoText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // drzavaCombo
            // 
            this.drzavaCombo.FormattingEnabled = true;
            this.drzavaCombo.Location = new System.Drawing.Point(24, 46);
            this.drzavaCombo.Name = "drzavaCombo";
            this.drzavaCombo.Size = new System.Drawing.Size(130, 21);
            this.drzavaCombo.TabIndex = 0;            // 
            // potvrdiButton
            // 
            this.potvrdiButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.potvrdiButton.Location = new System.Drawing.Point(143, 90);
            this.potvrdiButton.Name = "potvrdiButton";
            this.potvrdiButton.Size = new System.Drawing.Size(75, 23);
            this.potvrdiButton.TabIndex = 2;
            this.potvrdiButton.Text = "Potvrdi";
            this.potvrdiButton.UseVisualStyleBackColor = true;
            this.potvrdiButton.Click += new System.EventHandler(this.potvrdiButton_Click);
            // 
            // mjestoText
            // 
            this.mjestoText.Location = new System.Drawing.Point(174, 47);
            this.mjestoText.Name = "mjestoText";
            this.mjestoText.Size = new System.Drawing.Size(167, 20);
            this.mjestoText.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 125);
            this.Controls.Add(this.mjestoText);
            this.Controls.Add(this.potvrdiButton);
            this.Controls.Add(this.drzavaCombo);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Unos";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox drzavaCombo;
        private System.Windows.Forms.Button potvrdiButton;
        private System.Windows.Forms.TextBox mjestoText;
    }
}