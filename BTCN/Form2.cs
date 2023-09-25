using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTCN
{
	public partial class Form2 : Form
	{
		DataGridView dgvStudent;
		List<Student> students;
		public Form2(DataGridView dgvStudent, List<Student> students)
		{
			InitializeComponent();
			loadListFaculty();
			this.dgvStudent = dgvStudent;
			this.students = students;
		}

		void loadListFaculty()
		{
			cbFaculty.Items.Add("Công nghệ thông tin");
			cbFaculty.Items.Add("Quản trị kinh doanh");
			cbFaculty.Items.Add("Ngôn ngữ anh");
		}

		private void btnAddNew_Click(object sender, EventArgs e)
		{
			
			if (txbID.Text.Length == 0 || txbName.Text.Length == 0 || cbFaculty.Text.Length == 0 || txbScore.Text.Length == 0)
				MessageBox.Show("Bạn cần phải nhập đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			else if(students.Where(p => p.Id == txbID.Text).Count() != 0)
				MessageBox.Show("Sinh viên này đã tồn tại trong hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			else
			{
				double score;
				if (!double.TryParse(txbScore.Text, out score) || score < 0 || score > 10)
					MessageBox.Show("Điểm của sinh viên phải từ 0 - 10", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				else
				{
					students.Add(new Student() { STT = students.Count()+1, Id = txbID.Text, Name = txbName.Text, Faculty = cbFaculty.Text, Score = Convert.ToDouble(txbScore.Text) });
					dgvStudent.DataSource = null;
					dgvStudent.DataSource = students;
				}
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
