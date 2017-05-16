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
            this.drzavacmbBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nazivtextBox = new System.Windows.Forms.TextBox();
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
            this.button1 = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partneriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1284, 314);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.drzavacmbBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.mjestocmbBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nazivtextBox);
            this.groupBox1.Controls.Add(this.mailtxtBox);
            this.groupBox1.Controls.Add(this.napomenatxtBox);
            this.groupBox1.Controls.Add(this.tipcmbBox);
            this.groupBox1.Controls.Add(this.webtxtBox);
            this.groupBox1.Controls.Add(this.adresatxtBox);
            this.groupBox1.Controls.Add(this.fakstxtBox);
            this.groupBox1.Controls.Add(this.telefontxtBox);
            this.groupBox1.Controls.Add(this.oibtxtBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 332);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1284, 65);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // drzavacmbBox
            // 
            this.drzavacmbBox.FormattingEnabled = true;
            this.drzavacmbBox.Location = new System.Drawing.Point(184, 28);
            this.drzavacmbBox.Name = "drzavacmbBox";
            this.drzavacmbBox.Size = new System.Drawing.Size(92, 21);
            this.drzavacmbBox.TabIndex = 28;
            this.drzavacmbBox.TextChanged += new System.EventHandler(this.drzavacmbBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(209, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Država";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label11.Location = new System.Drawing.Point(1193, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Napomena";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label10.Location = new System.Drawing.Point(1049, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Web stranica";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label9.Location = new System.Drawing.Point(946, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Location = new System.Drawing.Point(836, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Telefaks";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Location = new System.Drawing.Point(690, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Telefon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Location = new System.Drawing.Point(564, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "OIB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Location = new System.Drawing.Point(322, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Mjesto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Location = new System.Drawing.Point(441, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Adresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Location = new System.Drawing.Point(108, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tip poduzeća";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Location = new System.Drawing.Point(36, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Naziv";
            // 
            // nazivtextBox
            // 
            this.nazivtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazivtextBox.Location = new System.Drawing.Point(19, 28);
            this.nazivtextBox.Name = "nazivtextBox";
            this.nazivtextBox.Size = new System.Drawing.Size(71, 23);
            this.nazivtextBox.TabIndex = 15;
            // 
            // mailtxtBox
            // 
            this.mailtxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mailtxtBox.Location = new System.Drawing.Point(926, 27);
            this.mailtxtBox.Name = "mailtxtBox";
            this.mailtxtBox.Size = new System.Drawing.Size(96, 23);
            this.mailtxtBox.TabIndex = 14;
            // 
            // napomenatxtBox
            // 
            this.napomenatxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.napomenatxtBox.Location = new System.Drawing.Point(1149, 27);
            this.napomenatxtBox.Name = "napomenatxtBox";
            this.napomenatxtBox.Size = new System.Drawing.Size(129, 23);
            this.napomenatxtBox.TabIndex = 13;
            // 
            // tipcmbBox
            // 
            this.tipcmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipcmbBox.FormattingEnabled = true;
            this.tipcmbBox.Items.AddRange(new object[] {
            "doo",
            "dd"});
            this.tipcmbBox.Location = new System.Drawing.Point(102, 29);
            this.tipcmbBox.Name = "tipcmbBox";
            this.tipcmbBox.Size = new System.Drawing.Size(76, 21);
            this.tipcmbBox.TabIndex = 11;
            // 
            // webtxtBox
            // 
            this.webtxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.webtxtBox.Location = new System.Drawing.Point(1028, 27);
            this.webtxtBox.Name = "webtxtBox";
            this.webtxtBox.Size = new System.Drawing.Size(115, 23);
            this.webtxtBox.TabIndex = 12;
            // 
            // adresatxtBox
            // 
            this.adresatxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adresatxtBox.Location = new System.Drawing.Point(400, 27);
            this.adresatxtBox.Name = "adresatxtBox";
            this.adresatxtBox.Size = new System.Drawing.Size(120, 23);
            this.adresatxtBox.TabIndex = 6;
            // 
            // fakstxtBox
            // 
            this.fakstxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fakstxtBox.Location = new System.Drawing.Point(787, 27);
            this.fakstxtBox.Name = "fakstxtBox";
            this.fakstxtBox.Size = new System.Drawing.Size(133, 23);
            this.fakstxtBox.TabIndex = 10;
            // 
            // mjestocmbBox
            // 
            this.mjestocmbBox.FormattingEnabled = true;
            this.mjestocmbBox.Location = new System.Drawing.Point(282, 27);
            this.mjestocmbBox.Name = "mjestocmbBox";
            this.mjestocmbBox.Size = new System.Drawing.Size(112, 21);
            this.mjestocmbBox.TabIndex = 7;
            // 
            // telefontxtBox
            // 
            this.telefontxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.telefontxtBox.Location = new System.Drawing.Point(648, 27);
            this.telefontxtBox.Name = "telefontxtBox";
            this.telefontxtBox.Size = new System.Drawing.Size(133, 23);
            this.telefontxtBox.TabIndex = 9;
            // 
            // oibtxtBox
            // 
            this.oibtxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.oibtxtBox.Location = new System.Drawing.Point(526, 27);
            this.oibtxtBox.Name = "oibtxtBox";
            this.oibtxtBox.Size = new System.Drawing.Size(116, 23);
            this.oibtxtBox.TabIndex = 8;
            this.oibtxtBox.TextChanged += new System.EventHandler(this.oibtxtBox_TextChanged);
            // 
            // InsertButton
            // 
            this.InsertButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.InsertButton.Location = new System.Drawing.Point(22, 429);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(135, 40);
            this.InsertButton.TabIndex = 18;
            this.InsertButton.Text = "INSERT";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DeleteButton.Location = new System.Drawing.Point(304, 429);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(135, 40);
            this.DeleteButton.TabIndex = 17;
            this.DeleteButton.Text = "DELETE";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.UpdateButton.Location = new System.Drawing.Point(163, 429);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(135, 40);
            this.UpdateButton.TabIndex = 16;
            this.UpdateButton.Text = "UPDATE";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
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
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(1008, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Države i mjesta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearButton
            // 
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.clearButton.Location = new System.Drawing.Point(868, 429);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(108, 35);
            this.clearButton.TabIndex = 23;
            this.clearButton.Text = "Očisti unos";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.searchButton.Location = new System.Drawing.Point(445, 429);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(135, 40);
            this.searchButton.TabIndex = 24;
            this.searchButton.Text = "SEARCH";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.refreshButton.Location = new System.Drawing.Point(586, 429);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(135, 40);
            this.refreshButton.TabIndex = 25;
            this.refreshButton.Text = "REFRESH";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 488);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.nazivtxtBox);
            this.Name = "Form1";
            this.Text = "Unos podataka";
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
        private System.Windows.Forms.TextBox telefontxtBox;
        private System.Windows.Forms.TextBox oibtxtBox;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.BindingSource partneriBindingSource;
        private System.Windows.Forms.TextBox nazivtxtBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox mjestocmbBox;
        private System.Windows.Forms.TextBox nazivtextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox drzavacmbBox;
    }
}

