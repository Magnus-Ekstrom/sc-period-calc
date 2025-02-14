namespace period_calc
{
    partial class Form1
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            cbHolidaysUsed = new CheckBox();
            lblHolidaysUsed = new Label();
            lbHolidaysUsed = new ListBox();
            lbPeriods = new ListBox();
            cbShowWeekends = new CheckBox();
            numYear = new NumericUpDown();
            rtpOutput = new RichTextBox();
            tabPage2 = new TabPage();
            btnReadHolidays = new Button();
            label1 = new Label();
            tbHolydays = new TextBox();
            btnReset = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numYear).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(638, 608);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnReset);
            tabPage1.Controls.Add(cbHolidaysUsed);
            tabPage1.Controls.Add(lblHolidaysUsed);
            tabPage1.Controls.Add(lbHolidaysUsed);
            tabPage1.Controls.Add(lbPeriods);
            tabPage1.Controls.Add(cbShowWeekends);
            tabPage1.Controls.Add(numYear);
            tabPage1.Controls.Add(rtpOutput);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(630, 580);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Beräkna";
            // 
            // cbHolidaysUsed
            // 
            cbHolidaysUsed.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbHolidaysUsed.AutoSize = true;
            cbHolidaysUsed.Checked = true;
            cbHolidaysUsed.CheckState = CheckState.Checked;
            cbHolidaysUsed.Location = new Point(454, 298);
            cbHolidaysUsed.Name = "cbHolidaysUsed";
            cbHolidaysUsed.Size = new Size(129, 19);
            cbHolidaysUsed.TabIndex = 13;
            cbHolidaysUsed.Text = "Use holidays in calc";
            cbHolidaysUsed.UseVisualStyleBackColor = true;
            // 
            // lblHolidaysUsed
            // 
            lblHolidaysUsed.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblHolidaysUsed.AutoSize = true;
            lblHolidaysUsed.Location = new Point(454, 321);
            lblHolidaysUsed.Name = "lblHolidaysUsed";
            lblHolidaysUsed.Size = new Size(82, 15);
            lblHolidaysUsed.TabIndex = 12;
            lblHolidaysUsed.Text = "Holidays Used";
            // 
            // lbHolidaysUsed
            // 
            lbHolidaysUsed.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbHolidaysUsed.FormattingEnabled = true;
            lbHolidaysUsed.ItemHeight = 15;
            lbHolidaysUsed.Location = new Point(454, 339);
            lbHolidaysUsed.Name = "lbHolidaysUsed";
            lbHolidaysUsed.Size = new Size(176, 229);
            lbHolidaysUsed.TabIndex = 11;
            // 
            // lbPeriods
            // 
            lbPeriods.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbPeriods.FormattingEnabled = true;
            lbPeriods.ItemHeight = 15;
            lbPeriods.Location = new Point(454, 38);
            lbPeriods.Name = "lbPeriods";
            lbPeriods.Size = new Size(176, 229);
            lbPeriods.TabIndex = 10;
            lbPeriods.SelectedIndexChanged += lbPeriods_SelectedIndexChanged;
            // 
            // cbShowWeekends
            // 
            cbShowWeekends.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbShowWeekends.AutoSize = true;
            cbShowWeekends.Location = new Point(454, 273);
            cbShowWeekends.Name = "cbShowWeekends";
            cbShowWeekends.Size = new Size(110, 19);
            cbShowWeekends.TabIndex = 9;
            cbShowWeekends.Text = "Show weekends";
            cbShowWeekends.UseVisualStyleBackColor = true;
            // 
            // numYear
            // 
            numYear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numYear.Location = new Point(457, 9);
            numYear.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            numYear.Name = "numYear";
            numYear.Size = new Size(60, 23);
            numYear.TabIndex = 8;
            numYear.Value = new decimal(new int[] { 2025, 0, 0, 0 });
            numYear.ValueChanged += numYear_ValueChanged;
            // 
            // rtpOutput
            // 
            rtpOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtpOutput.Location = new Point(0, 0);
            rtpOutput.Name = "rtpOutput";
            rtpOutput.Size = new Size(451, 580);
            rtpOutput.TabIndex = 4;
            rtpOutput.Text = "";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnReadHolidays);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(tbHolydays);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(630, 580);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Lediga dagar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnReadHolidays
            // 
            btnReadHolidays.Location = new Point(363, 3);
            btnReadHolidays.Name = "btnReadHolidays";
            btnReadHolidays.Size = new Size(126, 23);
            btnReadHolidays.TabIndex = 2;
            btnReadHolidays.Text = "Läs in lediga dagar";
            btnReadHolidays.UseVisualStyleBackColor = true;
            btnReadHolidays.Click += btnReadHolidays_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 7);
            label1.Name = "label1";
            label1.Size = new Size(338, 15);
            label1.TabIndex = 1;
            label1.Text = "Lediga dagar. En dag per rad yyyy-mm-dd <short description>";
            // 
            // tbHolydays
            // 
            tbHolydays.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbHolydays.Location = new Point(0, 27);
            tbHolydays.Multiline = true;
            tbHolydays.Name = "tbHolydays";
            tbHolydays.Size = new Size(630, 553);
            tbHolydays.TabIndex = 0;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(552, 9);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 14;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 608);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "SteelTech Time Reporting Calculator";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numYear).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox tbHolydays;
        private Label label1;
        private RichTextBox rtpOutput;
        private NumericUpDown numYear;
        private CheckBox cbShowWeekends;
        private ListBox lbPeriods;
        private Button btnReadHolidays;
        private Label lblHolidaysUsed;
        private ListBox lbHolidaysUsed;
        private CheckBox cbHolidaysUsed;
        private Button btnReset;
    }
}
