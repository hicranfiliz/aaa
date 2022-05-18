namespace ExamApplication
{
    partial class SonuclariGor
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
            this.cmbsubject = new System.Windows.Forms.ComboBox();
            this.ResultDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblkullaniciadi = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbsubject
            // 
            this.cmbsubject.FormattingEnabled = true;
            this.cmbsubject.Location = new System.Drawing.Point(717, 110);
            this.cmbsubject.Name = "cmbsubject";
            this.cmbsubject.Size = new System.Drawing.Size(196, 31);
            this.cmbsubject.TabIndex = 5;
            this.cmbsubject.Text = "Konular";
            this.cmbsubject.SelectionChangeCommitted += new System.EventHandler(this.cmbsubject_SelectionChangeCommitted);
            // 
            // ResultDGV
            // 
            this.ResultDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultDGV.Location = new System.Drawing.Point(26, 147);
            this.ResultDGV.Name = "ResultDGV";
            this.ResultDGV.RowHeadersWidth = 51;
            this.ResultDGV.RowTemplate.Height = 24;
            this.ResultDGV.Size = new System.Drawing.Size(887, 331);
            this.ResultDGV.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "SONUÇLAR:";
            // 
            // lblkullaniciadi
            // 
            this.lblkullaniciadi.AutoSize = true;
            this.lblkullaniciadi.Location = new System.Drawing.Point(44, 42);
            this.lblkullaniciadi.Name = "lblkullaniciadi";
            this.lblkullaniciadi.Size = new System.Drawing.Size(80, 23);
            this.lblkullaniciadi.TabIndex = 6;
            this.lblkullaniciadi.Text = "Kişi Adı";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(882, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 42);
            this.button2.TabIndex = 56;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SonuclariGor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(937, 490);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblkullaniciadi);
            this.Controls.Add(this.cmbsubject);
            this.Controls.Add(this.ResultDGV);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SonuclariGor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SonuclariGor";
            ((System.ComponentModel.ISupportInitialize)(this.ResultDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbsubject;
        private System.Windows.Forms.DataGridView ResultDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblkullaniciadi;
        private System.Windows.Forms.Button button2;
    }
}