namespace Regisztracio
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
            this.NevLbl = new System.Windows.Forms.Label();
            this.SzulLbl = new System.Windows.Forms.Label();
            this.NemLbl = new System.Windows.Forms.Label();
            this.NevTextBox = new System.Windows.Forms.TextBox();
            this.RdiButF = new System.Windows.Forms.RadioButton();
            this.RdoBtnN = new System.Windows.Forms.RadioButton();
            this.HobbiLbl = new System.Windows.Forms.Label();
            this.HobbiLstBx = new System.Windows.Forms.ListBox();
            this.UjHobbiLbl = new System.Windows.Forms.Label();
            this.HobbiTxtBx = new System.Windows.Forms.TextBox();
            this.HozzaadBtn = new System.Windows.Forms.Button();
            this.Mentesbtn = new System.Windows.Forms.Button();
            this.Betoltesbtn = new System.Windows.Forms.Button();
            this.SzulDat = new System.Windows.Forms.DateTimePicker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // NevLbl
            // 
            this.NevLbl.AutoSize = true;
            this.NevLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NevLbl.Location = new System.Drawing.Point(12, 27);
            this.NevLbl.Name = "NevLbl";
            this.NevLbl.Size = new System.Drawing.Size(44, 20);
            this.NevLbl.TabIndex = 0;
            this.NevLbl.Text = "Név:";
            // 
            // SzulLbl
            // 
            this.SzulLbl.AutoSize = true;
            this.SzulLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SzulLbl.Location = new System.Drawing.Point(12, 60);
            this.SzulLbl.Name = "SzulLbl";
            this.SzulLbl.Size = new System.Drawing.Size(109, 20);
            this.SzulLbl.TabIndex = 1;
            this.SzulLbl.Text = "Szül. dátum:";
            // 
            // NemLbl
            // 
            this.NemLbl.AutoSize = true;
            this.NemLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NemLbl.Location = new System.Drawing.Point(12, 93);
            this.NemLbl.Name = "NemLbl";
            this.NemLbl.Size = new System.Drawing.Size(50, 20);
            this.NemLbl.TabIndex = 2;
            this.NemLbl.Text = "Nem:";
            // 
            // NevTextBox
            // 
            this.NevTextBox.Location = new System.Drawing.Point(127, 27);
            this.NevTextBox.Name = "NevTextBox";
            this.NevTextBox.Size = new System.Drawing.Size(140, 20);
            this.NevTextBox.TabIndex = 3;
            this.NevTextBox.TextChanged += new System.EventHandler(this.NevTextBox_TextChanged);
            // 
            // RdiButF
            // 
            this.RdiButF.AutoSize = true;
            this.RdiButF.Location = new System.Drawing.Point(132, 96);
            this.RdiButF.Name = "RdiButF";
            this.RdiButF.Size = new System.Drawing.Size(34, 17);
            this.RdiButF.TabIndex = 5;
            this.RdiButF.TabStop = true;
            this.RdiButF.Text = " F";
            this.RdiButF.UseVisualStyleBackColor = true;
            // 
            // RdoBtnN
            // 
            this.RdoBtnN.AutoSize = true;
            this.RdoBtnN.Location = new System.Drawing.Point(172, 96);
            this.RdoBtnN.Name = "RdoBtnN";
            this.RdoBtnN.Size = new System.Drawing.Size(33, 17);
            this.RdoBtnN.TabIndex = 6;
            this.RdoBtnN.TabStop = true;
            this.RdoBtnN.Text = "N";
            this.RdoBtnN.UseVisualStyleBackColor = true;
            // 
            // HobbiLbl
            // 
            this.HobbiLbl.AutoSize = true;
            this.HobbiLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HobbiLbl.Location = new System.Drawing.Point(274, 27);
            this.HobbiLbl.Name = "HobbiLbl";
            this.HobbiLbl.Size = new System.Drawing.Size(131, 20);
            this.HobbiLbl.TabIndex = 7;
            this.HobbiLbl.Text = "Kedvenc hobbi:";
            // 
            // HobbiLstBx
            // 
            this.HobbiLstBx.FormattingEnabled = true;
            this.HobbiLstBx.Items.AddRange(new object[] {
            "Futás",
            "Horgászat",
            "Úszás"});
            this.HobbiLstBx.Location = new System.Drawing.Point(278, 50);
            this.HobbiLstBx.Name = "HobbiLstBx";
            this.HobbiLstBx.Size = new System.Drawing.Size(120, 95);
            this.HobbiLstBx.TabIndex = 8;
            // 
            // UjHobbiLbl
            // 
            this.UjHobbiLbl.AutoSize = true;
            this.UjHobbiLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UjHobbiLbl.Location = new System.Drawing.Point(187, 149);
            this.UjHobbiLbl.Name = "UjHobbiLbl";
            this.UjHobbiLbl.Size = new System.Drawing.Size(80, 20);
            this.UjHobbiLbl.TabIndex = 9;
            this.UjHobbiLbl.Text = "Új hobbi:";
            // 
            // HobbiTxtBx
            // 
            this.HobbiTxtBx.Location = new System.Drawing.Point(298, 149);
            this.HobbiTxtBx.Name = "HobbiTxtBx";
            this.HobbiTxtBx.Size = new System.Drawing.Size(100, 20);
            this.HobbiTxtBx.TabIndex = 10;
            // 
            // HozzaadBtn
            // 
            this.HozzaadBtn.Location = new System.Drawing.Point(323, 175);
            this.HozzaadBtn.Name = "HozzaadBtn";
            this.HozzaadBtn.Size = new System.Drawing.Size(75, 23);
            this.HozzaadBtn.TabIndex = 11;
            this.HozzaadBtn.Text = "Hozzáad";
            this.HozzaadBtn.UseVisualStyleBackColor = true;
            this.HozzaadBtn.Click += new System.EventHandler(this.HozzaadBtn_Click);
            this.HozzaadBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HozzaadBtn_KeyDown);
            // 
            // Mentesbtn
            // 
            this.Mentesbtn.Location = new System.Drawing.Point(242, 222);
            this.Mentesbtn.Name = "Mentesbtn";
            this.Mentesbtn.Size = new System.Drawing.Size(75, 23);
            this.Mentesbtn.TabIndex = 12;
            this.Mentesbtn.Text = "Mentés";
            this.Mentesbtn.UseVisualStyleBackColor = true;
            this.Mentesbtn.Click += new System.EventHandler(this.Mentesbtn_Click);
            // 
            // Betoltesbtn
            // 
            this.Betoltesbtn.Location = new System.Drawing.Point(323, 222);
            this.Betoltesbtn.Name = "Betoltesbtn";
            this.Betoltesbtn.Size = new System.Drawing.Size(75, 23);
            this.Betoltesbtn.TabIndex = 13;
            this.Betoltesbtn.Text = "Betöltés";
            this.Betoltesbtn.UseVisualStyleBackColor = true;
            this.Betoltesbtn.Click += new System.EventHandler(this.Betoltesbtn_Click);
            // 
            // SzulDat
            // 
            this.SzulDat.Location = new System.Drawing.Point(127, 60);
            this.SzulDat.Name = "SzulDat";
            this.SzulDat.Size = new System.Drawing.Size(140, 20);
            this.SzulDat.TabIndex = 14;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 269);
            this.Controls.Add(this.SzulDat);
            this.Controls.Add(this.Betoltesbtn);
            this.Controls.Add(this.Mentesbtn);
            this.Controls.Add(this.HozzaadBtn);
            this.Controls.Add(this.HobbiTxtBx);
            this.Controls.Add(this.UjHobbiLbl);
            this.Controls.Add(this.HobbiLstBx);
            this.Controls.Add(this.HobbiLbl);
            this.Controls.Add(this.RdoBtnN);
            this.Controls.Add(this.RdiButF);
            this.Controls.Add(this.NevTextBox);
            this.Controls.Add(this.NemLbl);
            this.Controls.Add(this.SzulLbl);
            this.Controls.Add(this.NevLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Regisztrációs Alkalmazás";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NevLbl;
        private System.Windows.Forms.Label SzulLbl;
        private System.Windows.Forms.Label NemLbl;
        private System.Windows.Forms.TextBox NevTextBox;
        private System.Windows.Forms.RadioButton RdiButF;
        private System.Windows.Forms.RadioButton RdoBtnN;
        private System.Windows.Forms.Label HobbiLbl;
        private System.Windows.Forms.ListBox HobbiLstBx;
        private System.Windows.Forms.Label UjHobbiLbl;
        private System.Windows.Forms.TextBox HobbiTxtBx;
        private System.Windows.Forms.Button HozzaadBtn;
        private System.Windows.Forms.Button Mentesbtn;
        private System.Windows.Forms.Button Betoltesbtn;
        private System.Windows.Forms.DateTimePicker SzulDat;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

