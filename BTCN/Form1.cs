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
	public partial class Form1 : Form
	{
		List<Student> students = new List<Student>();
		public Form1()
		{
			InitializeComponent();
		}

		void addStudent()
		{
			Form2 form = new Form2(dgvStudent, students);
			form.ShowDialog();
		}

		private void tlsNew_Click(object sender, EventArgs e)
		{
			addStudent();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			addStudent();
		}

		private void tlsQuit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void txbSearch_TextChanged(object sender, EventArgs e)
		{
			ToolStripTextBox toolStripTextBox = sender as ToolStripTextBox;

			if(toolStripTextBox.Text.Length == 0)
			{
				dgvStudent.DataSource = null;
				dgvStudent.DataSource = students;
			}
			else
			{
				dgvStudent.DataSource = null;
				List<Student> student = new List<Student>();
				student = students.Where(p => p.Name.Contains(toolStripTextBox.Text)).ToList();

				if(student.Count > 0)
				{
					dgvStudent.DataSource = null;
					dgvStudent.DataSource = student;
				}
			}
		}
	}
}
