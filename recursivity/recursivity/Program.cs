using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Recursivity {
	class Program {
		static void Main(string[] args) {
			string path = @"C:\Intel\";
			string directoryPath = Path.GetDirectoryName(path);
			GetChildren(directoryPath);
		}

		static void GetChildren(string path) {
			Console.WriteLine(path);
			string[] paths = Directory.GetDirectories(path);
			foreach(var childPath in paths) {
				GetChildren(childPath);
			}
		}
	}
}
}
