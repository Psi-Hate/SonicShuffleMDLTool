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
            textBox1 = new TextBox();
            fileList = new ListView();
            chIndex = new ColumnHeader();
            chOffset = new ColumnHeader();
            chName = new ColumnHeader();
            chSize = new ColumnHeader();
            BTN_CreateMDL = new Button();
            BTN_SaveMDL = new Button();
            BTN_ExtractMDL = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(142, 15);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(101, 33);
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
            // textBox1
            // 
            textBox1.Location = new Point(35, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(420, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // fileList
            // 
            fileList.Activation = ItemActivation.OneClick;
            fileList.Columns.AddRange(new ColumnHeader[] { chIndex, chOffset, chName, chSize });
            fileList.GridLines = true;
            fileList.Location = new Point(35, 99);
            fileList.Name = "fileList";
            fileList.Size = new Size(420, 477);
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
            BTN_CreateMDL.Location = new Point(35, 15);
            BTN_CreateMDL.Margin = new Padding(3, 4, 3, 4);
            BTN_CreateMDL.Name = "BTN_CreateMDL";
            BTN_CreateMDL.Size = new Size(99, 33);
            BTN_CreateMDL.TabIndex = 5;
            BTN_CreateMDL.Text = "Create MDL";
            BTN_CreateMDL.UseVisualStyleBackColor = true;
            BTN_CreateMDL.Click += BTN_CreateMDL_Click;
            // 
            // BTN_SaveMDL
            // 
            BTN_SaveMDL.Location = new Point(35, 582);
            BTN_SaveMDL.Name = "BTN_SaveMDL";
            BTN_SaveMDL.Size = new Size(101, 33);
            BTN_SaveMDL.TabIndex = 6;
            BTN_SaveMDL.Text = "Save MDL";
            BTN_SaveMDL.UseVisualStyleBackColor = true;
            BTN_SaveMDL.Click += BTN_SaveMDL_Click;
            // 
            // BTN_ExtractMDL
            // 
            BTN_ExtractMDL.Location = new Point(354, 581);
            BTN_ExtractMDL.Name = "BTN_ExtractMDL";
            BTN_ExtractMDL.Size = new Size(101, 34);
            BTN_ExtractMDL.TabIndex = 7;
            BTN_ExtractMDL.Text = "Extract MDL";
            BTN_ExtractMDL.UseVisualStyleBackColor = true;
            BTN_ExtractMDL.Click += BTN_ExtractMDL_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 622);
            Controls.Add(BTN_ExtractMDL);
            Controls.Add(BTN_SaveMDL);
            Controls.Add(BTN_CreateMDL);
            Controls.Add(fileList);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Sonic Shuffle MDL Tool";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private TextBox textBox1;
        private ListView fileList;
        private ColumnHeader chIndex;
        private ColumnHeader chOffset;
        private ColumnHeader chName;
        private ColumnHeader chSize;
        private Button BTN_CreateMDL;
        private Button BTN_SaveMDL;
        private Button BTN_ExtractMDL;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}
