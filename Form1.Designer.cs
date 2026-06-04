namespace Sonic_Shuffle_Model_Importer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            fileList = new ListView();
            chIndex = new ColumnHeader();
            chOffset = new ColumnHeader();
            chName = new ColumnHeader();
            chSize = new ColumnHeader();
            BTN_CreateMDL = new Button();
            BTN_SaveMDL = new Button();
            BTN_ExtractMDL = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            BTN_OrigGDI = new Button();
            textBox1 = new TextBox();
            Tab_MDL = new TabControl();
            tabMDL = new TabPage();
            tabTest = new TabPage();
            BTN_TestGdi = new Button();
            BTN_BuildGDI = new Button();
            Text_OutPath = new TextBox();
            Text_ModPath = new TextBox();
            BTN_OutDir = new Button();
            BTN_ModDir = new Button();
            Text_OrigGDI = new TextBox();
            Tab_MDL.SuspendLayout();
            tabMDL.SuspendLayout();
            tabTest.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(19, 19);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(101, 35);
            button1.TabIndex = 0;
            button1.Text = "Open MDL";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.InitialDirectory = "./";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // fileList
            // 
            fileList.Activation = ItemActivation.OneClick;
            fileList.Columns.AddRange(new ColumnHeader[] { chIndex, chOffset, chName, chSize });
            fileList.GridLines = true;
            fileList.Location = new Point(19, 95);
            fileList.Name = "fileList";
            fileList.Size = new Size(420, 425);
            fileList.TabIndex = 3;
            fileList.UseCompatibleStateImageBehavior = false;
            fileList.View = View.Details;
            fileList.SelectedIndexChanged += fileList_SelectedIndexChanged;
            // 
            // chIndex
            // 
            chIndex.Text = "Index";
            chIndex.Width = 50;
            // 
            // chOffset
            // 
            chOffset.Text = "Offset";
            chOffset.Width = 80;
            // 
            // chName
            // 
            chName.Text = "Name";
            chName.Width = 130;
            // 
            // chSize
            // 
            chSize.Text = "Size";
            chSize.Width = 100;
            // 
            // BTN_CreateMDL
            // 
            BTN_CreateMDL.Location = new Point(128, 19);
            BTN_CreateMDL.Margin = new Padding(3, 4, 3, 4);
            BTN_CreateMDL.Name = "BTN_CreateMDL";
            BTN_CreateMDL.Size = new Size(101, 35);
            BTN_CreateMDL.TabIndex = 5;
            BTN_CreateMDL.Text = "Create MDL";
            BTN_CreateMDL.UseVisualStyleBackColor = true;
            BTN_CreateMDL.Click += BTN_CreateMDL_Click;
            // 
            // BTN_SaveMDL
            // 
            BTN_SaveMDL.Location = new Point(19, 526);
            BTN_SaveMDL.Name = "BTN_SaveMDL";
            BTN_SaveMDL.Size = new Size(101, 33);
            BTN_SaveMDL.TabIndex = 6;
            BTN_SaveMDL.Text = "Save MDL";
            BTN_SaveMDL.UseVisualStyleBackColor = true;
            BTN_SaveMDL.Click += BTN_SaveMDL_Click;
            // 
            // BTN_ExtractMDL
            // 
            BTN_ExtractMDL.Location = new Point(338, 526);
            BTN_ExtractMDL.Name = "BTN_ExtractMDL";
            BTN_ExtractMDL.Size = new Size(101, 32);
            BTN_ExtractMDL.TabIndex = 7;
            BTN_ExtractMDL.Text = "Extract MDL";
            BTN_ExtractMDL.UseVisualStyleBackColor = true;
            BTN_ExtractMDL.Click += BTN_ExtractMDL_Click;
            // 
            // BTN_OrigGDI
            // 
            BTN_OrigGDI.Location = new Point(6, 23);
            BTN_OrigGDI.Name = "BTN_OrigGDI";
            BTN_OrigGDI.Size = new Size(131, 27);
            BTN_OrigGDI.TabIndex = 8;
            BTN_OrigGDI.Text = "Original GDI";
            BTN_OrigGDI.UseVisualStyleBackColor = true;
            BTN_OrigGDI.Click += BTN_OrigGDI_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(420, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Tab_MDL
            // 
            Tab_MDL.Controls.Add(tabMDL);
            Tab_MDL.Controls.Add(tabTest);
            Tab_MDL.Location = new Point(12, 12);
            Tab_MDL.Name = "Tab_MDL";
            Tab_MDL.SelectedIndex = 0;
            Tab_MDL.Size = new Size(518, 598);
            Tab_MDL.TabIndex = 10;
            // 
            // tabMDL
            // 
            tabMDL.Controls.Add(fileList);
            tabMDL.Controls.Add(textBox1);
            tabMDL.Controls.Add(BTN_CreateMDL);
            tabMDL.Controls.Add(BTN_SaveMDL);
            tabMDL.Controls.Add(BTN_ExtractMDL);
            tabMDL.Controls.Add(button1);
            tabMDL.Location = new Point(4, 29);
            tabMDL.Name = "tabMDL";
            tabMDL.Padding = new Padding(3);
            tabMDL.Size = new Size(510, 565);
            tabMDL.TabIndex = 0;
            tabMDL.Text = "MDL";
            tabMDL.UseVisualStyleBackColor = true;
            // 
            // tabTest
            // 
            tabTest.Controls.Add(Text_OrigGDI);
            tabTest.Controls.Add(BTN_TestGdi);
            tabTest.Controls.Add(BTN_BuildGDI);
            tabTest.Controls.Add(Text_OutPath);
            tabTest.Controls.Add(Text_ModPath);
            tabTest.Controls.Add(BTN_OutDir);
            tabTest.Controls.Add(BTN_ModDir);
            tabTest.Controls.Add(BTN_OrigGDI);
            tabTest.Location = new Point(4, 29);
            tabTest.Name = "tabTest";
            tabTest.Padding = new Padding(3);
            tabTest.Size = new Size(510, 565);
            tabTest.TabIndex = 1;
            tabTest.Text = "Test";
            tabTest.UseVisualStyleBackColor = true;
            // 
            // BTN_TestGdi
            // 
            BTN_TestGdi.Location = new Point(143, 122);
            BTN_TestGdi.Name = "BTN_TestGdi";
            BTN_TestGdi.Size = new Size(131, 27);
            BTN_TestGdi.TabIndex = 15;
            BTN_TestGdi.Text = "Test GDI";
            BTN_TestGdi.UseVisualStyleBackColor = true;
            BTN_TestGdi.Click += BTN_TestGdi_Click;
            // 
            // BTN_BuildGDI
            // 
            BTN_BuildGDI.Location = new Point(6, 122);
            BTN_BuildGDI.Name = "BTN_BuildGDI";
            BTN_BuildGDI.Size = new Size(131, 27);
            BTN_BuildGDI.TabIndex = 14;
            BTN_BuildGDI.Text = "Build GDI";
            BTN_BuildGDI.UseVisualStyleBackColor = true;
            BTN_BuildGDI.Click += BTN_BuildGDI_Click;
            // 
            // Text_OutPath
            // 
            Text_OutPath.Location = new Point(143, 89);
            Text_OutPath.Name = "Text_OutPath";
            Text_OutPath.Size = new Size(361, 27);
            Text_OutPath.TabIndex = 13;
            // 
            // Text_ModPath
            // 
            Text_ModPath.Location = new Point(143, 56);
            Text_ModPath.Name = "Text_ModPath";
            Text_ModPath.Size = new Size(361, 27);
            Text_ModPath.TabIndex = 12;
            // 
            // BTN_OutDir
            // 
            BTN_OutDir.Location = new Point(6, 89);
            BTN_OutDir.Name = "BTN_OutDir";
            BTN_OutDir.Size = new Size(131, 27);
            BTN_OutDir.TabIndex = 11;
            BTN_OutDir.Text = "Output Folder";
            BTN_OutDir.UseVisualStyleBackColor = true;
            BTN_OutDir.Click += BTN_OutDir_Click;
            // 
            // BTN_ModDir
            // 
            BTN_ModDir.Location = new Point(6, 56);
            BTN_ModDir.Name = "BTN_ModDir";
            BTN_ModDir.Size = new Size(131, 27);
            BTN_ModDir.TabIndex = 10;
            BTN_ModDir.Text = "Modified Folder";
            BTN_ModDir.UseVisualStyleBackColor = true;
            BTN_ModDir.Click += BTN_ModDir_Click;
            // 
            // Text_OrigGDI
            // 
            Text_OrigGDI.Location = new Point(143, 23);
            Text_OrigGDI.Name = "Text_OrigGDI";
            Text_OrigGDI.Size = new Size(361, 27);
            Text_OrigGDI.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 622);
            Controls.Add(Tab_MDL);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Sonic Shuffle MDL Tool";
            Load += Form1_Load;
            Tab_MDL.ResumeLayout(false);
            tabMDL.ResumeLayout(false);
            tabMDL.PerformLayout();
            tabTest.ResumeLayout(false);
            tabTest.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private ListView fileList;
        private ColumnHeader chIndex;
        private ColumnHeader chOffset;
        private ColumnHeader chName;
        private ColumnHeader chSize;
        private Button BTN_CreateMDL;
        private Button BTN_SaveMDL;
        private Button BTN_ExtractMDL;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button BTN_OrigGDI;
        private TextBox textBox1;
        private TabControl Tab_MDL;
        private TabPage tabMDL;
        private TabPage tabTest;
        private TextBox Text_OutPath;
        private TextBox Text_ModPath;
        private Button BTN_OutDir;
        private Button BTN_ModDir;
        private Button BTN_BuildGDI;
        private Button BTN_TestGdi;
        private TextBox Text_OrigGDI;
    }
}
