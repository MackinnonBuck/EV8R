﻿using System;
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
        /// Loads subfiles from the given array of file names.
        /// </summary>
        /// <param name="fileNames"></param>
        public void Load(string[] fileNames)
        {
            subFiles.Clear();

            foreach (string fileName in fileNames)
            {
                SubFile subFile = new SubFile();
                subFile.LoadFromExisting(fileName);

                if (!subFiles.ContainsKey(subFile.GUID))
                    subFiles[subFile.GUID] = new Dictionary<int, SubFile>();

                subFiles[subFile.GUID][subFile.SubFileIndex] = subFile;
            }
        }

        /// <summary>
        /// Uses generated subfile data to reform the original files and write them to the given folder path.
        /// </summary>
        /// <param name="folderPath"></param>
        public void Write(string folderPath)
        {
            foreach (var subFileData in subFiles)
            {
                bool hasReachedLast = false;
                List<byte> buffer = new List<byte>();

                SubFile subFile = null;

                for (int i = 0; subFileData.Value.ContainsKey(i); i++)
                {
                    subFile = subFileData.Value[i];

                    if (subFile.IsLast)
                        hasReachedLast = true;

                    buffer.AddRange(subFile.Buffer);
                }

                if (!hasReachedLast)
                    return;

                string fileName = subFile.FileName.Remove(subFile.FileName.LastIndexOf('.'));
                int lastUnderscore = subFile.FileName.LastIndexOf('_');
                fileName = fileName.Remove(lastUnderscore, fileName.IndexOf('.', lastUnderscore) - lastUnderscore);

                BinaryWriter writer = new BinaryWriter(File.Open(folderPath + '\\' + fileName, FileMode.Create));

                // Writes the combined buffer data.
                writer.Write(buffer.ToArray());

                writer.Close();
            }
        }
    }
}