namespace BTCN
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tlsNew = new System.Windows.Forms.ToolStripMenuItem();
			this.tlsQuit = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnAdd = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.txbSearch = new System.Windows.Forms.ToolStripTextBox();
			this.dgvStudent = new System.Windows.Forms.DataGridView();
			this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.faculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.score = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(826, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// chứcNăngToolStripMenuItem
			// 
			this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsNew,
            this.tlsQuit});
			this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
			this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
			this.chứcNăngToolStripMenuItem.Text = "Chức năng";
			// 
			// tlsNew
			// 
			this.tlsNew.Name = "tlsNew";
			this.tlsNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.tlsNew.Size = new System.Drawing.Size(224, 26);
			this.tlsNew.Text = "New";
			this.tlsNew.Click += new System.EventHandler(this.tlsNew_Click);
			// 
			// tlsQuit
			// 
			this.tlsQuit.Name = "tlsQuit";
			this.tlsQuit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
			this.tlsQuit.Size = new System.Drawing.Size(224, 26);
			this.tlsQuit.Text = "Quit";
			this.tlsQuit.Click += new System.EventHandler(this.tlsQuit_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.toolStripLabel1,
            this.txbSearch});
			this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.toolStrip1.Location = new System.Drawing.Point(0, 28);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(826, 35);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
			this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnAdd.Margin = new System.Windows.Forms.Padding(40, 1, 20, 2);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(124, 32);
			this.btnAdd.Text = "Thêm Mới";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(169, 32);
			this.toolStripLabel1.Text = "Tìm kiếm theo tên";
			// 
			// txbSearch
			// 
			this.txbSearch.BackColor = System.Drawing.Color.Gainsboro;
			this.txbSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txbSearch.Name = "txbSearch";
			this.txbSearch.Size = new System.Drawing.Size(225, 35);
			this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
			// 
			// dgvStudent
			// 
			this.dgvStudent.AllowUserToAddRows = false;
			this.dgvStudent.AllowUserToDeleteRows = false;
			this.dgvStudent.AllowUserToResizeColumns = false;
			this.dgvStudent.AllowUserToResizeRows = false;
			this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.id,
            this.name,
            this.faculty,
            this.score});
			this.dgvStudent.Location = new System.Drawing.Point(12, 66);
			this.dgvStudent.Name = "dgvStudent";
			this.dgvStudent.RowHeadersWidth = 51;
			this.dgvStudent.RowTemplate.Height = 24;
			this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvStudent.Size = new System.Drawing.Size(801, 373);
			this.dgvStudent.TabIndex = 2;
			// 
			// STT
			// 
			this.STT.DataPropertyName = "STT";
			this.STT.HeaderText = "STT";
			this.STT.MinimumWidth = 6;
			this.STT.Name = "STT";
			this.STT.Width = 50;
			// 
			// id
			// 
			this.id.DataPropertyName = "Id";
			this.id.HeaderText = "MSSV";
			this.id.MinimumWidth = 6;
			this.id.Name = "id";
			this.id.Width = 125;
			// 
			// name
			// 
			this.name.DataPropertyName = "name";
			this.name.HeaderText = "Tên sinh viên";
			this.name.MinimumWidth = 6;
			this.name.Name = "name";
			this.name.Width = 125;
			// 
			// faculty
			// 
			this.faculty.DataPropertyName = "faculty";
			this.faculty.HeaderText = "Khoa";
			this.faculty.MinimumWidth = 6;
			this.faculty.Name = "faculty";
			this.faculty.Width = 125;
			// 
			// score
			// 
			this.score.DataPropertyName = "score";
			this.score.HeaderText = "Điểm TB";
			this.score.MinimumWidth = 6;
			this.score.Name = "score";
			this.score.Width = 125;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(826, 451);
			this.Controls.Add(this.dgvStudent);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnAdd;
		private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tlsNew;
		private System.Windows.Forms.ToolStripMenuItem tlsQuit;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripTextBox txbSearch;
		private System.Windows.Forms.DataGridView dgvStudent;
		private System.Windows.Forms.DataGridViewTextBoxColumn STT;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn name;
		private System.Windows.Forms.DataGridViewTextBoxColumn faculty;
		private System.Windows.Forms.DataGridViewTextBoxColumn score;
	}
}

