using EV8R;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace runme
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string directory = new FileInfo(path).Directory.FullName;
            string[] files = Directory.GetFiles(directory, "*.ev8r");

            if (files.Length == 0)
                return;

            Importer importer = new Importer();

            foreach (string file in files)
                importer.Load(file);

            if (importer.Write(directory))
            {
                foreach (string file in files)
                    File.Delete(file);
            }         
        }
    }
}
