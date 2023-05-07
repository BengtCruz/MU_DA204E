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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newSubFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openDataSubFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataSubFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitSubFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSubHelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimeLbl = new System.Windows.Forms.Label();
            this.priorityLbl = new System.Windows.Forms.Label();
            this.priorityBox = new System.Windows.Forms.ComboBox();
            this.toDoLbl = new System.Windows.Forms.Label();
            this.toDoIn = new System.Windows.Forms.TextBox();
            this.toDoBox = new System.Windows.Forms.GroupBox();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.priorityLblBox = new System.Windows.Forms.Label();
            this.hourLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.toDoList = new System.Windows.Forms.ListBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.changeBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.clockLbl = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip2.SuspendLayout();
            this.toDoBox.SuspendLayout();
            this.SuspendLayout();
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
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSubFileMenu,
            this.toolStripSeparator1,
            this.openDataSubFileMenu,
            this.saveDataSubFileMenu,
            this.toolStripSeparator2,
            this.exitSubFileMenu});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(71, 36);
            this.FileMenu.Text = "File";
            // 
            // newSubFileMenu
            // 
            this.newSubFileMenu.Name = "newSubFileMenu";
            this.newSubFileMenu.Size = new System.Drawing.Size(352, 44);
            this.newSubFileMenu.Text = "New            Ctrl+N";
            this.newSubFileMenu.Click += new System.EventHandler(this.newSubFileMenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(349, 6);
            // 
            // openDataSubFileMenu
            // 
            this.openDataSubFileMenu.Name = "openDataSubFileMenu";
            this.openDataSubFileMenu.Size = new System.Drawing.Size(352, 44);
            this.openDataSubFileMenu.Text = "Open data file";
            this.openDataSubFileMenu.Click += new System.EventHandler(this.openDataSubFileMenu_Click);
            // 
            // saveDataSubFileMenu
            // 
            this.saveDataSubFileMenu.Name = "saveDataSubFileMenu";
            this.saveDataSubFileMenu.Size = new System.Drawing.Size(352, 44);
            this.saveDataSubFileMenu.Text = "Save data file";
            this.saveDataSubFileMenu.Click += new System.EventHandler(this.saveDataSubFileMenu_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(349, 6);
            // 
            // exitSubFileMenu
            // 
            this.exitSubFileMenu.Name = "exitSubFileMenu";
            this.exitSubFileMenu.Size = new System.Drawing.Size(352, 44);
            this.exitSubFileMenu.Text = "Exit              Alt+F4";
            this.exitSubFileMenu.Click += new System.EventHandler(this.exitSubFileMenu_Click);
            // 
            // HelpMenu
            // 
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutSubHelpMenu});
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(84, 36);
            this.HelpMenu.Text = "Help";
            // 
            // aboutSubHelpMenu
            // 
            this.aboutSubHelpMenu.Name = "aboutSubHelpMenu";
            this.aboutSubHelpMenu.Size = new System.Drawing.Size(359, 44);
            this.aboutSubHelpMenu.Text = "About...";
            this.aboutSubHelpMenu.Click += new System.EventHandler(this.aboutSubHelpMenu_Click);
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
            // priorityBox
            // 
            this.priorityBox.FormattingEnabled = true;
            this.priorityBox.Location = new System.Drawing.Point(880, 84);
            this.priorityBox.Name = "priorityBox";
            this.priorityBox.Size = new System.Drawing.Size(242, 40);
            this.priorityBox.TabIndex = 5;
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
            // toDoIn
            // 
            this.toDoIn.Location = new System.Drawing.Point(188, 163);
            this.toDoIn.Name = "toDoIn";
            this.toDoIn.Size = new System.Drawing.Size(934, 39);
            this.toDoIn.TabIndex = 7;
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
            this.toDoList.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toDoList.FormattingEnabled = true;
            this.toDoList.ItemHeight = 30;
            this.toDoList.Location = new System.Drawing.Point(19, 87);
            this.toDoList.Name = "toDoList";
            this.toDoList.Size = new System.Drawing.Size(1531, 424);
            this.toDoList.TabIndex = 0;
            this.toDoList.SelectedIndexChanged += new System.EventHandler(this.toDoList_SelectedIndexChanged);
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
            // changeBtn
            // 
            this.changeBtn.Location = new System.Drawing.Point(69, 886);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(263, 46);
            this.changeBtn.TabIndex = 10;
            this.changeBtn.Text = "Change";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(368, 886);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(263, 46);
            this.deleteBtn.TabIndex = 11;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
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
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.toDoBox);
            this.Controls.Add(this.toDoIn);
            this.Controls.Add(this.toDoLbl);
            this.Controls.Add(this.priorityBox);
            this.Controls.Add(this.priorityLbl);
            this.Controls.Add(this.dateTimeLbl);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.menuStrip2);
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
        private MenuStrip menuStrip2;
        private ToolStripMenuItem FileMenu;
        private ToolStripMenuItem HelpMenu;
        private DateTimePicker dateTimePicker;
        private Label dateTimeLbl;
        private Label priorityLbl;
        private ComboBox priorityBox;
        private Label toDoLbl;
        private TextBox toDoIn;
        private GroupBox toDoBox;
        private Button addBtn;
        private ListBox toDoList;
        private Label dateLbl;
        private Button changeBtn;
        private Button deleteBtn;
        private Label descriptionLbl;
        private Label priorityLblBox;
        private Label hourLbl;
        private System.Windows.Forms.Timer timer;
        private Label clockLbl;
        private ToolStripMenuItem newSubFileMenu;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem openDataSubFileMenu;
        private ToolStripMenuItem saveDataSubFileMenu;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitSubFileMenu;
        private ToolStripMenuItem aboutSubHelpMenu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}