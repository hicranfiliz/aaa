namespace ExamApplication
{
    partial class Subject
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
            this.SubjectDGV = new System.Windows.Forms.DataGridView();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // SubjectDGV
            // 
            this.SubjectDGV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.SubjectDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectDGV.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.SubjectDGV.Location = new System.Drawing.Point(12, 279);
            this.SubjectDGV.Name = "SubjectDGV";
            this.SubjectDGV.RowHeadersWidth = 51;
            this.SubjectDGV.RowTemplate.Height = 24;
            this.SubjectDGV.Size = new System.Drawing.Size(581, 240);
            this.SubjectDGV.TabIndex = 25;
            this.SubjectDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SubjectDGV_CellDoubleClick);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.IndianRed;
            this.btnreset.Location = new System.Drawing.Point(393, 207);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(124, 39);
            this.btnreset.TabIndex = 24;
            this.btnreset.Text = "Sil";
            this.btnreset.UseVisualStyleBackColor = false;
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.IndianRed;
            this.btnedit.Location = new System.Drawing.Point(243, 207);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(123, 39);
            this.btnedit.TabIndex = 23;
            this.btnedit.Text = "Güncelle";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.IndianRed;
            this.btnsave.Location = new System.Drawing.Point(80, 207);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(143, 39);
            this.btnsave.TabIndex = 22;
            this.btnsave.Text = "Kaydet";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Konu Adı:";
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Location = new System.Drawing.Point(80, 158);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(437, 30);
            this.txtSubjectName.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(550, -3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 42);
            this.button2.TabIndex = 56;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(605, 549);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SubjectDGV);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSubjectName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Subject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subject";
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SubjectDGV;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.Button button2;
    }
}