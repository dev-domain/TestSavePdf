
namespace TestSavePdf
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            openExplorer = new Button();
            listBox1 = new ListBox();
            button2 = new Button();
            button1 = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            panel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(openExplorer);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 421);
            panel1.TabIndex = 0;
            // 
            // openExplorer
            // 
            openExplorer.Location = new Point(13, 280);
            openExplorer.Name = "openExplorer";
            openExplorer.Size = new Size(116, 110);
            openExplorer.TabIndex = 3;
            openExplorer.Text = "Open Windows Explorer";
            openExplorer.UseVisualStyleBackColor = true;
            openExplorer.Click += openExplorer_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(203, 13);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(586, 394);
            listBox1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(13, 144);
            button2.Name = "button2";
            button2.Size = new Size(116, 110);
            button2.TabIndex = 1;
            button2.Text = "Launch Hidden Window and Save Pdf";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(13, 13);
            button1.Name = "button1";
            button1.Size = new Size(116, 110);
            button1.TabIndex = 0;
            button1.Text = "Launch New Window";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 1;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(58, 17);
            toolStripStatusLabel1.Text = "Status OK";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
            Name = "MainWindow";
            Text = "Silent PDF Export Tester";
            Load += MainWindow_Load;
            panel1.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Button button2;
        private Button button1;
        private ListBox listBox1;
        private Button openExplorer;
    }
}
