namespace A6
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimeLbl = new System.Windows.Forms.Label();
            this.priorityLbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.toDoLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toDoBox = new System.Windows.Forms.GroupBox();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.priorityLblBox = new System.Windows.Forms.Label();
            this.hourLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.toDoList = new System.Windows.Forms.ListBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.clockLbl = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.toDoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Location = new System.Drawing.Point(0, 40);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1580, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.HelpMenu});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1580, 40);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // FileMenu
            // 
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(71, 36);
            this.FileMenu.Text = "File";
            // 
            // HelpMenu
            // 
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(84, 36);
            this.HelpMenu.Text = "Help";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(301, 85);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(400, 39);
            this.dateTimePicker.TabIndex = 2;
            // 
            // dateTimeLbl
            // 
            this.dateTimeLbl.AutoSize = true;
            this.dateTimeLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimeLbl.Location = new System.Drawing.Point(31, 87);
            this.dateTimeLbl.Name = "dateTimeLbl";
            this.dateTimeLbl.Size = new System.Drawing.Size(185, 37);
            this.dateTimeLbl.TabIndex = 3;
            this.dateTimeLbl.Text = "Date and time";
            // 
            // priorityLbl
            // 
            this.priorityLbl.AutoSize = true;
            this.priorityLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priorityLbl.Location = new System.Drawing.Point(772, 85);
            this.priorityLbl.Name = "priorityLbl";
            this.priorityLbl.Size = new System.Drawing.Size(102, 37);
            this.priorityLbl.TabIndex = 4;
            this.priorityLbl.Text = "Priority";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(880, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(242, 40);
            this.comboBox1.TabIndex = 5;
            // 
            // toDoLbl
            // 
            this.toDoLbl.AutoSize = true;
            this.toDoLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toDoLbl.Location = new System.Drawing.Point(31, 165);
            this.toDoLbl.Name = "toDoLbl";
            this.toDoLbl.Size = new System.Drawing.Size(86, 37);
            this.toDoLbl.TabIndex = 6;
            this.toDoLbl.Text = "To Do";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(188, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(934, 39);
            this.textBox1.TabIndex = 7;
            // 
            // toDoBox
            // 
            this.toDoBox.Controls.Add(this.descriptionLbl);
            this.toDoBox.Controls.Add(this.priorityLblBox);
            this.toDoBox.Controls.Add(this.hourLbl);
            this.toDoBox.Controls.Add(this.dateLbl);
            this.toDoBox.Controls.Add(this.toDoList);
            this.toDoBox.ForeColor = System.Drawing.Color.Olive;
            this.toDoBox.Location = new System.Drawing.Point(12, 303);
            this.toDoBox.Name = "toDoBox";
            this.toDoBox.Size = new System.Drawing.Size(1556, 549);
            this.toDoBox.TabIndex = 8;
            this.toDoBox.TabStop = false;
            this.toDoBox.Text = "To Do ";
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Location = new System.Drawing.Point(1016, 35);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(135, 32);
            this.descriptionLbl.TabIndex = 4;
            this.descriptionLbl.Text = "Description";
            // 
            // priorityLblBox
            // 
            this.priorityLblBox.AutoSize = true;
            this.priorityLblBox.Location = new System.Drawing.Point(678, 35);
            this.priorityLblBox.Name = "priorityLblBox";
            this.priorityLblBox.Size = new System.Drawing.Size(89, 32);
            this.priorityLblBox.TabIndex = 3;
            this.priorityLblBox.Text = "Priority";
            // 
            // hourLbl
            // 
            this.hourLbl.AutoSize = true;
            this.hourLbl.Location = new System.Drawing.Point(569, 35);
            this.hourLbl.Name = "hourLbl";
            this.hourLbl.Size = new System.Drawing.Size(67, 32);
            this.hourLbl.TabIndex = 2;
            this.hourLbl.Text = "Hour";
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Location = new System.Drawing.Point(57, 35);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(64, 32);
            this.dateLbl.TabIndex = 1;
            this.dateLbl.Text = "Date";
            // 
            // toDoList
            // 
            this.toDoList.FormattingEnabled = true;
            this.toDoList.ItemHeight = 32;
            this.toDoList.Location = new System.Drawing.Point(19, 87);
            this.toDoList.Name = "toDoList";
            this.toDoList.Size = new System.Drawing.Size(1531, 452);
            this.toDoList.TabIndex = 0;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(615, 227);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(371, 58);
            this.addBtn.TabIndex = 9;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 886);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(368, 886);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(263, 46);
            this.button2.TabIndex = 11;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // clockLbl
            // 
            this.clockLbl.AutoSize = true;
            this.clockLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.clockLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clockLbl.Location = new System.Drawing.Point(1222, 895);
            this.clockLbl.Name = "clockLbl";
            this.clockLbl.Size = new System.Drawing.Size(2, 39);
            this.clockLbl.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1580, 969);
            this.Controls.Add(this.clockLbl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.toDoBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toDoLbl);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.priorityLbl);
            this.Controls.Add(this.dateTimeLbl);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.toDoBox.ResumeLayout(false);
            this.toDoBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem FileMenu;
        private ToolStripMenuItem HelpMenu;
        private DateTimePicker dateTimePicker;
        private Label dateTimeLbl;
        private Label priorityLbl;
        private ComboBox comboBox1;
        private Label toDoLbl;
        private TextBox textBox1;
        private GroupBox toDoBox;
        private Button addBtn;
        private ListBox toDoList;
        private Label dateLbl;
        private Button button1;
        private Button button2;
        private Label descriptionLbl;
        private Label priorityLblBox;
        private Label hourLbl;
        private System.Windows.Forms.Timer timer;
        private Label clockLbl;
    }
}