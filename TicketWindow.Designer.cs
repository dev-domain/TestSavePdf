namespace TestSavePdf
{
    partial class TicketWindow
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
            tableLayoutPanel1 = new TableLayoutPanel();
            settleDtGp = new GroupBox();
            dateTimePicker2 = new DateTimePicker();
            prodGp = new GroupBox();
            textBox2 = new TextBox();
            notional = new GroupBox();
            textBox3 = new TextBox();
            custGp = new GroupBox();
            textBox5 = new TextBox();
            tradeDtGp = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            bSGp = new GroupBox();
            comboBox1 = new ComboBox();
            firmAccGp = new GroupBox();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            tableLayoutPanel1.SuspendLayout();
            settleDtGp.SuspendLayout();
            prodGp.SuspendLayout();
            notional.SuspendLayout();
            custGp.SuspendLayout();
            tradeDtGp.SuspendLayout();
            bSGp.SuspendLayout();
            firmAccGp.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.74174F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.25826F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 143F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 171F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 214F));
            tableLayoutPanel1.Controls.Add(settleDtGp, 1, 1);
            tableLayoutPanel1.Controls.Add(prodGp, 3, 0);
            tableLayoutPanel1.Controls.Add(notional, 2, 0);
            tableLayoutPanel1.Controls.Add(custGp, 4, 0);
            tableLayoutPanel1.Controls.Add(tradeDtGp, 0, 1);
            tableLayoutPanel1.Controls.Add(bSGp, 1, 0);
            tableLayoutPanel1.Controls.Add(firmAccGp, 0, 0);
            tableLayoutPanel1.Controls.Add(button1, 4, 1);
            tableLayoutPanel1.Controls.Add(button2, 3, 1);
            tableLayoutPanel1.Location = new Point(0, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(866, 253);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // settleDtGp
            // 
            settleDtGp.Controls.Add(dateTimePicker2);
            settleDtGp.Dock = DockStyle.Fill;
            settleDtGp.Location = new Point(144, 129);
            settleDtGp.Name = "settleDtGp";
            settleDtGp.Size = new Size(190, 121);
            settleDtGp.TabIndex = 11;
            settleDtGp.TabStop = false;
            settleDtGp.Text = "Settle Date";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(6, 21);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(158, 23);
            dateTimePicker2.TabIndex = 1;
            // 
            // prodGp
            // 
            prodGp.Controls.Add(textBox2);
            prodGp.Dock = DockStyle.Fill;
            prodGp.Location = new Point(483, 3);
            prodGp.Name = "prodGp";
            prodGp.Size = new Size(165, 120);
            prodGp.TabIndex = 10;
            prodGp.TabStop = false;
            prodGp.Text = "Product";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 22);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(190, 23);
            textBox2.TabIndex = 0;
            // 
            // notional
            // 
            notional.Controls.Add(textBox3);
            notional.Dock = DockStyle.Fill;
            notional.Location = new Point(340, 3);
            notional.Name = "notional";
            notional.Size = new Size(137, 120);
            notional.TabIndex = 8;
            notional.TabStop = false;
            notional.Text = "Notional";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 22);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(119, 23);
            textBox3.TabIndex = 0;
            // 
            // custGp
            // 
            custGp.Controls.Add(textBox5);
            custGp.Dock = DockStyle.Fill;
            custGp.Location = new Point(654, 3);
            custGp.Name = "custGp";
            custGp.Size = new Size(209, 120);
            custGp.TabIndex = 4;
            custGp.TabStop = false;
            custGp.Text = "Customer";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(6, 22);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(197, 23);
            textBox5.TabIndex = 0;
            // 
            // tradeDtGp
            // 
            tradeDtGp.Controls.Add(dateTimePicker1);
            tradeDtGp.Dock = DockStyle.Fill;
            tradeDtGp.Location = new Point(3, 129);
            tradeDtGp.Name = "tradeDtGp";
            tradeDtGp.Size = new Size(135, 121);
            tradeDtGp.TabIndex = 3;
            tradeDtGp.TabStop = false;
            tradeDtGp.Text = "Trade Date";
            tradeDtGp.Enter += groupBox4_Enter;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(6, 21);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(158, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // bSGp
            // 
            bSGp.Controls.Add(comboBox1);
            bSGp.Dock = DockStyle.Fill;
            bSGp.Location = new Point(144, 3);
            bSGp.Name = "bSGp";
            bSGp.Size = new Size(190, 120);
            bSGp.TabIndex = 2;
            bSGp.TabStop = false;
            bSGp.Text = "Buy/Sell";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 21);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(127, 23);
            comboBox1.TabIndex = 0;
            // 
            // firmAccGp
            // 
            firmAccGp.Controls.Add(textBox1);
            firmAccGp.Dock = DockStyle.Fill;
            firmAccGp.Location = new Point(3, 3);
            firmAccGp.Name = "firmAccGp";
            firmAccGp.Size = new Size(135, 120);
            firmAccGp.TabIndex = 0;
            firmAccGp.TabStop = false;
            firmAccGp.Text = "Firm Account";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(119, 23);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(654, 129);
            button1.Name = "button1";
            button1.Size = new Size(209, 121);
            button1.TabIndex = 6;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.Location = new Point(483, 129);
            button2.Name = "button2";
            button2.Size = new Size(165, 121);
            button2.TabIndex = 7;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            // 
            // TicketWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 265);
            Controls.Add(tableLayoutPanel1);
            Name = "TicketWindow";
            Text = "TicketWindow";
            tableLayoutPanel1.ResumeLayout(false);
            settleDtGp.ResumeLayout(false);
            prodGp.ResumeLayout(false);
            prodGp.PerformLayout();
            notional.ResumeLayout(false);
            notional.PerformLayout();
            custGp.ResumeLayout(false);
            custGp.PerformLayout();
            tradeDtGp.ResumeLayout(false);
            bSGp.ResumeLayout(false);
            firmAccGp.ResumeLayout(false);
            firmAccGp.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox firmAccGp;
        private TextBox textBox1;
        private GroupBox custGp;
        private TextBox textBox5;
        private GroupBox tradeDtGp;
        private GroupBox bSGp;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private GroupBox prodGp;
        private TextBox textBox2;
        private GroupBox notional;
        private TextBox textBox3;
        private GroupBox settleDtGp;
        private DateTimePicker dateTimePicker2;
    }
}