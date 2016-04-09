using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EV8R
{
    /// <summary>
    /// Represents a file generated from the base file provided.
    /// </summary>
    class SubFile
    {
        /// <summary>
        /// Represents the size of a 16-byte globally unique identifier.
        /// </summary>
        private const int SIZEOF_GUID = 16;

        /// <summary>
        /// The globally unique identifier that distinguishes the base file from other base files.
        /// </summary>
        public Guid GUID { get; private set; }

        /// <summary>
        /// The name of the subfile.
        /// </summary>
        public string FileName { get; private set; }

        /// <summary>
        /// Indicates what part of the file this subfile represents.
        /// </summary>
        public int SubFileIndex { get; private set; }

        /// <summary>
        /// Indicates if this subfile is the last that makes up the base file.
        /// </summary>
        public bool IsLast { get; set; }

        /// <summary>
        /// The bytes contained in the file.
        /// </summary>
        public byte[] Buffer { get; private set; }

        /// <summary>
        /// Returns the total size of custom injected data into the subfile.
        /// </summary>
        private int CDataSize
        {
            get
            {
                return
                    SIZEOF_GUID // The globally unique identifier.
                    + sizeof(int) // The sub-file index.
                    + sizeof(bool); // End-of-file marker.
            }
        }

        /// <summary>
        /// Initializes this instance with uninitialized file data.
        /// </summary>
        public SubFile()
        {
            GUID = Guid.Empty;
            FileName = string.Empty;
            SubFileIndex = -1;
            IsLast = false;
        }

        /// <summary>
        /// Initializes this instance with the given file index.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="subFileIndex"></param>
        /// <param name="maxBufferSize"></param>
        public SubFile(Guid guid, string fileName, int subFileIndex, int maxBufferSize)
        {
            GUID = guid;
            SubFileIndex = subFileIndex;
            string visibleName = new FileInfo(fileName).Name;
            FileName = (subFileIndex == 0 ? visibleName : visibleName.Insert(visibleName.LastIndexOf('.'), "_" + SubFileIndex)) + ".ev8r";
            IsLast = false;
            Buffer = new byte[maxBufferSize - CDataSize];
        }

        /// <summary>
        /// Generates buffer data from the given BinaryReader.
        /// </summary>
        /// <param name="reader"></param>
        public void LoadFromBase(BinaryReader reader)
        {
            if (Buffer == null)
                return;

            Array.Clear(Buffer, 0, Buffer.Length);
            Buffer = reader.ReadBytes(Buffer.Length);
        }

        /// <summary>
        /// Loads file data from an existing EV8R file.
        /// </summary>
        /// <param name="fileName"></param>
        public void LoadFromExisting(string fileName)
        {
            FileInfo fileInfo = new FileInfo(fileName);
            FileName = fileInfo.Name;
            long sizeInBytes = fileInfo.Length;

            BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open));

            // Generates GUID data from the first 16 bytes of the file.
            GUID = new Guid(reader.ReadBytes(SIZEOF_GUID));
            
            // Gets the sub-file index from the next 4 bytes of the file.
            SubFileIndex = reader.ReadInt32();

            // Determines if this is the last sub-file from the next byte.
            IsLast = reader.ReadBoolean();

            // Reads until the end of the file and fills the data into the buffer.
            Buffer = reader.ReadBytes((int)sizeInBytes - CDataSize);

            reader.Close();
        }

        /// <summary>
        /// Writes the custom data and buffer data to the given folder.
        /// </summary>
        /// <param name="folderPath"></param>
        public void Write(string folderPath)
        {
            if (Buffer == null)
                return;

            BinaryWriter writer = new BinaryWriter(File.Open(folderPath + FileName, FileMode.Create));

            // Writes the GUID data.
            writer.Write(GUID.ToByteArray());

            // Writes the sub-file index.
            writer.Write(SubFileIndex);

            // Writes the marker indicating if this is the last subfile.
            writer.Write(IsLast);

            // Writes the actual file data.
            writer.Write(Buffer);

            writer.Close();
        }
    }
}
