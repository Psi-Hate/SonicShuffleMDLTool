using ArchiveLib;
using NodeBuffer;
using SAModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ArchiveLib.MDLArchive;

namespace Sonic_Shuffle_Model_Importer
{
    public partial class Form1 : Form
    {
        public class MDLHeader
        {
            public UInt16 unk0;
            public UInt16 fileCount;
            public UInt32 unk4;
            public MDLTableEntry[] entries; // Till End of 0x1000 Chunk
        }

        public class MDLTableEntry
        {
            /* 0x00 */
            public UInt32 type;
            /* 0x04 */
            public UInt32 size;
            /* 0x08 */
            public UInt32 offset;
        }   /* 0xC */

        public MDLArchive archive;
        public string currentFilePath;
        public string gdiFilePath;
        public string modFilePath;
        public string outputFilePath;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MDL Files (*.mdl)|*.mdl";
            openFileDialog.Title = "Select an MDL File";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                AddFileToList(openFileDialog.FileName);
                currentFilePath = openFileDialog.FileName;
            }
        }

        private void AddFileToList(string filePath)
        {
            // Implement logic to add the file to the list view
            // For example, you can read the file and extract necessary information to display
            // in the list view, such as file name, size, etc.

            textBox1.Text = filePath;
            int offset = 0x1000;
            archive = Program.OpenMDLArchive(filePath);
            fileList.Items.Clear();

            foreach (var entry in archive.Entries)
            {
                fileList.Items.Add(new ListViewItem(new string[] { $"{archive.Entries.IndexOf(entry)}", $"0x{offset.ToString("X")}", $"{entry.Name}", $"0x{entry.Data.Length.ToString("X")}" }));
                offset = offset + (int)Align(archive.Entries.IndexOf(entry) + entry.Data.Length, 0x1000);
            }

        }

        private void fileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedItems = fileList.SelectedItems;
            Debug.WriteLine(selectedItems.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTN_AddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "NJ Files (*.nj)|*.nj";
            openFileDialog.Title = "Select an NJ File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

            }
        }

        static long Align(long value, long alignment)
        {
            return (value + alignment - 1) & ~(alignment - 1);
        }

        private void BTN_CreateMDL_Click(object sender, EventArgs e)
        {
            List<string> filePathList = new List<string>();
            List<byte[]> fileDataList = new List<byte[]>();

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Allow selection of more than one file
                openFileDialog.Multiselect = true;

                // Filter to display all file extensions
                openFileDialog.Filter = "All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // FileNames contains the full paths of all selected files
                    foreach (string filePath in openFileDialog.FileNames)
                    {
                        try
                        {
                            // Action: Read or process each file
                            fileDataList.Add(File.ReadAllBytes(filePath));
                            filePathList.Add(filePath);
                            Debug.WriteLine($"Processed: {Path.GetFileName(filePath)}");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error reading {filePath}: {ex.Message}");
                        }
                    }
                }
            }

            MDLHeader header = new MDLHeader()
            {
                unk0 = 0x0200,
                fileCount = (ushort)fileDataList.Count,
                unk4 = 0x00E80000,
                entries = new MDLTableEntry[fileDataList.Count]
            };

            Buffer mdlBuf = new Buffer(0x1000);

            mdlBuf.WriteU16BE(0x00, header.unk0);
            mdlBuf.WriteU16(0x02, header.fileCount);
            mdlBuf.WriteU32BE(0x04, header.unk4);

            int chunkOffset = 0x1000;

            for (int i = 0; i < fileDataList.Count; i++)
            {
                mdlBuf.Resize((int)Align(mdlBuf._buffer.Length + fileDataList[i].Length, 0x1000));


                string extension = Encoding.ASCII.GetString(fileDataList[i], 0, 3);
                MDLEntryType fileType = 0;

                switch (extension)
                {
                    case "PVM":
                        fileType = MDLEntryType.PVM;
                        break;
                    case "NJ":
                        fileType = MDLEntryType.Motion;
                        break;
                    case "NMD":
                        fileType = MDLEntryType.Motion;
                        break;
                    case "NJM":
                        fileType = MDLEntryType.ShapeMotion;
                        break;
                    case "NJC":
                        fileType = MDLEntryType.ChunkModel;
                        break;
                    default:
                        Debug.WriteLine($"Index {i}: {extension}");
                        fileType = MDLEntryType.Unknown;
                        break;
                }

                int entryOffset = 0x08 + (i * 0x0C);
                int fileOffset = chunkOffset;
                int fileSize = fileDataList[i].Length;

                mdlBuf.WriteU32(entryOffset + 0x00, (uint)fileType);
                mdlBuf.WriteU32(entryOffset + 0x04, (uint)fileSize);
                mdlBuf.WriteU32(entryOffset + 0x08, (uint)fileOffset);

                mdlBuf.WriteBytes(chunkOffset, fileDataList[i]);

                //mdl.Entries.Add(new MDLArchive.MDLArchiveEntry() { Name = $"{mdl.Entries.Count}", Data = fileDataList[i] });

                chunkOffset = (int)Align(chunkOffset + fileDataList[i].Length, 0x1000);
            }
            currentFilePath = "Output.MDL";
            File.WriteAllBytes("Output.MDL", mdlBuf._buffer);

            AddFileToList("Output.MDL");

        }

        private void BTN_SaveMDL_Click(object sender, EventArgs e)
        {
            if (archive == null)
            {
                MessageBox.Show("No MDL file loaded. Please open an MDL file first.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "MDL Files (*.mdl)|*.mdl";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(saveFileDialog.FileName, File.ReadAllBytes(currentFilePath));
                MessageBox.Show("MDL file saved successfully!");
            }

        }

        private void BTN_ExtractMDL_Click(object sender, EventArgs e)
        {
            if (archive == null)
            {
                MessageBox.Show("No MDL file loaded. Please open an MDL file first.");
                return;
            }

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string extractPath = folderBrowserDialog.SelectedPath;
                foreach (var entry in archive.Entries)
                {
                    string filePath = Path.Combine(extractPath, entry.Name);
                    File.WriteAllBytes(filePath, entry.Data);
                    Debug.WriteLine($"Extracted: {entry.Name}");
                }
                MessageBox.Show("MDL file extracted successfully!");
            }
        }

        private void BTN_OrigGDI_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                gdiFilePath = openFileDialog.FileName;
                Text_OrigGDI.Text = gdiFilePath;
            }
        }

        private void BTN_ModDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialogue = new FolderBrowserDialog();

            if (folderBrowserDialogue.ShowDialog() == DialogResult.OK)
            {
                modFilePath = folderBrowserDialogue.SelectedPath;
                Text_ModPath.Text = modFilePath;
            }
        }

        private void BTN_OutDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialogue = new FolderBrowserDialog();

            if (folderBrowserDialogue.ShowDialog() == DialogResult.OK)
            {
                outputFilePath = folderBrowserDialogue.SelectedPath;
                Text_OutPath.Text = outputFilePath;
            }
        }

        private void BTN_BuildGDI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gdiFilePath) || string.IsNullOrEmpty(modFilePath) || string.IsNullOrEmpty(outputFilePath))
            {
                MessageBox.Show("Please select the GDI file, modified files directory, and output directory before building the GDI.");
                return;
            }

            string args = $"-gdi \"{gdiFilePath}\" -data \"{modFilePath}\" -output \"{outputFilePath}\" -rebuild";
            Debug.WriteLine(args);
            Process.Start("buildgdi.exe", args);

        }

        private void BTN_TestGdi_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo() { FileName = $"{outputFilePath}\\disc.gdi", UseShellExecute = true });
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
