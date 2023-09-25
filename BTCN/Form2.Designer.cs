namespace BTCN
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txbID = new System.Windows.Forms.TextBox();
			this.txbName = new System.Windows.Forms.TextBox();
			this.txbScore = new System.Windows.Forms.TextBox();
			this.btnAddNew = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.cbFaculty = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(26, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã số sinh viên";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(39, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 16);
			this.label2.TabIndex = 0;
			this.label2.Text = "Tên sinh viên";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(86, 101);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 16);
			this.label3.TabIndex = 0;
			this.label3.Text = "Khoa";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(27, 135);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(98, 16);
			this.label4.TabIndex = 0;
			this.label4.Text = "Điểm trung bình";
			// 
			// txbID
			// 
			this.txbID.Location = new System.Drawing.Point(143, 22);
			this.txbID.Name = "txbID";
			this.txbID.Size = new System.Drawing.Size(210, 22);
			this.txbID.TabIndex = 1;
			// 
			// txbName
			// 
			this.txbName.Location = new System.Drawing.Point(143, 62);
			this.txbName.Name = "txbName";
			this.txbName.Size = new System.Drawing.Size(210, 22);
			this.txbName.TabIndex = 1;
			// 
			// txbScore
			// 
			this.txbScore.Location = new System.Drawing.Point(143, 132);
			this.txbScore.Name = "txbScore";
			this.txbScore.Size = new System.Drawing.Size(210, 22);
			this.txbScore.TabIndex = 1;
			// 
			// btnAddNew
			// 
			this.btnAddNew.BackColor = System.Drawing.Color.LightGreen;
			this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddNew.Location = new System.Drawing.Point(157, 170);
			this.btnAddNew.Name = "btnAddNew";
			this.btnAddNew.Size = new System.Drawing.Size(95, 39);
			this.btnAddNew.TabIndex = 2;
			this.btnAddNew.Text = "Thêm";
			this.btnAddNew.UseVisualStyleBackColor = false;
			this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.IndianRed;
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(258, 170);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(95, 39);
			this.btnExit.TabIndex = 2;
			this.btnExit.Text = "Thoát";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// cbFaculty
			// 
			this.cbFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbFaculty.FormattingEnabled = true;
			this.cbFaculty.Location = new System.Drawing.Point(143, 98);
			this.cbFaculty.Name = "cbFaculty";
			this.cbFaculty.Size = new System.Drawing.Size(210, 24);
			this.cbFaculty.TabIndex = 3;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(389, 225);
			this.Controls.Add(this.cbFaculty);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnAddNew);
			this.Controls.Add(this.txbScore);
			this.Controls.Add(this.txbName);
			this.Controls.Add(this.txbID);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form2";
			this.Text = "Form2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txbID;
		private System.Windows.Forms.TextBox txbName;
		private System.Windows.Forms.TextBox txbScore;
		private System.Windows.Forms.Button btnAddNew;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.ComboBox cbFaculty;
	}
}