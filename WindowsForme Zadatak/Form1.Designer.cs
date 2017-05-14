namespace WindowsForme_Zadatak
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mailtxtBox = new System.Windows.Forms.TextBox();
            this.napomenatxtBox = new System.Windows.Forms.TextBox();
            this.tipcmbBox = new System.Windows.Forms.ComboBox();
            this.webtxtBox = new System.Windows.Forms.TextBox();
            this.adresatxtBox = new System.Windows.Forms.TextBox();
            this.fakstxtBox = new System.Windows.Forms.TextBox();
            this.mjestocmbBox = new System.Windows.Forms.ComboBox();
            this.telefontxtBox = new System.Windows.Forms.TextBox();
            this.oibtxtBox = new System.Windows.Forms.TextBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.partneriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nazivtxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partneriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1328, 314);
            this.dataGridView1.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mailtxtBox);
            this.groupBox1.Controls.Add(this.napomenatxtBox);
            this.groupBox1.Controls.Add(this.tipcmbBox);
            this.groupBox1.Controls.Add(this.webtxtBox);
            this.groupBox1.Controls.Add(this.adresatxtBox);
            this.groupBox1.Controls.Add(this.fakstxtBox);
            this.groupBox1.Controls.Add(this.mjestocmbBox);
            this.groupBox1.Controls.Add(this.telefontxtBox);
            this.groupBox1.Controls.Add(this.oibtxtBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 332);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1218, 56);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // mailtxtBox
            // 
            this.mailtxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mailtxtBox.Location = new System.Drawing.Point(838, 19);
            this.mailtxtBox.Name = "mailtxtBox";
            this.mailtxtBox.Size = new System.Drawing.Size(96, 23);
            this.mailtxtBox.TabIndex = 14;
            // 
            // napomenatxtBox
            // 
            this.napomenatxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.napomenatxtBox.Location = new System.Drawing.Point(1061, 19);
            this.napomenatxtBox.Name = "napomenatxtBox";
            this.napomenatxtBox.Size = new System.Drawing.Size(151, 23);
            this.napomenatxtBox.TabIndex = 13;
            // 
            // tipcmbBox
            // 
            this.tipcmbBox.FormattingEnabled = true;
            this.tipcmbBox.Items.AddRange(new object[] {
            "doo",
            "dd"});
            this.tipcmbBox.Location = new System.Drawing.Point(112, 21);
            this.tipcmbBox.Name = "tipcmbBox";
            this.tipcmbBox.Size = new System.Drawing.Size(76, 21);
            this.tipcmbBox.TabIndex = 11;
            // 
            // webtxtBox
            // 
            this.webtxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.webtxtBox.Location = new System.Drawing.Point(940, 19);
            this.webtxtBox.Name = "webtxtBox";
            this.webtxtBox.Size = new System.Drawing.Size(115, 23);
            this.webtxtBox.TabIndex = 12;
            // 
            // adresatxtBox
            // 
            this.adresatxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adresatxtBox.Location = new System.Drawing.Point(194, 21);
            this.adresatxtBox.Name = "adresatxtBox";
            this.adresatxtBox.Size = new System.Drawing.Size(120, 23);
            this.adresatxtBox.TabIndex = 6;
            // 
            // fakstxtBox
            // 
            this.fakstxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fakstxtBox.Location = new System.Drawing.Point(699, 20);
            this.fakstxtBox.Name = "fakstxtBox";
            this.fakstxtBox.Size = new System.Drawing.Size(133, 23);
            this.fakstxtBox.TabIndex = 10;
            // 
            // mjestocmbBox
            // 
            this.mjestocmbBox.FormattingEnabled = true;
            this.mjestocmbBox.Location = new System.Drawing.Point(320, 21);
            this.mjestocmbBox.Name = "mjestocmbBox";
            this.mjestocmbBox.Size = new System.Drawing.Size(112, 21);
            this.mjestocmbBox.TabIndex = 7;
            // 
            // telefontxtBox
            // 
            this.telefontxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.telefontxtBox.Location = new System.Drawing.Point(560, 19);
            this.telefontxtBox.Name = "telefontxtBox";
            this.telefontxtBox.Size = new System.Drawing.Size(133, 23);
            this.telefontxtBox.TabIndex = 9;
            // 
            // oibtxtBox
            // 
            this.oibtxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.oibtxtBox.Location = new System.Drawing.Point(438, 19);
            this.oibtxtBox.Name = "oibtxtBox";
            this.oibtxtBox.Size = new System.Drawing.Size(116, 23);
            this.oibtxtBox.TabIndex = 8;
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(22, 434);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(157, 46);
            this.InsertButton.TabIndex = 18;
            this.InsertButton.Text = "INSERT";
            this.InsertButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(1000, 434);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(157, 46);
            this.DeleteButton.TabIndex = 17;
            this.DeleteButton.Text = "DELETE";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(533, 434);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(157, 46);
            this.UpdateButton.TabIndex = 16;
            this.UpdateButton.Text = "UPDATE";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // partneriBindingSource
            // 
            this.partneriBindingSource.DataMember = "Partneri";
            // 
            // nazivtxtBox
            // 
            this.nazivtxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazivtxtBox.Location = new System.Drawing.Point(22, 353);
            this.nazivtxtBox.Name = "nazivtxtBox";
            this.nazivtxtBox.Size = new System.Drawing.Size(97, 23);
            this.nazivtxtBox.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 489);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.nazivtxtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partneriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox mailtxtBox;
        private System.Windows.Forms.TextBox napomenatxtBox;
        private System.Windows.Forms.ComboBox tipcmbBox;
        private System.Windows.Forms.TextBox webtxtBox;
        private System.Windows.Forms.TextBox adresatxtBox;
        private System.Windows.Forms.TextBox fakstxtBox;
        private System.Windows.Forms.ComboBox mjestocmbBox;
        private System.Windows.Forms.TextBox telefontxtBox;
        private System.Windows.Forms.TextBox oibtxtBox;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.BindingSource partneriBindingSource;
        private System.Windows.Forms.TextBox nazivtxtBox;
    }
}

