using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EV8R
{
    class Importer
    {
        /// <summary>
        /// A list containing all imported subFiles.
        /// </summary>
        Dictionary<Guid, Dictionary<int, SubFile>> subFiles;

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public Importer()
        {
            subFiles = new Dictionary<Guid, Dictionary<int, SubFile>>();
        }

        /// <summary>
        /// Loads a subfile from the given file name.
        /// </summary>
        /// <param name="fileName"></param>
        public void Load(string fileName)
        {
            SubFile subFile = new SubFile();
            subFile.LoadFromExisting(fileName);

            if (!subFiles.ContainsKey(subFile.GUID))
                subFiles[subFile.GUID] = new Dictionary<int, SubFile>();

            subFiles[subFile.GUID][subFile.SubFileIndex] = subFile;
        }

        /// <summary>
        /// Uses generated subfile data to reform the original files and write them to the given folder path.
        /// </summary>
        /// <param name="folderPath"></param>
        public bool Write(string folderPath)
        {
            bool hasSucceeded = true;

            foreach (var subFileData in subFiles)
            {
                bool hasReachedLast = false;
                List<byte> buffer = new List<byte>();

                for (int i = 0; subFileData.Value.ContainsKey(i); i++)
                {
                    SubFile subFile = subFileData.Value[i];

                    if (subFile.IsLast)
                        hasReachedLast = true;

                    buffer.AddRange(subFile.Buffer);
                }

                if (!hasReachedLast)
                {
                    hasSucceeded = false;
                    continue;
                }

                string fileName = subFileData.Value[0].FileName;
                fileName = fileName.Remove(fileName.LastIndexOf('.'));

                BinaryWriter writer = new BinaryWriter(File.Open(folderPath + '\\' + fileName, FileMode.Create));

                // Writes the combined buffer data.
                writer.Write(buffer.ToArray());

                writer.Close();
            }

            return hasSucceeded;
        }

        /// <summary>
        /// Clears the list of sub files.
        /// </summary>
        public void Clear()
        {
            subFiles.Clear();
        }
    }
}
