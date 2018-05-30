using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldProject {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("Hello, World!");

			Student student = new Student();
			student.SetFirstname("Frank");
			student.SetLastname("Castle");
			student.SetStudentId(123);
			student.SetGPA(3.7);
			student.SetSAT(750);
			student.SetIsFemale(false);

			string fname;
			string lname;
			int Sid;
			double GPA;
			int SAT;
			bool Gender;

			fname = student.GetFirstname();
			lname = student.GetLastname();
			Sid = student.GetStudentId();
			GPA = student.GetGPA();
			SAT = student.GetSAT();
			Gender = student.GetIsFemale();

			Console.WriteLine(fname + " " + lname + " " + Sid + " " + GPA + " " + SAT + " " + Gender);

		}
	}
}
