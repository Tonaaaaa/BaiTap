using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCN
{
	public class Student
	{
		private int stt;
		private string id;
		private string name;
		private string faculty;
		private double score;

		public int STT { get => stt; set => stt = value; }
		public string Id { get => id; set => id = value; }
		public string Name { get => name; set => name = value; }
		public string Faculty { get => faculty; set => faculty = value; }
		public double Score { get => score; set => score = value; }
	}
}
