using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

using ArchiveLib;

namespace Sonic_Shuffle_Model_Importer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }


        public static List<string> MDL_Entries;

        public static MDLArchive OpenMDLArchive(string path)
        {
            byte[] file = File.ReadAllBytes(path);
            MDLArchive archive = new MDLArchive(file);

            int offset = 0;

            for(int i = 0; i < archive.Entries.Count; i++)
            {

                MDLArchive.MDLArchiveEntry entry = (MDLArchive.MDLArchiveEntry)archive.Entries[i];

                Debug.WriteLine("Entry " + i + ": " + entry.Name + " (Offset: 0x" + offset.ToString("X") + ", Size: 0x" + entry.Data.Length.ToString("X") + ")");

                offset += entry.Data.Length;
            }

            Debug.WriteLine("MDL Entries: " + archive.Entries.Count);

            return archive;
        }
    }
}
