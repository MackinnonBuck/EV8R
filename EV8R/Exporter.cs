using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EV8R
{
    class Exporter
    {
        /// <summary>
        /// Stores each subfile generated.
        /// </summary>
        private List<SubFile> subFiles;

        /// <summary>
        /// Number of bits in a megabyte.
        /// </summary>
        private const int BYTES_IN_MB = 1048576;

        /// <summary>
        /// The output file size limit in bytes.
        /// </summary>
        private int byteLimit;

        /// <summary>
        /// The output file size limit in megabytes.
        /// </summary>
        public int SizeLimit
        {
            get
            {
                return byteLimit / BYTES_IN_MB;
            }
            set
            {
                byteLimit = value * BYTES_IN_MB;
            }
        }

        /// <summary>
        /// Initializes this instance with given settings.
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="sizeLimitInMegabytes"></param>
        public Exporter(int sizeLimitInMegabytes)
        {
            SizeLimit = sizeLimitInMegabytes;
            subFiles = new List<SubFile>();
        }

        /// <summary>
        /// Loads the given file and generates EV8R subfiles.
        /// </summary>
        /// <param name="fileName"></param>
        public void Load(string fileName)
        {
            Guid guid = Guid.NewGuid();

            BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open));
            
            for (int subFileID = 0; reader.BaseStream.Position != reader.BaseStream.Length; subFileID++)
            {
                SubFile subFile = new SubFile(guid, fileName, subFileID, byteLimit);
                subFile.LoadFromBase(reader);
                subFiles.Add(subFile);
            }

            subFiles.Last().IsLast = true;

            reader.Close();
        }

        /// <summary>
        /// Writes each child subfile to the given folder path.
        /// </summary>
        /// <param name="folderPath"></param>
        public void Write(string folderPath)
        {
            foreach (SubFile file in subFiles)
                file.Write(folderPath);
        }

        /// <summary>
        /// Erases all subfile data.
        /// </summary>
        public void Clear()
        {
            subFiles.Clear();
        }
    }
}
