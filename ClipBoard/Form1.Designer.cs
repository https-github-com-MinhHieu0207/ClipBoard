namespace ClipBoard
{
    partial class ClipBoard
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
            this.components = new System.ComponentModel.Container();
            this.CopyButton = new System.Windows.Forms.Button();
            this.PasteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HistoryOfDataBox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BoxCopyData = new System.Windows.Forms.TextBox();
            this.DisplayBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.cLearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(258, 136);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(105, 44);
            this.CopyButton.TabIndex = 2;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // PasteButton
            // 
            this.PasteButton.Location = new System.Drawing.Point(380, 136);
            this.PasteButton.Name = "PasteButton";
            this.PasteButton.Size = new System.Drawing.Size(105, 44);
            this.PasteButton.TabIndex = 3;
            this.PasteButton.Text = "Paste";
            this.PasteButton.UseVisualStyleBackColor = true;
            this.PasteButton.Click += new System.EventHandler(this.PasteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 82);
            this.label1.TabIndex = 7;
            this.label1.Text = "CLIP BOARD\r\n      History\r\n";
            // 
            // HistoryOfDataBox
            // 
            this.HistoryOfDataBox.ContextMenuStrip = this.contextMenuStrip1;
            this.HistoryOfDataBox.Location = new System.Drawing.Point(19, 113);
            this.HistoryOfDataBox.Name = "HistoryOfDataBox";
            this.HistoryOfDataBox.ReadOnly = true;
            this.HistoryOfDataBox.Size = new System.Drawing.Size(225, 515);
            this.HistoryOfDataBox.TabIndex = 6;
            this.HistoryOfDataBox.Text = "";
            this.HistoryOfDataBox.MultilineChanged += new System.EventHandler(this.CopyButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.cLearAllToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(131, 100);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.PasteButton_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // BoxCopyData
            // 
            this.BoxCopyData.AcceptsReturn = true;
            this.BoxCopyData.ContextMenuStrip = this.contextMenuStrip1;
            this.BoxCopyData.Location = new System.Drawing.Point(258, 44);
            this.BoxCopyData.Multiline = true;
            this.BoxCopyData.Name = "BoxCopyData";
            this.BoxCopyData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.BoxCopyData.Size = new System.Drawing.Size(559, 86);
            this.BoxCopyData.TabIndex = 1;
            // 
            // DisplayBox
            // 
            this.DisplayBox.AcceptsReturn = true;
            this.DisplayBox.BackColor = System.Drawing.SystemColors.Window;
            this.DisplayBox.ContextMenuStrip = this.contextMenuStrip1;
            this.DisplayBox.ForeColor = System.Drawing.Color.Black;
            this.DisplayBox.Location = new System.Drawing.Point(259, 229);
            this.DisplayBox.Multiline = true;
            this.DisplayBox.Name = "DisplayBox";
            this.DisplayBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DisplayBox.Size = new System.Drawing.Size(558, 399);
            this.DisplayBox.TabIndex = 5;
            this.DisplayBox.MultilineChanged += new System.EventHandler(this.PasteButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(254, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Vui lòng nhập văn bản ở đây !";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(505, 136);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(105, 44);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(255, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Hộp thoại hiển thị văn bản !";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(630, 136);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(105, 44);
            this.ExitButton.TabIndex = 13;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // cLearAllToolStripMenuItem
            // 
            this.cLearAllToolStripMenuItem.Name = "cLearAllToolStripMenuItem";
            this.cLearAllToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.cLearAllToolStripMenuItem.Text = "ClearAll";
            this.cLearAllToolStripMenuItem.Click += new System.EventHandler(this.cLearAllToolStripMenuItem_Click);
            // 
            // ClipBoard
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(827, 640);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DisplayBox);
            this.Controls.Add(this.BoxCopyData);
            this.Controls.Add(this.HistoryOfDataBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasteButton);
            this.Controls.Add(this.CopyButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ClipBoard";
            this.Text = "CLIP BOARD";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button PasteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox HistoryOfDataBox;
        private System.Windows.Forms.TextBox BoxCopyData;
        private System.Windows.Forms.TextBox DisplayBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ToolStripMenuItem cLearAllToolStripMenuItem;
    }
}

