namespace ExamApplication
{
    partial class Question
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
            this.label8 = new System.Windows.Forms.Label();
            this.QuestionDGV = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbsubject = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtanswer = new System.Windows.Forms.TextBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtoption4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtoption3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtoption2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtoption1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtquestion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(408, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 25);
            this.label8.TabIndex = 53;
            this.label8.Text = "Question Bank";
            // 
            // QuestionDGV
            // 
            this.QuestionDGV.BackgroundColor = System.Drawing.Color.White;
            this.QuestionDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QuestionDGV.Location = new System.Drawing.Point(12, 361);
            this.QuestionDGV.Name = "QuestionDGV";
            this.QuestionDGV.RowHeadersWidth = 51;
            this.QuestionDGV.RowTemplate.Height = 24;
            this.QuestionDGV.Size = new System.Drawing.Size(961, 367);
            this.QuestionDGV.TabIndex = 52;
            this.QuestionDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.QuestionDGV_CellDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(561, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 25);
            this.label7.TabIndex = 51;
            this.label7.Text = "Konu:";
            // 
            // cmbsubject
            // 
            this.cmbsubject.FormattingEnabled = true;
            this.cmbsubject.Location = new System.Drawing.Point(632, 60);
            this.cmbsubject.Name = "cmbsubject";
            this.cmbsubject.Size = new System.Drawing.Size(147, 33);
            this.cmbsubject.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(627, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 25);
            this.label6.TabIndex = 49;
            this.label6.Text = "Doğru Cevap:";
            // 
            // txtanswer
            // 
            this.txtanswer.Location = new System.Drawing.Point(632, 224);
            this.txtanswer.Name = "txtanswer";
            this.txtanswer.Size = new System.Drawing.Size(234, 30);
            this.txtanswer.TabIndex = 48;
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.IndianRed;
            this.btnreset.Location = new System.Drawing.Point(566, 278);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(124, 39);
            this.btnreset.TabIndex = 47;
            this.btnreset.Text = "Temizle";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.IndianRed;
            this.btnedit.Location = new System.Drawing.Point(413, 278);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(123, 39);
            this.btnedit.TabIndex = 46;
            this.btnedit.Text = "Güncelle";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.IndianRed;
            this.btnsave.Location = new System.Drawing.Point(250, 278);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(143, 39);
            this.btnsave.TabIndex = 45;
            this.btnsave.Text = "Kaydet";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 44;
            this.label5.Text = "Seçenek 4:";
            // 
            // txtoption4
            // 
            this.txtoption4.Location = new System.Drawing.Point(323, 224);
            this.txtoption4.Name = "txtoption4";
            this.txtoption4.Size = new System.Drawing.Size(234, 30);
            this.txtoption4.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 42;
            this.label4.Text = "Seçenek 3:";
            // 
            // txtoption3
            // 
            this.txtoption3.Location = new System.Drawing.Point(49, 224);
            this.txtoption3.Name = "txtoption3";
            this.txtoption3.Size = new System.Drawing.Size(234, 30);
            this.txtoption3.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(627, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "Seçenek 2:";
            // 
            // txtoption2
            // 
            this.txtoption2.Location = new System.Drawing.Point(632, 152);
            this.txtoption2.Name = "txtoption2";
            this.txtoption2.Size = new System.Drawing.Size(234, 30);
            this.txtoption2.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "Seçenek 1:";
            // 
            // txtoption1
            // 
            this.txtoption1.Location = new System.Drawing.Point(323, 152);
            this.txtoption1.Name = "txtoption1";
            this.txtoption1.Size = new System.Drawing.Size(234, 30);
            this.txtoption1.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Soru:";
            // 
            // txtquestion
            // 
            this.txtquestion.Location = new System.Drawing.Point(49, 152);
            this.txtquestion.Name = "txtquestion";
            this.txtquestion.Size = new System.Drawing.Size(234, 30);
            this.txtquestion.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Location = new System.Drawing.Point(816, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 71);
            this.button1.TabIndex = 54;
            this.button1.Text = "Konu Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(932, -3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 42);
            this.button2.TabIndex = 55;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 740);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.QuestionDGV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbsubject);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtanswer);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtoption4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtoption3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtoption2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtoption1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtquestion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Question";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question";
            ((System.ComponentModel.ISupportInitialize)(this.QuestionDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView QuestionDGV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbsubject;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtanswer;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtoption4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtoption3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtoption2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtoption1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtquestion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}