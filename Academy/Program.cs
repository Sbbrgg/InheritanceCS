//#define INHERITANCE_1
//#define INHERITANCE_2
//#define SAVE_TO_FILE
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Program
	{
		static readonly string delimiter = "\n------------------------------------------------------------------------------------------------------------------\n";
		static void Main(string[] args)
		{
#if INHERITANCE_1
			Console.WriteLine("Academy");
			Human human = new Human("Montana", "Antonio", 25);
			human.Info();
			Console.WriteLine(delimiter);
			Student student = new Student("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 90, 95);
			student.Info();
			Console.WriteLine(delimiter);
			Teacher teacher = new Teacher("White", "Walter", 50, "Chemistry", 25);
			teacher.Info();
			Console.WriteLine(delimiter); 
#endif

#if INHERITANCE_2
			Human human = new Human("Pinkman", "Jessie", 22);
			human.Info();
			Console.WriteLine(delimiter);
			Student student = new Student(human, "Chemistry", "WW_220", 90, 95);
			student.Info();
			Console.WriteLine(delimiter);

			Teacher teacher = new Teacher(new Human("White", "Walter", 50), "Chemistry", 25);
			teacher.Info();
			Console.WriteLine(delimiter);

			Human h_hank = new Human("Schreder", "Hank", 40);
			Student s_hank = new Student(h_hank, "Cryminalisic", "OBN", 50, 60);
			Graduate graduate = new Graduate(s_hank, "How to catch Heisenberg");
			graduate.Info();
			Console.WriteLine(delimiter);
#endif

			/*Base-class pointers: Generalisation (Upcast - привидение дочернего объекта)

			*/
#if SAVE_TO_FILE
			Human[] group =
				{
				new Student("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 90, 95),
				new Teacher("White", "Walter", 50, "Chemistry", 25),
				new Graduate("Schreder", "Hank", 40, "Cryminalisic", "OBN", 50, 60, "How to catch Heisenberg"),
				new Student("Vercetty", "Tommy", 30, "Theft", "Vice", 98, 99),
				new Teacher("Diaz", "Ricardo", 50, "Weapons distribution", 20),
				new Teacher("Schwaznegger", "Arnold", 78, "Heavy Metal", 65)
			};
			Console.WriteLine(delimiter);
			//Specialisation: virtual методы
			for (int i = 0; i < group.Length; i++)
			{
				//group[i].Info();
				Console.WriteLine(group[i]);
				Console.WriteLine(delimiter);
			}
			SaveToFile(group, "Group.txt"); 
#endif
			Human[] Group = LoadFromFile("Group.txt");
			for(int i = 0; i < Group.Length; i++)
			{
				Console.WriteLine(Group[i]);
				Console.WriteLine(delimiter);
			}
		}


		static void SaveToFile(Human[] group, string fileName)
		{
			StreamWriter writer = new StreamWriter(fileName);
			for(int i = 0; i < group.Length; i++)
			{
				writer.WriteLine(group[i].GetType().Name + "|" + group[i].ToFileString());
			}
			writer.Close();
		}
		static Human[] LoadFromFile(string filename)
		{
			int lines = CountLineInFile(filename);
			Human[] group = new Human[lines];
			int i = 0;

			StreamReader reader = new StreamReader(filename);
			string line;
			while((line = reader.ReadLine())!=null)
			{
				if(line.Length == 0) continue;
				string[] parts = line.Split('|');
				if(parts.Length < 2) continue;

				group[i] = CreateHuman(parts[0], parts[1]);
				i++;
			}

			reader.Close();
			return group;
		}
		static int CountLineInFile(string filename)
		{
			int count = 0;
			StreamReader reader = new StreamReader(filename);
			while(reader.ReadLine()!= null)
				count++;
			reader.Close();
			return count;
		}
		static Human CreateHuman(string typeName, string data)
		{
			string[] fields = data.Split(';');
			switch(typeName)
			{
				case "Human":
					return new Human
						(
							fields[0], fields[1], Convert.ToInt32(fields[2])
						);
				case "Student":
					return new Student
						(
							fields[0], fields[1], Convert.ToInt32(fields[2]),
							fields[3], fields[4], Convert.ToDouble(fields[5]),
							Convert.ToDouble(fields[6])
						);
				case "Teacher":
					return new Teacher
						(
							fields[0], fields[1], Convert.ToInt32(fields[2]),
							fields[3], Convert.ToInt32(fields[4])
						);
				case "Graduate":
					return new Graduate
						(
							fields[0], fields[1], Convert.ToInt32(fields[2]),
							fields[3], fields[4], Convert.ToDouble(fields[5]),
							Convert.ToDouble(fields[6]), fields[7]
						);
			}
			return null;
		}
	}
}
